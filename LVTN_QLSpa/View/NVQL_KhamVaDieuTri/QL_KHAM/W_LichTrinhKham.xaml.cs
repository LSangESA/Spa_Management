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
    /// Interaction logic for W_LichTrinhKham.xaml
    /// </summary>
    public partial class W_LichTrinhKham : Window
    {
        public W_LichTrinhKham()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            grdV2.Visibility = Visibility.Collapsed;
            grdV1.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            grdV2.Visibility = Visibility.Visible;
            grdV1.Visibility = Visibility.Collapsed;
        }
    }
}
