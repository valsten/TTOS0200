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

namespace wpfteht3
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

        private void calculatebutton_Click(object sender, RoutedEventArgs e)
        {
            double value1 = Int32.Parse(korkeusBox.Text);
            double value2 = Int32.Parse(leveysBox.Text);
            double value3 = Int32.Parse(karmipuuBox.Text);
            double calculation1 = value1 * value2;
            ikkunaBox.Text = calculation1.ToString("0.00") + " cm^2";

            double calculation2 = (value1 - value3) * (value2 - value3);
            lasiBox.Text = calculation2.ToString("0.00") + " cm^2";

            double calculation3 = calculation1 - calculation2;
            karmiBox.Text = calculation3.ToString("0.00") + " cm";
        }

        private void ikkunaBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox ikkunaBox = (TextBox)sender;
            ikkunaBox.Text = string.Empty;
            ikkunaBox.GotFocus -= ikkunaBox_GotFocus;
        }

        private void lasiBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox lasiBox = (TextBox)sender;
            lasiBox.Text = string.Empty;
            lasiBox.GotFocus -= lasiBox_GotFocus;
        }

        private void karmiBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox karmiBox = (TextBox)sender;
            karmiBox.Text = string.Empty;
            karmiBox.GotFocus -= karmiBox_GotFocus;
        }

        private void karmipuuBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox karmipuuBox = (TextBox)sender;
            karmipuuBox.Text = string.Empty;
            karmipuuBox.GotFocus -= karmipuuBox_GotFocus;
        }

        private void korkeusBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox korkeusBox = (TextBox)sender;
            korkeusBox.Text = string.Empty;
            korkeusBox.GotFocus -= korkeusBox_GotFocus;
        }

        private void leveysBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox leveysBox = (TextBox)sender;
            leveysBox.Text = string.Empty;
            leveysBox.GotFocus -= leveysBox_GotFocus;
        }
    }
}
