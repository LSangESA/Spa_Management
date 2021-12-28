using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using LVTN_QLSpa.Model.ModelClass;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Aspose.Cells;
using LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham;

namespace LVTN_QLSpa.ViewModel.NVDK_LichHenVaDangKy
{
    public class BaoCaoPhieuThuViewModel : BaseViewModel
    {
        private string _KeySearch;
        public string KeySearch { get => _KeySearch; set { _KeySearch = value; OnPropertyChanged(); } }

        private DateTime _NGAYBD;
        public DateTime NGAYBD { get => _NGAYBD; set { _NGAYBD = value; OnPropertyChanged(); } }

        private DateTime _NGAYKT;
        public DateTime NGAYKT { get => _NGAYKT; set { _NGAYKT = value; OnPropertyChanged(); } }

        private int _TONGSOPHIEUTHU;
        public int TONGSOPHIEUTHU { get => _TONGSOPHIEUTHU; set { _TONGSOPHIEUTHU = value; OnPropertyChanged(); } }

        private string _TONGTIENPHIEUTHU;
        public string TONGTIENPHIEUTHU { get => _TONGTIENPHIEUTHU; set { _TONGTIENPHIEUTHU = value; OnPropertyChanged(); } }

        private string _KH_TEN;
        public string KH_TEN { get => _KH_TEN; set { _KH_TEN = value; OnPropertyChanged(); } }

        private string _KH_SDT;
        public string KH_SDT { get => _KH_SDT; set { _KH_SDT = value; OnPropertyChanged(); } }

        private string _KH_MA;
        public string KH_MA { get => _KH_MA; set { _KH_MA = value; OnPropertyChanged(); } }

        private string _KH_EMAIL;
        public string KH_EMAIL { get => _KH_EMAIL; set { _KH_EMAIL = value; OnPropertyChanged(); } }

        private string _KH_GIOITINH;
        public string KH_GIOITINH { get => _KH_GIOITINH; set { _KH_GIOITINH = value; OnPropertyChanged(); } }

        private string _KH_ANH;
        public string KH_ANH { get => _KH_ANH; set { _KH_ANH = value; OnPropertyChanged(); } }

        private DateTime _KH_NGAYSINH;
        public DateTime KH_NGAYSINH { get => _KH_NGAYSINH; set { _KH_NGAYSINH = value; OnPropertyChanged(); } }

        private string _PT_STT;
        public string PT_STT { get => _PT_STT; set { _PT_STT = value; OnPropertyChanged(); } }

        private string _NV_TEN;
        public string NV_TEN { get => _NV_TEN; set { _NV_TEN = value; OnPropertyChanged(); } }

        private string _HTTT_TEN;
        public string HTTT_TEN { get => _HTTT_TEN; set { _HTTT_TEN = value; OnPropertyChanged(); } }

        private string _HTTT_ICON;
        public string HTTT_ICON { get => _HTTT_ICON; set { _HTTT_ICON = value; OnPropertyChanged(); } }

        private string _THANHTIEN;
        public string THANHTIEN { get => _THANHTIEN; set { _THANHTIEN = value; OnPropertyChanged(); } }

        private string _GIAMGIA;
        public string GIAMGIA { get => _GIAMGIA; set { _GIAMGIA = value; OnPropertyChanged(); } }

        private string _TONGTIEN;
        public string TONGTIEN { get => _TONGTIEN; set { _TONGTIEN = value; OnPropertyChanged(); } }

        private ObservableCollection<LOCNGAY> _FilterNgayXem;
        public ObservableCollection<LOCNGAY> FilterNgayXem { get => _FilterNgayXem; set { _FilterNgayXem = value; OnPropertyChanged(); } }

        private ObservableCollection<NHANVIEN> _NHANVIEN;
        public ObservableCollection<NHANVIEN> NHANVIEN { get => _NHANVIEN; set { _NHANVIEN = value; OnPropertyChanged(); } }

        private ObservableCollection<PHIEUTHU> _PHIEUTHU;
        public ObservableCollection<PHIEUTHU> PHIEUTHU { get => _PHIEUTHU; set { _PHIEUTHU = value; OnPropertyChanged(); } }

        private ObservableCollection<ClassPhieuDieuTri> _PHIEUDIEUTRI;
        public ObservableCollection<ClassPhieuDieuTri> PHIEUDIEUTRI { get => _PHIEUDIEUTRI; set { _PHIEUDIEUTRI = value; OnPropertyChanged(); } }

        private LOCNGAY _SelectedFilterNgayXem;
        public LOCNGAY SelectedFilterNgayXem
        {
            get => _SelectedFilterNgayXem;
            set
            {
                _SelectedFilterNgayXem = value;
                OnPropertyChanged();
            }
        }

