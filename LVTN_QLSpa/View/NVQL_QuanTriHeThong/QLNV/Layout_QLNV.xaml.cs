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

namespace LVTN_QLSpa.View.QLNV
{
    /// <summary>
    /// Interaction logic for Layout_QLNV.xaml
    /// </summary>
    public partial class Layout_QLNV : UserControl
    {
        public Layout_QLNV()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);

            GridCursor.Margin = new Thickness(10 + (200 * index), 0, 0, 0);

            UserControl usc = null;
            GridMain.Children.Clear();

            switch (index)
            {
                case 0:
                    usc = new UC_CapNhatNhanVien();
                    GridMain.Children.Add(usc);
                    break;
                case 1:
                    usc = new UC_PhuTrachDichVu();
                    GridMain.Children.Add(usc);
                    break;
                case 2:
                    usc = new UC_VaiTroVaChuyenMon();
                    GridMain.Children.Add(usc);
                    break;

                default:
                    break;
            }
        }

        private void Button_Loaded(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new UC_CapNhatNhanVien();
            GridMain.Children.Add(usc);
        }
    }
}
