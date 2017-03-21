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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfteht2
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

        private void eurotomarkka_Click(object sender, RoutedEventArgs e)
        {
            double temp = Int32.Parse(amount.Text);
            double conversion = temp * 5.94573;
            converted.Text = conversion.ToString("0.00");
        }

        private void markkatoeuro_Click(object sender, RoutedEventArgs e)
        {
            double temp = Int32.Parse(amount.Text);
            double conversion = temp / 5.94573;
            converted.Text = conversion.ToString("0.00");
        }

        private void amount_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox amount = (TextBox)sender;
            amount.Text = string.Empty;
            amount.GotFocus -= amount_GotFocus;
        }
    }
}
