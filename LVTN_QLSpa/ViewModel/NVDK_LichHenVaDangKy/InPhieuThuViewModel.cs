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

namespace LVTN_QLSpa.ViewModel.NVDK_LichHenVaDangKy
{
    public class PhieuThu
    {
        public int STT { get; set; }
        public string PDT_STT { get; set; }
        public string DICHVU { get; set; }
        public string DONGIA { get; set; }
        public string GIAGIAM { get; set; }
        public string TONGTIEN { get; set; }
    }

    public class InPhieuThuViewModel : BaseViewModel
    {
        private string _KH_HOTEN;
        public string KH_HOTEN { get => _KH_HOTEN; set { _KH_HOTEN = value; OnPropertyChanged(); } }

        private string _KH_SDT;
        public string KH_SDT { get => _KH_SDT; set { _KH_SDT = value; OnPropertyChanged(); } }

        private string _KH_EMAIL;
        public string KH_EMAIL { get => _KH_EMAIL; set { _KH_EMAIL = value; OnPropertyChanged(); } }

        private string _KH_GIOITINH;
        public string KH_GIOITINH { get => _KH_GIOITINH; set { _KH_GIOITINH = value; OnPropertyChanged(); } }

        private DateTime _KH_NGAYSINH;
        public DateTime KH_NGAYSINH { get => _KH_NGAYSINH; set { _KH_NGAYSINH = value; OnPropertyChanged(); } }

        private string _KH_DIACHI;
        public string KH_DIACHI { get => _KH_DIACHI; set { _KH_DIACHI = value; OnPropertyChanged(); } }

        private string _PT_STTs;
        public string PT_STTs { get => _PT_STTs; set { _PT_STTs = value; OnPropertyChanged(); } }

        private string _NV_TEN;
        public string NV_TEN { get => _NV_TEN; set { _NV_TEN = value; OnPropertyChanged(); } }

        private string _HTTT_TEN;
        public string HTTT_TEN { get => _HTTT_TEN; set { _HTTT_TEN = value; OnPropertyChanged(); } }

        private DateTime _PT_NGAYLAP;
        public DateTime PT_NGAYLAP { get => _PT_NGAYLAP; set { _PT_NGAYLAP = value; OnPropertyChanged(); } }

        private string _THANHTIEN;
        public string THANHTIEN { get => _THANHTIEN; set { _THANHTIEN = value; OnPropertyChanged(); } }

        private string _GIAMGIA;
        public string GIAMGIA { get => _GIAMGIA; set { _GIAMGIA = value; OnPropertyChanged(); } }

        private string _TONGTIEN;
        public string TONGTIEN { get => _TONGTIEN; set { _TONGTIEN = value; OnPropertyChanged(); } }

        private ObservableCollection<PhieuThu> _ListPhieuThu;
        public ObservableCollection<PhieuThu> ListPhieuThu { get => _ListPhieuThu; set { _ListPhieuThu = value; OnPropertyChanged(); } }

        public ICommand LoadWindow { get; set; }
        public ICommand CommandClose { get; set; }

