using L052_Labb3_Code_along.Model;
using L052_Labb3_Code_along.ViewModel;
using System.Windows;

namespace L052_Labb3_Code_along
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();



        }
    }
}