using LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_DMT;
using LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_HSBenhAn;
using LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_KHAM;
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
    /// Interaction logic for MainUserManageExaminationAndTreatmentWindow.xaml
    /// </summary>
    public partial class MainUserManageExaminationAndTreatmentWindow : Window
    {
        public MainUserManageExaminationAndTreatmentWindow()
        {
            InitializeComponent();
        }

        private void RdHome_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new UC_DanhSachCho();
            GridMain.Children.Add(usc);
        }

        private void RdHome_Loaded(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new UC_DanhSachCho();
            GridMain.Children.Add(usc);
        }

        private void RdHistoryExamination_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new UC_HoSoBenhAn();
            GridMain.Children.Add(usc);
        }

        private void RdMedicine_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new UC_CapNhatDanhMucThuoc();
            GridMain.Children.Add(usc);
        }
    }
}
