using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using LVTN_QLSpa.Model.ModelClass;
using LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LVTN_QLSpa.ViewModel.NVDK_LichHenVaDangKy
{
    public class TaoLichHenViewModel : BaseViewModel
    {
        private Visibility _ShowKhachHang;
        public Visibility ShowKhachHang { get => _ShowKhachHang; set { _ShowKhachHang = value; OnPropertyChanged(); } }

        private string _KH_HOTEN;
        public string KH_HOTEN { get => _KH_HOTEN; set { _KH_HOTEN = value; OnPropertyChanged(); } }

        private string _KH_SDT;
        public string KH_SDT { get => _KH_SDT; set { _KH_SDT = value; OnPropertyChanged(); } }

        private string _KH_EMAIL;
        public string KH_EMAIL { get => _KH_EMAIL; set { _KH_EMAIL = value; OnPropertyChanged(); } }

        private DateTime _KH_NGAYSINH;
        public DateTime KH_NGAYSINH { get => _KH_NGAYSINH; set { _KH_NGAYSINH = value; OnPropertyChanged(); } }

        private string _KH_DIACHI;
        public string KH_DIACHI { get => _KH_DIACHI; set { _KH_DIACHI = value; OnPropertyChanged(); } }

        private string _KH_ANHS;
        public string KH_ANHS { get => _KH_ANHS; set { _KH_ANHS = value; OnPropertyChanged(); } }

        private string _KH_MAS;
        public string KH_MAS { get => _KH_MAS; set { _KH_MAS = value; OnPropertyChanged(); } }

        private string _KH_HOTENS;
        public string KH_HOTENS { get => _KH_HOTENS; set { _KH_HOTENS = value; OnPropertyChanged(); } }

        private string _KH_SDTS;
        public string KH_SDTS { get => _KH_SDTS; set { _KH_SDTS = value; OnPropertyChanged(); } }

        private string _KH_EMAILS;
        public string KH_EMAILS { get => _KH_EMAILS; set { _KH_EMAILS = value; OnPropertyChanged(); } }

        private string _KH_GIOITINHS;
        public string KH_GIOITINHS { get => _KH_GIOITINHS; set { _KH_GIOITINHS = value; OnPropertyChanged(); } }

        private DateTime _KH_NGAYSINHS;
        public DateTime KH_NGAYSINHS { get => _KH_NGAYSINHS; set { _KH_NGAYSINHS = value; OnPropertyChanged(); } }

        private string _KH_DIACHIS;
        public string KH_DIACHIS { get => _KH_DIACHIS; set { _KH_DIACHIS = value; OnPropertyChanged(); } }

        private DateTime _LH_NGAYDEN;
        public DateTime LH_NGAYDEN { get => _LH_NGAYDEN; set { _LH_NGAYDEN = value; OnPropertyChanged(); } }

        private TimeSpan _LH_THOIGIANDEN;
        public TimeSpan LH_THOIGIANDEN { get => _LH_THOIGIANDEN; set { _LH_THOIGIANDEN = value; OnPropertyChanged(); } }

        private string _LH_GHICHU;
        public string LH_GHICHU { get => _LH_GHICHU; set { _LH_GHICHU = value; OnPropertyChanged(); } }

        private LICHHEN _LICHHEN;
        public LICHHEN LICHHEN { get => _LICHHEN; set { _LICHHEN = value; OnPropertyChanged(); } }

        private ObservableCollection<KHACHHANG> _KHACHHANG;
        public ObservableCollection<KHACHHANG> KHACHHANG { get => _KHACHHANG; set { _KHACHHANG = value; OnPropertyChanged(); } }

        private ObservableCollection<XAPHUONG> _XAPHUONG;
        public ObservableCollection<XAPHUONG> XAPHUONG { get => _XAPHUONG; set { _XAPHUONG = value; OnPropertyChanged(); } }

        private ObservableCollection<HUYENQUAN> _HUYENQUAN;
        public ObservableCollection<HUYENQUAN> HUYENQUAN { get => _HUYENQUAN; set { _HUYENQUAN = value; OnPropertyChanged(); } }

        private ObservableCollection<TINHTHANH> _TINHTHANH;
        public ObservableCollection<TINHTHANH> TINHTHANH { get => _TINHTHANH; set { _TINHTHANH = value; OnPropertyChanged(); } }

        private ObservableCollection<GIOITINH> _GIOITINH;
        public ObservableCollection<GIOITINH> GIOITINH { get => _GIOITINH; set { _GIOITINH = value; OnPropertyChanged(); } }

        private ObservableCollection<GOIDICHVU> _GOIDICHVU;
        public ObservableCollection<GOIDICHVU> GOIDICHVU { get => _GOIDICHVU; set { _GOIDICHVU = value; OnPropertyChanged(); } }

        private ObservableCollection<ClassNhanVien> _NHANVIEN;
        public ObservableCollection<ClassNhanVien> NHANVIEN { get => _NHANVIEN; set { _NHANVIEN = value; OnPropertyChanged(); } }

        private ObservableCollection<TRANGTHAI> _TRANGTHAI;
        public ObservableCollection<TRANGTHAI> TRANGTHAI { get => _TRANGTHAI; set { _TRANGTHAI = value; OnPropertyChanged(); } }

        private GIOITINH _SelectedGIOITINH;
        public GIOITINH SelectedGIOITINH
        {
            get => _SelectedGIOITINH;
            set
            {
                _SelectedGIOITINH = value;
                OnPropertyChanged();
            }
        }

        private GOIDICHVU _SelectedGOIDICHVU;
        public GOIDICHVU SelectedGOIDICHVU
        {
            get => _SelectedGOIDICHVU;
            set
            {
                _SelectedGOIDICHVU = value;
                OnPropertyChanged();
            }
        }

        private ClassNhanVien _SelectedNHANVIEN;
        public ClassNhanVien SelectedNHANVIEN
        {
            get => _SelectedNHANVIEN;
            set
            {
                _SelectedNHANVIEN = value;
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

        private TRANGTHAI _SelectedTRANGTHAI;
        public TRANGTHAI SelectedTRANGTHAI
        {
            get => _SelectedTRANGTHAI;
            set
            {
                _SelectedTRANGTHAI = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoadWindow { get; set; }
        public ICommand CommandRemoveKhachHang { get; set; }
        public ICommand CommandSelectedKHACHHANG { get; set; }
        public ICommand CommandSelectedGOIDICHVU { get; set; }
        public ICommand CommandDangKyGDV { get; set; }
        public ICommand CommandAddLichHen { get; set; }
        public ICommand CommandClose { get; set; }
        public ICommand CommandSelectTinhThanh { get; set; }
        public ICommand CommandSelectHuyenQuan { get; set; }

        public TaoLichHenViewModel()
        {
            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                KHACHHANG = new ObservableCollection<KHACHHANG>();
                NHANVIEN = new ObservableCollection<ClassNhanVien>();
                GOIDICHVU = new ObservableCollection<GOIDICHVU>();
                ShowKhachHang = Visibility.Collapsed;
                KH_NGAYSINH = DateTime.Now;
                LH_NGAYDEN = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                LH_THOIGIANDEN = new TimeSpan(08, 00, 00);
                TINHTHANH = DAO_Address.GetListTinhThanh();
                LoadKhachHang();
                LoadGoiDichVu();
                LoadTrangThai();

                LoadLichHen();
            }
            );

            CommandSelectedKHACHHANG = new RelayCommand<object>((p) =>
            {
                if (SelectedKHACHHANG == null)
                    return false;

                return true;
            }, (p) =>
            {
                ShowKhachHang = Visibility.Visible;
                KH_MAS = SelectedKHACHHANG.KH_MA;
                KH_HOTENS = SelectedKHACHHANG.KH_HOTEN;
                KH_SDTS = SelectedKHACHHANG.KH_SDT;
                KH_GIOITINHS = SelectedKHACHHANG.KH_GIOITINH;
                KH_NGAYSINHS = SelectedKHACHHANG.KH_NGAYSINH;
                KH_EMAILS = SelectedKHACHHANG.KH_EMAIL;
                KH_DIACHIS = SelectedKHACHHANG.KH_DIACHI + ", " + SelectedKHACHHANG.XAPHUONG.XP_TEN + ", " + SelectedKHACHHANG.XAPHUONG.HUYENQUAN.HQ_TEN + ", " + SelectedKHACHHANG.XAPHUONG.HUYENQUAN.TINHTHANH.TT_TEN;

                if (SelectedKHACHHANG.KH_GIOITINH == "Nam")
                    KH_ANHS = @"E:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Avatars\Customer\man.png";
                else
                    KH_ANHS = @"E:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Avatars\Customer\woman.png";
            }
            );

            CommandRemoveKhachHang = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                ShowKhachHang = Visibility.Collapsed;
                SelectedKHACHHANG = null;
                KH_MAS = "";
                KH_HOTENS = "";
                KH_SDTS = "";
                KH_GIOITINHS = "";
                KH_EMAILS = "";
                KH_DIACHI = "";
                KH_ANHS = "";
            }
            );

            CommandSelectedGOIDICHVU = new RelayCommand<object>((p) =>
            {
                if (SelectedGOIDICHVU == null)
                    return false;

                return true;
            }, (p) =>
            {
                LH_NGAYDEN = new DateTime(LH_NGAYDEN.Year, LH_NGAYDEN.Month, LH_NGAYDEN.Day);
                NHANVIEN = DAO_LichLamViec.GetListNhanVienBSVaKTVTheoNgay(LH_NGAYDEN, SelectedGOIDICHVU.GDV_MA);
            }
            );

            CommandDangKyGDV = new RelayCommand<Window>((p) =>
            {
                if (LICHHEN == null)
                    return false;

                return true;
            }, (p) =>
            {
                W_LapPhieuDangKy window = new W_LapPhieuDangKy();
                window.ShowDialog();

                LichHenViewModel.LH_DATA = null;
            }
            );

            CommandAddLichHen = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                if(LichHenViewModel.LH_DATA == null)
                {
                    if(LICHHEN == null)
                    {
                        // Add Lich hen
                        var lichHen = new LICHHEN();
                        lichHen.KH_MA = AddKhachHang();
                        lichHen.LH_GHICHU = LH_GHICHU;
                        lichHen.LH_NGAYDEN = LH_NGAYDEN;
                        lichHen.LH_THOIGIANDEN = LH_THOIGIANDEN;
                        lichHen.LH_TRANGTHAI = SelectedTRANGTHAI.Name;

                        if (SelectedGOIDICHVU != null)
                            lichHen.GDV_MA = SelectedGOIDICHVU.GDV_MA;

                        LICHLAMVIEC lichLamViec = new LICHLAMVIEC();
                        if (SelectedNHANVIEN != null)
                        {
                            lichLamViec = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.NV_MA == SelectedNHANVIEN.NV_MA && x.CLV_MA == SelectedNHANVIEN.CLV_MA && x.THOIGIAN == LH_NGAYDEN).SingleOrDefault();
                            lichHen.NV_MA = lichLamViec.NV_MA;
                            lichHen.CLV_MA = lichLamViec.CLV_MA;
                            lichHen.THOIGIAN = lichLamViec.THOIGIAN;
                        }

                        DataProvider.Ins.DB.LICHHEN.Add(lichHen);
                        DataProvider.Ins.DB.SaveChanges();

                        LICHHEN = lichHen;
                    }
                    else
                    {
                        var lichHen = LICHHEN;
                        lichHen.LH_TRANGTHAI = SelectedTRANGTHAI.Name;
                        DataProvider.Ins.DB.SaveChanges();
                    }
                }
                else
                {
                    var lichHen = LICHHEN;
                    lichHen.LH_TRANGTHAI = SelectedTRANGTHAI.Name;
                    DataProvider.Ins.DB.SaveChanges();
                }
                
            }
            );

            CommandClose = new RelayCommand<Window>((p) =>
            {
                return true;
            }, (p) =>
            {
                LICHHEN = null;
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

        }

        string AddKhachHang()
        {
            if(SelectedKHACHHANG != null)
            {
                return SelectedKHACHHANG.KH_MA;
            }
            else
            {
                Random r = new Random();
                var khachhang = new KHACHHANG()
                {
                    KH_MA = "KH" + r.Next(10000, 99999).ToString(),
                    KH_HOTEN = KH_HOTEN,
                    KH_DIACHI = KH_DIACHI,
                    KH_EMAIL = KH_EMAIL,
                    KH_NGAYSINH = KH_NGAYSINH,
                    KH_SDT = KH_SDT,
                    KH_GIOITINH = SelectedGIOITINH.Name,
                    XP_MA = SelectedXAPHUONG.XP_MA
                };

                DataProvider.Ins.DB.KHACHHANG.Add(khachhang);
                DataProvider.Ins.DB.SaveChanges();

                return khachhang.KH_MA;
            }
        }

        void LoadGoiDichVu()
        {
            GOIDICHVU = new ObservableCollection<GOIDICHVU>(DataProvider.Ins.DB.GOIDICHVU.OrderBy(x=>x.LGDV_MA).ToList());
        }

        void LoadKhachHang()
        {
            KHACHHANG = new ObservableCollection<KHACHHANG>(DataProvider.Ins.DB.KHACHHANG);

            GIOITINH = new ObservableCollection<GIOITINH>();
            GIOITINH.Add(new GIOITINH { Name = "Nam"});
            GIOITINH.Add(new GIOITINH { Name = "Nữ"});
        }

        void LoadTrangThai()
        {
            TRANGTHAI = new ObservableCollection<TRANGTHAI>();
            TRANGTHAI.Add(new TRANGTHAI { Name = "Lên lịch", Color = "#f9a825" });
            TRANGTHAI.Add(new TRANGTHAI { Name = "Lịch hẹn hoàn tất", Color = "#00bfa5" });
            TRANGTHAI.Add(new TRANGTHAI { Name = "Khách không đến", Color = "#d50000" });

            SelectedTRANGTHAI = TRANGTHAI.Where(x => x.Name == "Lên lịch").SingleOrDefault();
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

        void LoadLichHen()
        {
            if(ThongTinKhachHangViewModel.KH_DATA != null)
            {
                SelectedKHACHHANG = ThongTinKhachHangViewModel.KH_DATA;
                ShowKhachHang = Visibility.Visible;
                KH_MAS = SelectedKHACHHANG.KH_MA;
                KH_HOTENS = SelectedKHACHHANG.KH_HOTEN;
                KH_SDTS = SelectedKHACHHANG.KH_SDT;
                KH_GIOITINHS = SelectedKHACHHANG.KH_GIOITINH;
                KH_NGAYSINHS = SelectedKHACHHANG.KH_NGAYSINH;
                KH_EMAILS = SelectedKHACHHANG.KH_EMAIL;
                KH_DIACHIS = SelectedKHACHHANG.KH_DIACHI + ", " + SelectedKHACHHANG.XAPHUONG.XP_TEN + ", " + SelectedKHACHHANG.XAPHUONG.HUYENQUAN.HQ_TEN + ", " + SelectedKHACHHANG.XAPHUONG.HUYENQUAN.TINHTHANH.TT_TEN;

                if (SelectedKHACHHANG.KH_GIOITINH == "Nam")
                    KH_ANHS = @"E:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Avatars\Customer\man.png";
                else
                    KH_ANHS = @"E:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Avatars\Customer\woman.png";
            }

            if(LichHenViewModel.LH_DATA != null)
            {
                var lichHen = DataProvider.Ins.DB.LICHHEN.Where(x => x.LH_ID == LichHenViewModel.LH_DATA.LH_ID).SingleOrDefault();
                LICHHEN = lichHen;
                LH_NGAYDEN = lichHen.LH_NGAYDEN;
                LH_THOIGIANDEN = new TimeSpan();
                LH_THOIGIANDEN = lichHen.LH_THOIGIANDEN;
                LH_GHICHU = lichHen.LH_GHICHU;
                SelectedTRANGTHAI = TRANGTHAI.Where(x => x.Name == lichHen.LH_TRANGTHAI).SingleOrDefault();

                KHACHHANG = new ObservableCollection<KHACHHANG>();
                KHACHHANG.Add(lichHen.KHACHHANG);
                SelectedKHACHHANG = lichHen.KHACHHANG;

                ShowKhachHang = Visibility.Visible;
                KH_MAS = SelectedKHACHHANG.KH_MA;
                KH_HOTENS = SelectedKHACHHANG.KH_HOTEN;
                KH_SDTS = SelectedKHACHHANG.KH_SDT;
                KH_GIOITINHS = SelectedKHACHHANG.KH_GIOITINH;
                KH_NGAYSINHS = SelectedKHACHHANG.KH_NGAYSINH;
                KH_EMAILS = SelectedKHACHHANG.KH_EMAIL;
                KH_DIACHIS = SelectedKHACHHANG.KH_DIACHI + ", " + SelectedKHACHHANG.XAPHUONG.XP_TEN + ", " + SelectedKHACHHANG.XAPHUONG.HUYENQUAN.HQ_TEN + ", " + SelectedKHACHHANG.XAPHUONG.HUYENQUAN.TINHTHANH.TT_TEN;

                if (SelectedKHACHHANG.KH_GIOITINH == "Nam")
                    KH_ANHS = @"E:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Avatars\Customer\man.png";
                else
                    KH_ANHS = @"E:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Avatars\Customer\woman.png";

                if (lichHen.GDV_MA != null)
                {
                    GOIDICHVU = new ObservableCollection<GOIDICHVU>();
                    GOIDICHVU.Add(lichHen.GOIDICHVU);
                    SelectedGOIDICHVU = lichHen.GOIDICHVU;

                    if(lichHen.NV_MA != null)
                    {
                        NHANVIEN = DAO_LichLamViec.GetListNhanVienBSVaKTVTheoNgay(LH_NGAYDEN, SelectedGOIDICHVU.GDV_MA);
                        SelectedNHANVIEN = NHANVIEN.Where(x => x.NV_MA == lichHen.NV_MA).SingleOrDefault();
                    }
                }
            }
        }
    }
    

    public class GIOITINH
    {
        public string Name { get; set; }
    }

    public class TRANGTHAI
    {
        public string Name { get; set;}
        public string Color { get; set;}
    }
}
