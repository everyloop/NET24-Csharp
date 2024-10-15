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

namespace L048_WPF_Standardkontroller
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newButton = new Button() { 
                Content = $"Button{wrapPanel.Children.Count}", 
                Margin = new Thickness(10, 10, 0, 0), 
                VerticalAlignment = VerticalAlignment.Top 
            };

            wrapPanel.Children.Add(newButton);
        }
    }
}