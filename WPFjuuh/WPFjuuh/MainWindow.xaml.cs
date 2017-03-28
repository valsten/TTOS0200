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

namespace WPFjuuh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            InitializeMyStuff();
        }

        private void InitializeMyStuff()
        {
            cbMagazine.Items.Add("");
            cbMagazine.Items.Add("Pelit");
            cbMagazine.Items.Add("Aku Ankka");
            cbMagazine.Items.Add("Korkeajännitys");
            cbMagazine.Items.Add("Seiska");
        }
        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            string msg = "";

            foreach(object control in spMarx.Children)
            {
                if(control is CheckBox)
                {
                    CheckBox cb = (CheckBox)control;
                    if ((bool)cb.IsChecked)
                    {
                        msg += cb.Content + "\n";
                    }
                }
            }

            msg += cbMagazine.SelectedValue;

            txbList.Text = msg;
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            About yee = new About();
            yee.ShowDialog();
        }
    }
}
