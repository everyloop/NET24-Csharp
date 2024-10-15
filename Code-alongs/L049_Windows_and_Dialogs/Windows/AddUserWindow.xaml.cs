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
    /// Interaction logic for AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        public string FirstName { get => textboxFirstName.Text; }
        public string LastName {
            get
            {
                return textboxLastName.Text;
            }
            set
            {
                textboxLastName.Text = value;
            }
        }

        public AddUserWindow()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private string Greet(string name) => $"Hi, {name}!";
        private void GreetPrint(string name) => Console.WriteLine($"Hi, {name}!");

    }
}
