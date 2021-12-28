using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LVTN_QLSpa.ViewModel.NVQL_QuanTriHeThong
{
    public class LichLamViecNhanVien
    {
        public DateTime NGAY { get; set; }
        public string ColorDay { get; set; }
        public string SANG { get; set; }
        public string ColorSang { get; set; }
        public string CHIEU { get; set; }
        public string ColorChieu { get; set; }
        public string CANGAY { get; set; }
        public string ColorCaNgay { get; set; }
    }

    public class InfoLichLamViecNhanVienViewModel : BaseViewModel
    {
        public static LICHLAMVIEC lichLamViec;
        private string _NV_ANH;
        public string NV_ANH { get => _NV_ANH; set { _NV_ANH = value; OnPropertyChanged(); } }

        private string _NV_MA;
        public string NV_MA { get => _NV_MA; set { _NV_MA = value; OnPropertyChanged(); } }

        private string _NV_TEN;
        public string NV_TEN { get => _NV_TEN; set { _NV_TEN = value; OnPropertyChanged(); } }

        private DateTime _NV_NGAYSINH;
        public DateTime NV_NGAYSINH { get => _NV_NGAYSINH; set { _NV_NGAYSINH = value; OnPropertyChanged(); } }

        private string _NV_CCCD;
        public string NV_CCCD { get => _NV_CCCD; set { _NV_CCCD = value; OnPropertyChanged(); } }

        private string _NV_SDT;
        public string NV_SDT { get => _NV_SDT; set { _NV_SDT = value; OnPropertyChanged(); } }

        private string _NV_EMAIL;
        public string NV_EMAIL { get => _NV_EMAIL; set { _NV_EMAIL = value; OnPropertyChanged(); } }

        private string _NV_GIOITINH;
        public string NV_GIOITINH { get => _NV_GIOITINH; set { _NV_GIOITINH = value; OnPropertyChanged(); } }

        private string _NV_TRANGTHAI;
        public string NV_TRANGTHAI { get => _NV_TRANGTHAI; set { _NV_TRANGTHAI = value; OnPropertyChanged(); } }

        private string _VT_TEN;
        public string VT_TEN { get => _VT_TEN; set { _VT_TEN = value; OnPropertyChanged(); } }

        private string _CLV_TEN;
        public string CLV_TEN { get => _CLV_TEN; set { _CLV_TEN = value; OnPropertyChanged(); } }

        private DateTime _N_THOIGIAN;
        public DateTime N_THOIGIAN { get => _N_THOIGIAN; set { _N_THOIGIAN = value; OnPropertyChanged(); } }

        private string _P_SO;
        public string P_SO { get => _P_SO; set { _P_SO = value; OnPropertyChanged(); } }

        private string _LLV_GHICHU;
        public string LLV_GHICHU { get => _LLV_GHICHU; set { _LLV_GHICHU = value; OnPropertyChanged(); } }

        private bool _EnabledPhong;
        public bool EnabledPhong { get => _EnabledPhong; set { _EnabledPhong = value; OnPropertyChanged(); } }

        private string _TextCa;
        public string TextCa { get => _TextCa; set { _TextCa = value; OnPropertyChanged(); } }

        private DateTime _TextNgay;
        public DateTime TextNgay { get => _TextNgay; set { _TextNgay = value; OnPropertyChanged(); } }

        private string _TextPhong;
        public string TextPhong { get => _TextPhong; set { _TextPhong = value; OnPropertyChanged(); } }

        private ObservableCollection<CALAMVIEC> _CALAMVIEC;
        public ObservableCollection<CALAMVIEC> CALAMVIEC { get => _CALAMVIEC; set { _CALAMVIEC = value; OnPropertyChanged(); } }

        private ObservableCollection<Phong> _PHONG;
        public ObservableCollection<Phong> PHONG { get => _PHONG; set { _PHONG = value; OnPropertyChanged(); } }

        private ObservableCollection<LichLamViecNhanVien> _LICHLAMVIEC;
        public ObservableCollection<LichLamViecNhanVien> LICHLAMVIEC { get => _LICHLAMVIEC; set { _LICHLAMVIEC = value; OnPropertyChanged(); } }

        private CALAMVIEC _SelectedCALAMVIEC;
        public CALAMVIEC SelectedCALAMVIEC
        {
            get => _SelectedCALAMVIEC;
            set
            {
                _SelectedCALAMVIEC = value;
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

        private LichLamViecNhanVien _SelectedLICHLAMVIEC;
        public LichLamViecNhanVien SelectedLICHLAMVIEC
        {
            get => _SelectedLICHLAMVIEC;
            set
            {
                _SelectedLICHLAMVIEC = value;
                OnPropertyChanged();

            }
        }

        public ICommand LoadWindow { get; set; }
        public ICommand CommandSelectedLICHLAMVIEC { get; set; }
        public ICommand CommandXacNhan { get; set; }
        public ICommand CommandXoaLich { get; set; }
        public ICommand CommandClose { get; set; }
        
        public InfoLichLamViecNhanVienViewModel()
        {
            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                CALAMVIEC = new ObservableCollection<CALAMVIEC>(DataProvider.Ins.DB.CALAMVIEC);
                PHONG = DAO_Phong.GetListPhong(DAO_Phong.GetList());
                lichLamViec = LichLamViecViewModel.LLV_DATA;

                NV_ANH = lichLamViec.NHANVIEN.NV_ANH;
                NV_MA = lichLamViec.NHANVIEN.NV_MA;
                NV_TEN = lichLamViec.NHANVIEN.NV_HOTEN;
                NV_NGAYSINH = lichLamViec.NHANVIEN.NV_NGAYSINH;
                NV_CCCD = lichLamViec.NHANVIEN.NV_CCCD;
                NV_SDT = lichLamViec.NHANVIEN.NV_SDT;
                NV_EMAIL = lichLamViec.NHANVIEN.NV_EMAIL;
                NV_GIOITINH = lichLamViec.NHANVIEN.NV_GIOITINH;
                NV_TRANGTHAI = lichLamViec.NHANVIEN.NV_TRANGTHAI;
                N_THOIGIAN = lichLamViec.THOIGIAN;
                LLV_GHICHU = lichLamViec.LLV_GHICHU;
                if (lichLamViec.P_MA != null)
                    SelectedPHONG = PHONG.Where(x=>x.P_MA == lichLamViec.PHONG.P_MA).SingleOrDefault();
                else
                    SelectedPHONG = null;
                SelectedCALAMVIEC = lichLamViec.CALAMVIEC;
                VT_TEN = DAO_ChuyenMon.LayVaiTroNhanVien(lichLamViec.NV_MA);

                LoadText(lichLamViec);
                LICHLAMVIEC = LoadLichLamViecNhanVien(NV_MA, lichLamViec, lichLamViec.THOIGIAN);
            }
            );

            CommandXacNhan = new RelayCommand<Window>((p) =>
            {
                if (DateTime.Now >= N_THOIGIAN)
                    return false;

                return true;
            }, (p) =>
            {
                // Chỉ thay đổi ghi chú
                if(SelectedCALAMVIEC.CLV_MA == lichLamViec.CLV_MA && N_THOIGIAN.Day == lichLamViec.THOIGIAN.Day && SelectedPHONG.P_MA == lichLamViec.P_MA && LLV_GHICHU != lichLamViec.LLV_GHICHU)
                {
                    DAO_LichLamViec.EditGhiChu(lichLamViec, LLV_GHICHU);
                }
                // Thay đổi phòng
                else if(SelectedCALAMVIEC.CLV_MA == lichLamViec.CLV_MA && N_THOIGIAN.Day == lichLamViec.THOIGIAN.Day && SelectedPHONG.P_MA != lichLamViec.P_MA)
                {
                    if (lichLamViec.LLV_GHICHU != LLV_GHICHU)
                    {
                        var llv = DAO_LichLamViec.EditPhong(lichLamViec, SelectedPHONG.P_MA, LLV_GHICHU);
                        LoadText(llv);
                        LICHLAMVIEC = LoadLichLamViecNhanVien(NV_MA, lichLamViec, lichLamViec.THOIGIAN);
                    }
                    else
                    {
                        var llv = DAO_LichLamViec.EditPhong(lichLamViec, SelectedPHONG.P_MA, lichLamViec.LLV_GHICHU);
                        LoadText(llv);
                        LICHLAMVIEC = LoadLichLamViecNhanVien(NV_MA, lichLamViec, lichLamViec.THOIGIAN);
                    }
                    
                    DAO_LichLamViec.GomNhanVienCoHaiCaVaoCaNgay();
                }
                // Thay dổi ca làm hoặc ngày làm
                else if (SelectedCALAMVIEC.CLV_MA != lichLamViec.CLV_MA || N_THOIGIAN.Day != lichLamViec.THOIGIAN.Day || SelectedPHONG.P_MA != lichLamViec.PHONG.P_MA)
                {
                    if (MessageBox.Show("Thay đổi lịch cho nhân viên này?", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
                    {
                        if(SelectedCALAMVIEC.CLV_MA == "CLV2765             ")
                        {
                            var getNhanVienDaCoLich = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.NV_MA == lichLamViec.NV_MA && x.CLV_MA == SelectedCALAMVIEC.CLV_MA && x.THOIGIAN.Day == N_THOIGIAN.Day && x.THOIGIAN.Month == N_THOIGIAN.Month && x.THOIGIAN.Year == N_THOIGIAN.Year).SingleOrDefault();
                            if (getNhanVienDaCoLich != null)
                            {
                                MessageBox.Show("Nhân viên đã có ca làm vào ngày này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                                return;
                            }
                            else
                            {
                                var getPhongNhanVien = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.NV_MA == lichLamViec.NV_MA && x.THOIGIAN == N_THOIGIAN && x.P_MA != SelectedPHONG.P_MA).ToList();
                                if (getPhongNhanVien.Count != 0)
                                {
                                    MessageBox.Show("Ca làm việc và phòng được chọn không hợp lệ!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                                    return;
                                }
                                else
                                {
                                    var llv = new LICHLAMVIEC();
                                    if (lichLamViec.LLV_GHICHU != LLV_GHICHU)
                                    {
                                        llv = DAO_LichLamViec.AddInfo(lichLamViec.NV_MA, SelectedCALAMVIEC.CLV_MA, N_THOIGIAN, SelectedPHONG.P_MA, LLV_GHICHU);
                                        LoadText(llv);
                                    }
                                    else
                                    {
                                        llv = DAO_LichLamViec.AddInfo(lichLamViec.NV_MA, SelectedCALAMVIEC.CLV_MA, N_THOIGIAN, SelectedPHONG.P_MA, lichLamViec.LLV_GHICHU);
                                        LoadText(llv);
                                    }

                                    DataProvider.Ins.DB.LICHLAMVIEC.Remove(lichLamViec);
                                    DataProvider.Ins.DB.SaveChanges();
                                    lichLamViec = llv;
                                    DAO_LichLamViec.GomNhanVienCoHaiCaVaoCaNgay();
                                    LICHLAMVIEC = LoadLichLamViecNhanVien(NV_MA, lichLamViec, lichLamViec.THOIGIAN);
                                }
                            }
                        }
                        else
                        {
                            var getNhanVienDaCoLich = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.NV_MA == lichLamViec.NV_MA && x.CLV_MA == SelectedCALAMVIEC.CLV_MA && x.THOIGIAN.Day == N_THOIGIAN.Day && x.THOIGIAN.Month == N_THOIGIAN.Month && x.THOIGIAN.Year == N_THOIGIAN.Year).SingleOrDefault();
                            if (getNhanVienDaCoLich != null)
                            {
                                MessageBox.Show("Nhân viên đã có ca làm vào ngày này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                                return;
                            }
                            else
                            {
                                var llv = new LICHLAMVIEC();
                                if (lichLamViec.LLV_GHICHU != LLV_GHICHU)
                                {
                                    llv = DAO_LichLamViec.AddInfo(lichLamViec.NV_MA, SelectedCALAMVIEC.CLV_MA, N_THOIGIAN, SelectedPHONG.P_MA, LLV_GHICHU);
                                    LoadText(llv);
                                }
                                else
                                {
                                    llv = DAO_LichLamViec.AddInfo(lichLamViec.NV_MA, SelectedCALAMVIEC.CLV_MA, N_THOIGIAN, SelectedPHONG.P_MA, lichLamViec.LLV_GHICHU);
                                    LoadText(llv);
                                }
                                DataProvider.Ins.DB.LICHLAMVIEC.Remove(lichLamViec);
                                DataProvider.Ins.DB.SaveChanges();
                                lichLamViec = llv;
                                DAO_LichLamViec.GomNhanVienCoHaiCaVaoCaNgay();
                                LICHLAMVIEC = LoadLichLamViecNhanVien(NV_MA, lichLamViec, lichLamViec.THOIGIAN);
                            }
                        }
                    }
                    else
                    {
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
                    FrameworkElement window = GetWindowParent(p);
                    var w = window as Window;
                    if (w != null)
                    {
                        w.Close();
                    }
                }
            }
            );

            CommandXoaLich = new RelayCommand<object>((p) =>
            {
                var lichLamViec = LichLamViecViewModel.LLV_DATA;
                if (lichLamViec.THOIGIAN <= DateTime.Now)
                    return false;

                return true;
            }, (p) =>
            {
                if (MessageBox.Show("Bạn muốn xóa lịch làm việc của nhân viên này?", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
                {
                    var lichLamViec = LichLamViecViewModel.LLV_DATA;
                    DataProvider.Ins.DB.LICHLAMVIEC.Remove(lichLamViec);
                    DataProvider.Ins.DB.SaveChanges();
                }
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
        
        void LoadText(LICHLAMVIEC llv)
        {
            TextCa = llv.CALAMVIEC.CLV_TEN;
            TextNgay = llv.THOIGIAN;
            TextPhong = llv.P_MA == null ? "Chưa lập" : llv.PHONG.P_SO;
        }

        ObservableCollection<LichLamViecNhanVien> LoadLichLamViecNhanVien(string NV_MA, LICHLAMVIEC lichDangXet, DateTime ngayTrongTuan)
        {
            var ngayDauTuan = GetFirstDayOfWeek(ngayTrongTuan);
            int i = 0;

            var listLLV = new ObservableCollection<LichLamViecNhanVien>();
            while (i < 7)
            {
                var ngayTiepTheo = ngayDauTuan.AddDays((double)i);
                var getLichLamViecTrongTuanNhanVien = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.NV_MA == NV_MA && x.THOIGIAN == ngayTiepTheo).ToList();

                var lichLamViec = new LichLamViecNhanVien();
                if(lichDangXet.THOIGIAN == ngayTiepTheo)
                {
                    lichLamViec.ColorDay = "Red";
                    lichLamViec.NGAY = ngayTiepTheo;
                }
                else
                {
                    lichLamViec.ColorDay = "Black";
                    lichLamViec.NGAY = ngayTiepTheo;
                }
                foreach (var item in getLichLamViecTrongTuanNhanVien)
                {
                    if (item.CLV_MA == "CLV7961             ")
                    {
                        if(item == lichDangXet)
                        {
                            lichLamViec.ColorSang = "Red";
                            lichLamViec.SANG = item.P_MA == null ? "Chưa lập" : item.PHONG.P_SO;
                        }
                        else
                        {
                            lichLamViec.ColorSang = "Black";
                            lichLamViec.SANG = item.P_MA == null ? "Chưa lập" : item.PHONG.P_SO;
                        }
                    }
                    else if(item.CLV_MA == "CLV8258             ")
                    {
                        if (item == lichDangXet)
                        {
                            lichLamViec.ColorChieu = "Red";
                            lichLamViec.CHIEU = item.P_MA == null ? "Chưa lập" : item.PHONG.P_SO;
                        }
                        else
                        {
                            lichLamViec.ColorChieu = "Black";
                            lichLamViec.CHIEU = item.P_MA == null ? "Chưa lập" : item.PHONG.P_SO;
                        }
                    }
                    else
                    {
                        if (item == lichDangXet)
                        {
                            lichLamViec.ColorCaNgay = "Red";
                            lichLamViec.CANGAY = item.P_MA == null ? "Chưa lập" : item.PHONG.P_SO;
                        }
                        else
                        {
                            lichLamViec.ColorCaNgay = "Black";
                            lichLamViec.CANGAY = item.P_MA == null ? "Chưa lập" : item.PHONG.P_SO;
                        }
                    }
                }
                listLLV.Add(lichLamViec);
                i++;
            }

            return listLLV;
        }

        DateTime GetFirstDayOfWeek(DateTime dayInWeek)
        {
            CultureInfo defaultCultureInfo = CultureInfo.CurrentCulture;
            return GetFirstDayOfWeek(dayInWeek, defaultCultureInfo);
        }

        DateTime GetFirstDayOfWeek(DateTime dayInWeek, CultureInfo cultureInfo)
        {
            DayOfWeek firstDay = cultureInfo.DateTimeFormat.FirstDayOfWeek;
            DateTime firstDayInWeek = dayInWeek.Date;
            while (firstDayInWeek.DayOfWeek != firstDay)
            {
                firstDayInWeek = firstDayInWeek.AddDays(-1);
            }
            return firstDayInWeek;
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
