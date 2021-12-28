using LVTN_QLSpa.ViewModel;
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

namespace LVTN_QLSpa.UserControlSpa
{
    /// <summary>
    /// Interaction logic for UseControlUC.xaml
    /// </summary>
    public partial class UseControlUC : UserControl
    {
        public ControlBarViewModel viewModel { get; set; }
        public UseControlUC()
        {
            InitializeComponent();
            this.DataContext = viewModel = new ControlBarViewModel();
        }
    }
}
