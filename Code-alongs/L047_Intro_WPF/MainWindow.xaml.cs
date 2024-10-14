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
        public MainWindow()
        {
            InitializeComponent();
            //Button button = new Button() { Content = "Hello" };
            //button.Content = "Hello";
            //button.HorizontalAlignment = HorizontalAlignment.Left;

            var stackPanel = new StackPanel();

            stackPanel.Children.Add(new Button());
            stackPanel.Children.Add(new Label());

        }
    }
}