        public InPhieuThuViewModel()
        {
            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                LoadThongTinPhieuThu(LapPhieuThuViewModel.PT_STT_DATA);
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

        void LoadThongTinPhieuThu(string PT_STT)
        {
            // Thong tin phieu thu
            var phieuThu = DataProvider.Ins.DB.PHIEUTHU.Where(x => x.PT_STT == PT_STT).SingleOrDefault();
            PT_STTs = phieuThu.PT_STT;
            NV_TEN = phieuThu.NHANVIEN.NV_HOTEN;
            HTTT_TEN = phieuThu.HINHTHUCTHANHTOAN.HTTT_TEN;
            PT_NGAYLAP = phieuThu.PT_NGAYLAP;

            // Thong tin khach hang
            KH_HOTEN = DAO_PhieuThu.LayPhieuThuCuaKhachHang(PT_STT).KH_HOTEN;
            KH_SDT = DAO_PhieuThu.LayPhieuThuCuaKhachHang(PT_STT).KH_SDT;
            KH_EMAIL = DAO_PhieuThu.LayPhieuThuCuaKhachHang(PT_STT).KH_EMAIL;
            KH_GIOITINH = DAO_PhieuThu.LayPhieuThuCuaKhachHang(PT_STT).KH_GIOITINH;
            KH_NGAYSINH = DAO_PhieuThu.LayPhieuThuCuaKhachHang(PT_STT).KH_NGAYSINH;
            KH_DIACHI = DAO_PhieuThu.LayPhieuThuCuaKhachHang(PT_STT).KH_DIACHI + ", " +
                        DAO_PhieuThu.LayPhieuThuCuaKhachHang(PT_STT).XAPHUONG.XP_TEN + ", " +
                        DAO_PhieuThu.LayPhieuThuCuaKhachHang(PT_STT).XAPHUONG.HUYENQUAN.HQ_TEN + ", " +
                        DAO_PhieuThu.LayPhieuThuCuaKhachHang(PT_STT).XAPHUONG.HUYENQUAN.TINHTHANH.TT_TEN;

            // Danh sach phieu thu
            ListPhieuThu = LoadListPhieuThu(PT_STT);

            // Tong tien
            var listPhieuThu = DataProvider.Ins.DB.PT_PDT.Where(x => x.PT_STT == PT_STT).Select(x=>x.PHIEUDIEUTRI).ToList();
            THANHTIEN = ClassXuLyChuoi.ChuyenSoThanhTien(TinhThanhTien(listPhieuThu));
            GIAMGIA = ClassXuLyChuoi.ChuyenSoThanhTien(TinhGiamGia(listPhieuThu));
            TONGTIEN = ClassXuLyChuoi.ChuyenSoThanhTien(TinhThanhTien(listPhieuThu) - TinhGiamGia(listPhieuThu));
        }

        ObservableCollection<PhieuThu> LoadListPhieuThu(string PT_STT)
        {
            int i = 0;
            var listPhieuThu = DataProvider.Ins.DB.PT_PDT.Where(x => x.PT_STT == PT_STT).Select(x => x.PHIEUDIEUTRI).ToList();
            ListPhieuThu = new ObservableCollection<PhieuThu>();

            foreach(var item in listPhieuThu)
            {
                i++;
                var phieuThu = new PhieuThu();
                phieuThu.STT = i;
                phieuThu.PDT_STT = item.PDT_STT;

                // Lay ra dich vu phieu dieu tri va don gia
                if (item.PHIEUDANGKY.GOIDICHVU.LGDV_MA == 1)
                    phieuThu.DICHVU = DAO_LieuTrinh.LayLieuTrinhTuPhieuDieuTri(item).LT_STT + " - " + DAO_LieuTrinh.LayLieuTrinhTuPhieuDieuTri(item).LT_MOTA;
                else if (item.PHIEUDANGKY.GOIDICHVU.LGDV_MA == 2)
                    phieuThu.DICHVU = item.PHIEUDANGKY.GOIDICHVU.GDV_TEN;

                // Lay don gia
                phieuThu.DONGIA = ClassXuLyChuoi.ChuyenSoThanhTien(TinhThanhTien(item));
                phieuThu.GIAGIAM = ClassXuLyChuoi.ChuyenSoThanhTien(TinhGiamGia(item));
                phieuThu.TONGTIEN = ClassXuLyChuoi.ChuyenSoThanhTien(TinhThanhTien(item) - TinhGiamGia(item));

                ListPhieuThu.Add(phieuThu);
            }

            return ListPhieuThu;
        }

        int TinhThanhTien(List<PHIEUDIEUTRI> listPhieuDieuTri)
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

        int TinhGiamGia(List<PHIEUDIEUTRI> listPhieuDieuTri)
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

        int TinhThanhTien(PHIEUDIEUTRI phieuDieuTri)
        {
            int thanhTien = 0;
            int totalMoney = 0;
            
            if (phieuDieuTri.PHIEUDANGKY.CTT_MA == 2)
            {
                int PDT_STT = Convert.ToInt32(phieuDieuTri.PDT_STT);
                var getMoneyLT = DataProvider.Ins.DB.DG_LT.Where(x => x.LIEUTRINH.LT_STT == PDT_STT && x.GDV_MA == phieuDieuTri.PHIEUDANGKY.GDV_MA).Select(x => x.DONGIA).SingleOrDefault();
                totalMoney += int.Parse(getMoneyLT.Replace(".", ""));

            }
            else if (phieuDieuTri.PHIEUDANGKY.CTT_MA == 1)
            {
                //int PDT_STT = Convert.ToInt32(item.PDT_STT);
                var getMoneyGDV = DataProvider.Ins.DB.DG_GDV.Where(x => x.GDV_MA == phieuDieuTri.PHIEUDANGKY.GDV_MA).Select(x => x.DONGIA).SingleOrDefault();
                totalMoney += int.Parse(getMoneyGDV.Replace(".", ""));
            }

            thanhTien = totalMoney;

            return thanhTien;
        }

        int TinhGiamGia(PHIEUDIEUTRI phieuDieuTri)
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
            
            var getPDK_GG = DataProvider.Ins.DB.GIAMGIA_PDK.Where(x => x.PDK_STT == phieuDieuTri.PDK_STT).SingleOrDefault();
            if (getPDK_GG != null)
            {
                if (phieuDieuTri.PHIEUDANGKY.CTT_MA == 1)
                {
                    //int PDT_STT = Convert.ToInt32(item.PDT_STT);
                    var getMoneyGDV = DataProvider.Ins.DB.DG_GDV.Where(x => x.GDV_MA == phieuDieuTri.PHIEUDANGKY.GDV_MA).Select(x => x.DONGIA).SingleOrDefault();
                    totalMoney = int.Parse(getMoneyGDV.Replace(".", ""));
                    giaGiam += totalMoney * getPDK_GG.GIAMGIA.GG_PHANTRAMGIAM / 100;
                }
                else if (phieuDieuTri.PHIEUDANGKY.CTT_MA == 2)
                {
                    int PDT_STT = Convert.ToInt32(phieuDieuTri.PDT_STT);
                    var getMoneyLT = DataProvider.Ins.DB.DG_LT.Where(x => x.LIEUTRINH.LT_STT == PDT_STT && x.GDV_MA == phieuDieuTri.PHIEUDANGKY.GDV_MA).Select(x => x.DONGIA).SingleOrDefault();
                    totalMoney += int.Parse(getMoneyLT.Replace(".", ""));
                    giaGiam += totalMoney * getPDK_GG.GIAMGIA.GG_PHANTRAMGIAM / 100;
                }
            }

            return giaGiam;
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
