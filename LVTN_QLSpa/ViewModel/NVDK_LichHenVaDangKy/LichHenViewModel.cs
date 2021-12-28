using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLLichHen;
using LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace LVTN_QLSpa.ViewModel.NVDK_LichHenVaDangKy
{
    public class LichHenViewModel : BaseViewModel
    {
        private static LICHHEN lh_DATA;
        public static LICHHEN LH_DATA
        {
            get { return LichHenViewModel.lh_DATA; }
            set { LichHenViewModel.lh_DATA = value; }
        }

        private string _KeySearch;
        public string KeySearch { get => _KeySearch; set { _KeySearch = value; OnPropertyChanged(); } }

        private DateTime _LH_NGAYBD;
        public DateTime LH_NGAYBD { get => _LH_NGAYBD; set { _LH_NGAYBD = value; OnPropertyChanged(); } }

        private DateTime _LH_NGAYKT;
        public DateTime LH_NGAYKT { get => _LH_NGAYKT; set { _LH_NGAYKT = value; OnPropertyChanged(); } }

        private ObservableCollection<LICHHEN> _ListLichHen;
        public ObservableCollection<LICHHEN> ListLichHen { get => _ListLichHen; set { _ListLichHen = value; OnPropertyChanged(); } }

        private ObservableCollection<TRANGTHAI> _TRANGTHAI;
        public ObservableCollection<TRANGTHAI> TRANGTHAI { get => _TRANGTHAI; set { _TRANGTHAI = value; OnPropertyChanged(); } }

        private LICHHEN _SelectedLichHen;
        public LICHHEN SelectedLichHen
        {
            get => _SelectedLichHen;
            set
            {
                _SelectedLichHen = value;
                OnPropertyChanged();
            }
        }

        private TRANGTHAI _SelectedTRANGTHAI;
        public TRANGTHAI SelectedTRANGTHAI
        {
            get => _SelectedTRANGTHAI;
            set
            {
                _SelectedTRANGTHAI = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoadWindow { get; set; }
        public ICommand CommandKeySearch { get; set; }
        public ICommand CommandLocNgayLH { get; set; }
        public ICommand CommandTaoLichHen { get; set; }
        public ICommand CommandDangKyDichVu { get; set; }
        public ICommand CommandLamMoiLichHen { get; set; }
        public ICommand CommandSelectedTRANGTHAI { get; set; }
        public ICommand CommandShowDetailLichHen { get; set; }

        public LichHenViewModel()
        {
            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                LH_NGAYBD = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                LH_NGAYKT = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                LoadTrangThai();
                ListLichHen = LoadLichHenTheoNgay(LH_NGAYBD, LH_NGAYKT);
            }
            );

            //CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(ListLichHen);
            //view.Filter = UserFilter;
            //CommandKeySearch = new RelayCommand<object>((p) =>
            //{
            //    return true;
            //}, (p) =>
            //{
            //    CollectionViewSource.GetDefaultView(ListLichHen).Refresh();
            //}
            //);

            CommandTaoLichHen = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                LH_DATA = null;
                W_TaoLichHen window = new W_TaoLichHen();
                window.ShowDialog();
            }
            );

            CommandDangKyDichVu = new RelayCommand<object>((p) =>
            {
                if (SelectedLichHen == null)
                    return false;

                return true;
            }, (p) =>
            {
                LH_DATA = SelectedLichHen;
                W_LapPhieuDangKy window = new W_LapPhieuDangKy();
                window.ShowDialog();
                LH_DATA = null;

                ListLichHen = LoadLichHenTheoNgay(LH_NGAYBD, LH_NGAYKT);
            }
            );

            CommandShowDetailLichHen = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                LH_DATA = SelectedLichHen;
                W_TaoLichHen window = new W_TaoLichHen();
                window.ShowDialog();
                LH_DATA = null;

                ListLichHen = LoadLichHenTheoNgay(LH_NGAYBD, LH_NGAYKT);
            }
            );

            CommandLocNgayLH = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                LH_NGAYBD = new DateTime(LH_NGAYBD.Year, LH_NGAYBD.Month, LH_NGAYBD.Day);
                LH_NGAYKT = new DateTime(LH_NGAYKT.Year, LH_NGAYKT.Month, LH_NGAYKT.Day);
                ListLichHen = LoadLichHenTheoNgay(LH_NGAYBD, LH_NGAYKT);
            }
            );

            CommandLamMoiLichHen = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                KeySearch = "";
                LH_NGAYBD = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                LH_NGAYKT = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                LoadTrangThai();
                ListLichHen = LoadLichHenTheoNgay(LH_NGAYBD, LH_NGAYKT);
            }
            );

            CommandSelectedTRANGTHAI = new RelayCommand<object>((p) =>
            {
                if (SelectedTRANGTHAI == null)
                    return false;

                return true;
            }, (p) =>
            {
                ListLichHen = LoadLichHenTheoNgay(LH_NGAYBD, LH_NGAYKT, SelectedTRANGTHAI.Name);
            }
            );
        }

        void LoadTrangThai()
        {
            TRANGTHAI = new ObservableCollection<TRANGTHAI>();
            TRANGTHAI.Add(new TRANGTHAI { Name = "Lên lịch", Color = "#f9a825" });
            TRANGTHAI.Add(new TRANGTHAI { Name = "Lịch hẹn hoàn tất", Color = "#00bfa5" });
            TRANGTHAI.Add(new TRANGTHAI { Name = "Khách không đến", Color = "#d50000" });
        }
        
        ObservableCollection<LICHHEN> LoadLichHenTheoNgay(DateTime ngayBatDau, DateTime ngayKetThuc, string trangThai = null)
        {
            if (!string.IsNullOrEmpty(trangThai))
                return new ObservableCollection<LICHHEN>(DataProvider.Ins.DB.LICHHEN.Where(x => x.LH_NGAYDEN >= ngayBatDau && x.LH_NGAYDEN <= ngayKetThuc && x.LH_TRANGTHAI == trangThai));
            else
                return new ObservableCollection<LICHHEN>(DataProvider.Ins.DB.LICHHEN.Where(x => x.LH_NGAYDEN >= ngayBatDau && x.LH_NGAYDEN <= ngayKetThuc));
        }

        //private bool UserFilter(object item)
        //{
        //    if (String.IsNullOrEmpty(KeySearch))
        //        return true;
        //    else
        //        return ((item as LICHHEN).KHACHHANG.KH_HOTEN.ToString().IndexOf(KeySearch, StringComparison.OrdinalIgnoreCase) >= 0
        //            || (item as LICHHEN).GOIDICHVU.GDV_TEN.ToString().IndexOf(KeySearch, StringComparison.OrdinalIgnoreCase) >= 0
        //            || (item as LICHHEN).LICHLAMVIEC.NHANVIEN.NV_HOTEN.ToString().IndexOf(KeySearch, StringComparison.OrdinalIgnoreCase) >= 0);
        //}

    }
}
