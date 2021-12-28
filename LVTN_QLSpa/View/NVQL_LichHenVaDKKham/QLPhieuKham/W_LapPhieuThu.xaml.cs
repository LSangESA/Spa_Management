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
    /// Interaction logic for W_LapPhieuThu.xaml
    /// </summary>
    public partial class W_LapPhieuThu : Window
    {
        public W_LapPhieuThu()
        {
            InitializeComponent();
        }

        private void TxtTIENKHACHDUA_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (txtTIENKHACHDUA.Text == "" || txtTIENKHACHDUA.Text == "0")
                    return;
                decimal number;
                number = decimal.Parse(txtTIENKHACHDUA.Text, System.Globalization.NumberStyles.Currency);
                txtTIENTHUACHOKHACH.Text = (number - Convert.ToDecimal(txtTONGTHU.Text)).ToString();
                txtTIENKHACHDUA.Text = number.ToString("#,#");
                txtTIENKHACHDUA.SelectionStart = txtTIENKHACHDUA.Text.Length;
            }
            catch { }
        }

        private void TxtTIENTHUACHOKHACH_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txtTONGTHU.Text) > decimal.Parse(txtTIENKHACHDUA.Text, System.Globalization.NumberStyles.Currency))
                {
                    txtTIENTHUACHOKHACH.Text = "0";
                }
                else
                {
                    if (txtTIENTHUACHOKHACH.Text == "" || txtTIENTHUACHOKHACH.Text == "0")
                        return;
                    decimal number;
                    number = decimal.Parse(txtTIENTHUACHOKHACH.Text, System.Globalization.NumberStyles.Currency);
                    txtTIENTHUACHOKHACH.Text = number.ToString("#,#");
                }
            }
            catch { }
        }
    }
}
