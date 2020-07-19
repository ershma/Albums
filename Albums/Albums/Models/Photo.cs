using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Albums.Models
{

    public class Photo 
    {
        [Newtonsoft.Json.JsonIgnore]
        public BitmapImage TemplateImage { get; private set; }
        public string Name { get; set; }
        public string Dir { get; set; }
        public string DateCreate { get; set; }
        
        public string Path { get; set; }

        public Photo(string path)
        {
            Path = path;
            if (!File.Exists(path))
                Path = System.IO.Path.GetFullPath("Error.png");
                BitmapImage image = new BitmapImage();
                
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = new Uri(Path);
                image.DecodePixelWidth = 100;
          
                image.EndInit();
                image.Freeze();
                TemplateImage = image;
            
                
        }
   
    }
}

