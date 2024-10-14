using System.Globalization;
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

namespace L047_Intro_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int counter = 1;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (sender as Button);

            //MessageBox.Show($"Du klickade på knapp '{button.Content}'");

            button.HorizontalAlignment = button.HorizontalAlignment == HorizontalAlignment.Right
                ? HorizontalAlignment.Left
                : HorizontalAlignment.Right;

            Button newButton = new Button() { Content = counter++, Width = 50, Margin = new Thickness(0, 10, 10, 10) };
            myStackPanel.Children.Add(newButton);

        }

        private void ButtonClick1(object sender, RoutedEventArgs e)
        {
            Button button = (sender as Button);

            //button.Visibility = Visibility.Hidden;
            
            button1.IsEnabled = !button1.IsEnabled;
        }
    }
}