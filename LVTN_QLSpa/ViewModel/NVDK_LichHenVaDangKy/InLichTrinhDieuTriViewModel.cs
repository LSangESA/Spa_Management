using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
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
    public class InLichTrinhDieuTriViewModel : BaseViewModel
    {
        private string _KH_HOTEN;
        public string KH_HOTEN { get => _KH_HOTEN; set { _KH_HOTEN = value; OnPropertyChanged(); } }

        private string _GDV_TEN;
        public string GDV_TEN { get => _GDV_TEN; set { _GDV_TEN = value; OnPropertyChanged(); } }

        private int? _GDV_SOLAN;
        public int? GDV_SOLAN { get => _GDV_SOLAN; set { _GDV_SOLAN = value; OnPropertyChanged(); } }

        private DateTime _PDK_NGAYBDDT;
        public DateTime PDK_NGAYBDDT { get => _PDK_NGAYBDDT; set { _PDK_NGAYBDDT = value; OnPropertyChanged(); } }

        private DateTime _LTDT_NGAYDT;
        public DateTime LTDT_NGAYDT { get => _LTDT_NGAYDT; set { _LTDT_NGAYDT = value; OnPropertyChanged(); } }

        private ObservableCollection<LICHTRINHDIEUTRI> _ListLichTrinhDieuTri;
        public ObservableCollection<LICHTRINHDIEUTRI> ListLichTrinhDieuTri { get => _ListLichTrinhDieuTri; set { _ListLichTrinhDieuTri = value; OnPropertyChanged(); } }

        private ObservableCollection<BUOI> _BUOI;
        public ObservableCollection<BUOI> BUOI { get => _BUOI; set { _BUOI = value; OnPropertyChanged(); } }

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

        private BUOI _SelectedBUOI;
        public BUOI SelectedBUOI
        {
            get => _SelectedBUOI;
            set
            {
                _SelectedBUOI = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoadWindow { get; set; }
        public ICommand CommandSelectedLichTrinhDieuTri { get; set; }
        public ICommand CommandLapLichLamViec { get; set; }
        public ICommand CommandLuuLTDT { get; set; }
        public ICommand CommandClose { get; set; }

        public InLichTrinhDieuTriViewModel()
        {
            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                LoadBuoi();

                if (LapPhieuDangKyViewModel.PDK_STT_DATA != null)
                {
                    var PDK_STT = LapPhieuDangKyViewModel.PDK_STT_DATA;
                    ListLichTrinhDieuTri = DAO_LichTrinhDieuTri.GetList(PDK_STT);
                    //ListLichTrinhDieuTri = new ObservableCollection<LICHTRINHDIEUTRI>(DataProvider.Ins.DB.LICHTRINHDIEUTRI.Where(x => x.PDK_STT == PDK_STT));

                    var getPDK = DataProvider.Ins.DB.LICHTRINHDIEUTRI.Where(x => x.PDK_STT == PDK_STT).Select(x => x.PHIEUDANGKY).ToList().LastOrDefault();
                    KH_HOTEN = getPDK.KHACHHANG.KH_HOTEN;
                    GDV_TEN = getPDK.GOIDICHVU.GDV_TEN;
                    GDV_SOLAN = getPDK.GOIDICHVU.GDV_SOLAN;
                    PDK_NGAYBDDT = getPDK.PDK_NGAYBATDAU;

                }
            }
            );

            CommandSelectedLichTrinhDieuTri = new RelayCommand<object>((p) =>
            {
                if (SelectedLichTrinhDieuTri == null)
                    return false;

                return true;
            }, (p) =>
            {
                LTDT_NGAYDT = SelectedLichTrinhDieuTri.LTDT_NGAYDT;
                SelectedBUOI = BUOI.Where(x => x.Name == SelectedLichTrinhDieuTri.LTDT_THOIGIANDEN).SingleOrDefault();
            }
            );

            CommandLapLichLamViec = new RelayCommand<Window>((p) =>
            {
                if (SelectedLichTrinhDieuTri == null)
                    return false;

                return true;
            }, (p) =>
            {

                W_XacNhanTheoDoiBenhNhan window = new W_XacNhanTheoDoiBenhNhan();
                window.ShowDialog();
            }
            );

            CommandLuuLTDT = new RelayCommand<object>((p) =>
            {
                if (SelectedLichTrinhDieuTri == null)
                    return false;

                var soLieuTrinhTruoc = SelectedLichTrinhDieuTri.LIEUTRINH.LT_STT - 1;
                var ngayDuocChon = DataProvider.Ins.DB.LICHTRINHDIEUTRI.Where(x => x.LIEUTRINH.LT_STT == soLieuTrinhTruoc && x.PDK_STT == SelectedLichTrinhDieuTri.PDK_STT).SingleOrDefault();
                if (LTDT_NGAYDT <= ngayDuocChon.LTDT_NGAYDT)
                    return false;

                return true;
            }, (p) =>
            {
                var getLichTrinhDieuTri = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDT_STT == SelectedLichTrinhDieuTri.LIEUTRINH.LT_STT.ToString() && x.PDK_STT == SelectedLichTrinhDieuTri.PDK_STT).SingleOrDefault();
                if (getLichTrinhDieuTri != null)
                    MessageBox.Show("Lịch khám đã được lập, không thể sửa!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                else
                    ListLichTrinhDieuTri = DAO_LichTrinhDieuTri.Edit(SelectedLichTrinhDieuTri, LTDT_NGAYDT, SelectedBUOI.Name);
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

        void LoadBuoi()
        {
            BUOI = new ObservableCollection<BUOI>();
            BUOI.Add(new BUOI() { Name = "Sáng" });
            BUOI.Add(new BUOI() { Name = "Trưa" });
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

    public class BUOI
    {
        public string Name { get; set; }
    }
}
