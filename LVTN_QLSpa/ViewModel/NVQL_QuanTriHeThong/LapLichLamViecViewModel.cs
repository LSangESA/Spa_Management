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
    public class NhanVien
    {
        public string NV_MA { get; set; }
        public string NV_ANH { get; set; }
        public string NV_TEN { get; set; }
        public string VT_TEN { get; set; }
        public string CM_TEN { get; set; }
    }

    public class LapLichLamViecViewModel : BaseViewModel
    {
        private DateTime _N_THOIGIAN;
        public DateTime N_THOIGIAN { get => _N_THOIGIAN; set { _N_THOIGIAN = value; OnPropertyChanged(); } }

        private string _LLV_GHICHU;
        public string LLV_GHICHU { get => _LLV_GHICHU; set { _LLV_GHICHU = value; OnPropertyChanged(); } }

        private string _GhiChuSucChuaPhong;
        public string GhiChuSucChuaPhong { get => _GhiChuSucChuaPhong; set { _GhiChuSucChuaPhong = value; OnPropertyChanged(); } }

        private string _Icon;
        public string Icon { get => _Icon; set { _Icon = value; OnPropertyChanged(); } }

        private string _ThongBaoSucChuaPhong;
        public string ThongBaoSucChuaPhong { get => _ThongBaoSucChuaPhong; set { _ThongBaoSucChuaPhong = value; OnPropertyChanged(); } }

        private bool _CheckAddLamViecCaTuan;
        public bool CheckAddLamViecCaTuan { get => _CheckAddLamViecCaTuan; set { _CheckAddLamViecCaTuan = value; OnPropertyChanged(); } }

        private ObservableCollection<PHONG> _PHONG;
        public ObservableCollection<PHONG> PHONG { get => _PHONG; set { _PHONG = value; OnPropertyChanged(); } }

        private ObservableCollection<CALAMVIEC> _CALAMVIEC;
        public ObservableCollection<CALAMVIEC> CALAMVIEC { get => _CALAMVIEC; set { _CALAMVIEC = value; OnPropertyChanged(); } }

        private ObservableCollection<VAITRO> _VAITRO;
        public ObservableCollection<VAITRO> VAITRO { get => _VAITRO; set { _VAITRO = value; OnPropertyChanged(); } }

        private ObservableCollection<NhanVien> _ListNhanVien;
        public ObservableCollection<NhanVien> ListNhanVien { get => _ListNhanVien; set { _ListNhanVien = value; OnPropertyChanged(); } }

        private ObservableCollection<NhanVien> _ListNhanVienXepLich;
        public ObservableCollection<NhanVien> ListNhanVienXepLich { get => _ListNhanVienXepLich; set { _ListNhanVienXepLich = value; OnPropertyChanged(); } }

        private PHONG _SelectedPHONG;
        public PHONG SelectedPHONG
        {
            get => _SelectedPHONG;
            set
            {
                _SelectedPHONG = value;
                OnPropertyChanged();
            }
        }

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

        private VAITRO _SelectedVAITRO;
        public VAITRO SelectedVAITRO
        {
            get => _SelectedVAITRO;
            set
            {
                _SelectedVAITRO = value;
                OnPropertyChanged();
            }
        }

        private NhanVien _SelectedNhanVien;
        public NhanVien SelectedNhanVien
        {
            get => _SelectedNhanVien;
            set
            {
                _SelectedNhanVien = value;
                OnPropertyChanged();
            }
        }

        private NhanVien _SelectedNhanVienXepLich;
        public NhanVien SelectedNhanVienXepLich
        {
            get => _SelectedNhanVienXepLich;
            set
            {
                _SelectedNhanVienXepLich = value;
                OnPropertyChanged();
            }
        }


        public ICommand LoadWindow { get; set; }
        public ICommand CommandLapLichTuanToi { get; set; }
        public ICommand CommandAddLLV { get; set; }
        public ICommand CommandCloseLLV { get; set; }
        public ICommand CommandSelectedDate { get; set; }
        public ICommand CommandSelectedCLV { get; set; }
        public ICommand CommandSelectedPhong { get; set; }
        public ICommand CommandSelectedVaiTro { get; set; }
        public ICommand CommandMoveRight { get; set; }
        public ICommand CommandMoveLeft { get; set; }
        public ICommand CommandMoveRightAll { get; set; }
        public ICommand CommandMoveLeftAll { get; set; }

        public LapLichLamViecViewModel()
        {
            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                CheckAddLamViecCaTuan = false;
                N_THOIGIAN = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                PHONG = DAO_Phong.GetList();
                VAITRO = DAO_VaiTro.GetList();
                CALAMVIEC = new ObservableCollection<CALAMVIEC>(DataProvider.Ins.DB.CALAMVIEC.OrderBy(x=>x.CLV_TEN));
                ListNhanVienXepLich = new ObservableCollection<NhanVien>();

                Load();
            }
            );

            CommandLapLichTuanToi = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                var thuHaiTuanNay = MondayOfWeek();
                var chuNhatTuanNay = MondayOfNextWeek(DateTime.Now).AddDays(-1);
                chuNhatTuanNay = new DateTime(chuNhatTuanNay.Year, chuNhatTuanNay.Month, chuNhatTuanNay.Day, 23, 59, 59);
                var thuHaiTuanToi = MondayOfNextWeek(DateTime.Now);
                var chuNhatTuanToi = SundayOfNextWeek(thuHaiTuanToi);

                if (MessageBox.Show("Lập lại lịch cho tuần tiếp theo? Bắt đầu từ ngày " + thuHaiTuanToi.ToString("dd/MM/yyyy"), "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
                {
                    var getListNhanVienDaLapTuanNay = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => thuHaiTuanNay <= x.THOIGIAN && x.THOIGIAN <= chuNhatTuanNay).ToList();
                    var getListNhanVienDaLapTuanSau = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => thuHaiTuanToi <= x.THOIGIAN && x.THOIGIAN <= chuNhatTuanToi).ToList();

                    foreach(var item in getListNhanVienDaLapTuanSau.ToList())
                    {
                        foreach(var item2 in getListNhanVienDaLapTuanNay.ToList())
                        {
                            if(item.NHANVIEN == item2.NHANVIEN)
                            {
                                var ngayTuanSau = DayOfBackWeek(item.THOIGIAN);
                                if(ngayTuanSau.Day == item2.THOIGIAN.Day && ngayTuanSau.Month == item2.THOIGIAN.Month && ngayTuanSau.Year == item2.THOIGIAN.Year)
                                {
                                    getListNhanVienDaLapTuanNay.Remove(item2);
                                }
                            }
                        }
                    }

                    foreach(var item in getListNhanVienDaLapTuanNay)
                    {
                        var ngayCuaTuanToi = DayOfNextWeek(item.THOIGIAN);
                        var getDate = DataProvider.Ins.DB.NGAY.Where(x => x.THOIGIAN == ngayCuaTuanToi).Count();
                        if (getDate == 0)
                        {
                            var ngay = new NGAY();
                            ngay.THOIGIAN = ngayCuaTuanToi;
                            DAO_Ngay.Add(ngay);
                        }
                        DAO_LichLamViec.Add(item.NV_MA, item.CLV_MA, ngayCuaTuanToi, item.P_MA, item.LLV_GHICHU);
                    }
                }
            }
            );

            CommandSelectedDate = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                SelectedCALAMVIEC = null;
                SelectedPHONG = null;
                SelectedVAITRO = null;
                ListNhanVienXepLich = new ObservableCollection<NhanVien>();
                ListNhanVien = new ObservableCollection<NhanVien>();
            }
            );

            CommandSelectedCLV = new RelayCommand<object>((p) =>
            {
                if (SelectedCALAMVIEC == null)
                    return false;

                return true;
            }, (p) =>
            {
                if(SelectedPHONG != null)
                {
                    GhiChuSucChuaPhong = SelectedPHONG.P_SO.Trim(' ') + " (" + SelectedPHONG.P_TEN + ")" + ": ";
                    var getListSucChuaPhong = DataProvider.Ins.DB.CHITIETPHONG.Where(x => x.P_MA == SelectedPHONG.P_MA).ToList();
                    foreach (var item in getListSucChuaPhong)
                    {
                        GhiChuSucChuaPhong += item.VAITRO.VT_TEN + " - " + item.CTP_SOLUONG + ", ";
                    }
                    GhiChuSucChuaPhong = GhiChuSucChuaPhong.TrimEnd().Substring(0, GhiChuSucChuaPhong.Length - 2);

                    var getListNhanVienByPhongAndThoiGian = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.P_MA == SelectedPHONG.P_MA && x.CLV_MA == SelectedCALAMVIEC.CLV_MA && x.THOIGIAN == N_THOIGIAN).Select(x => x.NHANVIEN).ToList();
                    ListNhanVienXepLich = new ObservableCollection<NhanVien>();
                    foreach (var item in getListNhanVienByPhongAndThoiGian)
                    {
                        var nhanVien = new NhanVien();
                        nhanVien.NV_MA = item.NV_MA;
                        nhanVien.NV_TEN = item.NV_HOTEN;
                        nhanVien.NV_ANH = item.NV_ANH;
                        nhanVien.VT_TEN = DAO_ChuyenMon.LayVaiTroNhanVien(item.NV_MA);
                        nhanVien.CM_TEN = DAO_ChuyenMon.LayChuyenMonNhanVien(item.NV_MA);

                        ListNhanVienXepLich.Add(nhanVien);
                    }

                    SelectedVAITRO = null;
                    ListNhanVien = new ObservableCollection<NhanVien>();
                }
            }
            );

            CommandSelectedPhong = new RelayCommand<object>((p) =>
            {
                if (N_THOIGIAN == null || N_THOIGIAN == new DateTime(0001, 01, 01) || SelectedPHONG == null || SelectedCALAMVIEC == null)
                    return false;

                return true;
            }, (p) =>
            {
                GhiChuSucChuaPhong = SelectedPHONG.P_SO.Trim(' ') + " (" + SelectedPHONG.P_TEN + ")" + ": ";
                var getListSucChuaPhong = DataProvider.Ins.DB.CHITIETPHONG.Where(x => x.P_MA == SelectedPHONG.P_MA).ToList();
                foreach(var item in getListSucChuaPhong)
                {
                    GhiChuSucChuaPhong += item.VAITRO.VT_TEN + " - " + item.CTP_SOLUONG + ", ";
                }
                GhiChuSucChuaPhong = GhiChuSucChuaPhong.TrimEnd().Substring(0, GhiChuSucChuaPhong.Length - 2);

                var getListNhanVienByPhongAndThoiGian = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.P_MA == SelectedPHONG.P_MA && x.CLV_MA == SelectedCALAMVIEC.CLV_MA && x.THOIGIAN == N_THOIGIAN).Select(x=>x.NHANVIEN).ToList();
                ListNhanVienXepLich = new ObservableCollection<NhanVien>();
                foreach (var item in getListNhanVienByPhongAndThoiGian)
                {
                    var nhanVien = new NhanVien();
                    nhanVien.NV_MA = item.NV_MA;
                    nhanVien.NV_TEN = item.NV_HOTEN;
                    nhanVien.NV_ANH = item.NV_ANH;
                    nhanVien.VT_TEN = DAO_ChuyenMon.LayVaiTroNhanVien(item.NV_MA);
                    nhanVien.CM_TEN = DAO_ChuyenMon.LayChuyenMonNhanVien(item.NV_MA);

                    ListNhanVienXepLich.Add(nhanVien);
                }

                SelectedVAITRO = null;
                ListNhanVien = new ObservableCollection<NhanVien>();
            }
            );

            CommandSelectedVaiTro = new RelayCommand<object>((p) =>
            {
                if (SelectedVAITRO == null)
                    return false;

                if (N_THOIGIAN == null || N_THOIGIAN < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day) || SelectedPHONG == null || SelectedCALAMVIEC == null)
                    return false;

                return true;
            }, (p) =>
            {
                var getListNhanVienForVaiTro = DataProvider.Ins.DB.CHUYENMONNHANVIEN.Where(x => x.CHUYENMON.VAITRO.VT_MA == SelectedVAITRO.VT_MA).Select(x => x.NHANVIEN).Distinct().ToList();
                var getListNhanVienDaCoCa = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.THOIGIAN == N_THOIGIAN && x.CLV_MA == SelectedCALAMVIEC.CLV_MA).Select(x=>x.NHANVIEN).ToList();
                ListNhanVien = new ObservableCollection<NhanVien>();

                foreach (var item in getListNhanVienForVaiTro.ToList())
                {
                    foreach (var item2 in getListNhanVienDaCoCa.ToList())
                    {
                        if (item == item2)
                        {
                            getListNhanVienForVaiTro.Remove(item);
                        }
                    }
                }

                foreach (var item in getListNhanVienForVaiTro)
                {
                    var nhanVien = new NhanVien();
                    nhanVien.NV_MA = item.NV_MA;
                    nhanVien.NV_TEN = item.NV_HOTEN;
                    nhanVien.NV_ANH = item.NV_ANH;
                    nhanVien.VT_TEN = DAO_ChuyenMon.LayVaiTroNhanVien(item.NV_MA);
                    nhanVien.CM_TEN = DAO_ChuyenMon.LayChuyenMonNhanVien(item.NV_MA);

                    ListNhanVien.Add(nhanVien);
                }

                if(SelectedCALAMVIEC.CLV_MA == "CLV2765             ")
                {
                    foreach (var item in ListNhanVien.ToList())
                    {
                        var getNhanVienDaCoPhong = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.NV_MA == item.NV_MA && x.THOIGIAN == N_THOIGIAN && x.P_MA != SelectedPHONG.P_MA).ToList();
                        foreach(var item2 in getNhanVienDaCoPhong)
                        {
                            if (item.NV_MA == item2.NV_MA)
                                ListNhanVien.Remove(item);
                        }
                    }
                }
                else
                {
                    foreach (var item in ListNhanVien.ToList())
                    {
                        var getNhanVienDaCoPhong = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.NV_MA == item.NV_MA && x.THOIGIAN == N_THOIGIAN && x.CLV_MA == "CLV2765             ").ToList();
                        foreach (var item2 in getNhanVienDaCoPhong)
                        {
                            if (item.NV_MA == item2.NV_MA)
                                ListNhanVien.Remove(item);
                        }
                    }
                }
            }
            );

            CommandMoveRight = new RelayCommand<object>((p) =>
            {
                if (SelectedNhanVien == null)
                    return false;

                return true;
            }, (p) =>
            {
                ListNhanVienXepLich.Add(SelectedNhanVien);
                ListNhanVien.Remove(SelectedNhanVien);
            }
            );

            CommandMoveLeft = new RelayCommand<object>((p) =>
            {
                if (SelectedNhanVienXepLich == null)
                    return false;

                return true;
            }, (p) =>
            {
                ListNhanVien.Add(SelectedNhanVienXepLich);
                ListNhanVienXepLich.Remove(SelectedNhanVienXepLich);
            }
            );

            CommandMoveRightAll = new RelayCommand<object>((p) =>
            {
                if (SelectedVAITRO == null)
                    return false;

                return true;
            }, (p) =>
            {
                foreach(var item in ListNhanVien.ToList())
                {
                    ListNhanVienXepLich.Add(item);
                    ListNhanVien.Remove(item);
                }
            }
            );

            CommandMoveLeftAll = new RelayCommand<object>((p) =>
            {
                if (SelectedVAITRO == null)
                    return false;

                return true;
            }, (p) =>
            {
                foreach (var item in ListNhanVienXepLich.ToList())
                {
                    ListNhanVien.Add(item);
                    ListNhanVienXepLich.Remove(item);
                }
            }
            );

            CommandAddLLV = new RelayCommand<object>((p) =>
            {
                if (SelectedCALAMVIEC == null || N_THOIGIAN < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day) || SelectedPHONG == null || SelectedCALAMVIEC == null)
                    return false;

                if (ListNhanVienXepLich.Count() == 0)
                    return false;

                return true;
            }, (p) =>
            {
                // Xác nhận lưu thông tin
                if (MessageBox.Show("Lưu thông tin lịch làm việc cho " + SelectedCALAMVIEC.CLV_TEN + "?", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
                {
                    // Lựa chọn tạo lịch cho cả tuần
                    if (CheckAddLamViecCaTuan == true)
                    {
                        // Xác nhận lưu thông tin cho cả tuần
                        if (MessageBox.Show("Bạn muốn danh sách nhân viên được lưu lịch làm việc cho 7 ngày tới", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
                        {
                            // Thêm nhân viên cần lập lịch cho 7 ngày tới
                            for (int i = 0; i < 7; i++)
                            {
                                // Lấy ngày được chọn trên dtpk
                                N_THOIGIAN = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

                                // Thêm nhân viên bắt đầu từ ngày được chọn
                                N_THOIGIAN = N_THOIGIAN.AddDays((double)i);

                                // Nếu như thời gian đã tồn tạo trong csdl thì không cần thêm ngày
                                var getDate = DataProvider.Ins.DB.NGAY.Where(x => x.THOIGIAN == N_THOIGIAN).Count();
                                if (getDate == 0)
                                {
                                    var ngay = new NGAY();
                                    ngay.THOIGIAN = N_THOIGIAN;
                                    DAO_Ngay.Add(ngay);
                                }

                                // Lấy dữ liệu nhân viên đã được lập lịch từ trước
                                var getListLichlamViec = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.P_MA == SelectedPHONG.P_MA && x.CLV_MA == SelectedCALAMVIEC.CLV_MA && x.THOIGIAN == N_THOIGIAN).ToList();

                                // Lấy dữ liệu nhân viên hiện đang chọn
                                var getListLLVMoi = ListNhanVienXepLich.ToList();

                                // Kiểm tra nhân viên trong danh sách hiện đang chọn xem có nhân viên nào đã tồn tại trong CSDL không, nếu có thì xóa đi chỉ lấy nhân viên chưa lập
                                foreach (var item in getListLichlamViec.ToList())
                                {
                                    foreach(var item2 in getListLLVMoi.ToList())
                                    {
                                        if(item.NV_MA == item2.NV_MA)
                                            getListLLVMoi.Remove(item2);
                                    }
                                }
                                foreach (var item in getListLLVMoi)
                                {
                                    DAO_LichLamViec.Add(item.NV_MA, SelectedCALAMVIEC.CLV_MA, N_THOIGIAN, SelectedPHONG.P_MA, LLV_GHICHU);
                                }
                            }
                        }
                    }

                    // Nếu như không chọn thêm cho cả tuần
                    else
                    {
                        // Lấy ngày được chọn trên dtpk
                        N_THOIGIAN = new DateTime(N_THOIGIAN.Year, N_THOIGIAN.Month, N_THOIGIAN.Day);

                        // Nếu như thời gian đã tồn tạo trong csdl thì không cần thêm ngày
                        var getDate = DataProvider.Ins.DB.NGAY.Where(x => x.THOIGIAN == N_THOIGIAN).Count();
                        if (getDate == 0)
                        {
                            var ngay = new NGAY();
                            ngay.THOIGIAN = N_THOIGIAN;
                            DAO_Ngay.Add(ngay);
                        }

                        // Lấy dữ liệu nhân viên đã được lập lịch từ trước
                        var getListLichlamViec = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.P_MA == SelectedPHONG.P_MA && x.CLV_MA == SelectedCALAMVIEC.CLV_MA && x.THOIGIAN == N_THOIGIAN).ToList();

                        // Lấy dữ liệu nhân viên hiện đang chọn
                        var getListLLVMoi = ListNhanVienXepLich.ToList();

                        // Nếu như thêm mới nhân viên
                        if(getListLichlamViec.Count() < getListLLVMoi.Count())
                        {
                            // Kiểm tra nhân viên trong danh sách hiện đang chọn xem có nhân viên nào đã tồn tại trong CSDL không, nếu có thì xóa đi chỉ lấy nhân viên chưa lập
                            foreach (var item in getListLichlamViec.ToList())
                            {
                                foreach (var item2 in getListLLVMoi.ToList())
                                {
                                    if (item.NV_MA == item2.NV_MA)
                                        getListLLVMoi.Remove(item2);
                                }
                            }
                            foreach (var item in getListLLVMoi)
                            {
                                DAO_LichLamViec.Add(item.NV_MA, SelectedCALAMVIEC.CLV_MA, N_THOIGIAN, SelectedPHONG.P_MA, LLV_GHICHU);
                            }
                        }

                        // Nếu như xóa nhân viên
                        else
                        {
                            foreach (var item in getListLLVMoi.ToList())
                            {
                                foreach (var item2 in getListLichlamViec.ToList())
                                {
                                    if (item.NV_MA == item2.NV_MA)
                                        getListLichlamViec.Remove(item2);
                                }
                            }
                            foreach (var item in getListLichlamViec)
                            {
                                DAO_LichLamViec.Delete(item.NV_MA, SelectedCALAMVIEC.CLV_MA, N_THOIGIAN);
                            }
                        }
                    }

                    DAO_LichLamViec.GomNhanVienCoHaiCaVaoCaNgay();
                }
            }
            );

            CommandCloseLLV = new RelayCommand<Window>((p) =>
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

        void Load()
        {
            SelectedCALAMVIEC = null;
            LLV_GHICHU = null;
            SelectedPHONG = null;
            SelectedVAITRO = null;
            ListNhanVien = new ObservableCollection<NhanVien>();
            ListNhanVienXepLich = new ObservableCollection<NhanVien>();
        }

        DateTime MondayOfWeek()
        {
            DateTime mondayOfWeek = new DateTime();
            var dayOfWeek = DateTime.Now.DayOfWeek;

            if (dayOfWeek == DayOfWeek.Sunday)
            {
                //xét chủ nhật là đầu tuần thì thứ 2 là ngày kế tiếp nên sẽ tăng 1 ngày  
                //return date.AddDays(1);
                  
                // nếu xét chủ nhật là ngày cuối tuần  
                return DateTime.Now.AddDays(-6);
            }

            // nếu không phải thứ 2 thì lùi ngày lại cho đến thứ 2  
            int offset = dayOfWeek - DayOfWeek.Monday;
            mondayOfWeek = DateTime.Now.AddDays(-offset);
            mondayOfWeek = new DateTime(mondayOfWeek.Year, mondayOfWeek.Month, mondayOfWeek.Day, 0, 0, 0);
            return mondayOfWeek;
        }

        DateTime MondayOfNextWeek(DateTime dateNow)
        {
            dateNow = dateNow.AddDays((double)1);
            var dayOfWeek = dateNow.DayOfWeek;
            int i = 1;

            while(dayOfWeek != DayOfWeek.Monday)
            {
                dateNow = DateTime.Now.AddDays((double)i);
                dayOfWeek = dateNow.DayOfWeek;
                i++;
            }

            dateNow = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 0, 0, 0);
            return dateNow;
        }

        DateTime SundayOfNextWeek(DateTime mondayNextWeek)
        {
            var dayNow = mondayNextWeek;
            var dayOfWeek = dayNow.DayOfWeek;
            int i = 1;

            while (dayOfWeek != DayOfWeek.Sunday)
            {
                dayNow = mondayNextWeek.AddDays((double)i);
                dayOfWeek = dayNow.DayOfWeek;
                i++;
            }

            dayNow = new DateTime(dayNow.Year, dayNow.Month, dayNow.Day, 23, 59, 59);
            return dayNow;
        }
        
        // Lấy ra ngày thứ của tuần tới dựa vào ngày được chọn
        DateTime DayOfNextWeek(DateTime dayNow)
        {
            var homNay = dayNow.AddDays((double)1);
            var dayOfWeek = homNay.DayOfWeek;
            int i = 1;

            while (dayOfWeek != dayNow.DayOfWeek)
            {
                homNay = dayNow.AddDays((double)i);
                dayOfWeek = homNay.DayOfWeek;
                i++;
            }

            return homNay;
        }

        DateTime DayOfBackWeek(DateTime dayOfNextWeek)
        {
            return dayOfNextWeek.AddDays((double)-7);
        }
    }
}
