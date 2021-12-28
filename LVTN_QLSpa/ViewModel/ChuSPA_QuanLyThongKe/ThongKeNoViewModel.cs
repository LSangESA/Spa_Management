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

namespace LVTN_QLSpa.ViewModel.ChuSPA_QuanLyThongKe
{
    public class ThongKeNoViewModel : BaseViewModel
    {
        private int _TONGKHACHHANG;
        public int TONGKHACHHANG { get => _TONGKHACHHANG; set { _TONGKHACHHANG = value; OnPropertyChanged(); } }

        private string _TONGTIENNO;
        public string TONGTIENNO { get => _TONGTIENNO; set { _TONGTIENNO = value; OnPropertyChanged(); } }

        private DateTime _NGAYBATDAU;
        public DateTime NGAYBATDAU { get => _NGAYBATDAU; set { _NGAYBATDAU = value; OnPropertyChanged(); } }

        private DateTime _NGAYKETTHUC;
        public DateTime NGAYKETTHUC { get => _NGAYKETTHUC; set { _NGAYKETTHUC = value; OnPropertyChanged(); } }

        private bool _CheckCuThe;
        public bool CheckCuThe { get => _CheckCuThe; set { _CheckCuThe = value; OnPropertyChanged(); } }

        private bool _CheckTuyChon;
        public bool CheckTuyChon { get => _CheckTuyChon; set { _CheckTuyChon = value; OnPropertyChanged(); } }

        private ObservableCollection<THANG> _THANG;
        public ObservableCollection<THANG> THANG { get => _THANG; set { _THANG = value; OnPropertyChanged(); } }

        private ObservableCollection<NAM> _NAM;
        public ObservableCollection<NAM> NAM { get => _NAM; set { _NAM = value; OnPropertyChanged(); } }

        private ObservableCollection<ClassKhachHangNo> _ListKhachHangNo;
        public ObservableCollection<ClassKhachHangNo> ListKhachHangNo { get => _ListKhachHangNo; set { _ListKhachHangNo = value; OnPropertyChanged(); } }

        private ObservableCollection<ClassPhieuDieuTriNo> _ListPhieuDieuTriNo;
        public ObservableCollection<ClassPhieuDieuTriNo> ListPhieuDieuTriNo { get => _ListPhieuDieuTriNo; set { _ListPhieuDieuTriNo = value; OnPropertyChanged(); } }

        private THANG _SelectedTHANG;
        public THANG SelectedTHANG
        {
            get => _SelectedTHANG;
            set
            {
                _SelectedTHANG = value;
                OnPropertyChanged();

            }
        }

        private NAM _SelectedNAM;
        public NAM SelectedNAM
        {
            get => _SelectedNAM;
            set
            {
                _SelectedNAM = value;
                OnPropertyChanged();

            }
        }

        private ClassKhachHangNo _SelectedKhachHangNo;
        public ClassKhachHangNo SelectedKhachHangNo
        {
            get => _SelectedKhachHangNo;
            set
            {
                _SelectedKhachHangNo = value;
                OnPropertyChanged();

            }
        }

        private ClassPhieuDieuTriNo _SelectedPhieuDieuTriNo;
        public ClassPhieuDieuTriNo SelectedPhieuDieuTriNo
        {
            get => _SelectedPhieuDieuTriNo;
            set
            {
                _SelectedPhieuDieuTriNo = value;
                OnPropertyChanged();

            }
        }

        public ICommand LoadWindow { get; set; }
        public ICommand CommandLoc { get; set; }
        public ICommand CommandBoLoc { get; set; }
        public ICommand CommandSelectedKhachHangNo { get; set; }

        public ThongKeNoViewModel()
        {
            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                CheckCuThe = true;
                THANG = LoadThang();
                NAM = LoadNam();
                NGAYBATDAU = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                NGAYKETTHUC = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
                SelectedTHANG = THANG.Where(x => x.Name == DateTime.Now.Month).SingleOrDefault();
                SelectedNAM = NAM.Where(x => x.Name == DateTime.Now.Year).SingleOrDefault();

                Load();
            }
            );

