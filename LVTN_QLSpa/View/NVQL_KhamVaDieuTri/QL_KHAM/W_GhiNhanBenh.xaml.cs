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
using System.Windows.Shapes;

namespace LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_KHAM
{
    /// <summary>
    /// Interaction logic for W_GhiNhanBenh.xaml
    /// </summary>
    public partial class W_GhiNhanBenh : Window
    {
        public W_GhiNhanBenh()
        {
            InitializeComponent();
            grdTT.Visibility = Visibility.Collapsed;
            rdTT.Height = GridLength.Auto;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            grdCDDT.Visibility = Visibility.Collapsed;
            grdTT.Visibility = Visibility.Visible;
            rdCDDT.Height = GridLength.Auto;
            rdTT.Height = new GridLength(1.0, GridUnitType.Star);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            grdTT.Visibility = Visibility.Collapsed;
            grdCDDT.Visibility = Visibility.Visible;
            rdTT.Height = GridLength.Auto;
            rdCDDT.Height = new GridLength(1.0, GridUnitType.Star);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
