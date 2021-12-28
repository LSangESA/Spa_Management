using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.ModelClass;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace LVTN_QLSpa.View.QLNV
{
    /// <summary>
    /// Interaction logic for QuanLyNhanVien.xaml
    /// </summary>
    public partial class UC_CapNhatNhanVien : UserControl
    {
        public ObservableCollection<ClassChuyenMonNhanVien> ListChuyenMonNhanVien;
        public UC_CapNhatNhanVien()
        {
            InitializeComponent();
        }

        private void ChkTaoTaiKhoan_Checked(object sender, RoutedEventArgs e)
        {
            txtTaiKhoan.IsEnabled = false;
        }

        private void ChkTaoTaiKhoan_Unchecked(object sender, RoutedEventArgs e)
        {
            txtTaiKhoan.IsEnabled = true;
        }
        
    }
}