            CommandLoc = new RelayCommand<object>((p) =>
            {
                if(CheckTuyChon == true)
                    if (NGAYBATDAU > NGAYKETTHUC)
                        return false;

                if (CheckCuThe == true)
                    if (SelectedTHANG != null && SelectedNAM == null)
                        return false;

                return true;
            }, (p) =>
            {
                Load();
            }
            );

            CommandBoLoc = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                CheckCuThe = true;
                THANG = LoadThang();
                NAM = LoadNam();
                NGAYBATDAU = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                NGAYKETTHUC = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
                SelectedNAM = NAM.Where(x => x.Name == DateTime.Now.Year).SingleOrDefault();

                Load();
            }
            );

            CommandSelectedKhachHangNo = new RelayCommand<object>((p) =>
            {
                if (SelectedKhachHangNo == null)
                    return false;

                return true;
            }, (p) =>
            {
                var phieuDTNoKH = LayDuLieuLoc().Where(x => x.PHIEUDANGKY.KH_MA == SelectedKhachHangNo.KH_MA).ToList();
                ListPhieuDieuTriNo = new ObservableCollection<ClassPhieuDieuTriNo>();
                
                foreach(var item in phieuDTNoKH)
                {
                    var phieuDieuTri = new ClassPhieuDieuTriNo();
                    phieuDieuTri.PDK_STT = item.PDK_STT;
                    phieuDieuTri.PDT_STT = item.PDT_STT;
                    phieuDieuTri.GDV_TEN = item.PHIEUDANGKY.GOIDICHVU.GDV_TEN;
                    phieuDieuTri.PDT_NGAYKHAM = item.PDT_NGAYLAP;

                    // Tính thành tiền
                    int thanhTien = 0;
                    if (item.PHIEUDANGKY.CTT_MA == 2)
                    {
                        int PDT_STT = Convert.ToInt32(item.PDT_STT);
                        var getMoneyLT = DataProvider.Ins.DB.DG_LT.Where(x => x.LIEUTRINH.LT_STT == PDT_STT && x.GDV_MA == item.PHIEUDANGKY.GDV_MA).Select(x => x.DONGIA).SingleOrDefault();
                        thanhTien += int.Parse(getMoneyLT.Replace(".", ""));

                    }
                    else if (item.PHIEUDANGKY.CTT_MA == 1)
                    {
                        //int PDT_STT = Convert.ToInt32(item.PDT_STT);
                        var getMoneyGDV = DataProvider.Ins.DB.DG_GDV.Where(x => x.GDV_MA == item.PHIEUDANGKY.GDV_MA).Select(x => x.DONGIA).SingleOrDefault();
                        thanhTien += int.Parse(getMoneyGDV.Replace(".", ""));
                    }
                    phieuDieuTri.THANHTIEN = thanhTien;

                    // Tính giảm giá
                    int totalMoney = 0;
                    int giaGiam = 0;
                    var getPDK_GG = DataProvider.Ins.DB.GIAMGIA_PDK.Where(x => x.PDK_STT == item.PDK_STT).SingleOrDefault();
                    if (getPDK_GG != null)
                    {
                        if (item.PHIEUDANGKY.CTT_MA == 1)
                        {
                            //int PDT_STT = Convert.ToInt32(item.PDT_STT);
                            var getMoneyGDV = DataProvider.Ins.DB.DG_GDV.Where(x => x.GDV_MA == item.PHIEUDANGKY.GDV_MA).Select(x => x.DONGIA).SingleOrDefault();
                            totalMoney = int.Parse(getMoneyGDV.Replace(".", ""));
                            giaGiam += totalMoney * getPDK_GG.GIAMGIA.GG_PHANTRAMGIAM / 100;
                        }
                        else if (item.PHIEUDANGKY.CTT_MA == 2)
                        {
                            int PDT_STT = Convert.ToInt32(item.PDT_STT);
                            var getMoneyLT = DataProvider.Ins.DB.DG_LT.Where(x => x.LIEUTRINH.LT_STT == PDT_STT && x.GDV_MA == item.PHIEUDANGKY.GDV_MA).Select(x => x.DONGIA).SingleOrDefault();
                            totalMoney += int.Parse(getMoneyLT.Replace(".", ""));
                            giaGiam += totalMoney * getPDK_GG.GIAMGIA.GG_PHANTRAMGIAM / 100;
                        }
                    }
                    phieuDieuTri.GIAGIAM = giaGiam;

                    // Tinh tổng thu
                    phieuDieuTri.TONGTHU = phieuDieuTri.THANHTIEN - phieuDieuTri.GIAGIAM;

                    ListPhieuDieuTriNo.Add(phieuDieuTri);
                }
            }
            );
        }

        void Load()
        {
            TONGKHACHHANG = TongKhachHangNo();
            TONGTIENNO = TongTienNo()+"đ";

            // Lấy ra danh sách khách hàng nợ
            var khachHangNo = LayDuLieuLoc();
            ListKhachHangNo = new ObservableCollection<ClassKhachHangNo>();

            // Đưa dữ liệu khách hàng lên UI
            foreach(var item in khachHangNo.Select(x => x.PHIEUDANGKY.KHACHHANG).Distinct())
            {
                var khachHang = new ClassKhachHangNo();

                // Lấy thông tin khách hàng
                khachHang.KH_MA = item.KH_MA;
                khachHang.KH_TEN = item.KH_HOTEN;
                khachHang.KH_GIOITINH = item.KH_GIOITINH;
                khachHang.KH_SDT = item.KH_SDT;

                // Lấy ngày cuối cùng sử dụng dịch vụ
                var layNgayCuoi = khachHangNo.Where(x=>x.PHIEUDANGKY.KH_MA == item.KH_MA).Select(x => x.PHIEUDANGKY).OrderByDescending(x=>x.PDK_NGAYDK).ToList().FirstOrDefault();
                khachHang.KH_NGAYKHAMCUOI = layNgayCuoi.PDK_NGAYDK;

                // Lấy tổng phiếu nợ
                khachHang.KH_TONGPHIEUNO = khachHangNo.Where(x => x.PHIEUDANGKY.KH_MA == item.KH_MA).Count();

                // Lấy tổng số nợ khách hàng
                var listPDTNo = new ObservableCollection<PHIEUDIEUTRI>(khachHangNo.Where(x => x.PHIEUDANGKY.KH_MA == item.KH_MA));
                khachHang.KH_TONGNO = ClassXuLyChuoi.ChuyenSoThanhTien(TinhThanhTien(listPDTNo) - TinhGiamGia(listPDTNo));

                ListKhachHangNo.Add(khachHang);
            }
        }

        ObservableCollection<THANG> LoadThang()
        {
            var thang = new ObservableCollection<THANG>();
            thang.Add(new THANG() { Name = 1 });
            thang.Add(new THANG() { Name = 2 });
            thang.Add(new THANG() { Name = 3 });
            thang.Add(new THANG() { Name = 4 });
            thang.Add(new THANG() { Name = 5 });
            thang.Add(new THANG() { Name = 6 });
            thang.Add(new THANG() { Name = 7 });
            thang.Add(new THANG() { Name = 8 });
            thang.Add(new THANG() { Name = 9 });
            thang.Add(new THANG() { Name = 10 });
            thang.Add(new THANG() { Name = 11 });
            thang.Add(new THANG() { Name = 12 });

            return thang;
        }

        ObservableCollection<NAM> LoadNam()
        {
            var nam = new ObservableCollection<NAM>();

            nam.Add(new NAM() { Name = 2020 });
            nam.Add(new NAM() { Name = 2021 });
            nam.Add(new NAM() { Name = 2022 });

            return nam;
        }

        ObservableCollection<PHIEUDIEUTRI> LayDuLieuLoc()
        {
            if (CheckTuyChon == true)
            {
                return LayDanhSachPhieuDieuTriNoTheoTuyChon(NGAYBATDAU, NGAYKETTHUC);
            }
            else
            {
                // Nếu như lọc cả tháng và năm
                if (SelectedNAM != null && SelectedTHANG != null)
                {
                    return LayDanhSachPhieuDieuTriNoTheoCuThe(SelectedTHANG.Name, SelectedNAM.Name);
                }
                else
                {
                    return LayDanhSachPhieuDieuTriNoTheoCuTheTheoNam(SelectedNAM.Name);
                }
            }
        }

        string TongTienNo()
        {
            //if (CheckTuyChon == true)
            //{
            //    var phieuDieuTri = LayDanhSachPhieuDieuTriNoTheoTuyChon(NGAYBATDAU, NGAYKETTHUC);
            //    return ClassXuLyChuoi.ChuyenSoThanhTien(TinhThanhTien(phieuDieuTri) - TinhGiamGia(phieuDieuTri));
            //}
            //else
            //{
            //    // Nếu như lọc cả tháng và năm
            //    if (SelectedNAM != null && SelectedTHANG != null)
            //    {
            //        var phieuDieuTri = LayDanhSachPhieuDieuTriNoTheoCuThe(SelectedTHANG.Name, SelectedNAM.Name);
            //        return ClassXuLyChuoi.ChuyenSoThanhTien(TinhThanhTien(phieuDieuTri) - TinhGiamGia(phieuDieuTri));
            //    }
            //    else
            //    {
            //        var phieuDieuTri = LayDanhSachPhieuDieuTriNoTheoCuTheTheoNam(SelectedNAM.Name);
            //        return ClassXuLyChuoi.ChuyenSoThanhTien(TinhThanhTien(phieuDieuTri) - TinhGiamGia(phieuDieuTri));
            //    }
            //}

            var phieuDieuTri = LayDuLieuLoc();
            return ClassXuLyChuoi.ChuyenSoThanhTien(TinhThanhTien(phieuDieuTri) - TinhGiamGia(phieuDieuTri));
        }

        int TongKhachHangNo()
        {
            //if(CheckTuyChon == true)
            //{
            //    return LayDanhSachPhieuDieuTriNoTheoTuyChon(NGAYBATDAU, NGAYKETTHUC).Select(x => x.PHIEUDANGKY.KHACHHANG).Distinct().Count();
            //}
            //else
            //{
            //    // Nếu như lọc cả tháng và năm
            //    if (SelectedNAM != null && SelectedTHANG != null)
            //        return LayDanhSachPhieuDieuTriNoTheoCuThe(SelectedTHANG.Name, SelectedNAM.Name).Select(x => x.PHIEUDANGKY.KHACHHANG).Distinct().Count();
            //    // Lọc cả năm
            //    else
            //        return LayDanhSachPhieuDieuTriNoTheoCuTheTheoNam(SelectedNAM.Name).Select(x => x.PHIEUDANGKY.KHACHHANG).Distinct().Count();
            //}

            return LayDuLieuLoc().Select(x => x.PHIEUDANGKY.KHACHHANG).Distinct().Count();
        }

        ObservableCollection<PHIEUDIEUTRI> LayDanhSachPhieuDieuTriNoTheoTuyChon(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            var dauNgay = new DateTime(ngayBatDau.Year, ngayBatDau.Month, ngayBatDau.Day, 0, 0, 0);
            var cuoiNgay = new DateTime(ngayKetThuc.Year, ngayKetThuc.Month, ngayKetThuc.Day, 23, 59, 59);

            return new ObservableCollection<PHIEUDIEUTRI>(DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDT_TRANGTHAINNO == true && dauNgay <= x.PDT_NGAYLAP && x.PDT_NGAYLAP <= cuoiNgay));
        }

        ObservableCollection<PHIEUDIEUTRI> LayDanhSachPhieuDieuTriNoTheoCuThe(int thang, int nam)
        {
            return new ObservableCollection<PHIEUDIEUTRI>(DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDT_TRANGTHAINNO == true && x.PDT_NGAYLAP.Month == thang && x.PDT_NGAYLAP.Year == nam));
        }

        ObservableCollection<PHIEUDIEUTRI> LayDanhSachPhieuDieuTriNoTheoCuTheTheoNam(int nam)
        {
            return new ObservableCollection<PHIEUDIEUTRI>(DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDT_TRANGTHAINNO == true && x.PDT_NGAYLAP.Year == nam));
        }

        int TinhThanhTien(ObservableCollection<PHIEUDIEUTRI> listPhieuDieuTri)
        {
            int thanhTien = 0;
            int totalMoney = 0;

            var getPhieuDieuTriThanhToan = listPhieuDieuTri.ToList();

            foreach (var item in getPhieuDieuTriThanhToan)
            {
                if (item.PHIEUDANGKY.CTT_MA == 2)
                {
                    int PDT_STT = Convert.ToInt32(item.PDT_STT);
                    var getMoneyLT = DataProvider.Ins.DB.DG_LT.Where(x => x.LIEUTRINH.LT_STT == PDT_STT && x.GDV_MA == item.PHIEUDANGKY.GDV_MA).Select(x => x.DONGIA).SingleOrDefault();
                    totalMoney += int.Parse(getMoneyLT.Replace(".", ""));

                }
                else if (item.PHIEUDANGKY.CTT_MA == 1)
                {
                    //int PDT_STT = Convert.ToInt32(item.PDT_STT);
                    var getMoneyGDV = DataProvider.Ins.DB.DG_GDV.Where(x => x.GDV_MA == item.PHIEUDANGKY.GDV_MA).Select(x => x.DONGIA).SingleOrDefault();
                    totalMoney += int.Parse(getMoneyGDV.Replace(".", ""));
                }
            }

            thanhTien = totalMoney;

            return thanhTien;
        }

        int TinhGiamGia(ObservableCollection<PHIEUDIEUTRI> listPhieuDieuTri)
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
                    if (item.PHIEUDANGKY.CTT_MA == 1)
                    {
                        //int PDT_STT = Convert.ToInt32(item.PDT_STT);
                        var getMoneyGDV = DataProvider.Ins.DB.DG_GDV.Where(x => x.GDV_MA == item.PHIEUDANGKY.GDV_MA).Select(x => x.DONGIA).SingleOrDefault();
                        totalMoney = int.Parse(getMoneyGDV.Replace(".", ""));
                        giaGiam += totalMoney * getPDK_GG.GIAMGIA.GG_PHANTRAMGIAM / 100;
                    }
                    else if (item.PHIEUDANGKY.CTT_MA == 2)
                    {
                        int PDT_STT = Convert.ToInt32(item.PDT_STT);
                        var getMoneyLT = DataProvider.Ins.DB.DG_LT.Where(x => x.LIEUTRINH.LT_STT == PDT_STT && x.GDV_MA == item.PHIEUDANGKY.GDV_MA).Select(x => x.DONGIA).SingleOrDefault();
                        totalMoney += int.Parse(getMoneyLT.Replace(".", ""));
                        giaGiam += totalMoney * getPDK_GG.GIAMGIA.GG_PHANTRAMGIAM / 100;
                    }
                }
            }

            return giaGiam;
        }
    }

    public class THANG
    {
        public int Name { get; set; }
    }

    public class NAM
    {
        public int Name { get; set; }
    }

    public class ClassKhachHangNo
    {
        public string KH_MA { get; set; }
        public string KH_TEN { get; set; }
        public string KH_GIOITINH { get; set; }
        public string KH_SDT { get; set; }
        public DateTime KH_NGAYKHAMCUOI { get; set; }
        public int KH_TONGPHIEUNO { get; set; }
        public string KH_TONGNO { get; set; }
    }

    public class ClassPhieuDieuTriNo
    {
        public string PDK_STT { get; set; }
        public string PDT_STT { get; set; }
        public string GDV_TEN { get; set; }
        public DateTime PDT_NGAYKHAM { get; set; }
        public int THANHTIEN { get; set; }
        public int GIAGIAM { get; set; }
        public int TONGTHU { get; set; }
    }
}
