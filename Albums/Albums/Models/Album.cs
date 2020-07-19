using Albums.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Albums.Models
{
    public class Album : INotifyPropertyChanged
    {
       public ulong ID { get; set; }
        private string title;
        private Photo selectedPhoto;
        //private string path;
        
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Photo> Photos { get; set; }
      

        //public string Path
        //{
        //    get => path;
        //    set
        //    {
        //        path = "Albums\\"+value;
        //        OnPropertyChanged("Path");
        //    }
        //}

        public Album(string title)
        {
            this.title = title;
            Photos = new ObservableCollection<Photo>();
        
 


        }
        public Photo SelectedPhoto
        {
            get => selectedPhoto;
            set
            {
                selectedPhoto = value;
                OnPropertyChanged("SelectedPhoto");
            }

        }
        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
