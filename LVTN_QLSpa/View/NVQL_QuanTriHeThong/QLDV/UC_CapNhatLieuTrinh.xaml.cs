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

namespace LVTN_QLSpa.View.QLDV
{
    /// <summary>
    /// Interaction logic for UC_CapNhatLieuTrinh.xaml
    /// </summary>
    public partial class UC_CapNhatLieuTrinh : UserControl
    {
        public UC_CapNhatLieuTrinh()
        {
            InitializeComponent();
        }

        private void TxtGiaLieuTrinh_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (txtGiaLieuTrinh.Text == "" || txtGiaLieuTrinh.Text == "0")
                    return;
                decimal number;
                number = decimal.Parse(txtGiaLieuTrinh.Text, System.Globalization.NumberStyles.Currency);
                txtGiaLieuTrinh.Text = number.ToString("#,#");
                txtGiaLieuTrinh.SelectionStart = txtGiaLieuTrinh.Text.Length;
            }
            catch { }
        }
    }
}
