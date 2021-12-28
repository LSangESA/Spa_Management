using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using LVTN_QLSpa.Model.ModelClass;
using LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham;
using LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLDV;
using LVTN_QLSpa.ViewModel.NVQL_QuanTriHeThong;
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
    public class Phong
    {
        public int P_MA { get; set; }
        public string P_SO { get; set; }
        public string P_TEN { get; set; }
    }

    public class LapPhieuDangKyViewModel : BaseViewModel
    {
        private static string kh_MA_DATA;
        public static string KH_MA_DATA
        {
            get { return LapPhieuDangKyViewModel.kh_MA_DATA; }
            set { LapPhieuDangKyViewModel.kh_MA_DATA = value; }
        }

        private static string pdk_STT_DATA;
        public static string PDK_STT_DATA
        {
            get { return LapPhieuDangKyViewModel.pdk_STT_DATA; }
            set { LapPhieuDangKyViewModel.pdk_STT_DATA = value; }
        }

        private static string gdv_MA_DATA;
        public static string GDV_MA_DATA
        {
            get { return LapPhieuDangKyViewModel.gdv_MA_DATA; }
            set { LapPhieuDangKyViewModel.gdv_MA_DATA = value; }
        }

        private static int p_MA_DATA;
        public static int P_MA_DATA
        {
            get { return LapPhieuDangKyViewModel.p_MA_DATA; }
            set { LapPhieuDangKyViewModel.p_MA_DATA = value; }
        }

        private string _KeySearch;
        public string KeySearch { get => _KeySearch; set { _KeySearch = value; OnPropertyChanged(); } }

        private string _PDK_STT;
        public string PDK_STT { get => _PDK_STT; set { _PDK_STT = value; OnPropertyChanged(); } }

        private string _PDK_TRANGTHAI;
        public string PDK_TRANGTHAI { get => _PDK_TRANGTHAI; set { _PDK_TRANGTHAI = value; OnPropertyChanged(); } }

        private DateTime _PDK_NGAYDK;
        public DateTime PDK_NGAYDK { get => _PDK_NGAYDK; set { _PDK_NGAYDK = value; OnPropertyChanged(); } }

        private DateTime _PDK_NGAYBDTH;
        public DateTime PDK_NGAYBDTH { get => _PDK_NGAYBDTH; set { _PDK_NGAYBDTH = value; OnPropertyChanged(); } }

        private string _GDV_TEN;
        public string GDV_TEN { get => _GDV_TEN; set { _GDV_TEN = value; OnPropertyChanged(); } }

        private string _GDV_ANH;
        public string GDV_ANH { get => _GDV_ANH; set { _GDV_ANH = value; OnPropertyChanged(); } }

        private string _LGDV_TEN;
        public string LGDV_TEN { get => _LGDV_TEN; set { _LGDV_TEN = value; OnPropertyChanged(); } }

        private int? _GDV_SOLAN;
        public int? GDV_SOLAN { get => _GDV_SOLAN; set { _GDV_SOLAN = value; OnPropertyChanged(); } }

        private string _DONGIA;
        public string DONGIA { get => _DONGIA; set { _DONGIA = value; OnPropertyChanged(); } }

        private string _GG_TEN;
        public string GG_TEN { get => _GG_TEN; set { _GG_TEN = value; OnPropertyChanged(); } }

        private DateTime _GG_NGAYBATDAU;
        public DateTime GG_NGAYBATDAU { get => _GG_NGAYBATDAU; set { _GG_NGAYBATDAU = value; OnPropertyChanged(); } }

        private DateTime _GG_NGAYKETTHUC;
        public DateTime GG_NGAYKETTHUC { get => _GG_NGAYKETTHUC; set { _GG_NGAYKETTHUC = value; OnPropertyChanged(); } }

        private int _GG_PHANTRAMGIAM;
        public int GG_PHANTRAMGIAM { get => _GG_PHANTRAMGIAM; set { _GG_PHANTRAMGIAM = value; OnPropertyChanged(); } }

        private string _KH_TEN;
        public string KH_TEN { get => _KH_TEN; set { _KH_TEN = value; OnPropertyChanged(); } }

        private string _KH_SDT;
        public string KH_SDT { get => _KH_SDT; set { _KH_SDT = value; OnPropertyChanged(); } }

        private string _KH_MA;
        public string KH_MA { get => _KH_MA; set { _KH_MA = value; OnPropertyChanged(); } }

        private string _SONOKHACHHANG;
        public string SONOKHACHHANG { get => _SONOKHACHHANG; set { _SONOKHACHHANG = value; OnPropertyChanged(); } }

        private string _KH_EMAIL;
        public string KH_EMAIL { get => _KH_EMAIL; set { _KH_EMAIL = value; OnPropertyChanged(); } }

        private string _KH_GIOITINH;
        public string KH_GIOITINH { get => _KH_GIOITINH; set { _KH_GIOITINH = value; OnPropertyChanged(); } }

        private string _KH_ANH;
        public string KH_ANH { get => _KH_ANH; set { _KH_ANH = value; OnPropertyChanged(); } }

        private DateTime? _KH_NGAYSINH;
        public DateTime? KH_NGAYSINH { get => _KH_NGAYSINH; set { _KH_NGAYSINH = value; OnPropertyChanged(); } }

        private bool _CheckGDVLT;
        public bool CheckGDVLT { get => _CheckGDVLT; set { _CheckGDVLT = value; OnPropertyChanged(); } }

        private bool _CheckGDVNotLT;
        public bool CheckGDVNotLT { get => _CheckGDVNotLT; set { _CheckGDVNotLT = value; OnPropertyChanged(); } }

        private Visibility _ShowInfoKH;
        public Visibility ShowInfoKH { get => _ShowInfoKH; set { _ShowInfoKH = value; OnPropertyChanged(); } }

        private Visibility _NullInfo;
        public Visibility NullInfo { get => _NullInfo; set { _NullInfo = value; OnPropertyChanged(); } }

        private ObservableCollection<CACHTHANHTOAN> _CACHTHANHTOAN;
        public ObservableCollection<CACHTHANHTOAN> CACHTHANHTOAN { get => _CACHTHANHTOAN; set { _CACHTHANHTOAN = value; OnPropertyChanged(); } }

        private ObservableCollection<GOIDICHVU> _GOIDICHVU;
        public ObservableCollection<GOIDICHVU> GOIDICHVU { get => _GOIDICHVU; set { _GOIDICHVU = value; OnPropertyChanged(); } }

        private ObservableCollection<ClassNhanVien> _NHANVIEN;
        public ObservableCollection<ClassNhanVien> NHANVIEN { get => _NHANVIEN; set { _NHANVIEN = value; OnPropertyChanged(); } }

        private ObservableCollection<DICHVU> _DICHVU;
        public ObservableCollection<DICHVU> DICHVU { get => _DICHVU; set { _DICHVU = value; OnPropertyChanged(); } }

        private ObservableCollection<DG_GDV> _ListGoiDichVu;
        public ObservableCollection<DG_GDV> ListGoiDichVu { get => _ListGoiDichVu; set { _ListGoiDichVu = value; OnPropertyChanged(); } }

        private ObservableCollection<GIAMGIA> _GIAMGIA;
        public ObservableCollection<GIAMGIA> GIAMGIA { get => _GIAMGIA; set { _GIAMGIA = value; OnPropertyChanged(); } }

        private ObservableCollection<Filter> _Filter;
        public ObservableCollection<Filter> Filter { get => _Filter; set { _Filter = value; OnPropertyChanged(); } }

        private ObservableCollection<Phong> _PHONG;
        public ObservableCollection<Phong> PHONG { get => _PHONG; set { _PHONG = value; OnPropertyChanged(); } }

        private CACHTHANHTOAN _SelectedCACHTHANHTOAN;
        public CACHTHANHTOAN SelectedCACHTHANHTOAN
        {
            get => _SelectedCACHTHANHTOAN;
            set
            {
                _SelectedCACHTHANHTOAN = value;
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

        private GIAMGIA _SelectedGIAMGIA;
        public GIAMGIA SelectedGIAMGIA
        {
            get => _SelectedGIAMGIA;
            set
            {
                _SelectedGIAMGIA = value;
                OnPropertyChanged();

                if (SelectedGIAMGIA != null)
                {
                    GG_TEN = SelectedGIAMGIA.GG_TEN;
                    GG_NGAYKETTHUC = SelectedGIAMGIA.GG_NGAYKETTHUC;
                    GG_NGAYBATDAU = SelectedGIAMGIA.GG_NGAYBATDAU;
                    GG_PHANTRAMGIAM = SelectedGIAMGIA.GG_PHANTRAMGIAM;
                }
            }
        }

        private DICHVU _SelectedDICHVU;
        public DICHVU SelectedDICHVU
        {
            get => _SelectedDICHVU;
            set
            {
                _SelectedDICHVU = value;
                OnPropertyChanged();
            }
        }

        private DG_GDV _SelectedGoiDichVu;
        public DG_GDV SelectedGoiDichVu
        {
            get => _SelectedGoiDichVu;
            set
            {
                _SelectedGoiDichVu = value;
                OnPropertyChanged();
            }
        }

        private Filter _SelectedFilter;
        public Filter SelectedFilter
        {
            get => _SelectedFilter;
            set
            {
                _SelectedFilter = value;
                OnPropertyChanged();
            }
        }

        private Phong _SelectedPHONG;
        public Phong SelectedPHONG
        {
            get => _SelectedPHONG;
            set
            {
                _SelectedPHONG = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoadWindow { get; set; }
        public ICommand CommandAddKhachHang { get; set; }
        public ICommand CommandEditKhachHang { get; set; }
        public ICommand CommandThanhToanNo { get; set; }
        public ICommand CommandCheckGDVLT { get; set; }
        public ICommand CommandCheckGDVNotLT { get; set; }
        public ICommand CommandInThongTinGDV { get; set; }
        public ICommand CommandSelectedFilter { get; set; }
        public ICommand CommandSelectDICHVU { get; set; }
        public ICommand CommandSelectedPHONG { get; set; }
        public ICommand CommandSelectGOIDICHVU { get; set; }
        public ICommand CommandAddPhieuDK { get; set; }
        public ICommand CommandInLichTrinh { get; set; }
        public ICommand CommandOpenPDT { get; set; }
        public ICommand CommandClosePDK { get; set; }
        public ICommand CommandLapLich { get; set; }

        public LapPhieuDangKyViewModel()
        {
            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                LoadLaiDuLieu();

                if (!string.IsNullOrEmpty(KH_MA))
                    ShowInfoKH = Visibility.Visible;
                else
                {
                    NullInfo = Visibility.Visible;
                    ShowInfoKH = Visibility.Hidden;
                }
                CheckGDVLT = true;
                LoadDataPDK();
                LoadDataGDV();
                LoadDataGG();
                LoadInfoKhachLichHen();
                LoadInfoTuKhachHang();
            }
            );

            CommandAddKhachHang = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                KH_MA_DATA = null;
                W_ThemKhachHangPDK themKhachWindow = new W_ThemKhachHangPDK();
                themKhachWindow.ShowDialog();

                if (!string.IsNullOrEmpty(ThemKhachHangPDKViewModel.KH_MA_DATA))
                {
                    GetInfoKhachHang(ThemKhachHangPDKViewModel.KH_MA_DATA);
                    ShowInfoKH = Visibility.Visible;
                    NullInfo = Visibility.Hidden;
                }
            }
            );

            CommandEditKhachHang = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(ThemKhachHangPDKViewModel.KH_MA_DATA))
                    return false;

                return true;
            }, (p) =>
            {
                KH_MA_DATA = ThemKhachHangPDKViewModel.KH_MA_DATA;
                W_ThemKhachHangPDK themKhachWindow = new W_ThemKhachHangPDK();
                themKhachWindow.ShowDialog();

                if (!string.IsNullOrEmpty(ThemKhachHangPDKViewModel.KH_MA_DATA))
                {
                    GetInfoKhachHang(ThemKhachHangPDKViewModel.KH_MA_DATA);
                }
                else if (string.IsNullOrEmpty(ThemKhachHangPDKViewModel.KH_MA_DATA))
                {
                    ShowInfoKH = Visibility.Hidden;
                    NullInfo = Visibility.Visible;
                }
            }
            );

            CommandThanhToanNo = new RelayCommand<Window>((p) =>
            {
                if (string.IsNullOrEmpty(SONOKHACHHANG))
                    return false;

                return true;
            }, (p) =>
            {
                LapPhieuDieuTriViewModel.PDT_STT_DATA = null;
                LapPhieuDieuTriViewModel.PDK_STT_DATA = null;
                KH_MA_DATA = KH_MA;

                W_LapPhieuThu window = new W_LapPhieuThu();
                p.Hide();
                window.ShowDialog();
                p.Show();

                SONOKHACHHANG = DAO_PhieuThu.TinhTongNoKhachHang(KH_MA);
            }
            );

            CommandCheckGDVLT = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                ListGoiDichVu = DAO_GoiDichVu.GetList(1);
                SelectedDICHVU = null;
                SelectedFilter = null;
            }
            );

            CommandCheckGDVNotLT = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                ListGoiDichVu = DAO_GoiDichVu.GetList(2);
                SelectedDICHVU = null;
                SelectedFilter = null;
            }
            );

            CommandInThongTinGDV = new RelayCommand<object>((p) =>
            {
                if (SelectedGoiDichVu == null || SelectedGoiDichVu.GOIDICHVU.LGDV_MA == 2)
                    return false;

                return true;
            }, (p) =>
            {
                CapNhatGoiDichVuViewModel.GDV_DATA = SelectedGoiDichVu;
                W_InThongTinGoiDichVu window = new W_InThongTinGoiDichVu();
                window.ShowDialog();
                CapNhatGoiDichVuViewModel.GDV_DATA = null;
            }
            );

            CommandSelectedFilter = new RelayCommand<object>((p) =>
            {
                if (SelectedFilter == null)
                    return false;

                return true;
            }, (p) =>
            {
                //if(SelectedFilter.Name == "Giá giảm dần")
                //{
                //    ListGoiDichVu = new ObservableCollection<DG_GDV>(ListGoiDichVu.OrderBy(x => x.DONGIA));
                //}
                //else if(SelectedFilter.Name == "Giá tăng dần")
                //{

                //}
                //else if(SelectedFilter.Name == "A->Z")
                //{

                //}
                //else if(SelectedFilter.Name == "Z->A")
                //{

                //}
            }
            );

            CommandSelectDICHVU = new RelayCommand<object>((p) =>
            {
                if (SelectedDICHVU == null)
                    return false;

                return true;
            }, (p) =>
            {
                if (CheckGDVLT == true)
                {
                    ListGoiDichVu = new ObservableCollection<DG_GDV>(DataProvider.Ins.DB.DG_GDV.Where(x => x.GOIDICHVU.DV_MA == SelectedDICHVU.DV_MA && x.GOIDICHVU.LGDV_MA == 1));
                }
                else if (CheckGDVNotLT == true)
                {
                    ListGoiDichVu = new ObservableCollection<DG_GDV>(DataProvider.Ins.DB.DG_GDV.Where(x => x.GOIDICHVU.DV_MA == SelectedDICHVU.DV_MA && x.GOIDICHVU.LGDV_MA == 2));
                }
            }
            );

            CommandAddPhieuDK = new RelayCommand<object>((p) =>
            {
                if (SelectedGoiDichVu == null || string.IsNullOrEmpty(KH_MA) || SelectedCACHTHANHTOAN == null || PDK_NGAYBDTH < PDK_NGAYDK || SelectedPHONG == null)
                    return false;

                var getPDK = DataProvider.Ins.DB.PHIEUDANGKY.Where(x => x.PDK_STT == PDK_STT).Count();
                if (getPDK > 0)
                    return false;
                
                
                return true;
            }, (p) =>
            {
                if (PDK_NGAYDK == PDK_NGAYBDTH)
                    PDK_TRANGTHAI = "Đang điều trị";
                else if (PDK_NGAYDK < PDK_NGAYBDTH)
                    PDK_TRANGTHAI = "Đợi đến ngày";

                if (SelectedGoiDichVu.GOIDICHVU.LGDV_MA == 1)
                {
                    if(SelectedNHANVIEN == null)
                    {
                        MessageBox.Show("Phải chọn nhân viên phụ trách cho gói dịch vụ này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                        
                    var phieuDangKy = DAO_PhieuDangKy.Add(PDK_STT, PDK_NGAYDK, PDK_NGAYBDTH, PDK_TRANGTHAI, SelectedGoiDichVu.GDV_MA, KH_MA, SelectedCACHTHANHTOAN.CTT_MA, SelectedNHANVIEN.NV_MA);
                }
                else
                {
                    var phieuDangKy = DAO_PhieuDangKy.Add(PDK_STT, PDK_NGAYDK, PDK_NGAYBDTH, PDK_TRANGTHAI, SelectedGoiDichVu.GDV_MA, KH_MA, SelectedCACHTHANHTOAN.CTT_MA);
                }

                if (SelectedGIAMGIA != null)
                {
                    var giamGiaPDK = new GIAMGIA_PDK() { GG_MA = SelectedGIAMGIA.GG_MA, PDK_STT = PDK_STT };
                    DataProvider.Ins.DB.GIAMGIA_PDK.Add(giamGiaPDK);
                    DataProvider.Ins.DB.SaveChanges();
                }

                var getPDK = DataProvider.Ins.DB.PHIEUDANGKY.Where(x => x.PDK_STT == PDK_STT).SingleOrDefault();
                AddLichTrinhDieuTri(getPDK.GDV_MA, getPDK.PDK_STT, getPDK.NV_MA);
            }
            );

            CommandInLichTrinh = new RelayCommand<Window>((p) =>
            {
                var getPDK = DataProvider.Ins.DB.PHIEUDANGKY.Where(x => x.PDK_STT == PDK_STT).Count();
                if (getPDK == 0)
                    return false;

                var getLoaiGDV = DataProvider.Ins.DB.PHIEUDANGKY.Where(x => x.PDK_STT == PDK_STT).SingleOrDefault();
                if (getLoaiGDV.GOIDICHVU.LGDV_MA == 2)
                    return false;

                return true;
            }, (p) =>
            {
                PDK_STT_DATA = PDK_STT;
                W_InLichTrinhDieuTri window = new W_InLichTrinhDieuTri();
                window.ShowDialog();
            }
            );

            CommandOpenPDT = new RelayCommand<Window>((p) =>
            {
                var getPDK = DataProvider.Ins.DB.PHIEUDANGKY.Where(x => x.PDK_STT == PDK_STT).Count();
                if (getPDK == 0)
                    return false;

                return true;
            }, (p) =>
            {
                P_MA_DATA = SelectedPHONG.P_MA;
                PDK_STT_DATA = PDK_STT;
                GDV_MA_DATA = DataProvider.Ins.DB.PHIEUDANGKY.Where(x=>x.PDK_STT == PDK_STT).Select(x=>x.GDV_MA).SingleOrDefault();
                KH_MA_DATA = KH_MA;
                W_LapPhieuDieuTri window = new W_LapPhieuDieuTri();
                p.Hide();
                window.ShowDialog();
                p.Show();

                SONOKHACHHANG = DAO_PhieuThu.TinhTongNoKhachHang(KH_MA);
            }
            );

            CommandClosePDK = new RelayCommand<Window>((p) =>
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

            CommandLapLich = new RelayCommand<Window>((p) =>
            {
                var phieuDangKy = DataProvider.Ins.DB.PHIEUDANGKY.Where(x => x.PDK_STT == PDK_STT).SingleOrDefault();
                if (phieuDangKy == null)
                    return false;

                if (phieuDangKy.GOIDICHVU.LGDV_MA == 2)
                    return false;

                return true;
            }, (p) =>
            {
                PDK_STT_DATA = PDK_STT;
                W_XacNhanTheoDoiBenhNhan window = new W_XacNhanTheoDoiBenhNhan();
                window.ShowDialog();
                PDK_STT_DATA = null;
            }
            );

            CommandSelectedPHONG = new RelayCommand<object>((p) =>
            {
                if (SelectedPHONG == null)
                    return false;

                return true;
            }, (p) =>
            {
                // Lay ra nhan vien thuoc phong duoc chon cho lich lam viec hom nay
                var ngayHienTai = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                NHANVIEN = DAO_LichLamViec.GetListNhanVienBSTrongNgayTheoPhong(ngayHienTai, SelectedGoiDichVu.GDV_MA, SelectedPHONG.P_MA);
            }
            );

            CommandSelectGOIDICHVU = new RelayCommand<object>((p) =>
            {
                if (SelectedGoiDichVu == null)
                    return false;

                return true;
            }, (p) =>
            {
                SelectedNHANVIEN = null;
                GDV_ANH = SelectedGoiDichVu.GOIDICHVU.GDV_ANH;
                GDV_TEN = SelectedGoiDichVu.GOIDICHVU.GDV_TEN;
                LGDV_TEN = SelectedGoiDichVu.GOIDICHVU.LOAIGOIDICHVU.LGDV_TEN;
                GDV_SOLAN = SelectedGoiDichVu.GOIDICHVU.GDV_SOLAN;
                DONGIA = SelectedGoiDichVu.DONGIA;

                // Lay ra phong thuoc goi dich vu
                var phongGDV = DataProvider.Ins.DB.DICHVUPHONG.Where(x => x.GDV_MA == SelectedGoiDichVu.GDV_MA).Select(x => x.PHONG).ToList();
                PHONG = new ObservableCollection<Phong>();
                foreach(var item in phongGDV)
                {
                    var phong = new Phong();
                    phong.P_MA = item.P_MA;
                    phong.P_SO = item.P_SO.Trim(' ');
                    phong.P_TEN = item.P_TEN;

                    PHONG.Add(phong);
                }

                // Lay ra goi dich vu duoc giam gia
                var dayNow = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                var getGG_GDV = DataProvider.Ins.DB.GIAMGOIDICHVU.Where(x => x.GDV_MA == SelectedGoiDichVu.GDV_MA && x.GIAMGIA.GG_NGAYBATDAU <= dayNow && x.GIAMGIA.GG_NGAYKETTHUC >= dayNow && x.GIAMGIA.GG_TRANGTHAI == "Đang diễn ra").Select(x => x.GIAMGIA).ToList();
                GIAMGIA = new ObservableCollection<GIAMGIA>();
                foreach (var item in getGG_GDV)
                {
                    // Lọc những loại giảm giá cho phép theo lựa chọn cách thanh toán
                    var getLGG = DataProvider.Ins.DB.LGG_GG.Where(x => x.LGG_MA == SelectedCACHTHANHTOAN.CTT_MA && x.GG_MA == item.GG_MA).SingleOrDefault();
                    if (getLGG != null)
                    {
                        GIAMGIA.Add(item);
                    }
                }
            }
            );
        }

        ObservableCollection<ClassNhanVien> GetListNhanVienBSVaKTVTheoNgay(DateTime THOIGIAN, string GDV_MA)
        {
            /*
                1. Lay ra danh sach nhan vien co vai tro bac si va ky thuat vien
                2. Lay ra nhan vien phu trach goi dich vu duoc chon
                3. Tao vong lap cho 2 danh sach lay ra nhan vien bac si va ky thuat vien phu trach goi dich vu duoc chon va them danh sach nhan vien do vao 1 list
                4. Lay ra danh sach nhan vien co lich lam viec theo ngay duoc chon
                5. Tao vong lap cho 2 danh sach lay ra danh sach nhan vien cho lich hen
             */
            // 1
            var getNhanVienBSvaKTV = DataProvider.Ins.DB.CHUYENMONNHANVIEN.Where(x => x.CHUYENMON.VT_MA == 2).Select(x => new { x.NHANVIEN, x.CHUYENMON.VAITRO.VT_TEN }).Distinct().OrderBy(x => x.VT_TEN).ToList();

            // 2
            var getNhanVienPhuTrachDichVu = DataProvider.Ins.DB.PHUTRACHGOI.Where(x => x.GDV_MA == GDV_MA).Select(x => x.NHANVIEN).ToList();

            // 3
            var nhanVienPhuTrach = new ObservableCollection<ClassNhanVien>();
            foreach (var item in getNhanVienPhuTrachDichVu)
            {
                foreach (var item2 in getNhanVienBSvaKTV)
                {
                    if (item == item2.NHANVIEN)
                    {
                        var nhanVien = new ClassNhanVien();
                        nhanVien.NV_MA = item2.NHANVIEN.NV_MA;
                        nhanVien.NV_ANH = item2.NHANVIEN.NV_ANH;
                        nhanVien.NV_TEN = item2.NHANVIEN.NV_HOTEN;
                        nhanVien.VT_TEN = item2.VT_TEN;
                        nhanVienPhuTrach.Add(nhanVien);
                    }
                }
            }

            // 4
            var getNhanVienLamTheoNgay = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.THOIGIAN == THOIGIAN).ToList();

            var listNhanVien = new ObservableCollection<ClassNhanVien>();
            foreach (var item in nhanVienPhuTrach)
            {
                foreach (var item2 in getNhanVienLamTheoNgay)
                {
                    if (item.NV_MA == item2.NV_MA)
                    {
                        var nhanVien = new ClassNhanVien();
                        nhanVien.NV_MA = item2.NV_MA;
                        nhanVien.NV_ANH = item2.NHANVIEN.NV_ANH;
                        nhanVien.NV_TEN = item2.NHANVIEN.NV_HOTEN;
                        nhanVien.VT_TEN = item.VT_TEN;
                        nhanVien.CLV_MA = item2.CALAMVIEC.CLV_MA;
                        nhanVien.CLV_TEN = item2.CALAMVIEC.CLV_TEN;
                        listNhanVien.Add(nhanVien);
                    }
                }
            }
            return new ObservableCollection<ClassNhanVien>(listNhanVien.OrderBy(x => x.NV_TEN));
        }

        void AddLichTrinhDieuTri(string GDV_MA, string PDK_STT, string NV_MA)
        {
            var buoi = "Sáng";
            var gioBatDau = new TimeSpan(7, 30, 0);
            var ngayBatDau = DataProvider.Ins.DB.PHIEUDANGKY.Where(x=>x.PDK_STT == PDK_STT).Select(x=>x.PDK_NGAYBATDAU).SingleOrDefault();
            var getListLieuTrinh = DataProvider.Ins.DB.LIEUTRINH.Where(x => x.GDV_MA == GDV_MA).ToList();
            foreach(var item in getListLieuTrinh)
            {
                /*
                    Giờ quy định từ 7h30 - 12h và 1h - 5h30h
                    Lấy tất vả các lich trình điêu trị của ngày hôm khách hàng được chọn ra (theo bac si)
                    Từ 7h30 cộng lên cho thời gian điều trị
                        Nếu từ 7h30-12h thì là buoi sáng
                        Nếu quá 12h thì chuyển qua buoi trưa
                        Nếu quá 5h30 thì chuyển qua ngày hôm sau
                 */
                var dauNgay = new DateTime(ngayBatDau.Year, ngayBatDau.Month, ngayBatDau.Day, 0, 0, 0);
                var cuoiNgay = new DateTime(ngayBatDau.Year, ngayBatDau.Month, ngayBatDau.Day, 23, 59, 59);
                var getLTDTSang = DataProvider.Ins.DB.LICHTRINHDIEUTRI.Where(x => x.LTDT_NGAYDT >= dauNgay && x.LTDT_NGAYDT <= cuoiNgay && x.PHIEUDANGKY.NV_MA == NV_MA && x.LTDT_THOIGIANDEN == "Sáng").ToList();
                foreach(var item2 in getLTDTSang)
                {
                    gioBatDau = gioBatDau.Add(new TimeSpan(0, Convert.ToInt32(item2.LIEUTRINH.LT_THOIGIANTH), 0));
                }
                if(gioBatDau > new TimeSpan(12,15,0))
                {
                    gioBatDau = new TimeSpan(1, 0, 0);
                    buoi = "Trưa";
                    var getLTDTTrua = DataProvider.Ins.DB.LICHTRINHDIEUTRI.Where(x => x.LTDT_NGAYDT >= dauNgay && x.LTDT_NGAYDT <= cuoiNgay && x.PHIEUDANGKY.NV_MA == NV_MA && x.LTDT_THOIGIANDEN == "Trưa").ToList();
                    foreach(var item3 in getLTDTTrua)
                    {
                        gioBatDau = gioBatDau.Add(new TimeSpan(0, Convert.ToInt32(item3.LIEUTRINH.LT_THOIGIANTH), 0));
                    }
                    if (gioBatDau > new TimeSpan(17,45,0))
                    {
                        buoi = "Sáng";
                        ngayBatDau = ngayBatDau.AddDays((double)1);
                    }
                }

                DAO_LichTrinhDieuTri.Add(PDK_STT, item.GDV_MA, item.LT_MA, ngayBatDau, buoi);
                ngayBatDau = ngayBatDau.AddDays((double)item.LT_NGAYTHU);
                gioBatDau = new TimeSpan(7, 30, 0);
            }
        }

        void LoadDataPDK()
        {
            Random r = new Random();
            PDK_STT = "PDK" + r.Next(10000, 99999).ToString();
            PDK_NGAYDK = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            PDK_NGAYBDTH = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            CACHTHANHTOAN = new ObservableCollection<CACHTHANHTOAN>(DataProvider.Ins.DB.CACHTHANHTOAN);
            SelectedCACHTHANHTOAN = CACHTHANHTOAN.Where(x => x.CTT_MA == 1).SingleOrDefault();
        }

        void LoadDataGG()
        {
            GG_TEN = null;
            var dayNow = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            var getListGG = new ObservableCollection<GIAMGIA>(DataProvider.Ins.DB.GIAMGIA.Where(x => x.GG_NGAYBATDAU <= dayNow && x.GG_NGAYKETTHUC >= dayNow));
            GIAMGIA = getListGG;
        }

        void LoadDataGDV()
        {
            CheckGDVLT = true;
            DICHVU = DAO_DichVu.GetList();
            ListGoiDichVu = new ObservableCollection<DG_GDV>(DataProvider.Ins.DB.DG_GDV.Where(x => x.GOIDICHVU.LOAIGOIDICHVU.LGDV_MA == 1));
        }

        void GetInfoKhachHang(string KH_MA_Data)
        {
            var getKhachHang = DataProvider.Ins.DB.KHACHHANG.Where(x => x.KH_MA == KH_MA_Data).SingleOrDefault();
            KH_TEN = getKhachHang.KH_HOTEN;
            KH_EMAIL = getKhachHang.KH_EMAIL;
            KH_GIOITINH = getKhachHang.KH_GIOITINH;
            KH_NGAYSINH = getKhachHang.KH_NGAYSINH;
            KH_SDT = getKhachHang.KH_SDT;
            KH_MA = getKhachHang.KH_MA;
            if (getKhachHang.KH_GIOITINH == "Nam")
            {
                KH_ANH = @"E:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Avatars\Customer\man.png";
            }
            else
            {
                KH_ANH = @"E:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Avatars\Customer\woman.png";
            }

            SONOKHACHHANG = DAO_PhieuThu.TinhTongNoKhachHang(KH_MA);
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

        void LoadInfoKhachLichHen()
        {
            if(LichHenViewModel.LH_DATA != null)
            {
                var lichHen = LichHenViewModel.LH_DATA;
                GetInfoKhachHang(lichHen.KH_MA);
                ShowInfoKH = Visibility.Visible;
                NullInfo = Visibility.Hidden;

                if (lichHen.GDV_MA != null)
                {
                    SelectedGoiDichVu = DataProvider.Ins.DB.DG_GDV.Where(x=>x.GDV_MA == lichHen.GDV_MA).SingleOrDefault();

                    GDV_ANH = lichHen.GOIDICHVU.GDV_ANH;
                    GDV_TEN = lichHen.GOIDICHVU.GDV_TEN;
                    LGDV_TEN = lichHen.GOIDICHVU.LOAIGOIDICHVU.LGDV_TEN;
                    GDV_SOLAN = lichHen.GOIDICHVU.GDV_SOLAN;
                    DONGIA = DataProvider.Ins.DB.DG_GDV.Where(x=>x.GDV_MA == lichHen.GDV_MA).Select(x=>x.DONGIA).SingleOrDefault();

                    if(lichHen.NV_MA != null)
                    {
                        // Lay ra phong thuoc goi dich vu
                        var phongGDV = DataProvider.Ins.DB.DICHVUPHONG.Where(x => x.GDV_MA == SelectedGoiDichVu.GDV_MA).Select(x => x.PHONG).ToList();
                        PHONG = new ObservableCollection<Phong>();
                        foreach (var item in phongGDV)
                        {
                            var phong = new Phong();
                            phong.P_MA = item.P_MA;
                            phong.P_SO = item.P_SO.Trim(' ');
                            phong.P_TEN = item.P_TEN;

                            PHONG.Add(phong);
                        }

                        /* Lấy ra phòng mà nhân viên đó có lịch
                         * Nếu như nhân viên đó làm việc cả ngày thì lấy ra phòng mà nhân viên đó làm
                         * Ngược lại dựa vào thời gian hiện tại mà xác định phòng làm việc của nhân viên đó
                         * Nếu như khách hàng đến sớm hơn hoặc muộn hơn ca làm việc của bác sĩ đó thì không chọn
                         */
                        var ngayHienTai = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                        var phongCaNgay = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.NV_MA == lichHen.LICHLAMVIEC.NV_MA && x.THOIGIAN == ngayHienTai && x.CLV_MA == "CLV2765             ").SingleOrDefault();
                        if (phongCaNgay != null)
                        {
                            SelectedPHONG = PHONG.Where(x => x.P_MA == phongCaNgay.P_MA).SingleOrDefault();
                        }
                        else
                        {
                            var caLamViecTheoGioHienTai = LayCaLamViecTuongUngBuoiLieuTri(new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second));
                            var phongTheoCa = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.NV_MA == lichHen.LICHLAMVIEC.NV_MA && x.THOIGIAN == ngayHienTai && x.CLV_MA == caLamViecTheoGioHienTai.CLV_MA).SingleOrDefault();
                            if(phongTheoCa != null)
                            {
                                SelectedPHONG = PHONG.Where(x => x.P_MA == phongTheoCa.P_MA).SingleOrDefault();
                            }
                        }

                        // Neu nhu lay duoc phong thi tiep tuc lay nhung nhan vien dang trong phong do
                        if(SelectedPHONG != null)
                        {
                            NHANVIEN = DAO_LichLamViec.GetListNhanVienBSTrongNgayTheoPhong(ngayHienTai, SelectedGoiDichVu.GDV_MA, SelectedPHONG.P_MA);
                            SelectedNHANVIEN = NHANVIEN.Where(x => x.NV_MA == lichHen.LICHLAMVIEC.NV_MA).SingleOrDefault();
                        }
                            
                    }
                }
            }
        }

        void LoadInfoTuKhachHang()
        {
            if(ThongTinKhachHangViewModel.KH_DATA != null)
            {
                var khachHang = ThongTinKhachHangViewModel.KH_DATA;
                GetInfoKhachHang(khachHang.KH_MA);
                ShowInfoKH = Visibility.Visible;
                NullInfo = Visibility.Hidden;
            }
        }

        CALAMVIEC LayCaLamViecTuongUngBuoiLieuTri(TimeSpan gioHienTai)
        {
            if (new TimeSpan(0,0,0) <= gioHienTai && gioHienTai <= new TimeSpan(11, 59, 59))
                return DataProvider.Ins.DB.CALAMVIEC.Where(x => x.CLV_MA == "CLV7961             ").SingleOrDefault();
            else
                return DataProvider.Ins.DB.CALAMVIEC.Where(x => x.CLV_MA == "CLV8258             ").SingleOrDefault();
        }

        void LoadFilter()
        {
            Filter = new ObservableCollection<Filter>();
            Filter.Add(new Filter() { Name = "Giá giảm dần" });
            Filter.Add(new Filter() { Name = "Giá tăng dần" });
            Filter.Add(new Filter() { Name = "A->Z" });
            Filter.Add(new Filter() { Name = "Z->A" });
        }

        void LoadLaiDuLieu()
        {
            KH_MA = null;
            SelectedGoiDichVu = null;
            SelectedPHONG = null;
            SelectedNHANVIEN = null;
            SelectedGIAMGIA = null;

        }
    }
    
    public class Filter
    {
        public string Name { get; set; }
    }
}
