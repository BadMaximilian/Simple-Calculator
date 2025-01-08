using System.Text;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HelloWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string text;
        public MainWindow()
        {
            InitializeComponent();
        }

        static double Magic(string expression) 
        {
            DataTable table = new DataTable();
            return Convert.ToDouble(table.Compute(expression, String.Empty));
        }

        private void click_button_1(object sender, RoutedEventArgs e)
        {
            whatever.Text += "1";
        }

        private void click_button_0(object sender, RoutedEventArgs e)
        {
            whatever.Text += "0";
        }

        private void click_button_backspace(object sender, RoutedEventArgs e)
        {
            whatever.Text = string.Empty;
        }

        private void click_button_equal(object sender, RoutedEventArgs e)
        {
            text = whatever.Text;
            string expression = text;
            var result = Magic(expression);
            whatever.Text = string.Empty;
            string int_result = result.ToString();
            whatever.Text = int_result;
        }

        private void click_button_plus(object sender, RoutedEventArgs e)
        {
            whatever.Text += "+";
        }

        private void click_button_2(object sender, RoutedEventArgs e)
        {
            whatever.Text += "2";
        }

        private void click_button_3(object sender, RoutedEventArgs e)
        {
            whatever.Text += "3";
        }

        private void click_button_minus(object sender, RoutedEventArgs e)
        {
            whatever.Text += "-";
        }

        private void click_button_4(object sender, RoutedEventArgs e)
        {
            whatever.Text += "4";
        }

        private void click_button_5(object sender, RoutedEventArgs e)
        {
            whatever.Text += "5";
        }

        private void click_button_6(object sender, RoutedEventArgs e)
        {
            whatever.Text += "6";
        }

        private void click_button_multiplication(object sender, RoutedEventArgs e)
        {
            whatever.Text += "*";
        }

        private void click_button_7(object sender, RoutedEventArgs e)
        {
            whatever.Text += "7";
        }

        private void click_button_9(object sender, RoutedEventArgs e)
        {
            whatever.Text += "9";
        }

        private void click_button_division(object sender, RoutedEventArgs e)
        {
            whatever.Text += "/";
        }
    }
}