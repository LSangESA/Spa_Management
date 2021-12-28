using LVTN_QLSpa.View.NVQL_LichHenVaDKKham.TrangChu;
using LVTN_QLSpa.View.NVQL_QuanTriHeThong.TrangChu;
using LVTN_QLSpa.View.QLCTKM;
using LVTN_QLSpa.View.QLDV;
using LVTN_QLSpa.View.QLLLV;
using LVTN_QLSpa.View.QLNV;
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
    /// Interaction logic for MainUserManage.xaml
    /// </summary>
    public partial class MainUserManageWindow : Window
    {
        public MainUserManageWindow()
        {
            InitializeComponent();
        }
        
        private void RdService_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new Layout_QLDV();
            GridMain.Children.Add(usc);
        }

        private void RdDiscount_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new UC_ChuongTrinhKhuyenMai();
            GridMain.Children.Add(usc);
        }

        private void RdEmployees_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new Layout_QLNV();
            GridMain.Children.Add(usc);
        }

        private void RdCalendar_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new Layout_QLLLV();
            GridMain.Children.Add(usc);
        }

        private void RdCalendar_Loaded(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new Layout_QLLLV();
            GridMain.Children.Add(usc);
        }

        //private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        //{
        //    ButtonCloseMenu.Visibility = Visibility.Visible;
        //    ButtonOpenMenu.Visibility = Visibility.Collapsed;
        //}

        //private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        //{
        //    ButtonCloseMenu.Visibility = Visibility.Collapsed;
        //    ButtonOpenMenu.Visibility = Visibility.Visible;
        //}

        //private void LvMenu_Loaded(object sender, RoutedEventArgs e)
        //{
        //    UserControl usc = null;
        //    GridMain.Children.Clear();

        //    usc = new Layout_QLNV();
        //    GridMain.Children.Add(usc);
        //}

        //private void LvMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    UserControl usc = null;
        //    GridMain.Children.Clear();

        //    switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
        //    {
        //        case "Item1":
        //            usc = new Layout_QLNV();
        //            GridMain.Children.Add(usc);
        //            break;
        //        case "Item2":
        //            usc = new Layout_QLDV();
        //            GridMain.Children.Add(usc);
        //            break;
        //        case "Item3":
        //            usc = new UC_ChuongTrinhKhuyenMai();
        //            GridMain.Children.Add(usc);
        //            break;
        //        case "Item4":
        //            usc = new Layout_QLLLV();
        //            GridMain.Children.Add(usc);
        //            break;
        //        case "Item5":
        //            usc = new UC_ThongTinKhachHang();
        //            GridMain.Children.Add(usc);
        //            break;
        //        case "Item6":
        //            usc = new UC_CapNhatDanhMucThuoc();
        //            GridMain.Children.Add(usc);
        //            break;
        //        default:
        //            break;
        //    }
        //}


        //private void btnExit_Click(object sender, RoutedEventArgs e)
        //{
        //    Application.Current.Shutdown();
        //}



        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    UserControl usc = null;
        //    GridMain.Children.Clear();

        //    usc = new Layout_QLNV();
        //    GridMain.Children.Add(usc);
        //}

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    UserControl usc = null;
        //    GridMain.Children.Clear();

        //    usc = new Layout_QLDV();
        //    GridMain.Children.Add(usc);
        //}
    }
}
