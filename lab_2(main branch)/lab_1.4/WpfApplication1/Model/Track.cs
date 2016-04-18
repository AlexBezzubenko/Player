using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using TagLib;

namespace TestApp.Model
{
    [Serializable]
    public class Track : ISerializable
    {
        public int ID { get; set; }
        public string TrackName { get; set; }
        public string TrackString { get; set; }
        public string FileName { get; set; }
        public TimeSpan TrackLength { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }
        public TagLib.File mp3File {get; set;}

        //ID (уникальный); название (строка длиной до 256 символов); 
        //длина (минуты, секунды); исполнитель (строка длиной до 256 символов); 
        //жанр (значение из перечисления допустимых жанров); 
        //рейтинг (целое число от 0 до 10). 
        public Track()
        {
            this.ID = 0;
            this.TrackName = "unknown";
            this.FileName = String.Empty;
            this.TrackLength = new TimeSpan();
            this.Artist = "unknown";
            this.Genre = "unknown";
            this.Rating = 2;
            StringConversion();
        }
        public Track(int id, string name, TimeSpan length, string artist, string genre, int rating)
        {
            this.ID = id;
            this.TrackName = name;
            this.TrackLength = length;
            this.Artist = artist;
            this.Genre = genre;
            this.Rating = rating;
            StringConversion();
        }
        public Track(string name, string artist, string FileName)
        {            
            this.TrackName = name;
            this.FileName = FileName;
            this.Artist = artist;
            StringConversion();
        }
        public Track(string FileName)
        {
            this.FileName = FileName;
            LoadFileInfo();
            StringConversion();
        }
        public Track(int Rating)
        {
            this.Rating = Rating;           
        }

        public void LoadFileInfo(){
            if (FileName != String.Empty)
            {
                mp3File = TagLib.File.Create(FileName);
                Artist = mp3File.Tag.FirstPerformer;
                TrackName = mp3File.Tag.Title;        
                //MessageBox.Show("Year: " + mp3File.Tag.Year);
                Genre = mp3File.Tag.FirstGenre;
                TrackLength = mp3File.Properties.Duration;//.ToString("mm\\:ss"));
            }
        }

        private Track( SerializationInfo info, StreamingContext ctxt )
        {   
            TimeSpan ts = new TimeSpan(0,0,0);
            this.ID = info.GetInt32("ID");
            this.TrackName = info.GetString("TrackName");
            this.FileName = info.GetString("FileName");
            this.TrackLength = (TimeSpan)info.GetValue("TrackLength", ts.GetType());
            this.Artist = info.GetString("Artist");
            this.Genre = info.GetString("Genre");
            this.Rating = info.GetInt32("Rating");
            StringConversion();
        }

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
        public virtual void GetObjectData( SerializationInfo info, StreamingContext ctxt )
        {
           info.AddValue("ID", this.ID);
           info.AddValue("TrackName", this.TrackName);
           info.AddValue("FileName", this.FileName);
           info.AddValue("TrackLength", this.TrackLength);
           info.AddValue("Artist", this.Artist);
           info.AddValue("Genre", this.Genre);
           info.AddValue("Rating", this.Rating);
        }

        public void StringConversion()
        {
            TrackString = Artist + " - " + TrackName;
        }
    }
}
