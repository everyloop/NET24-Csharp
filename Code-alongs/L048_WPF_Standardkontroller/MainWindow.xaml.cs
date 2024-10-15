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

            comboBox.Items.Clear();
            comboBox.Items.Add(new Language("English", "Engelska"));
            comboBox.Items.Add(new Language("Swedish", "Svenska"));
            comboBox.DisplayMemberPath = "SwedishName";

            //listBox.Items.Clear();
            listBox.Items.Add("Spain");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myLabel.Content = textBox.Text;
            
            var language = new Language( textBox.Text, textBox2.Text );
            comboBox.Items.Add(language);
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            button.Content = textBox2.Text;
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                myLabel.Content = "ENTER";
            }
            else
            { 
                myLabel.Content = e.Key.ToString();
            }
        }

        private void checkBox_Click(object sender, RoutedEventArgs e)
        {
            button.IsEnabled = (checkBox.IsChecked == true);
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            if (radioButtonA.IsChecked == true)
            {
                myLabel.Content = "Option A";
            }
            else if (radioButtonB.IsChecked == true)
            {
                myLabel.Content = "Option B";
            }
            else if (radioButtonC.IsChecked == true)
            {
                myLabel.Content = "Option C";
            }
            else if (radioButtonD.IsChecked == true)
            {
                myLabel.Content = "Option D";
            }
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            myLabel.Content = slider.Value.ToString("N2");
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Language language = comboBox.SelectedItem as Language;
            Language? language = comboBox.Items[comboBox.SelectedIndex] as Language;

            textBox.Text = language.EnglishName;
            textBox2.Text = language.SwedishName;
        }
    }

    public class Language
    {
        public Language(string englishName, string swedishName)
        {
            EnglishName = englishName;
            SwedishName = swedishName;
        }

        public string EnglishName { get; set; }
        public string SwedishName { get; set; }
    }
}