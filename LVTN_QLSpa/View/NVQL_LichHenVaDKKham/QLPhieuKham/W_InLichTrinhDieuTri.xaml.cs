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

namespace LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham
{
    /// <summary>
    /// Interaction logic for W_InLichTrinhDieuTri.xaml
    /// </summary>
    public partial class W_InLichTrinhDieuTri : Window
    {
        public W_InLichTrinhDieuTri()
        {
            InitializeComponent();
            grdEditLichTrinh.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (grdEditLichTrinh.Visibility == Visibility.Collapsed)
                grdEditLichTrinh.Visibility = Visibility.Visible;
            else if (grdEditLichTrinh.Visibility == Visibility.Visible)
                grdEditLichTrinh.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                this.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(print, "invoice");
                }
            }
            finally
            {
                this.IsEnabled = true;
            }
        }
    }
}
