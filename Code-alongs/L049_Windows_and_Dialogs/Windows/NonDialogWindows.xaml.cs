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

namespace L049_Windows_and_Dialogs.Windows
{
    /// <summary>
    /// Interaction logic for NonDialogWindows.xaml
    /// </summary>
    public partial class NonDialogWindow : Window
    {
        private readonly TextBox textBox;

        public NonDialogWindow(TextBox textBox)
        {
            InitializeComponent();
            this.textBox = textBox;
            myLabel.Content = textBox.Text;            
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            myLabel.Content = textBox.Text;
        }
    }
}
