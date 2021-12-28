using LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLLichHen;
using LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuThu;
using LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLTTKH;
using LVTN_QLSpa.View.NVQL_LichHenVaDKKham.TrangChu;
using LVTN_QLSpa.View.NVQL_QuanTriHeThong.TrangChu;
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

namespace LVTN_QLSpa.View
{
    /// <summary>
    /// Interaction logic for MainUserManageAppointmentsAndRegistrationsWindow.xaml
    /// </summary>
    public partial class MainUserManageAppointmentsAndRegistrationsWindow : Window
    {
        public MainUserManageAppointmentsAndRegistrationsWindow()
        {
            InitializeComponent();
        }

        private void RdHome_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new UC_Main();
            GridMain.Children.Add(usc);
        }

        private void RdHome_Loaded(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new UC_Main();
            GridMain.Children.Add(usc);
        }

        private void RdCustomer_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new UC_ThongTinKhachHang();
            GridMain.Children.Add(usc);
        }

        private void RdAppointmentSchedule_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new UC_LichHen();
            GridMain.Children.Add(usc);
        }

        private void RdInvoice_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new UC_BaoCaoPhieuThu();
            GridMain.Children.Add(usc);
        }
    }
}
