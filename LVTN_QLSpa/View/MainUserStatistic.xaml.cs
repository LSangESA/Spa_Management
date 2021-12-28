using LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLLLV;
using LVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeDichVu;
using LVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeDoanhThu;
using LVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeNo;
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
    /// Interaction logic for MainUserStatistic.xaml
    /// </summary>
    public partial class MainUserStatistic : Window
    {
        public MainUserStatistic()
        {
            InitializeComponent();
        }

        private void RdChart_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new UC_ThongKeDoanhThu();
            GridMain.Children.Add(usc);
        }

        private void RdChart_Loaded(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new UC_ThongKeDoanhThu();
            GridMain.Children.Add(usc);
        }

        private void RdChartService_Click(object sender, RoutedEventArgs e)
        {
            
            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new UC_ThongKeDichVu();
            GridMain.Children.Add(usc);
        }

        private void RdCalendar_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new UC_LichLamViec();
            GridMain.Children.Add(usc);
        }

        private void RdOwe_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new UC_ThongKeNo();
            GridMain.Children.Add(usc);
        }
    }
}
