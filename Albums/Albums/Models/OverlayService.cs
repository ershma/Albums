using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Albums.Models
{
   public class  OverlayService:INotifyPropertyChanged 
   {
        private static OverlayService _Instance = new OverlayService() {
        Text=""};
    public static OverlayService GetInstance() => _Instance;
        public event PropertyChangedEventHandler PropertyChanged;
        private string text;

        private OverlayService() { }

    public Action<string> Show { get; set; }

    public string Text { get => text; set { text = value; OnPropertyChanged("Text"); } }

    public void Close()
    {
        Text = "";
    }

        public void OnPropertyChanged([CallerMemberName] string prop="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
   }
}
