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

namespace L051_DataContext
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Planet mars;

        public MainWindow()
        {
            InitializeComponent();
            mars = new Planet() { Name = "Mars", Mass = 10.7 };
            mars.Moons.Add(new Moon() { Name = "Phobos", Mass = 0.5 });
            mars.Moons.Add(new Moon() { Name = "Deimos", Mass = 0.4 });

            DataContext = mars;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mars.Moons.Add(new Moon() { Name = myTextbox.Text });
            mars.Name = myTextbox.Text;
        }
    }
}