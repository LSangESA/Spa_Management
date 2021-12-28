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
    /// Interaction logic for UC_CapNhatGoiDichVu.xaml
    /// </summary>
    public partial class UC_CapNhatGoiDichVu : UserControl
    {
        public UC_CapNhatGoiDichVu()
        {
            InitializeComponent();
        }

        private void TxtGDV_DONGIA_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (txtGDV_DONGIA.Text == "" || txtGDV_DONGIA.Text == "0")
                    return;
                decimal number;
                number = decimal.Parse(txtGDV_DONGIA.Text, System.Globalization.NumberStyles.Currency);
                txtGDV_DONGIA.Text = number.ToString("#,#");
                txtGDV_DONGIA.SelectionStart = txtGDV_DONGIA.Text.Length;
            }
            catch { }
            
        }
    }
}
