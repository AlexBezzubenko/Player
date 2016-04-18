using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Permissions;
using System.Windows.Media;



namespace TestApp.Model
{

    [Serializable]
    public class Playlist : MyList<Track>, IEnumerable<Track>, INotifyCollectionChanged, ISerializable
    {
        private Playlist( SerializationInfo info, StreamingContext context )        
        {
            this.ID = info.GetInt32("ID");
            this.Name = info.GetString("Name");
            this.TotalLength = info.GetInt32("TotalLength");
            this.TotalRating = info.GetInt32("TotalRating");

            int count = info.GetInt32("NumOfTracks");  
            for (int iy = 0; iy < count; iy++)
            {
                string key = "Track_" + iy.ToString();        
                Track track = (Track)info.GetValue(key, typeof(Track));       
                this.Add(track);       
            }
        }
        
        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]       
        public void GetObjectData( SerializationInfo info, StreamingContext context )
        {
            info.AddValue("ID",this.ID);
            info.AddValue("Name", this.Name);
            info.AddValue("TotalLength", this.TotalLength);
            info.AddValue("TotalRating", this.TotalRating);
                                              
            info.AddValue("NumOfTracks", this.Count);       
            int iy = 0;       
            foreach (Track track in this)       
            {        
                string key = "Track_" + iy.ToString();        
                info.AddValue(key, track, typeof(Track));       
                iy++;        
            }        
        }
        //—оздать класс дл€ представлени€ плей-листа, представл€ющего коллекцию неповтор€ю-щихс€ композиций 
        //и обладающего следующими элементами: ID (уникальный); название (строка длиной до 256 символов);
        //обща€ длина (минуты, секунды); рейтинг (высчитываетс€ как среднее рейтинга композиций).  
        const string dataPath = @"Res/data.dat";
        const string gzipPath = @"Res/data.gzip";
        const string textPath = @"Res/Collection.doc";
        const string queuryPath = @"Res/QueuryResult.doc";
        const string Path = @"Res/";

        public int ID { get; set; }
        public string Name { get; set; }
        public int TotalLength { get; set; }
        public int TotalRating { get; set; }
        public Track CurrentTrack { get; set; }
        public MediaPlayer Player { get; set; }

        public Playlist()
        {
            this.Name = "New_Playlist";
            this.Player = new MediaPlayer();
        }

        public Playlist(string name)
        {
            this.Name = name;
            this.Player = new MediaPlayer();

            Add(new Track(1,"unknown",new TimeSpan(0,0,0),"unknown","unknown",2));
            Add(new Track(2, "unknown", new TimeSpan(0, 0, 0), "unknown", "unknown", 4));
            Add(new Track(@"C:\Users\Alexander\Downloads\Church.mp3"));
        }
        public event NotifyCollectionChangedEventHandler CollectionChanged;
        #region class PlaylistEnumeraror
        private sealed class PlaylistEnumerator : IEnumerator<Track>
        {
            public int curpos = -1;
            private MyList<Track> tracks;

            public PlaylistEnumerator(MyList<Track> tracks)
            {
                this.tracks = tracks;
            }

            public Track Current
            {
                get { return tracks[curpos]; }
            }

            public bool MoveNext()
            {
                if (curpos < tracks.Count - 1)
                {
                    curpos++;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                curpos = -1;
            }

            public void Dispose()
            {
            }

            object IEnumerator.Current
            {
                get { return Current; }
            }
        }
        #endregion
        #region IEnumerator
        public override IEnumerator<Track> GetEnumerator()
        {
            return new PlaylistEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
        #region methods Add, Remove
        public override void Add(Track t)
        {
            base.Add(t);

            if (CollectionChanged != null)
            {
                CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, t));
            }
        }

        public override bool Remove(Track t)
        {
            base.RemoveAt(this.IndexOf(t));
            if (CollectionChanged != null)
            {
                //CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, q));
                CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset)); //remove не пашет сучка
            }
            return true;
        }
        public override void RemoveAt(int Index)
        {
            base.RemoveAt(Index);
            if (CollectionChanged != null)
            {
                CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            }
        }
        public override void Clear()
        {
            base.Clear();
            if (CollectionChanged != null)
            {
                CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            }
        }
        public int FindIndex(Track t)
        {
            return this.IndexOf(t);
        }
        #endregion   
    }
}