        private NHANVIEN _SelectedNHANVIEN;
        public NHANVIEN SelectedNHANVIEN
        {
            get => _SelectedNHANVIEN;
            set
            {
                _SelectedNHANVIEN = value;
                OnPropertyChanged();
            }
        }

        private PHIEUTHU _SelectedPHIEUTHU;
        public PHIEUTHU SelectedPHIEUTHU
        {
            get => _SelectedPHIEUTHU;
            set
            {
                _SelectedPHIEUTHU = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoadWindow { get; set; }
        public ICommand KeySearchCommand { get; set; }
        public ICommand CommandLocNgay { get; set; }
        public ICommand CommandSelectedFilterNgayXem { get; set; }
        public ICommand CommandSelectedNHANVIEN { get; set; }
        public ICommand CommandInPhieuThu { get; set; }
        public ICommand CommandXuatPhieuThu { get; set; }
        public ICommand CommandSelectedPHIEUTHU { get; set; }

        public BaoCaoPhieuThuViewModel()
        {
            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                LoadDuLieuLoc();
                LoadNgay(DateTime.Now, DateTime.Now);
                PHIEUTHU = LoadListPhieuThu(NGAYBD, NGAYKT);
                TONGSOPHIEUTHU = GetSoLuongPhieuThu(PHIEUTHU);
                TONGTIENPHIEUTHU = GetTongTienPhieuThu(PHIEUTHU);
            }
            );

            KeySearchCommand = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {

            }
            );

            CommandLocNgay = new RelayCommand<object>((p) =>
            {
                if (NGAYBD == null || NGAYKT == null)
                    return false;

                return true;
            }, (p) =>
            {
                LoadNgay(NGAYBD, NGAYKT);
                PHIEUTHU = LoadListPhieuThu(NGAYBD, NGAYKT);
                TONGSOPHIEUTHU = GetSoLuongPhieuThu(PHIEUTHU);
                TONGTIENPHIEUTHU = GetTongTienPhieuThu(PHIEUTHU);
            }
            );

            CommandSelectedFilterNgayXem = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {

            }
            );

