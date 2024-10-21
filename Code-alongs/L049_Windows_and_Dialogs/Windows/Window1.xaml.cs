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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //await Task.Delay(5000);

            //Thread.Sleep(5000);

            AddUserWindow addUserWindow = new();

            addUserWindow.FirstName = "";
            addUserWindow.LastName = "";

            var result = addUserWindow.ShowDialog();

            if (result == true)
            {
                listBox.Items.Add($"{addUserWindow.FirstName} {addUserWindow.LastName}");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NonDialogWindow window = new(myTextBox);

            window.Show();
        }
    }
}
