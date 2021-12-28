using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_KHAM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LVTN_QLSpa.ViewModel.NVBS_QuanLyKhamVaDieuTri
{
    public class PhieuDieuTri
    {
        public string PDT_STT { get; set; }
        public string PDK_STT { get; set; }
        public DateTime PDT_NGAYLAP { get; set; }
        public string PDT_TRANGTHAI { get; set; }
        public string KH_HOTEN { get; set; }
        public string GDV_TEN { get; set; }
        public string LT_MOTA { get; set; }
    }
    public class DanhSachChoViewModel : BaseViewModel
    {
        private static PHIEUDIEUTRI pdt_STT;
        public static PHIEUDIEUTRI PDT_DATA
        {
            get { return DanhSachChoViewModel.pdt_STT; }
            set { DanhSachChoViewModel.pdt_STT = value; }
        }

        private bool _CheckAll;
        public bool CheckAll { get => _CheckAll; set { _CheckAll = value; OnPropertyChanged(); } }

        private bool _CheckChuaKham;
        public bool CheckChuaKham { get => _CheckChuaKham; set { _CheckChuaKham = value; OnPropertyChanged(); } }

        private bool _CheckHoanThanh;
        public bool CheckHoanThanh { get => _CheckHoanThanh; set { _CheckHoanThanh = value; OnPropertyChanged(); } }

        private ObservableCollection<PhieuDieuTri> _ListPHIEUDIEUTRI;
        public ObservableCollection<PhieuDieuTri> ListPHIEUDIEUTRI { get => _ListPHIEUDIEUTRI; set { _ListPHIEUDIEUTRI = value; OnPropertyChanged(); } }

        private PhieuDieuTri _SelectedPHIEUDIEUTRI;
        public PhieuDieuTri SelectedPHIEUDIEUTRI
        {
            get => _SelectedPHIEUDIEUTRI;
            set
            {
                _SelectedPHIEUDIEUTRI = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoadWindow { get; set; }
        public ICommand CommandAll { get; set; }
        public ICommand CommandCheckChuaKham { get; set; }
        public ICommand CommandCheckHoanThanh { get; set; }
        public ICommand CommandTiepNhan { get; set; }
        public ICommand CommandHuy { get; set; }

        public DanhSachChoViewModel()
        {
            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                CheckChuaKham = true;
                ListPHIEUDIEUTRI = LoadPhieuDieuTri(CheckAll, CheckHoanThanh, CheckChuaKham);
            }
            );

            CommandAll = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                ListPHIEUDIEUTRI = LoadPhieuDieuTri(CheckAll, CheckHoanThanh, CheckChuaKham);
            }
            );

            CommandCheckChuaKham = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                ListPHIEUDIEUTRI = LoadPhieuDieuTri(CheckAll, CheckHoanThanh, CheckChuaKham);
            }
            );

            CommandCheckHoanThanh = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                ListPHIEUDIEUTRI = LoadPhieuDieuTri(CheckAll, CheckHoanThanh, CheckChuaKham);
            }
            );

            CommandTiepNhan = new RelayCommand<object>((p) =>
            {
                if (SelectedPHIEUDIEUTRI == null)
                    return false;

                return true;
            }, (p) =>
            {
                PDT_DATA = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x=>x.PDT_STT == SelectedPHIEUDIEUTRI.PDT_STT && x.PDK_STT == SelectedPHIEUDIEUTRI.PDK_STT).SingleOrDefault();
                W_GhiNhanBenh window = new W_GhiNhanBenh();
                window.ShowDialog();
                PDT_DATA = null;
                // Load lai danh sach
                ListPHIEUDIEUTRI = LoadPhieuDieuTri(CheckAll, CheckHoanThanh, CheckChuaKham);
            }
            );

            CommandHuy = new RelayCommand<object>((p) =>
            {
                if (SelectedPHIEUDIEUTRI == null)
                    return false;

                return true;
            }, (p) =>
            {
                var phieuDieuTri = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDT_STT == SelectedPHIEUDIEUTRI.PDT_STT).SingleOrDefault();
                phieuDieuTri.PDT_NGAYLAP = phieuDieuTri.PDT_NGAYLAP.AddDays(Convert.ToDouble(1));
                DataProvider.Ins.DB.SaveChanges();
            }
            );
        }

        ObservableCollection<PhieuDieuTri> LoadPhieuDieuTri(bool tatCa, bool hoanThanh, bool chuaKham)
        {
            int i = 0;
            var dauNgay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            var cuoiNgay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            var getListPhieuDieutri = new List<PHIEUDIEUTRI>();
            if (tatCa)
            {
                getListPhieuDieutri = DataProvider.Ins.DB.PHIEUDIEUTRI.Where
                (
                x => x.PHIEUDANGKY.NV_MA == LoginViewModel.NV_DATA.NV_MA &&
                x.PDT_NGAYLAP >= dauNgay &&
                x.PDT_NGAYLAP <= cuoiNgay
                ).ToList();
            }
            else if(hoanThanh)
            {
                getListPhieuDieutri = DataProvider.Ins.DB.PHIEUDIEUTRI.Where
                (
                x => x.PHIEUDANGKY.NV_MA == LoginViewModel.NV_DATA.NV_MA && 
                x.PDT_TRANGTHAI == "Hoàn thành khám" &&
                x.PDT_NGAYLAP >= dauNgay &&
                x.PDT_NGAYLAP <= cuoiNgay
                ).ToList();
            }
            else if(chuaKham)
            {
                getListPhieuDieutri = DataProvider.Ins.DB.PHIEUDIEUTRI.Where
                (
                x => x.PHIEUDANGKY.NV_MA == LoginViewModel.NV_DATA.NV_MA &&
                x.PDT_TRANGTHAI == "Chờ khám" &&
                x.PDT_NGAYLAP >= dauNgay &&
                x.PDT_NGAYLAP <= cuoiNgay
                ).ToList();
            }

            var listPhieuDieuTri = new ObservableCollection<PhieuDieuTri>();
            foreach (var item in getListPhieuDieutri)
            {
                var phieuDieutri = new PhieuDieuTri();

                phieuDieutri.PDT_STT = item.PDT_STT;
                phieuDieutri.PDK_STT = item.PDK_STT;
                phieuDieutri.PDT_NGAYLAP = item.PDT_NGAYLAP;
                phieuDieutri.PDT_TRANGTHAI = item.PDT_TRANGTHAI;
                phieuDieutri.KH_HOTEN = item.PHIEUDANGKY.KHACHHANG.KH_HOTEN;
                phieuDieutri.GDV_TEN = item.PHIEUDANGKY.GOIDICHVU.GDV_TEN;

                // Lay lieu trinh theo phieu dieu tri
                if (item.PHIEUDANGKY.GOIDICHVU.LGDV_MA == 1)
                {
                    var soPDT = Convert.ToInt32(item.PDT_STT);
                    var lieuTrinh = DataProvider.Ins.DB.LIEUTRINH.Where(x => x.GDV_MA == item.PHIEUDANGKY.GDV_MA && x.LT_STT == soPDT).SingleOrDefault();

                    phieuDieutri.LT_MOTA = lieuTrinh.LT_STT + " - " + lieuTrinh.LT_MOTA.Trim(' ');
                }

                listPhieuDieuTri.Add(phieuDieutri);
            }

            return new ObservableCollection<PhieuDieuTri>(listPhieuDieuTri.OrderBy(x=>x.PDT_NGAYLAP));
        }
    }
}