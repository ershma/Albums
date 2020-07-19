using System;
using System.IO;

namespace Albums.Services
{
    public class IOFileService <T> where T : new()
    {
        private string path;

      public IOFileService(string path)
      {
            this.path = path;
      }
       public void Save(object o)
       {
        using (StreamWriter writer = File.CreateText(path))
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(o);
                writer.Write(output);
        }
       }
    public T Load()
    {
        if (!File.Exists(path))
        {
            File.CreateText(path).Dispose();
            return new T();
        }
        using (StreamReader reader = File.OpenText(path))
        {
            string output = reader.ReadToEnd();
            try
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(output);
            }
            catch (Exception e)
            {
                return new T();
            }
        }
    }
    }
}
