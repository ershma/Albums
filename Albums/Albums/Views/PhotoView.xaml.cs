using Albums.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Albums.Views
{
    /// <summary>
    /// Логика взаимодействия для PhotoView.xaml
    /// </summary>
    
    public partial class PhotoView : Window
    {
        private Album context;
        public PhotoView(Album context)
        {

            InitializeComponent();
            DataContext = context;
            this.context = context;

        }

        private void Prev_Click(object sender, RoutedEventArgs e)
        {
            int index = context.Photos.IndexOf(context.SelectedPhoto);
            context.SelectedPhoto=context.Photos.ElementAt(index-1 > 0 ? --index : context.Photos.Count-1);
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            int index = context.Photos.IndexOf(context.SelectedPhoto);
            context.SelectedPhoto = context.Photos.ElementAt(index+1 < context.Photos.Count ? ++index : 0);
        }
    }
}
