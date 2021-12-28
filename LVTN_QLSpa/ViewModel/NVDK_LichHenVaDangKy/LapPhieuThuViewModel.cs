using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using LVTN_QLSpa.Model.ModelClass;
using LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace LVTN_QLSpa.ViewModel.NVDK_LichHenVaDangKy
{
    public class LapPhieuThuViewModel : BaseViewModel
    {
        private static string pt_STT_DATA;
        public static string PT_STT_DATA
        {
            get { return LapPhieuThuViewModel.pt_STT_DATA; }
            set { LapPhieuThuViewModel.pt_STT_DATA = value; }
        }

        private string _PT_STT;
        public string PT_STT { get => _PT_STT; set { _PT_STT = value; OnPropertyChanged(); } }

        private DateTime _PT_NGAYLAP;
        public DateTime PT_NGAYLAP { get => _PT_NGAYLAP; set { _PT_NGAYLAP = value; OnPropertyChanged(); } }

        private string _KH_MA;
        public string KH_MA { get => _KH_MA; set { _KH_MA = value; OnPropertyChanged(); } }

        private string _KH_HOTEN;
        public string KH_HOTEN { get => _KH_HOTEN; set { _KH_HOTEN = value; OnPropertyChanged(); } }

        private string _NV_HOTEN_MA;
        public string NV_HOTEN_MA { get => _NV_HOTEN_MA; set { _NV_HOTEN_MA = value; OnPropertyChanged(); } }

        private string _THANHTIEN;
        public string THANHTIEN { get => _THANHTIEN; set { _THANHTIEN = value; OnPropertyChanged(); } }

        private string _GG_TIEN;
        public string GG_TIEN { get => _GG_TIEN; set { _GG_TIEN = value; OnPropertyChanged(); } }

        private string _TONGTIEN;
        public string TONGTIEN { get => _TONGTIEN; set { _TONGTIEN = value; OnPropertyChanged(); } }

        private string _TIENKHACHDUA;
        public string TIENKHACHDUA { get => _TIENKHACHDUA; set { _TIENKHACHDUA = value; OnPropertyChanged(); } }

        private string _TIENTHUACHOKHACH;
        public string TIENTHUACHOKHACH { get => _TIENTHUACHOKHACH; set { _TIENTHUACHOKHACH = value; OnPropertyChanged(); } }

        private ObservableCollection<ClassPhieuDieuTri> _PHIEUDIEUTRI;
        public ObservableCollection<ClassPhieuDieuTri> PHIEUDIEUTRI { get => _PHIEUDIEUTRI; set { _PHIEUDIEUTRI = value; OnPropertyChanged(); } }

        private ObservableCollection<HINHTHUCTHANHTOAN> _HTTT;
        public ObservableCollection<HINHTHUCTHANHTOAN> HTTT { get => _HTTT; set { _HTTT = value; OnPropertyChanged(); } }

        private HINHTHUCTHANHTOAN _SelectedHTTT;
        public HINHTHUCTHANHTOAN SelectedHTTT
        {
            get => _SelectedHTTT;
            set
            {
                _SelectedHTTT = value;
                OnPropertyChanged();
                
            }
        }

        public ICommand LoadWindow { get; set; }
        public ICommand CommandInHoaDon { get; set; }
        public ICommand CommandAddPT { get; set; }
        public ICommand CommandHuyPhieuThu { get; set; }
        public ICommand CommandCheckThanhToanPDT { get; set; }
        public ICommand CommandUnCheckThanhToanPDT { get; set; }

        public LapPhieuThuViewModel()
        {
            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                if (!string.IsNullOrEmpty(LapPhieuDangKyViewModel.KH_MA_DATA))
                {
                    KH_MA = LapPhieuDangKyViewModel.KH_MA_DATA;
                }
                else if (ThongTinKhachHangViewModel.KH_DATA != null)
                {
                    KH_MA = ThongTinKhachHangViewModel.KH_DATA.KH_MA;
                }
                else
                {
                    KH_MA = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDT_STT == LapPhieuDieuTriViewModel.PDT_STT_DATA && x.PDK_STT == LapPhieuDieuTriViewModel.PDK_STT_DATA).Select(x => x.PHIEUDANGKY.KH_MA).SingleOrDefault();
                }
                LoadPhieuPhu();

                PHIEUDIEUTRI = new ObservableCollection<ClassPhieuDieuTri>();

                // Lấy phiếu điều trị cần thanh toán
                if(!string.IsNullOrEmpty(LapPhieuDieuTriViewModel.PDT_STT_DATA) && !string.IsNullOrEmpty(LapPhieuDieuTriViewModel.PDK_STT_DATA))
                {
                    var getPDTThanhToan = DAO_PhieuDieuTri.GetPhieuDieuTri(LapPhieuDieuTriViewModel.getPDK_STT, LapPhieuDieuTriViewModel.PDT_STT_DATA);
                    ClassPhieuDieuTri classPhieuDieuTri = new ClassPhieuDieuTri();
                    classPhieuDieuTri.CTT_MA = getPDTThanhToan.PHIEUDANGKY.CTT_MA;
                    classPhieuDieuTri.GDV_MA = getPDTThanhToan.PHIEUDANGKY.GDV_MA;
                    classPhieuDieuTri.PDK_STT = ClassXuLyChuoi.XoaKhoanTrangKyTuCuoi(getPDTThanhToan.PHIEUDANGKY.PDK_STT);
                    classPhieuDieuTri.PDT_NGAYLAP = getPDTThanhToan.PDT_NGAYLAP;
                    classPhieuDieuTri.PDT_STT = ClassXuLyChuoi.XoaKhoanTrangKyTuCuoi(getPDTThanhToan.PDT_STT);
                    classPhieuDieuTri.GDV_TEN = getPDTThanhToan.PHIEUDANGKY.GOIDICHVU.GDV_TEN;
                    classPhieuDieuTri.IsSelected = true;
                    PHIEUDIEUTRI.Add(classPhieuDieuTri);
                }

                // Hiển thị danh sách phiếu điều trị nợ
                var getPDTCuaKH = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PHIEUDANGKY.KH_MA == KH_MA && x.PDT_TRANGTHAINNO == true).ToList();
                foreach (var item in getPDTCuaKH.OrderByDescending(x=>x.PDT_NGAYLAP).ToList())
                {
                    ClassPhieuDieuTri classPhieuDieuTri = new ClassPhieuDieuTri();
                    classPhieuDieuTri.CTT_MA = item.PHIEUDANGKY.CTT_MA;
                    classPhieuDieuTri.GDV_MA = item.PHIEUDANGKY.GDV_MA;
                    classPhieuDieuTri.PDK_STT = ClassXuLyChuoi.XoaKhoanTrangKyTuCuoi(item.PHIEUDANGKY.PDK_STT);
                    classPhieuDieuTri.PDT_NGAYLAP = item.PDT_NGAYLAP;
                    classPhieuDieuTri.PDT_STT = ClassXuLyChuoi.XoaKhoanTrangKyTuCuoi(item.PDT_STT);
                    classPhieuDieuTri.GDV_TEN = item.PHIEUDANGKY.GOIDICHVU.GDV_TEN;
                    classPhieuDieuTri.IsSelected = false;

                    PHIEUDIEUTRI.Add(classPhieuDieuTri);
                }
                PHIEUDIEUTRI = new ObservableCollection<ClassPhieuDieuTri>(PHIEUDIEUTRI.ToList().Distinct());

                THANHTIEN = ClassXuLyChuoi.ChuyenSoThanhTien(TinhThanhTien(PHIEUDIEUTRI));
                GG_TIEN = ClassXuLyChuoi.ChuyenSoThanhTien(TinhGiamGia(PHIEUDIEUTRI));
                TONGTIEN = ClassXuLyChuoi.ChuyenSoThanhTien(TinhThanhTien(PHIEUDIEUTRI) - TinhGiamGia(PHIEUDIEUTRI));
                TIENKHACHDUA = TONGTIEN;
            }
            );

            CommandInHoaDon = new RelayCommand<Window>((p) =>
            {
                var phieuThu = DataProvider.Ins.DB.PHIEUTHU.Where(x => x.PT_STT == PT_STT).SingleOrDefault();
                if (phieuThu == null)
                    return false;

                return true;
            }, (p) =>
            {
                PT_STT_DATA = PT_STT;
                W_InPhieuThu window = new W_InPhieuThu();
                window.ShowDialog();
                PT_STT_DATA = null;
            }
            );

            CommandAddPT = new RelayCommand<Window>((p) =>
            {
                if (SelectedHTTT == null)
                    return false;

                var phieuThu = DataProvider.Ins.DB.PHIEUTHU.Where(x => x.PT_STT == PT_STT).SingleOrDefault();
                if (phieuThu != null)
                    return false;

                return true;
            }, (p) =>
            {
                if(MessageBox.Show("Lưu thông tin phiếu thu?", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Information) == MessageBoxResult.OK)
                {
                    var phieuThu = DAO_PhieuThu.AddPT(PT_STT, LoginViewModel.NV_DATA.NV_MA, SelectedHTTT.HTTT_MA, DateTime.Now, ClassXuLyChuoi.ChuyenTienThanhSo(TONGTIEN));
                    AddPhieuThu_PDT(PHIEUDIEUTRI, phieuThu);
                }
            }
            );

            CommandHuyPhieuThu = new RelayCommand<Window>((p) =>
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

            CommandCheckThanhToanPDT = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                THANHTIEN = ClassXuLyChuoi.ChuyenSoThanhTien(TinhThanhTien(PHIEUDIEUTRI));
                GG_TIEN = ClassXuLyChuoi.ChuyenSoThanhTien(TinhGiamGia(PHIEUDIEUTRI));
                TONGTIEN = ClassXuLyChuoi.ChuyenSoThanhTien(TinhThanhTien(PHIEUDIEUTRI) - TinhGiamGia(PHIEUDIEUTRI));
                TIENKHACHDUA = TONGTIEN;
            }
            );

            CommandUnCheckThanhToanPDT = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                THANHTIEN = ClassXuLyChuoi.ChuyenSoThanhTien(TinhThanhTien(PHIEUDIEUTRI));
                GG_TIEN = ClassXuLyChuoi.ChuyenSoThanhTien(TinhGiamGia(PHIEUDIEUTRI));
                TONGTIEN = ClassXuLyChuoi.ChuyenSoThanhTien(TinhThanhTien(PHIEUDIEUTRI) - TinhGiamGia(PHIEUDIEUTRI));
                TIENKHACHDUA = TONGTIEN;
            }
            );
        }

        void LoadPhieuPhu()
        {
            Random r = new Random();
            PT_STT = "PT" + r.Next(10000, 99999);
            PT_NGAYLAP = DateTime.Now;
            KH_HOTEN = DataProvider.Ins.DB.KHACHHANG.Where(x=>x.KH_MA == KH_MA).Select(x=>x.KH_HOTEN).SingleOrDefault();
            NV_HOTEN_MA = LoginViewModel.NV_DATA.NV_HOTEN + " - " + LoginViewModel.NV_DATA.NV_MA;
            HTTT = new ObservableCollection<HINHTHUCTHANHTOAN>(DataProvider.Ins.DB.HINHTHUCTHANHTOAN);
            TIENKHACHDUA = TONGTIEN;
        }

        int TinhThanhTien(ObservableCollection<ClassPhieuDieuTri> listPhieuDieuTri)
        {
            int thanhTien = 0;
            int totalMoney = 0;

            var getPhieuDieuTriThanhToan = listPhieuDieuTri.Where(x => x.IsSelected == true).ToList();
            
            foreach (var item in getPhieuDieuTriThanhToan)
            {
                if(item.CTT_MA == 2)
                {
                    int PDT_STT = Convert.ToInt32(item.PDT_STT);
                    var getMoneyLT = DataProvider.Ins.DB.DG_LT.Where(x => x.LIEUTRINH.LT_STT == PDT_STT && x.GDV_MA == item.GDV_MA).Select(x => x.DONGIA).SingleOrDefault();
                    totalMoney += int.Parse(getMoneyLT.Replace(".", ""));
                    
                }
                else if(item.CTT_MA == 1)
                {
                    //int PDT_STT = Convert.ToInt32(item.PDT_STT);
                    var getMoneyGDV = DataProvider.Ins.DB.DG_GDV.Where(x => x.GDV_MA == item.GDV_MA).Select(x => x.DONGIA).SingleOrDefault();
                    totalMoney += int.Parse(getMoneyGDV.Replace(".", ""));
                }
            }

            thanhTien = totalMoney;

            return thanhTien;
        }

        int TinhGiamGia(ObservableCollection<ClassPhieuDieuTri> listPhieuDieuTri)
        {
            /*
                Xem gói dịch vụ đăng ký có nằm trong mục giảm giá hay không -> Nếu có
                Nếu phiếu đăng ký đó giảm theo gói
                    -> lấy ra giá gói -> tính số phần trăm được giảm của gói đó 
                Nếu phiếu đó giảm theo liệu trình
                    -> lấy ra giá liệu trình của phiếu điều trị đó -> tính phần trăm được giảm
            */
            int totalMoney = 0;
            int giaGiam = 0;

            var getPhieuDieuTriThanhToan = listPhieuDieuTri.Where(x => x.IsSelected == true).ToList();

            foreach(var item in getPhieuDieuTriThanhToan)
            {
                var getPDK_GG = DataProvider.Ins.DB.GIAMGIA_PDK.Where(x => x.PDK_STT == item.PDK_STT).SingleOrDefault();
                if (getPDK_GG != null)
                {
                    if (item.CTT_MA == 1)
                    {
                        //int PDT_STT = Convert.ToInt32(item.PDT_STT);
                        var getMoneyGDV = DataProvider.Ins.DB.DG_GDV.Where(x => x.GDV_MA == item.GDV_MA).Select(x => x.DONGIA).SingleOrDefault();
                        totalMoney = int.Parse(getMoneyGDV.Replace(".", ""));
                        giaGiam += totalMoney * getPDK_GG.GIAMGIA.GG_PHANTRAMGIAM / 100; 
                    }
                    else if (item.CTT_MA == 2)
                    {
                        int PDT_STT = Convert.ToInt32(item.PDT_STT);
                        var getMoneyLT = DataProvider.Ins.DB.DG_LT.Where(x => x.LIEUTRINH.LT_STT == PDT_STT && x.GDV_MA == item.GDV_MA).Select(x => x.DONGIA).SingleOrDefault();
                        totalMoney += int.Parse(getMoneyLT.Replace(".", ""));
                        giaGiam += totalMoney * getPDK_GG.GIAMGIA.GG_PHANTRAMGIAM / 100;
                    }
                }
            }

            return giaGiam;
        }

        void AddPhieuThu_PDT(ObservableCollection<ClassPhieuDieuTri> listPhieuDieuTri, PHIEUTHU phieuThu)
        {
            var phieuDieuTriCheck = listPhieuDieuTri.Where(x => x.IsSelected == true).ToList();
            foreach(var item in phieuDieuTriCheck)
            {
                DAO_PhieuThu.AddPT_PDT(phieuThu.PT_STT, item.PDT_STT, item.PDK_STT);
                DAO_PhieuDieuTri.EditTrangThaiNo(item.PDK_STT, item.PDT_STT, false);
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
