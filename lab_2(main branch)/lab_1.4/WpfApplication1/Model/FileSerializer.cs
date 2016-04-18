using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
 
using System.Windows;
using System.Collections;
using System.Runtime.Serialization.Formatters.Soap;

namespace TestApp.Model
{
    public static class FileSerializer
    {
        public static void Serialize(string filename, object objectToSerialize)
        {
            if (objectToSerialize == null)

                throw new ArgumentNullException("objectToSerialize cannot be null");
            
            using (var stream = File.Open(filename, FileMode.Create))
            {
                SoapFormatter bFormatter = new SoapFormatter();
                bFormatter.Serialize(stream, objectToSerialize);
                
            }
        }

        public static T Deserialize<T>(string filename)
        {

            T objectToSerialize = default(T);

            Stream stream = null;

            try
            {

                stream = File.Open(filename, FileMode.Open);

                SoapFormatter bFormatter = new SoapFormatter();

                objectToSerialize = (T)bFormatter.Deserialize(stream);

            }

            catch (Exception err)
            {

                MessageBox.Show("The application failed to retrieve the inventory - " + err.Message);

            }

            finally
            {

                if (stream != null)

                    stream.Close();

            }

            return objectToSerialize;

        }

    }
}