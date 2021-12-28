using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using LVTN_QLSpa.Model.ModelClass;
using LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_KHAM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace LVTN_QLSpa.ViewModel.NVBS_QuanLyKhamVaDieuTri
{
    public class HoSoBenhAnViewModel : BaseViewModel
    {
        private string _KeySearch;
        public string KeySearch { get => _KeySearch; set { _KeySearch = value; OnPropertyChanged(); } }

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

        private string _TONGPHIEUDANGKY;
        public string TONGPHIEUDANGKY { get => _TONGPHIEUDANGKY; set { _TONGPHIEUDANGKY = value; OnPropertyChanged(); } }

        private ObservableCollection<PHIEUDANGKY> _ListPhieuDangKy;
        public ObservableCollection<PHIEUDANGKY> ListPhieuDangKy { get => _ListPhieuDangKy; set { _ListPhieuDangKy = value; OnPropertyChanged(); } }

        private ObservableCollection<ClassPhieuDieuTriLichSuKham> _ListPhieuDieuTri;
        public ObservableCollection<ClassPhieuDieuTriLichSuKham> ListPhieuDieuTri { get => _ListPhieuDieuTri; set { _ListPhieuDieuTri = value; OnPropertyChanged(); } }

        private ObservableCollection<ClassToaThuoc> _ListChiDinh;
        public ObservableCollection<ClassToaThuoc> ListChiDinh { get => _ListChiDinh; set { _ListChiDinh = value; OnPropertyChanged(); } }

        private PHIEUDANGKY _SelectedPhieuDangKy;
        public PHIEUDANGKY SelectedPhieuDangKy
        {
            get => _SelectedPhieuDangKy;
            set
            {
                _SelectedPhieuDangKy = value;
                OnPropertyChanged();
            }
        }

        private ClassPhieuDieuTriLichSuKham _SelectedPhieuDieuTri;
        public ClassPhieuDieuTriLichSuKham SelectedPhieuDieuTri
        {
            get => _SelectedPhieuDieuTri;
            set
            {
                _SelectedPhieuDieuTri = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoadWindow { get; set; }
        public ICommand KeySearchCommand { get; set; }
        public ICommand CommandSelectedPhieuDangKy { get; set; }
        public ICommand CommandSelectedPhieuDieuTri { get; set; }
        public ICommand CommandXemPhieuDieuTri { get; set; }

        private bool UserFilter(object item)
        {
            if (String.IsNullOrEmpty(KeySearch))
                return true;
            else
                return ((item as PHIEUDANGKY).PDK_STT.IndexOf(KeySearch, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as PHIEUDANGKY).GOIDICHVU.GDV_TEN.ToString().IndexOf(KeySearch, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as PHIEUDANGKY).KHACHHANG.KH_HOTEN.ToString().IndexOf(KeySearch, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as PHIEUDANGKY).PDK_NGAYDK.ToString().IndexOf(KeySearch, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as PHIEUDANGKY).PDK_TRANGTHAI.ToString().IndexOf(KeySearch, StringComparison.OrdinalIgnoreCase) >= 0); /*|| (item as ListInvoice).NGAYLAP.ToString().IndexOf(TextFilter, StringComparison.OrdinalIgnoreCase) >= 0*/
        }

        static int i = 0;
        public HoSoBenhAnViewModel()
        {
            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                ListPhieuDangKy = new ObservableCollection<PHIEUDANGKY>(DataProvider.Ins.DB.PHIEUDANGKY.Where(x => x.NV_MA == LoginViewModel.NV_DATA.NV_MA).OrderByDescending(x=>x.PDK_NGAYBATDAU));
                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(ListPhieuDangKy);
                view.Filter = UserFilter;
            }
            );

            KeySearchCommand = new RelayCommand<object>((p) =>
            {
                var list = DataProvider.Ins.DB.PHIEUDANGKY.Count();

                if (list == 0)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                CollectionViewSource.GetDefaultView(ListPhieuDangKy).Refresh();
            }
            );

            CommandSelectedPhieuDangKy = new RelayCommand<object>((p) =>
            {
                if (SelectedPhieuDangKy == null)
                    return false;

                return true;
            }, (p) =>
            {
                var getKhachHang = SelectedPhieuDangKy;

                KH_TEN = getKhachHang.KHACHHANG.KH_HOTEN;
                KH_SDT = getKhachHang.KHACHHANG.KH_SDT;
                KH_MA = getKhachHang.KHACHHANG.KH_MA;
                KH_EMAIL = getKhachHang.KHACHHANG.KH_EMAIL;
                KH_GIOITINH = getKhachHang.KHACHHANG.KH_GIOITINH;
                KH_NGAYSINH = getKhachHang.KHACHHANG.KH_NGAYSINH;

                if (getKhachHang.KHACHHANG.KH_GIOITINH == "Nam")
                    KH_ANH = @"E:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Avatars\Customer\man.png";
                else
                    KH_ANH = @"E:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Avatars\Customer\woman.png";

                ListPhieuDieuTri = new ObservableCollection<ClassPhieuDieuTriLichSuKham>();
                var listPDT = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDK_STT == getKhachHang.PDK_STT);

                foreach(var item in listPDT)
                {
                    var phieuDieuTri = new ClassPhieuDieuTriLichSuKham();
                    phieuDieuTri.GDV_TEN = item.PHIEUDANGKY.GOIDICHVU.GDV_TEN;
                    phieuDieuTri.PDT_CHUANDOAN = item.PDT_CHUANDOAN;
                    phieuDieuTri.PDT_GHICHU = item.PDT_GHICHU;
                    phieuDieuTri.PDT_LOIDAN = item.PDT_LOIDAN;
                    phieuDieuTri.PDT_NGAYLAP = item.PDT_NGAYLAP;
                    phieuDieuTri.PDT_STT = item.PDT_STT;
                    phieuDieuTri.PDK_STT = item.PDK_STT;

                    if(item.PDT_TRANGTHAI == "Chờ khám")
                    {
                        phieuDieuTri.Icon = "FileClockOutline";
                        phieuDieuTri.ColorIcon = "#ff6f00";
                    }
                    else if(item.PDT_TRANGTHAI == "Hoàn thành khám")
                    {
                        phieuDieuTri.Icon = "ClipboardCheckOutline";
                        phieuDieuTri.ColorIcon = "Green";
                    }

                    ListPhieuDieuTri.Add(phieuDieuTri);
                }

                ListChiDinh = new ObservableCollection<ClassToaThuoc>();
            }
            );

            CommandSelectedPhieuDieuTri = new RelayCommand<object>((p) =>
            {
                if (SelectedPhieuDieuTri == null)
                    return false;

                return true;
            }, (p) =>
            {
                var phieuDieuTri = SelectedPhieuDieuTri;

                ListChiDinh = new ObservableCollection<ClassToaThuoc>();
                var chidinhList = new ObservableCollection<CHIDINH>(DataProvider.Ins.DB.CHIDINH.Where(x => x.PDT_STT == phieuDieuTri.PDT_STT && x.PHIEUDIEUTRI.PDK_STT == phieuDieuTri.PDK_STT));


                foreach (var item in chidinhList)
                {
                    int stt = ++i;
                    var ClassToaThuoc = new ClassToaThuoc();
                    ClassToaThuoc.DVT_TEN = item.THUOC.DVT.DVT_TEN;
                    ClassToaThuoc.T_TEN = item.THUOC.T_TEN + ", ";
                    ClassToaThuoc.CD_CACHDUNG = item.CD_CACHDUNG;
                    ClassToaThuoc.CD_LIEUDUNG = item.CD_LIEUDUNG + ", ";
                    ClassToaThuoc.CD_SOLUONG = item.CD_SOLUONG;
                    ClassToaThuoc.T_STT = (stt).ToString() + "/ ";

                    ListChiDinh.Add(ClassToaThuoc);
                }
                i = 0;
            }
            );

            CommandXemPhieuDieuTri = new RelayCommand<object>((p) =>
            {
                if (SelectedPhieuDieuTri == null)
                    return false;

                return true;
            }, (p) =>
            {
                DanhSachChoViewModel.PDT_DATA = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x=>x.PDT_STT == SelectedPhieuDieuTri.PDT_STT && x.PDK_STT == SelectedPhieuDieuTri.PDK_STT).SingleOrDefault();
                W_GhiNhanBenh window = new W_GhiNhanBenh();
                window.ShowDialog();
            }
            );
        }
    }
}
