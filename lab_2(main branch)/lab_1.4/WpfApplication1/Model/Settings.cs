using System.Runtime.Serialization;
using System;
using System.Security.Permissions;
using System.IO;
using System.Threading;
using System.Globalization;

namespace TestApp.Model
{
    [Serializable]
    public class Settings: ISerializable
    {       
        public bool SaveBeforeClosing { get; set; }

        public string Text { get; set; }
        public string Language { get; set; }
        public bool StopAll { get; set; }

        public int Number { get; set; }

        public Settings()
        {
            Text = "---";
            this.Language = String.Empty;
            this.StopAll = true;
        }
        public Settings(string text)
        {
            this.Text = text;
            this.Language = String.Empty;
            this.StopAll = true;
        }

        private Settings( SerializationInfo info, StreamingContext ctxt )
        {   
            this.Text = info.GetString("Text");
            this.Language = info.GetString("Language");
            this.SaveBeforeClosing = info.GetBoolean("SaveBeforeClosing");
            this.StopAll = info.GetBoolean("StopAll");
        }

        public void ChangeLanguage()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(this.Language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(this.Language);  
        }
        const string serializerPath = @"Res/serialize.dat";
        const string Path = @"Res/";

        public void Serialize()
        {
            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
            FileSerializer.Serialize(serializerPath, this);
        }

        public void Deserialize()
        {
            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }

            Settings set = FileSerializer.Deserialize<Settings>(serializerPath);
            this.Language = set.Language;
            this.SaveBeforeClosing = set.SaveBeforeClosing;
        }   

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
        public virtual void GetObjectData( SerializationInfo info, StreamingContext ctxt )
        {
           info.AddValue("Text", this.Text);
           info.AddValue("Language", this.Language);
           info.AddValue("SaveBeforeClosing", this.SaveBeforeClosing);
           info.AddValue("StopAll", this.StopAll);
        }
    }
}