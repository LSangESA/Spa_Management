using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LVTN_QLSpa.ViewModel.NVDK_LichHenVaDangKy
{
    public class InPhieuChoViewModel : BaseViewModel
    {
        private string _PHONG;
        public string PHONG { get => _PHONG; set { _PHONG = value; OnPropertyChanged(); } }

        private string _GDV_TEN;
        public string GDV_TEN { get => _GDV_TEN; set { _GDV_TEN = value; OnPropertyChanged(); } }

        private int _STT;
        public int STT { get => _STT; set { _STT = value; OnPropertyChanged(); } }

        private string _KH_HOTEN;
        public string KH_HOTEN { get => _KH_HOTEN; set { _KH_HOTEN = value; OnPropertyChanged(); } }

        private string _KH_MA;
        public string KH_MA { get => _KH_MA; set { _KH_MA = value; OnPropertyChanged(); } }

        private string _KH_TUOI;
        public string KH_TUOI { get => _KH_TUOI; set { _KH_TUOI = value; OnPropertyChanged(); } }

        private string _PDT_STT;
        public string PDT_STT { get => _PDT_STT; set { _PDT_STT = value; OnPropertyChanged(); } }

        private DateTime _PDT_NGAYLAP;
        public DateTime PDT_NGAYLAP { get => _PDT_NGAYLAP; set { _PDT_NGAYLAP = value; OnPropertyChanged(); } }

        public ICommand LoadWindow { get; set; }
        public ICommand CommandClose { get; set; }

        public InPhieuChoViewModel()
        {
            LoadWindow = new RelayCommand<Window>((p) =>
            {
                return true;
            }, (p) =>
            {
                var phieuDieuTri = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDT_STT == LapPhieuDieuTriViewModel.PDT_STT_DATA && x.PDK_STT == LapPhieuDieuTriViewModel.PDK_STT_DATA).SingleOrDefault();
                Load(phieuDieuTri);
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

        void Load(PHIEUDIEUTRI phieuDieuTri)
        {
            // Lấy phòng của phiếu đăng ký khi phiếu điều trị là số 1 và phải là loại gói dịch vụ có liệu trình
            if(phieuDieuTri.PDT_STT.Trim(' ') == "1")
            {
                PHONG = DataProvider.Ins.DB.PHONG.Where(x => x.P_MA == LapPhieuDangKyViewModel.P_MA_DATA).Select(x=>x.P_SO).SingleOrDefault().Trim(' ');
            }
            else if(phieuDieuTri.PDT_STT != "1" && phieuDieuTri.PHIEUDANGKY.GOIDICHVU.LGDV_MA == 2)
            {
                PHONG = DataProvider.Ins.DB.PHONG.Where(x => x.P_MA == LapPhieuDangKyViewModel.P_MA_DATA).Select(x => x.P_SO).SingleOrDefault().Trim(' ');
            }
            else
            {
                PHONG = DataProvider.Ins.DB.PHONG.Where(x => x.P_MA == LapPhieuDieuTriViewModel.P_MA_DATA).Select(x => x.P_SO).SingleOrDefault().Trim(' ');
            }

            GDV_TEN = phieuDieuTri.PHIEUDANGKY.GOIDICHVU.GDV_TEN;
            KH_HOTEN = phieuDieuTri.PHIEUDANGKY.KHACHHANG.KH_HOTEN;
            KH_MA = phieuDieuTri.PHIEUDANGKY.KHACHHANG.KH_MA.Trim(' ');
            KH_TUOI = Age(phieuDieuTri.PHIEUDANGKY.KHACHHANG.KH_NGAYSINH);
            PDT_STT = phieuDieuTri.PDT_STT;
            PDT_NGAYLAP = phieuDieuTri.PDT_NGAYLAP;

            if(phieuDieuTri.PHIEUDANGKY.GOIDICHVU.LOAIGOIDICHVU.LGDV_MA == 1)
            {
                STT = LaySoThuTuTheoGDVCoLT(phieuDieuTri);
            }
            else
            {
                STT = LaySoThuTuTheoGDVKoLT(phieuDieuTri.PHIEUDANGKY.GDV_MA);
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

        string Age(DateTime birthday)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - birthday.Year;
            if (now < birthday.AddYears(age)) age--;

            return age.ToString();
        }

        int LaySoThuTuTheoGDVCoLT(PHIEUDIEUTRI phieuDieuTri)
        {
            var dauNgay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            var cuoiNgay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            var listPhieuDieuTri = DataProvider.Ins.DB.PHIEUDIEUTRI.Where
                    (
                        x => x.PHIEUDANGKY.NV_MA == phieuDieuTri.PHIEUDANGKY.NV_MA &&
                        x.PDT_NGAYLAP >= dauNgay &&
                        x.PDT_NGAYLAP <= cuoiNgay
                    ).Count();

            return listPhieuDieuTri++;
        }

        int LaySoThuTuTheoGDVKoLT(string GDV_MA)
        {
            var dauNgay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            var cuoiNgay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            var listPhieuDang = DataProvider.Ins.DB.PHIEUDANGKY.Where
                    (
                        x => x.GDV_MA == GDV_MA &&
                        x.PDK_NGAYDK >= dauNgay &&
                        x.PDK_NGAYDK <= cuoiNgay
                    ).Count();

            return listPhieuDang++;
        }
    }
}
