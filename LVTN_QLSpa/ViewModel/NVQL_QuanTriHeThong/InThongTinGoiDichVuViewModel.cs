using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LVTN_QLSpa.ViewModel.NVQL_QuanTriHeThong
{
    public class InThongTinGoiDichVuViewModel : BaseViewModel
    {
        public string MAGDV = CapNhatGoiDichVuViewModel.GDV_DATA.GDV_MA;

        private int? _GDV_SOLAN;
        public int? GDV_SOLAN { get => _GDV_SOLAN; set { _GDV_SOLAN = value; OnPropertyChanged(); } }

        private string _GDV_MOTA;
        public string GDV_MOTA { get => _GDV_MOTA; set { _GDV_MOTA = value; OnPropertyChanged(); } }

        private string _PP_TEN_MOTA;
        public string PP_TEN_MOTA { get => _PP_TEN_MOTA; set { _PP_TEN_MOTA = value; OnPropertyChanged(); } }

        private string _DONGIA;
        public string DONGIA { get => _DONGIA; set { _DONGIA = value; OnPropertyChanged(); } }

        private string _GDV_TEN;
        public string GDV_TEN { get => _GDV_TEN; set { _GDV_TEN = value; OnPropertyChanged(); } }

        private ObservableCollection<DG_LT> _LTList;
        public ObservableCollection<DG_LT> LTList { get => _LTList; set { _LTList = value; OnPropertyChanged(); } }

        public ICommand LoadWindow { get; set; }
        public ICommand CommandClose { get; set; }

        public InThongTinGoiDichVuViewModel()
        {
            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                MAGDV = CapNhatGoiDichVuViewModel.GDV_DATA.GDV_MA;
                var getInfoGDV = DataProvider.Ins.DB.DG_GDV.Where(x => x.GOIDICHVU.GDV_MA == MAGDV).SingleOrDefault();

                DONGIA = getInfoGDV.DONGIA;
                GDV_SOLAN = getInfoGDV.GOIDICHVU.GDV_SOLAN;
                PP_TEN_MOTA = getInfoGDV.GOIDICHVU.PHUONGPHAP.PP_TEN + " - " + getInfoGDV.GOIDICHVU.PHUONGPHAP.PP_MOTA;
                GDV_MOTA = getInfoGDV.GOIDICHVU.GDV_MOTA;
                GDV_TEN = getInfoGDV.GOIDICHVU.GDV_TEN;

                LTList = new ObservableCollection<DG_LT>(DataProvider.Ins.DB.DG_LT.Where(x => x.LIEUTRINH.GDV_MA == MAGDV));
            }
            );

            CommandClose = new RelayCommand<Window>((p) =>
            {
                return true;
            }, (p) =>
            {
                FrameworkElement window = GetWindowParent(p);
                var w = window as Window;
                if (w != null)
                {
                    w.Close();
                }
            }
            );
        }

        FrameworkElement GetWindowParent(Window p)
        {
            FrameworkElement parent = p;

            while (parent.Parent != null)
            {
                parent = parent.Parent as FrameworkElement;
            }

            return parent;
        }
    }
}
