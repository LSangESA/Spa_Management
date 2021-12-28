using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using LVTN_QLSpa.Model.ModelClass;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LVTN_QLSpa.ViewModel.NVBS_QuanLyKhamVaDieuTri
{
    public class InToaThuocViewModel : BaseViewModel
    {
        private string _PDT_STT;
        public string PDT_STT { get => _PDT_STT; set { _PDT_STT = value; OnPropertyChanged(); } } 

        private string _LT_MOTA;
        public string LT_MOTA { get => _LT_MOTA; set { _LT_MOTA = value; OnPropertyChanged(); } }

        private string _GDV_TEN;
        public string GDV_TEN { get => _GDV_TEN; set { _GDV_TEN = value; OnPropertyChanged(); } }

        private string _KH_HOTEN;
        public string KH_HOTEN { get => _KH_HOTEN; set { _KH_HOTEN = value; OnPropertyChanged(); } }

        private DateTime _NGAY;
        public DateTime NGAY { get => _NGAY; set { _NGAY = value; OnPropertyChanged(); } }

        private string _PDT_CHUANDOAN;
        public string PDT_CHUANDOAN { get => _PDT_CHUANDOAN; set { _PDT_CHUANDOAN = value; OnPropertyChanged(); } }

        private string _PDT_LOIDAN;
        public string PDT_LOIDAN { get => _PDT_LOIDAN; set { _PDT_LOIDAN = value; OnPropertyChanged(); } }

        private ObservableCollection<ClassToaThuoc> _CHIDINHList;
        public ObservableCollection<ClassToaThuoc> CHIDINHList { get => _CHIDINHList; set { _CHIDINHList = value; OnPropertyChanged(); } }

        public ICommand LoadWindow { get; set; }
        public ICommand CommandThoat { get; set; }

        static int i = 0;
        public InToaThuocViewModel()
        {
            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                var phieuDieuTri = DanhSachChoViewModel.PDT_DATA;

                CHIDINHList = new ObservableCollection<ClassToaThuoc>();
                var chidinhList = new ObservableCollection<CHIDINH>(DataProvider.Ins.DB.CHIDINH.Where(x => x.PDT_STT == phieuDieuTri.PDT_STT && x.PHIEUDIEUTRI.PDK_STT == phieuDieuTri.PDK_STT));


                foreach (var item in chidinhList)
                {
                    int stt = ++i;
                    var ClassToaThuoc = new ClassToaThuoc();
                    ClassToaThuoc.DVT_TEN = item.THUOC.DVT.DVT_TEN;
                    ClassToaThuoc.T_TEN = item.THUOC.T_TEN + ", ";
                    ClassToaThuoc.CD_CACHDUNG = item.CD_CACHDUNG;
                    ClassToaThuoc.CD_LIEUDUNG = item.CD_LIEUDUNG + ", ";
                    ClassToaThuoc.CD_SOLUONG = item.CD_SOLUONG;
                    ClassToaThuoc.T_STT = (stt).ToString() + "/ ";

                    CHIDINHList.Add(ClassToaThuoc);
                }

                var getInfoKH = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDT_STT == phieuDieuTri.PDT_STT && x.PDK_STT == phieuDieuTri.PDK_STT).SingleOrDefault();
                PDT_STT = getInfoKH.PDT_STT;
                KH_HOTEN = getInfoKH.PHIEUDANGKY.KHACHHANG.KH_HOTEN;
                GDV_TEN = getInfoKH.PHIEUDANGKY.GOIDICHVU.GDV_TEN;
                NGAY = getInfoKH.PDT_NGAYLAP;
                PDT_CHUANDOAN = getInfoKH.PDT_CHUANDOAN;
                PDT_LOIDAN = getInfoKH.PDT_LOIDAN;

                if (phieuDieuTri.PHIEUDANGKY.GOIDICHVU.LOAIGOIDICHVU.LGDV_MA == 1)
                {
                    int SOPDT = Convert.ToInt32(phieuDieuTri.PDT_STT);
                    var lieuTrinh = DataProvider.Ins.DB.LIEUTRINH.Where(x => x.GDV_MA == phieuDieuTri.PHIEUDANGKY.GDV_MA && x.LT_STT == SOPDT).SingleOrDefault();
                    LT_MOTA = lieuTrinh.LT_STT + " - " + lieuTrinh.LT_MOTA;
                }
                else
                {
                    LT_MOTA = "";
                }
            }
            );

            CommandThoat = new RelayCommand<Window>((p) =>
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
