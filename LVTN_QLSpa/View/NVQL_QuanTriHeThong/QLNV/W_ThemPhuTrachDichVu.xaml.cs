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

namespace LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLNV
{
    /// <summary>
    /// Interaction logic for W_ThemPhuTrachDichVu.xaml
    /// </summary>
    public partial class W_ThemPhuTrachDichVu : Window
    {
        public W_ThemPhuTrachDichVu()
        {
            InitializeComponent();
            grdPhuTrachNV.Visibility = Visibility.Visible;
            grdPhuTrachAllNV.Visibility = Visibility.Collapsed;
            btnLuuPhuTrachNhieuNV.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            grdPhuTrachNV.Visibility = Visibility.Collapsed;
            grdPhuTrachAllNV.Visibility = Visibility.Visible;
            btnLuuPhuTrachNhieuNV.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            grdPhuTrachNV.Visibility = Visibility.Visible;
            grdPhuTrachAllNV.Visibility = Visibility.Collapsed;
            btnLuuPhuTrachNhieuNV.Visibility = Visibility.Collapsed;
        }
    }
}