            CommandSelectedNHANVIEN = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                LoadNgay(NGAYBD, NGAYKT);
                PHIEUTHU = LoadListPhieuThu(NGAYBD, NGAYKT, SelectedNHANVIEN.NV_MA);
                TONGSOPHIEUTHU = GetSoLuongPhieuThu(PHIEUTHU);
                TONGTIENPHIEUTHU = GetTongTienPhieuThu(PHIEUTHU);
            }
            );

            CommandInPhieuThu = new RelayCommand<object>((p) =>
            {
                if (SelectedPHIEUTHU == null)
                    return false;
                return true;
            }, (p) =>
            {
                LapPhieuThuViewModel.PT_STT_DATA = PT_STT;
                W_InPhieuThu window = new W_InPhieuThu();
                window.ShowDialog();
                LapPhieuThuViewModel.PT_STT_DATA = null;
            }
            );

            CommandXuatPhieuThu = new RelayCommand<object>((p) =>
            {
                if (PHIEUTHU.Count() == 0)
                    return false;
                return true;
            }, (p) =>
            {
                var List = DAO_PhieuThu.ListPhieuThuReport(PHIEUTHU);

                // Mở hộp thoại lưu tập tin
                Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
                saveFileDialog.DefaultExt = ".xlsx";
                saveFileDialog.Filter = "Excel Workbook (.xlsx)|*.xlsx";

                if (false == saveFileDialog.ShowDialog()) return;
                string filename = saveFileDialog.FileName;

                Workbook workbook = new Workbook();
                Worksheet worksheet = workbook.Worksheets[0];
                worksheet.Name = "DoanhThu";

                // Ghi các cột
                worksheet.Cells["A1"].PutValue("STT");
                worksheet.Cells["B1"].PutValue("SỐ PHIẾU THU");
                worksheet.Cells["C1"].PutValue("NGÀY LẬP");
                worksheet.Cells["D1"].PutValue("MÃ KHÁCH HÀNG");
                worksheet.Cells["E1"].PutValue("HỌ TÊN KHÁCH HÀNG");
                worksheet.Cells["F1"].PutValue("HÌNH THỨC THANH TOÁN");
                worksheet.Cells["G1"].PutValue("NHÂN VIÊN LẬP PHIẾU");
                worksheet.Cells["H1"].PutValue("SỐ PHIẾU ĐIÊU TRỊ THU");
                worksheet.Cells["I1"].PutValue("TỔNG TIỀN");
                for (int y = 0; y < List.Count; y++)
                {
                    worksheet.Cells[$"A{y + 2}"].PutValue(List[y].STT);
                    worksheet.Cells[$"B{y + 2}"].PutValue(List[y].PT_STT);
                    worksheet.Cells[$"C{y + 2}"].PutValue(List[y].PT_NGAYLAP.ToString("dd/MM/yyyy hh:mm"));
                    worksheet.Cells[$"D{y + 2}"].PutValue(List[y].KH_MA);
                    worksheet.Cells[$"E{y + 2}"].PutValue(List[y].KH_HOTEN);
                    worksheet.Cells[$"F{y + 2}"].PutValue(List[y].HTTT_TEN);
                    worksheet.Cells[$"G{y + 2}"].PutValue(List[y].NV_TEN);
                    worksheet.Cells[$"H{y + 2}"].PutValue(List[y].PDT_THU);
                    worksheet.Cells[$"I{y + 2}"].PutValue(List[y].PT_TONGTIEN);
                }

                worksheet.Cells[$"H{List.Count + 3}"].PutValue("TỔNG SỐ PHIẾU:");
                worksheet.Cells[$"I{List.Count + 3}"].PutValue(TONGSOPHIEUTHU);
                worksheet.Cells[$"H{List.Count + 4}"].PutValue("TỔNG TIỀN:");
                worksheet.Cells[$"I{List.Count + 4}"].PutValue(TONGTIENPHIEUTHU);

                worksheet.AutoFitColumns();
                workbook.Save(filename);
            }
            );

            CommandSelectedPHIEUTHU = new RelayCommand<object>((p) =>
            {
                if (SelectedPHIEUTHU == null)
                    return false;

                return true;
            }, (p) =>
            {
                HienThiChiTietPhieuThu(SelectedPHIEUTHU);
            }
            );
        }

        void HienThiChiTietPhieuThu(PHIEUTHU phieuThu)
        {
            // Lấy thông tin phiếu thu
            PT_STT = phieuThu.PT_STT;
            NV_TEN = phieuThu.NHANVIEN.NV_HOTEN;

            // Lấy thông tin khách hàng
            var getKhachHangThu = DataProvider.Ins.DB.PT_PDT.Where(x => x.PT_STT == phieuThu.PT_STT).Select(x => x.PHIEUDIEUTRI.PHIEUDANGKY.KHACHHANG).Distinct().SingleOrDefault();
            KH_TEN = getKhachHangThu.KH_HOTEN;
            KH_SDT = getKhachHangThu.KH_SDT;
            KH_MA = getKhachHangThu.KH_MA;
            KH_EMAIL = getKhachHangThu.KH_EMAIL;
            KH_GIOITINH = getKhachHangThu.KH_GIOITINH;
            KH_NGAYSINH = getKhachHangThu.KH_NGAYSINH;

            if (getKhachHangThu.KH_GIOITINH == "Nam")
                KH_ANH = @"E:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Avatars\Customer\man.png";
            else
                KH_ANH = @"E:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Avatars\Customer\woman.png";

            // Lấy danh sách phiếu điều trị được thu
            var listPhieuDieuTri = new ObservableCollection<PT_PDT>(DataProvider.Ins.DB.PT_PDT.Where(x => x.PT_STT == phieuThu.PT_STT));
            if(listPhieuDieuTri != null)
            {
                PHIEUDIEUTRI = new ObservableCollection<ClassPhieuDieuTri>();
                foreach (var item in listPhieuDieuTri)
                {
                    var phieuDieuTri = new ClassPhieuDieuTri();
                    phieuDieuTri.PDK_STT = ClassXuLyChuoi.XoaKhoanTrangKyTuCuoi(item.PDK_STT);
                    phieuDieuTri.PDT_NGAYLAP = item.PHIEUDIEUTRI.PDT_NGAYLAP;
                    phieuDieuTri.PDT_STT = ClassXuLyChuoi.XoaKhoanTrangKyTuCuoi(item.PDT_STT);
                    phieuDieuTri.GDV_TEN = ClassXuLyChuoi.XoaKhoanTrangKyTuCuoi(item.PHIEUDIEUTRI.PHIEUDANGKY.GOIDICHVU.GDV_TEN);
                    phieuDieuTri.GDV_MA = ClassXuLyChuoi.XoaKhoanTrangKyTuCuoi(item.PHIEUDIEUTRI.PHIEUDANGKY.GDV_MA);
                    phieuDieuTri.CTT_MA = item.PHIEUDIEUTRI.PHIEUDANGKY.CTT_MA;

                    PHIEUDIEUTRI.Add(phieuDieuTri);
                }
            }

            THANHTIEN = ClassXuLyChuoi.ChuyenSoThanhTien(TinhThanhTien(PHIEUDIEUTRI));
            GIAMGIA = ClassXuLyChuoi.ChuyenSoThanhTien(TinhGiamGia(PHIEUDIEUTRI));
            TONGTIEN = ClassXuLyChuoi.ChuyenSoThanhTien(TinhThanhTien(PHIEUDIEUTRI) - TinhGiamGia(PHIEUDIEUTRI));

            // Lấy hình thức thanh toán
            var getPhieuThu = DataProvider.Ins.DB.PHIEUTHU.Where(x => x.PT_STT == phieuThu.PT_STT).SingleOrDefault();
            if(getPhieuThu.HTTT_MA == 1)
            {
                HTTT_TEN = getPhieuThu.HINHTHUCTHANHTOAN.HTTT_TEN;
                HTTT_ICON = @"E:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Icons\pay\money.png";
            }
            else if(getPhieuThu.HTTT_MA == 2)
            {
                HTTT_TEN = getPhieuThu.HINHTHUCTHANHTOAN.HTTT_TEN;
                HTTT_ICON = @"E:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Icons\pay\credit-card.png";
            }
        }

        int TinhThanhTien(ObservableCollection<ClassPhieuDieuTri> listPhieuDieuTri)
        {
            int thanhTien = 0;
            int totalMoney = 0;

            var getPhieuDieuTriThanhToan = listPhieuDieuTri.ToList();

            foreach (var item in getPhieuDieuTriThanhToan)
            {
                if (item.CTT_MA == 2)
                {
                    int PDT_STT = Convert.ToInt32(item.PDT_STT);
                    var getMoneyLT = DataProvider.Ins.DB.DG_LT.Where(x => x.LIEUTRINH.LT_STT == PDT_STT && x.GDV_MA == item.GDV_MA).Select(x => x.DONGIA).SingleOrDefault();
                    totalMoney += int.Parse(getMoneyLT.Replace(".", ""));

                }
                else if (item.CTT_MA == 1)
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

            var getPhieuDieuTriThanhToan = listPhieuDieuTri.ToList();

            foreach (var item in getPhieuDieuTriThanhToan)
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

        int GetSoLuongPhieuThu(ObservableCollection<PHIEUTHU> phieuThu)
        {
            int soLuongPhieu = 0;
            if(phieuThu.Count() > 0)
            {
                soLuongPhieu = phieuThu.Count();
                return soLuongPhieu;
            }
            return soLuongPhieu;
        }

        string GetTongTienPhieuThu(ObservableCollection<PHIEUTHU> phieuThu)
        {
            decimal tongTienPhieuThu = 0;
            if (phieuThu.Count() > 0)
            {
                foreach (var item in phieuThu)
                {
                    tongTienPhieuThu += item.PT_TONGTIEN;
                }
                return ClassXuLyChuoi.ChuyenSoThanhTien(Convert.ToInt32(tongTienPhieuThu));
            }

            return ClassXuLyChuoi.ChuyenSoThanhTien(Convert.ToInt32(tongTienPhieuThu));
        }

        ObservableCollection<PHIEUTHU> LoadListPhieuThu(DateTime ngayBD, DateTime ngayKT, string NV_MA = null)
        {
            if(string.IsNullOrEmpty(NV_MA))
            {
                return new ObservableCollection<PHIEUTHU>(DataProvider.Ins.DB.PHIEUTHU.Where(x => x.PT_NGAYLAP >= ngayBD && x.PT_NGAYLAP <= ngayKT).OrderByDescending(x=>x.PT_NGAYLAP));
            }
            else
            {
                return new ObservableCollection<PHIEUTHU>(DataProvider.Ins.DB.PHIEUTHU.Where(x => x.PT_NGAYLAP >= ngayBD && x.PT_NGAYLAP <= ngayKT && x.NV_MA == NV_MA).OrderByDescending(x => x.PT_NGAYLAP));
            }
        }

        void LoadNgay(DateTime ngayDB, DateTime ngayKT)
        {
            NGAYBD = new DateTime(ngayDB.Year, ngayDB.Month, ngayDB.Day, 0, 0, 0);
            NGAYKT = new DateTime(ngayKT.Year, ngayKT.Month, ngayKT.Day, 23, 59, 59);
        }

        void LoadDuLieuLoc()
        {
            FilterNgayXem = new ObservableCollection<LOCNGAY>();
            FilterNgayXem.Add(new LOCNGAY { Name = "Hôm nay" });
            FilterNgayXem.Add(new LOCNGAY { Name = "Tuần trước" });
            FilterNgayXem.Add(new LOCNGAY { Name = "Tháng trước" });
            FilterNgayXem.Add(new LOCNGAY { Name = "Năm trước" });

            var getNhanVienThuNgan = DataProvider.Ins.DB.CHUYENMONNHANVIEN.Where(x => x.CHUYENMON.VAITRO.VT_MA == 4 || x.CHUYENMON.VAITRO.VT_MA == 5 || x.CHUYENMON.VAITRO.VT_MA == 1 ).Select(x=>x.NHANVIEN).ToList();
            NHANVIEN = new ObservableCollection<NHANVIEN>(getNhanVienThuNgan);
        }
    }

    public class LOCNGAY
    {
        public string Name { get; set; }
    }
}
