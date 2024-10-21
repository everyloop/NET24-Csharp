using System.Windows;

namespace L049_Windows_and_Dialogs.Windows
{
    /// <summary>
    /// Interaction logic for AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        public string FirstName
        {
            get
            {
                return textboxFirstName.Text;
            }
            set
            {
                textboxFirstName.Text = value;
            }
        }

        public string LastName
        {
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

        //private string Greet(string name) => $"Hi, {name}!";
        //private void GreetPrint(string name) => Console.WriteLine($"Hi, {name}!");

    }
}
