using Microsoft.Win32;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace L049_Windows_and_Dialogs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonShowMessageBox_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("This is a message?", "Important message!", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Yes, it really is a message!");
            }
            else
            {
                MessageBox.Show("What?");
            }
        }

        private void buttonOpenFile_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();

            var result = dialog.ShowDialog();

            if (result == true)
            {
                buttonOpenFile.Content = System.IO.Path.GetFileName(dialog.FileName);
            }

        }

        private void buttonSaveFile_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Open save file dialog!");

            var dialog = new SaveFileDialog();

            var result = dialog.ShowDialog();

            if (result == true)
            {
                buttonSaveFile.Content = System.IO.Path.GetFileName(dialog.FileName);
            }

        }

        private void buttonPrint_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new PrintDialog();

            var result = dialog.ShowDialog();

            if (result == true)
            {
                buttonPrint.Content = "Printed!";
            }
        }
    }
}