using Albums.ViewModels;
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
      public partial class InputBox : Window
      {
        private CommandTemplate acceptCommand;
        public string Message { get; set; }
        public CommandTemplate AcceptCommand
        {
            get
            {
                return acceptCommand ?? (acceptCommand = new CommandTemplate(
              obj => DialogResult = true,
              obj =>
              {
                  if (string.IsNullOrWhiteSpace(str.Text))
                      return false;
                  return true;
              }));
            }
        }
        public InputBox(string message)
        {
            Message = message;
            InitializeComponent();
        }

        public string Text
        {
            get { return str.Text; }
        }

      }
}
