using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham;
using LVTN_QLSpa.ViewModel.NVQL_QuanTriHeThong;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LVTN_QLSpa.ViewModel.NVDK_LichHenVaDangKy
{
    public class ThemKhachHangPDKViewModel : BaseViewModel
    {
        private static string kh_MA_DATA;
        public static string KH_MA_DATA
        {
            get { return ThemKhachHangPDKViewModel.kh_MA_DATA; }
            set { ThemKhachHangPDKViewModel.kh_MA_DATA = value; }
        }

        private string _KH_TEN;
        public string KH_TEN { get => _KH_TEN; set { _KH_TEN = value; OnPropertyChanged(); } }

        private string _KH_SDT;
        public string KH_SDT { get => _KH_SDT; set { _KH_SDT = value; OnPropertyChanged(); } }

        private string _KH_EMAIL;
        public string KH_EMAIL { get => _KH_EMAIL; set { _KH_EMAIL = value; OnPropertyChanged(); } }

        private DateTime _KH_NGAYSINH;
        public DateTime KH_NGAYSINH { get => _KH_NGAYSINH; set { _KH_NGAYSINH = value; OnPropertyChanged(); } }

        private string _KH_DIACHI;
        public string KH_DIACHI { get => _KH_DIACHI; set { _KH_DIACHI = value; OnPropertyChanged(); } }

        private string _KH_GIOITINHNAM;
        public string KH_GIOITINHNAM { get => _KH_GIOITINHNAM; set { _KH_GIOITINHNAM = value; OnPropertyChanged(); } }

        private string _KH_GIOITINHNU;
        public string KH_GIOITINHNU { get => _KH_GIOITINHNU; set { _KH_GIOITINHNU = value; OnPropertyChanged(); } }

        private string _KH_GIOITINH;
        public string KH_GIOITINH { get => _KH_GIOITINH; set { _KH_GIOITINH = value; OnPropertyChanged(); } }

        private ObservableCollection<XAPHUONG> _XAPHUONG;
        public ObservableCollection<XAPHUONG> XAPHUONG { get => _XAPHUONG; set { _XAPHUONG = value; OnPropertyChanged(); } }

        private ObservableCollection<HUYENQUAN> _HUYENQUAN;
        public ObservableCollection<HUYENQUAN> HUYENQUAN { get => _HUYENQUAN; set { _HUYENQUAN = value; OnPropertyChanged(); } }

        private ObservableCollection<TINHTHANH> _TINHTHANH;
        public ObservableCollection<TINHTHANH> TINHTHANH { get => _TINHTHANH; set { _TINHTHANH = value; OnPropertyChanged(); } }

        private ObservableCollection<KHACHHANG> _KHACHHANG;
        public ObservableCollection<KHACHHANG> KHACHHANG { get => _KHACHHANG; set { _KHACHHANG = value; OnPropertyChanged(); } }

        private XAPHUONG _SelectedXAPHUONG;
        public XAPHUONG SelectedXAPHUONG
        {
            get => _SelectedXAPHUONG;
            set
            {
                _SelectedXAPHUONG = value;
                OnPropertyChanged();
            }
        }

        private HUYENQUAN _SelectedHUYENQUAN;
        public HUYENQUAN SelectedHUYENQUAN
        {
            get => _SelectedHUYENQUAN;
            set
            {
                _SelectedHUYENQUAN = value;
                OnPropertyChanged();
            }
        }

        private TINHTHANH _SelectedTINHTHANH;
        public TINHTHANH SelectedTINHTHANH
        {
            get => _SelectedTINHTHANH;
            set
            {
                _SelectedTINHTHANH = value;
                OnPropertyChanged();
            }
        }

        private KHACHHANG _SelectedKHACHHANG;
        public KHACHHANG SelectedKHACHHANG
        {
            get => _SelectedKHACHHANG;
            set
            {
                _SelectedKHACHHANG = value;
                OnPropertyChanged();
            }
        }

        public ICommand CheckedChangeCommandKHGTNAM { get; set; }
        public ICommand CheckedChangeCommandKHGTNU { get; set; }
        public ICommand CommandAddKhachHang { get; set; }
        public ICommand CommandClose { get; set; }
        public ICommand LoadWindow { get; set; }
        public ICommand CommandSelectTinhThanh { get; set; }
        public ICommand CommandSelectHuyenQuan { get; set; }
        public ICommand CommandSelectKhachHang { get; set; }

        public ThemKhachHangPDKViewModel()
        {
            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                LoadKhachHang(LapPhieuDangKyViewModel.KH_MA_DATA);
            }
            );

            CheckedChangeCommandKHGTNAM = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                if (KH_GIOITINHNAM == "True")
                    KH_GIOITINHNU = "False";
                else if (KH_GIOITINHNAM == "False")
                    KH_GIOITINHNU = "True";
            }
            );

            CheckedChangeCommandKHGTNU = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                if (KH_GIOITINHNU == "True")
                    KH_GIOITINHNAM = "False";
                else if (KH_GIOITINHNU == "False")
                    KH_GIOITINHNAM = "True";
            }
            );

            CommandAddKhachHang = new RelayCommand<Window>((p) =>
            {
                if (string.IsNullOrEmpty(KH_TEN) ||string.IsNullOrEmpty(KH_SDT))
                    return false;

                return true;
            }, (p) =>
            {
                if(SelectedKHACHHANG != null)
                {
                    var getKhachHang = DataProvider.Ins.DB.KHACHHANG.Where(x => x.KH_MA == SelectedKHACHHANG.KH_MA).SingleOrDefault();
                    if(SelectedKHACHHANG.KH_MA == getKhachHang.KH_MA)
                    {
                        KH_MA_DATA = SelectedKHACHHANG.KH_MA;
                        FrameworkElement window = GetWindowParent(p);
                        var w = window as Window;
                        if (w != null)
                        {
                            w.Close();
                        }
                    }
                }
                else
                {
                    if (KH_GIOITINHNAM == "True")
                    {
                        KH_GIOITINH = "Nam";
                    }
                    else if (KH_GIOITINHNU == "True")
                    {
                        KH_GIOITINH = "Nu";
                    }

                    Random r = new Random();
                    var khachhang = new KHACHHANG()
                    {
                        KH_MA = "KH" + r.Next(10000, 99999).ToString(),
                        KH_HOTEN = KH_TEN,
                        KH_DIACHI = KH_DIACHI,
                        KH_EMAIL = KH_EMAIL,
                        KH_NGAYSINH = KH_NGAYSINH,
                        KH_SDT = KH_SDT,
                        KH_GIOITINH = KH_GIOITINH,
                        XP_MA = SelectedXAPHUONG.XP_MA
                    };

                    DataProvider.Ins.DB.KHACHHANG.Add(khachhang);
                    DataProvider.Ins.DB.SaveChanges();

                    KH_MA_DATA = khachhang.KH_MA;

                    FrameworkElement window = GetWindowParent(p);
                    var w = window as Window;
                    if (w != null)
                    {
                        w.Close();
                    }
                }
            }
            );

            CommandClose = new RelayCommand<Window>((p) =>
            {
                return true;
            }, (p) =>
            {
                KH_MA_DATA = null;
                FrameworkElement window = GetWindowParent(p);
                var w = window as Window;
                if (w != null)
                {
                    w.Close();
                }
            }
            );

            CommandSelectTinhThanh = new RelayCommand<object>((p) =>
            {
                if (SelectedTINHTHANH == null)
                    return false;
                return true;
            }, (p) =>
            {
                HUYENQUAN = DAO_Address.GetListHuyenQuan(SelectedTINHTHANH.TT_MA);
            }
            );

            CommandSelectHuyenQuan = new RelayCommand<object>((p) =>
            {
                if (SelectedHUYENQUAN == null)
                    return false;
                return true;
            }, (p) =>
            {
                XAPHUONG = DAO_Address.GetListXaPhuong(SelectedHUYENQUAN.HQ_MA);
            }
            );

            CommandSelectKhachHang = new RelayCommand<object>((p) =>
            {
                if (SelectedKHACHHANG == null)
                    return false;
                return true;
            }, (p) =>
            {
                KH_TEN = SelectedKHACHHANG.KH_HOTEN;
                KH_SDT = SelectedKHACHHANG.KH_SDT;
                KH_NGAYSINH = SelectedKHACHHANG.KH_NGAYSINH;
                KH_EMAIL = SelectedKHACHHANG.KH_EMAIL;
                KH_DIACHI = SelectedKHACHHANG.KH_DIACHI;
                SelectedXAPHUONG = SelectedKHACHHANG.XAPHUONG;
                SelectedHUYENQUAN = SelectedKHACHHANG.XAPHUONG.HUYENQUAN;
                SelectedTINHTHANH = SelectedKHACHHANG.XAPHUONG.HUYENQUAN.TINHTHANH;
                if (SelectedKHACHHANG.KH_GIOITINH == "Nam")
                {
                    KH_GIOITINHNAM = "True";
                    KH_GIOITINHNU = "False";
                }
                else
                {
                    KH_GIOITINHNAM = "False";
                    KH_GIOITINHNU = "True";
                }
            }
            );
        }

        void LoadKhachHang(string KH_MA_Data)
        {
            if (string.IsNullOrEmpty(KH_MA_Data))
            {
                KHACHHANG = new ObservableCollection<KHACHHANG>(DataProvider.Ins.DB.KHACHHANG);
                XAPHUONG = DAO_Address.GetListXaPhuong();
                HUYENQUAN = DAO_Address.GetListHuyenQuan();
                TINHTHANH = DAO_Address.GetListTinhThanh();
                SelectedHUYENQUAN = null;
                SelectedXAPHUONG = null;
                SelectedTINHTHANH = null;
                SelectedKHACHHANG = null;

                KH_DIACHI = "";
                KH_EMAIL = "";
                KH_SDT = "";
                KH_TEN = "";
            }
            else
            {
                var getKH = DataProvider.Ins.DB.KHACHHANG.Where(x => x.KH_MA == KH_MA_Data).SingleOrDefault();
                KH_TEN = getKH.KH_HOTEN;
                KH_SDT = getKH.KH_SDT;
                KH_NGAYSINH = getKH.KH_NGAYSINH;
                KH_EMAIL = getKH.KH_EMAIL;
                KH_DIACHI = getKH.KH_DIACHI;
                SelectedXAPHUONG = getKH.XAPHUONG;
                SelectedHUYENQUAN = getKH.XAPHUONG.HUYENQUAN;
                SelectedTINHTHANH = getKH.XAPHUONG.HUYENQUAN.TINHTHANH;
                SelectedKHACHHANG = getKH;
                if (getKH.KH_GIOITINH == "Nam")
                {
                    KH_GIOITINHNAM = "True";
                    KH_GIOITINHNU = "False";
                }
                else
                {
                    KH_GIOITINHNAM = "False";
                    KH_GIOITINHNU = "True";
                }
            }
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
