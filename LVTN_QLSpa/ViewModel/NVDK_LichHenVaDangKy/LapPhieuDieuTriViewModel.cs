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
    public class LapPhieuDieuTriViewModel : BaseViewModel
    {
        private static string pdt_STT_DATA;
        public static string PDT_STT_DATA
        {
            get { return LapPhieuDieuTriViewModel.pdt_STT_DATA; }
            set { LapPhieuDieuTriViewModel.pdt_STT_DATA = value; }
        }

        private static string pdk_STT_DATA;
        public static string PDK_STT_DATA
        {
            get { return LapPhieuDieuTriViewModel.pdk_STT_DATA; }
            set { LapPhieuDieuTriViewModel.pdk_STT_DATA = value; }
        }

        private static int p_MA_DATA;
        public static int P_MA_DATA
        {
            get { return LapPhieuDieuTriViewModel.p_MA_DATA; }
            set { LapPhieuDieuTriViewModel.p_MA_DATA = value; }
        }

        public static PHIEUDIEUTRI pdt { get; set; }
        public static string getPDK_STT { get; set; }
        public static string getGDV_MA { get; set; }

        private string _SOPDT;
        public string SOPDT { get => _SOPDT; set { _SOPDT = value; OnPropertyChanged(); } }

        private string _SOPDK;
        public string SOPDK { get => _SOPDK; set { _SOPDK = value; OnPropertyChanged(); } }

        private bool _PDT_NO;
        public bool PDT_NO { get => _PDT_NO; set { _PDT_NO = value; OnPropertyChanged(); } }

        private string _HOTENKH;
        public string HOTENKH { get => _HOTENKH; set { _HOTENKH = value; OnPropertyChanged(); } }

        private string _TENGDV;
        public string TENGDV { get => _TENGDV; set { _TENGDV = value; OnPropertyChanged(); } }

        private string _LT_STT;
        public string LT_STT { get => _LT_STT; set { _LT_STT = value; OnPropertyChanged(); } }

        private string _LT_MOTA;
        public string LT_MOTA { get => _LT_MOTA; set { _LT_MOTA = value; OnPropertyChanged(); } }

        private DateTime _NGAYDT;
        public DateTime NGAYDT { get => _NGAYDT; set { _NGAYDT = value; OnPropertyChanged(); } }

        private string _CTT_TEN;
        public string CTT_TEN { get => _CTT_TEN; set { _CTT_TEN = value; OnPropertyChanged(); } }

        private bool _CheckKhachNo;
        public bool CheckKhachNo { get => _CheckKhachNo; set { _CheckKhachNo = value; OnPropertyChanged(); } }

        private bool _EnabledKhachNo;
        public bool EnabledKhachNo { get => _EnabledKhachNo; set { _EnabledKhachNo = value; OnPropertyChanged(); } }

        private bool _HienThiPhong;
        public bool HienThiPhong { get => _HienThiPhong; set { _HienThiPhong = value; OnPropertyChanged(); } }
        
        private ObservableCollection<Phong> _PHONG;
        public ObservableCollection<Phong> PHONG { get => _PHONG; set { _PHONG = value; OnPropertyChanged(); } }
        

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
        public ICommand CommandInPhieu { get; set; }
        public ICommand CommandOpenPhieuThu { get; set; }
        public ICommand CommandClosePDT { get; set; }
        public ICommand CommandSelectedNHANVIEN { get; set; }
        public ICommand CommandCheckKhachNo { get; set; }
        public ICommand CommandUnCheckKhachNo { get; set; }

        public LapPhieuDieuTriViewModel()
        {
            LoadWindow = new RelayCommand<Window>((p) =>
            {
                return true;
            }, (p) =>
            {
                getPDK_STT = LapPhieuDangKyViewModel.PDK_STT_DATA;
                getGDV_MA = LapPhieuDangKyViewModel.GDV_MA_DATA;
                
                // Lay ra phong thuoc goi dich vu
                var phongGDV = DataProvider.Ins.DB.DICHVUPHONG.Where(x => x.GDV_MA == getGDV_MA).Select(x => x.PHONG).ToList();
                PHONG = new ObservableCollection<Phong>();
                foreach (var item in phongGDV)
                {
                    var phong = new Phong();
                    phong.P_MA = item.P_MA;
                    phong.P_SO = item.P_SO.Trim(' ');
                    phong.P_TEN = item.P_TEN;

                    PHONG.Add(phong);
                }
                
                // Lap phieu dieu tri
                int? soLanLieuTrinhGDV = DataProvider.Ins.DB.LIEUTRINH.Where(x=>x.GDV_MA == getGDV_MA).Count();
                int tongSoPhieuDTcuaPDK = DAO_PhieuDieuTri.GetSoPDTInPDK(getPDK_STT);

                PHIEUDIEUTRI phieuDieuTri = new PHIEUDIEUTRI();
                if(DataProvider.Ins.DB.PHIEUDANGKY.Where(x=>x.PDK_STT == getPDK_STT).Select(x=>x.GOIDICHVU.LGDV_MA).SingleOrDefault() == 1)
                {
                    if (tongSoPhieuDTcuaPDK < soLanLieuTrinhGDV)
                    {
                        if(tongSoPhieuDTcuaPDK > 0)
                        {
                            var getCachTTGDV = DataProvider.Ins.DB.PHIEUDANGKY.Where(x => x.PDK_STT == PDK_STT_DATA).Select(x=>x.CTT_MA).SingleOrDefault();
                            if (getCachTTGDV == 1)
                                PDT_NO = false;
                            else
                                PDT_NO = CheckKhachNo;
                        }
                        else
                        {
                            PDT_NO = CheckKhachNo;
                        }
                        // Add PDT
                        tongSoPhieuDTcuaPDK = tongSoPhieuDTcuaPDK + 1;
                        phieuDieuTri = DAO_PhieuDieuTri.Add(getPDK_STT, tongSoPhieuDTcuaPDK.ToString(), DateTime.Now, "Chờ khám", PDT_NO);
                        pdt = phieuDieuTri;
                        ThongTinKhachHangViewModel.PDT_DATA = phieuDieuTri;

                        // Lấy ra phòng của bác sĩ phụ trách gói dịch vụ có liệu trình đó, nếu không có thì khỏi lấy
                        if (phieuDieuTri.PHIEUDANGKY.GOIDICHVU.LGDV_MA == 1)
                        {
                            var ngayHienTai = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                            var phongCaNgay = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.NV_MA == phieuDieuTri.PHIEUDANGKY.NV_MA && x.THOIGIAN == ngayHienTai && x.CLV_MA == "CLV2765             ").SingleOrDefault();
                            if (phongCaNgay != null)
                            {
                                SelectedPHONG = PHONG.Where(x => x.P_MA == phongCaNgay.P_MA).SingleOrDefault();
                            }
                            else
                            {
                                var caLamViecTheoGioHienTai = LayCaLamViecTuongUngBuoiLieuTri(new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second));
                                var phongTheoCa = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.NV_MA == phieuDieuTri.PHIEUDANGKY.NV_MA && x.THOIGIAN == ngayHienTai && x.CLV_MA == caLamViecTheoGioHienTai.CLV_MA).SingleOrDefault();
                                if (phongTheoCa != null)
                                {
                                    SelectedPHONG = PHONG.Where(x => x.P_MA == phongTheoCa.P_MA).SingleOrDefault();
                                }
                            }
                        }
                    }
                }
                else
                {
                    Random r = new Random();
                    SOPDT = "PDT" + r.Next(10000, 99999);
                    phieuDieuTri = DAO_PhieuDieuTri.Add(getPDK_STT, SOPDT, DateTime.Now, "Chờ khám", CheckKhachNo);
                    pdt = phieuDieuTri;
                }
                
                if(phieuDieuTri.PDT_STT == null)
                {
                    FrameworkElement window = GetWindowParent(p);
                    var w = window as Window;
                    if (w != null)
                    {
                        w.Close();
                    }
                }
                else
                    LoadDataPDT(phieuDieuTri);
            }
            );

            CommandInPhieu = new RelayCommand<Window>((p) =>
            {
                return true;
            }, (p) =>
            {
                if(pdt.PDT_STT != "1" && pdt.PHIEUDANGKY.GOIDICHVU.LGDV_MA == 1)
                {
                    P_MA_DATA = SelectedPHONG.P_MA;
                }
                
                PDT_STT_DATA = SOPDT;
                PDK_STT_DATA = SOPDK;
                W_InPhieuCho window = new W_InPhieuCho();
                window.ShowDialog();
                PDT_STT_DATA = null;
                PDK_STT_DATA = null;
            }
            );

            CommandOpenPhieuThu = new RelayCommand<Window>((p) =>
            {
                if (CheckKhachNo == true)
                    return false;

                var getTrangThaiPhieu = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDT_STT == SOPDT && x.PDK_STT == SOPDK && x.PHIEUDANGKY.GOIDICHVU.LGDV_MA == 1 && x.PHIEUDANGKY.CTT_MA == 1 && x.PDT_STT != "1").SingleOrDefault();
                if (getTrangThaiPhieu != null)
                    return false;

                return true;
            }, (p) =>
            {
                PDT_STT_DATA = SOPDT;
                PDK_STT_DATA = SOPDK;
                DAO_PhieuDieuTri.EditTrangThaiNo(SOPDK, SOPDT, CheckKhachNo);

                W_LapPhieuThu windowPT = new W_LapPhieuThu();
                p.Hide();
                windowPT.ShowDialog();

                PDT_STT_DATA = null;
                PDK_STT_DATA = null;
                var getTTNo = DataProvider.Ins.DB.PT_PDT.Where(x => x.PDT_STT == SOPDT && x.PDK_STT == SOPDK).Count();
                if (getTTNo > 0)
                {
                    FrameworkElement window = GetWindowParent(p);
                    var w = window as Window;
                    if (w != null)
                    {
                        w.Close();
                    }
                }
                else
                {
                    p.Show();
                }
            }
            );

            CommandClosePDT = new RelayCommand<Window>((p) =>
            {
                //var getTrangThaiPhieu1 = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDT_STT == SOPDT && x.PDK_STT == SOPDK && x.PHIEUDANGKY.GOIDICHVU.LGDV_MA == 1 && x.PHIEUDANGKY.CTT_MA == 2).Select(x => x.PDT_TRANGTHAINNO).SingleOrDefault();
                //if (getTrangThaiPhieu1 == false)
                //{
                //    return false;
                //}

                //var getTrangThaiPhieu2 = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDT_STT == SOPDT && x.PDK_STT == SOPDK && x.PHIEUDANGKY.GOIDICHVU.LGDV_MA == 2).Select(x=>x.PDT_TRANGTHAINNO).SingleOrDefault();
                //if (getTrangThaiPhieu2 == false)
                //{
                //    return false;
                //}

                return true;
            }, (p) =>
            {
                //var getPTPDT = DataProvider.Ins.DB.PT_PDT.Where(x => x.PDT_STT == SOPDT && x.PDK_STT == SOPDK).Count();
                //if(getPTPDT == 0)
                //{
                //    var getNVPDT = DataProvider.Ins.DB.NV_PDT.Where(x => x.PDK_STT == SOPDK && x.PDT_STT == SOPDT).ToList();
                //    foreach (var item in getNVPDT)
                //    {
                //        DAO_PhieuDieuTri.Delete_NVPDT(item);
                //    }

                //    DAO_PhieuDieuTri.DeletePDT(SOPDT, SOPDK);
                //}
                if (CheckKhachNo == false)
                {
                    var getPDTCoCTTTheoLieuTrinhThu2 = DAO_PhieuDieuTri.GetLastPhieuDieuTri(SOPDK);
                    if(getPDTCoCTTTheoLieuTrinhThu2.PHIEUDANGKY.GOIDICHVU.LGDV_MA == 1)
                    {
                        if (getPDTCoCTTTheoLieuTrinhThu2.PDT_TRANGTHAINNO == false && Convert.ToInt32(getPDTCoCTTTheoLieuTrinhThu2.PDT_STT) >= 2 && getPDTCoCTTTheoLieuTrinhThu2.PHIEUDANGKY.CTT_MA == 1)
                        {
                            FrameworkElement window = GetWindowParent(p);
                            var w = window as Window;
                            if (w != null)
                            {
                                w.Close();
                            }
                        }
                        else
                            MessageBox.Show("Chưa thanh toán, không thể thoát", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);

                    }
                    else
                    {
                        var getTTNo = DataProvider.Ins.DB.PT_PDT.Where(x => x.PDT_STT == SOPDT && x.PDK_STT == SOPDK).Count();
                        if (getTTNo == 0)
                        {
                            MessageBox.Show("Chưa thanh toán, không thể thoát", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
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

            CommandCheckKhachNo = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                DAO_PhieuDieuTri.EditTrangThaiNo(SOPDK, SOPDT, true);
            }
            );

            CommandUnCheckKhachNo = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                DAO_PhieuDieuTri.EditTrangThaiNo(SOPDK, SOPDT, false);
            }
            );
        }

        void LoadDataPDT(PHIEUDIEUTRI phieuDieuTri)
        {
            if(phieuDieuTri.PHIEUDANGKY.GOIDICHVU.LOAIGOIDICHVU.LGDV_MA == 1)
            {
                int SOPDT = Convert.ToInt32(phieuDieuTri.PDT_STT);
                var lieuTrinh = DataProvider.Ins.DB.LIEUTRINH.Where(x => x.GDV_MA == phieuDieuTri.PHIEUDANGKY.GDV_MA && x.LT_STT == SOPDT).SingleOrDefault();
                LT_STT = lieuTrinh.LT_STT + " - " + lieuTrinh.LT_MOTA;
            }
            else
            {
                LT_STT = "";
            }

            SOPDT = phieuDieuTri.PDT_STT;
            SOPDK = phieuDieuTri.PDK_STT;
            TENGDV = phieuDieuTri.PHIEUDANGKY.GOIDICHVU.GDV_TEN;
            HOTENKH = phieuDieuTri.PHIEUDANGKY.KHACHHANG.KH_HOTEN;
            NGAYDT = phieuDieuTri.PDT_NGAYLAP;
            CTT_TEN = phieuDieuTri.PHIEUDANGKY.CACHTHANHTOAN.CTT_TEN;

            EnabledKhachNo = true;
            var getTrangThaiPhieu = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDT_STT == SOPDT && x.PDK_STT == SOPDK && x.PHIEUDANGKY.GOIDICHVU.LGDV_MA == 1 && x.PHIEUDANGKY.CTT_MA == 1 && x.PDT_STT != "1").SingleOrDefault();
            if (getTrangThaiPhieu != null)
                EnabledKhachNo = false;

            // Hien thi phong
            if(phieuDieuTri.PHIEUDANGKY.GOIDICHVU.LGDV_MA == 1 && phieuDieuTri.PDT_STT != "1")
            {
                HienThiPhong = true;
            }
            else
            {
                HienThiPhong = false;
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

        CALAMVIEC LayCaLamViecTuongUngBuoiLieuTri(TimeSpan gioHienTai)
        {
            if (new TimeSpan(0, 0, 0) <= gioHienTai && gioHienTai <= new TimeSpan(11, 59, 59))
                return DataProvider.Ins.DB.CALAMVIEC.Where(x => x.CLV_MA == "CLV7961             ").SingleOrDefault();
            else
                return DataProvider.Ins.DB.CALAMVIEC.Where(x => x.CLV_MA == "CLV8258             ").SingleOrDefault();
        }
    }
}
