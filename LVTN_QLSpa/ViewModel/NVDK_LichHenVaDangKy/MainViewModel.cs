using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using LVTN_QLSpa.Model.ModelClass;
using LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLLichHen;
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
    public class MainViewModel : BaseViewModel
    {
        private int _TongLichHenHomNay;
        public int TongLichHenHomNay { get => _TongLichHenHomNay; set { _TongLichHenHomNay = value; OnPropertyChanged(); } }

        private int _TongLichHenNgayMai;
        public int TongLichHenNgayMai { get => _TongLichHenNgayMai; set { _TongLichHenNgayMai = value; OnPropertyChanged(); } }

        private int _TongPhieuThuHomNay;
        public int TongPhieuThuHomNay { get => _TongPhieuThuHomNay; set { _TongPhieuThuHomNay = value; OnPropertyChanged(); } }

        private string _TongTienThuHomNay;
        public string TongTienThuHomNay { get => _TongTienThuHomNay; set { _TongTienThuHomNay = value; OnPropertyChanged(); } }

        private int _SoKhachHangHomNay;
        public int SoKhachHangHomNay { get => _SoKhachHangHomNay; set { _SoKhachHangHomNay = value; OnPropertyChanged(); } }

        private int _SoPhieuDangKyHomNay;
        public int SoPhieuDangKyHomNay { get => _SoPhieuDangKyHomNay; set { _SoPhieuDangKyHomNay = value; OnPropertyChanged(); } }

        private ObservableCollection<LICHHEN> _LICHHEN;
        public ObservableCollection<LICHHEN> LICHHEN { get => _LICHHEN; set { _LICHHEN = value; OnPropertyChanged(); } }

        private ObservableCollection<GIAMGIA> _GIAMGIA;
        public ObservableCollection<GIAMGIA> GIAMGIA { get => _GIAMGIA; set { _GIAMGIA = value; OnPropertyChanged(); } }

        private ObservableCollection<LICHTRINHDIEUTRI> _ListLichTrinhDieuTri;
        public ObservableCollection<LICHTRINHDIEUTRI> ListLichTrinhDieuTri { get => _ListLichTrinhDieuTri; set { _ListLichTrinhDieuTri = value; OnPropertyChanged(); } }

        private LICHHEN _SelectedLICHHEN;
        public LICHHEN SelectedLICHHEN
        {
            get => _SelectedLICHHEN;
            set
            {
                _SelectedLICHHEN = value;
                OnPropertyChanged();
            }
        }

        private LICHTRINHDIEUTRI _SelectedLichTrinhDieuTri;
        public LICHTRINHDIEUTRI SelectedLichTrinhDieuTri
        {
            get => _SelectedLichTrinhDieuTri;
            set
            {
                _SelectedLichTrinhDieuTri = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoadWindow { get; set; }
        public ICommand CommandLapBaoCaoExcel { get; set; }
        public ICommand CommandTaoLichHen { get; set; }
        public ICommand CommandLapPhieuDangKy { get; set; }
        public ICommand CommandLapPhieuDieuTri { get; set; }
        public ICommand CommandSelectedLICHHEN { get; set; }

        public MainViewModel()
        {
            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                LoadDuLieu();
            }
            );

            CommandLapBaoCaoExcel = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {

            }
            );

            CommandTaoLichHen = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                LichHenViewModel.LH_DATA = null;
                W_TaoLichHen window = new W_TaoLichHen();
                window.ShowDialog();
            }
            );

            CommandLapPhieuDieuTri = new RelayCommand<object>((p) =>
            {
                if (SelectedLichTrinhDieuTri == null)
                    return false;

                return true;
            }, (p) =>
            {
                var lichTrinhDieuTri = SelectedLichTrinhDieuTri;

                LapPhieuDangKyViewModel.GDV_MA_DATA = lichTrinhDieuTri.GDV_MA;
                LapPhieuDangKyViewModel.PDK_STT_DATA = lichTrinhDieuTri.PDK_STT;

                W_LapPhieuDieuTri window = new W_LapPhieuDieuTri();
                window.ShowDialog();

                LapPhieuDangKyViewModel.GDV_MA_DATA = null;
                LapPhieuDangKyViewModel.PDK_STT_DATA = null;

                ListLichTrinhDieuTri = DAO_LichTrinhDieuTri.GetListNgayHomNay();

                LoadDuLieu();
            }
            );

            CommandLapPhieuDangKy = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                W_LapPhieuDangKy window = new W_LapPhieuDangKy();
                window.ShowDialog();

                LoadDuLieu();
            }
            );

            CommandSelectedLICHHEN = new RelayCommand<object>((p) =>
            {
                if (SelectedLICHHEN == null)
                    return false;

                return true;
            }, (p) =>
            {
                LichHenViewModel.LH_DATA = SelectedLICHHEN;
                W_TaoLichHen window = new W_TaoLichHen();
                window.ShowDialog();
                LichHenViewModel.LH_DATA = null;

                // Lich hen hom nay
                LICHHEN = new ObservableCollection<LICHHEN>(GetLichHenHomNay().Where(x => x.LH_TRANGTHAI == "Lên lịch"));

                LoadDuLieu();
            }
            );
            
        }

        void LoadDuLieu()
        {
            // Thong tin chung
            TongLichHenHomNay = GetTongLichHenHomNay();
            TongLichHenNgayMai = GetTongLichHenNgayMai();
            TongPhieuThuHomNay = GetTongPhieuThuHomNay();
            TongTienThuHomNay = GetTongTienThuHomNay();
            SoKhachHangHomNay = GetSoKhachHangHomNay();
            SoPhieuDangKyHomNay = GetSoPhieuDangKyHomNay();

            // Lich hen hom nay
            LICHHEN = new ObservableCollection<LICHHEN>(GetLichHenHomNay().Where(x=>x.LH_TRANGTHAI == "Lên lịch"));

            // Giam gia
            GIAMGIA = GetGiamGiaHomNay();

            // Lich trinh dieu tri
            ListLichTrinhDieuTri = DAO_LichTrinhDieuTri.GetListNgayHomNay();
        }

        ObservableCollection<LICHHEN> GetLichHenHomNay()
        {
            var dauNgay = DauNgayHomNay();
            var cuoiNgay = CuoiNgayHomNay();
            return new ObservableCollection<LICHHEN>(DataProvider.Ins.DB.LICHHEN.Where(x => x.LH_NGAYDEN >= dauNgay && x.LH_NGAYDEN <= cuoiNgay).OrderBy(x=>x.LH_THOIGIANDEN));
        }

        ObservableCollection<GIAMGIA> GetGiamGiaHomNay()
        {
            var dauNgay = DauNgayHomNay();
            var cuoiNgay = CuoiNgayHomNay();
            return new ObservableCollection<GIAMGIA>(DataProvider.Ins.DB.GIAMGIA.Where(x=> dauNgay <= x.GG_NGAYBATDAU && x.GG_NGAYKETTHUC >= cuoiNgay));
        }

        DateTime DauNgayHomNay()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
        }

        DateTime CuoiNgayHomNay()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
        }

        int GetTongLichHenHomNay()
        {
            var dauNgay = DauNgayHomNay();
            var cuoiNgay = CuoiNgayHomNay();
            return DataProvider.Ins.DB.LICHHEN.Where(x => x.LH_NGAYDEN >= dauNgay && x.LH_NGAYDEN <= cuoiNgay).Count();
        }

        int GetTongLichHenNgayMai()
        {
            var dauNgay = DauNgayHomNay().AddDays(1.0);
            var cuoiNgay = CuoiNgayHomNay().AddDays(1.0);
            return DataProvider.Ins.DB.LICHHEN.Where(x => x.LH_NGAYDEN >= dauNgay && x.LH_NGAYDEN <= cuoiNgay).Count();
        }

        int GetTongPhieuThuHomNay()
        {
            var dauNgay = DauNgayHomNay();
            var cuoiNgay = CuoiNgayHomNay();
            return DataProvider.Ins.DB.PHIEUTHU.Where(x => x.PT_NGAYLAP >= dauNgay && x.PT_NGAYLAP <= cuoiNgay).Count();
        }

        string GetTongTienThuHomNay()
        {
            decimal tongThu = 0;
            var dauNgay = DauNgayHomNay();
            var cuoiNgay = CuoiNgayHomNay();
            var getPhieuThu = DataProvider.Ins.DB.PHIEUTHU.Where(x => x.PT_NGAYLAP >= dauNgay && x.PT_NGAYLAP <= cuoiNgay).ToList();
            foreach(var item in getPhieuThu)
            {
                tongThu += item.PT_TONGTIEN;
            }

            return ClassXuLyChuoi.ChuyenSoThanhTien(Convert.ToInt32(tongThu));
        }

        int GetSoKhachHangHomNay()
        {
            var dauNgay = DauNgayHomNay();
            var cuoiNgay = CuoiNgayHomNay();
            return DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDT_NGAYLAP >= dauNgay && x.PDT_NGAYLAP <= cuoiNgay).Count();
        }

        int GetSoPhieuDangKyHomNay()
        {
            var dauNgay = DauNgayHomNay();
            var cuoiNgay = CuoiNgayHomNay();
            return DataProvider.Ins.DB.PHIEUDANGKY.Where(x => x.PDK_NGAYDK >= dauNgay && x.PDK_NGAYDK <= cuoiNgay).Count();
        }
    }
}
