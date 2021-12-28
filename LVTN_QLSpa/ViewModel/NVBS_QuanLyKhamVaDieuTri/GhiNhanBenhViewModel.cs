using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using LVTN_QLSpa.Model.ModelClass;
using LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_KHAM;
using LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham;
using LVTN_QLSpa.ViewModel.NVDK_LichHenVaDangKy;
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
    public class Thuoc
    {
        public string T_MA { get; set; }
        public string T_TEN { get; set; }
    }
    public class GhiNhanBenhViewModel : BaseViewModel
    {
        private string _KH_TEN;
        public string KH_TEN { get => _KH_TEN; set { _KH_TEN = value; OnPropertyChanged(); } }

        private string _KH_SDT;
        public string KH_SDT { get => _KH_SDT; set { _KH_SDT = value; OnPropertyChanged(); } }

        private string _KH_TUOI;
        public string KH_TUOI { get => _KH_TUOI; set { _KH_TUOI = value; OnPropertyChanged(); } }

        private string _KH_EMAIL;
        public string KH_EMAIL { get => _KH_EMAIL; set { _KH_EMAIL = value; OnPropertyChanged(); } }

        private string _KH_GIOITINH;
        public string KH_GIOITINH { get => _KH_GIOITINH; set { _KH_GIOITINH = value; OnPropertyChanged(); } }

        private string _KH_DIACHI;
        public string KH_DIACHI { get => _KH_DIACHI; set { _KH_DIACHI = value; OnPropertyChanged(); } }

        private string _GDV_TEN;
        public string GDV_TEN { get => _GDV_TEN; set { _GDV_TEN = value; OnPropertyChanged(); } }

        private string _LGDV_TEN;
        public string LGDV_TEN { get => _LGDV_TEN; set { _LGDV_TEN = value; OnPropertyChanged(); } }

        private string _PDT_STT;
        public string PDT_STT { get => _PDT_STT; set { _PDT_STT = value; OnPropertyChanged(); } }

        private string _PDK_STT;
        public string PDK_STT { get => _PDK_STT; set { _PDK_STT = value; OnPropertyChanged(); } }

        private string _LT_STT_MOTA;
        public string LT_STT_MOTA { get => _LT_STT_MOTA; set { _LT_STT_MOTA = value; OnPropertyChanged(); } }

        private DateTime _PDT_NGAYKHAM;
        public DateTime PDT_NGAYKHAM { get => _PDT_NGAYKHAM; set { _PDT_NGAYKHAM = value; OnPropertyChanged(); } }

        private DateTime _LTDT_NGAY;
        public DateTime LTDT_NGAY { get => _LTDT_NGAY; set { _LTDT_NGAY = value; OnPropertyChanged(); } }

        private string _PDT_CHUANDOAN;
        public string PDT_CHUANDOAN { get => _PDT_CHUANDOAN; set { _PDT_CHUANDOAN = value; OnPropertyChanged(); } }

        private string _PDT_LOIDAN;
        public string PDT_LOIDAN { get => _PDT_LOIDAN; set { _PDT_LOIDAN = value; OnPropertyChanged(); } }

        private string _PDT_GHICHU;
        public string PDT_GHICHU { get => _PDT_GHICHU; set { _PDT_GHICHU = value; OnPropertyChanged(); } }

        private string _LTDT_THOIGIAN;
        public string LTDT_THOIGIAN { get => _LTDT_THOIGIAN; set { _LTDT_THOIGIAN = value; OnPropertyChanged(); } }

        private string _TextSearchThuoc;
        public string TextSearchThuoc { get => _TextSearchThuoc; set { _TextSearchThuoc = value; OnPropertyChanged(); } }

        private int _CD_SOLUONG;
        public int CD_SOLUONG { get => _CD_SOLUONG; set { _CD_SOLUONG = value; OnPropertyChanged(); } }

        private string _CD_LIEUDUNG;
        public string CD_LIEUDUNG { get => _CD_LIEUDUNG; set { _CD_LIEUDUNG = value; OnPropertyChanged(); } }

        private string _CD_CACHDUNG;
        public string CD_CACHDUNG { get => _CD_CACHDUNG; set { _CD_CACHDUNG = value; OnPropertyChanged(); } }

        private string _T_TEN;
        public string T_TEN { get => _T_TEN; set { _T_TEN = value; OnPropertyChanged(); } }

        private Visibility _HienThiListBox;
        public Visibility HienThiListBox { get => _HienThiListBox; set { _HienThiListBox = value; OnPropertyChanged(); } }

        private ObservableCollection<PHIEUDIEUTRI> _PHIEUDIEUTRI;
        public ObservableCollection<PHIEUDIEUTRI> PHIEUDIEUTRI { get => _PHIEUDIEUTRI; set { _PHIEUDIEUTRI = value; OnPropertyChanged(); } }

        private ObservableCollection<ClassChiDinh> _ListCHIDINH;
        public ObservableCollection<ClassChiDinh> ListCHIDINH { get => _ListCHIDINH; set { _ListCHIDINH = value; OnPropertyChanged(); } }

        private ObservableCollection<Thuoc> _ListThuoc;
        public ObservableCollection<Thuoc> ListThuoc { get => _ListThuoc; set { _ListThuoc = value; OnPropertyChanged(); } }

        private ObservableCollection<HOATCHAT> _BIETDUOCAdd;
        public ObservableCollection<HOATCHAT> BIETDUOCAdd { get => _BIETDUOCAdd; set { _BIETDUOCAdd = value; OnPropertyChanged(); } }

        private ObservableCollection<DVT> _DVT;
        public ObservableCollection<DVT> DVT { get => _DVT; set { _DVT = value; OnPropertyChanged(); } }

        private ObservableCollection<NHASX> _NSX;
        public ObservableCollection<NHASX> NSX { get => _NSX; set { _NSX = value; OnPropertyChanged(); } }

        private PHIEUDIEUTRI _SelectedPHIEUDIEUTRI;
        public PHIEUDIEUTRI SelectedPHIEUDIEUTRI
        {
            get => _SelectedPHIEUDIEUTRI;
            set
            {
                _SelectedPHIEUDIEUTRI = value;
                OnPropertyChanged();
            }
        }

        private Thuoc _SelectedTHUOC;
        public Thuoc SelectedTHUOC
        {
            get => _SelectedTHUOC;
            set
            {
                _SelectedTHUOC = value;
                OnPropertyChanged();
            }
        }

        private ClassChiDinh _SelectedCHIDINH;
        public ClassChiDinh SelectedCHIDINH
        {
            get => _SelectedCHIDINH;
            set
            {
                _SelectedCHIDINH = value;
                OnPropertyChanged();
            }
        }

        private HOATCHAT _SelectedBIETDUOCAdd;
        public HOATCHAT SelectedBIETDUOCAdd
        {
            get => _SelectedBIETDUOCAdd;
            set
            {
                _SelectedBIETDUOCAdd = value;
                OnPropertyChanged();
            }
        }

        private DVT _SelectedDVT;
        public DVT SelectedDVT
        {
            get => _SelectedDVT;
            set
            {
                _SelectedDVT = value;
                OnPropertyChanged();
            }
        }

        private NHASX _SelectedNSX;
        public NHASX SelectedNSX
        {
            get => _SelectedNSX;
            set
            {
                _SelectedNSX = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoadWindow { get; set; }
        public ICommand CommandSelectedPHIEUDANGKY { get; set; }
        public ICommand CommandSelectedThuoc { get; set; }
        public ICommand CommandSearchThuoc { get; set; }
        public ICommand CommandAddCHIDINH { get; set; }
        public ICommand CommandDeleteCHIDINH { get; set; }
        public ICommand CommnadAddThuoc { get; set; }
        public ICommand CommandSelectedCHIDINH { get; set; }
        public ICommand CommandLuuPhieu { get; set; }
        public ICommand CommandInToaThuoc { get; set; }
        public ICommand CommandLichTrinhKham { get; set; }
        public ICommand CommandDoiNgayKham { get; set; }
        public ICommand CommandDichVuDaDangKy { get; set; }
        public ICommand CommandHoanThanh { get; set; }

        private bool UserFilter(object item)
        {
            if (String.IsNullOrEmpty(TextSearchThuoc))
                return true;
            else
                return ((item as Thuoc).T_TEN.IndexOf(TextSearchThuoc, StringComparison.OrdinalIgnoreCase) >= 0); /*|| (item as ListInvoice).NGAYLAP.ToString().IndexOf(TextFilter, StringComparison.OrdinalIgnoreCase) >= 0*/
        }

        public GhiNhanBenhViewModel()
        {
            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                HienThiListBox = Visibility.Collapsed;
                ListThuoc = LoadThuoc();
                BIETDUOCAdd = DAO_Thuoc.GetListHoatChat();
                DVT = DAO_Thuoc.GetListDVT();
                NSX = DAO_Thuoc.GetListNSX();

                PHIEUDIEUTRI = new ObservableCollection<PHIEUDIEUTRI>(DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDK_STT == DanhSachChoViewModel.PDT_DATA.PDK_STT).OrderByDescending(x => x.PDT_NGAYLAP));

                var getListPhieuDieuTri = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDT_STT == DanhSachChoViewModel.PDT_DATA.PDT_STT && x.PDK_STT == DanhSachChoViewModel.PDT_DATA.PDK_STT).SingleOrDefault();
                LoadDataGhiNhanBenh(getListPhieuDieuTri);

                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(ListThuoc);
                view.Filter = UserFilter;
            }
            );

            CommandSelectedPHIEUDANGKY = new RelayCommand<object>((p) =>
            {
                if (SelectedPHIEUDIEUTRI == null)
                    return false;
                return true;
            }, (p) =>
            {
                LoadDataGhiNhanBenh(SelectedPHIEUDIEUTRI);
            }
            );

            CommandSearchThuoc = new RelayCommand<object>((p) =>
            {
                if (ListThuoc == null)
                    return false;
                return true;
            }, (p) =>
            {
                CollectionViewSource.GetDefaultView(ListThuoc).Refresh();
                HienThiListBox = Visibility.Visible;

                if(TextSearchThuoc == "")
                {
                    HienThiListBox = Visibility.Collapsed;
                }
            }
            );

            CommandSelectedThuoc = new RelayCommand<object>((p) =>
            {
                if (SelectedTHUOC == null)
                    return false;

                return true;
            }, (p) =>
            {
                TextSearchThuoc = SelectedTHUOC.T_TEN;
                HienThiListBox = Visibility.Collapsed;
            }
            );

            CommandAddCHIDINH = new RelayCommand<object>((p) =>
            {
                var getThuoc = DataProvider.Ins.DB.CHIDINH.Where(x => x.PDK_STT == PDK_STT && x.PDT_STT == PDT_STT && x.T_MA == SelectedTHUOC.T_MA).SingleOrDefault();
                if (SelectedCHIDINH != null || getThuoc != null || DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x=>x.PDK_STT == PDK_STT && x.PDT_STT == PDT_STT).Select(x=>x.PDT_TRANGTHAI).SingleOrDefault() == "Hoàn thành khám")
                    return false;

                return true;
            }, (p) =>
            {
                DAO_ChiDinh.AddCD(PDT_STT, PDK_STT, SelectedTHUOC.T_MA, CD_SOLUONG, CD_LIEUDUNG, CD_CACHDUNG);
                GetListChiDinh(PDT_STT, PDK_STT);
            }
            );

            CommandDeleteCHIDINH = new RelayCommand<object>((p) =>
            {
                if (SelectedCHIDINH == null || DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDK_STT == PDK_STT && x.PDT_STT == PDT_STT).Select(x => x.PDT_TRANGTHAI).SingleOrDefault() == "Hoàn thành khám")
                    return false;

                return true;
            }, (p) =>
            {
                DAO_ChiDinh.DeleteCD(PDT_STT, PDK_STT, SelectedCHIDINH.T_TEN);
                GetListChiDinh(PDT_STT, PDK_STT);
            }
            );

            CommandSelectedCHIDINH = new RelayCommand<object>((p) =>
            {
                if (SelectedCHIDINH == null)
                    return false;

                return true;
            }, (p) =>
            {
                //SelectedTHUOC = DataProvider.Ins.DB.THUOC.Where(x => x.T_MA == SelectedCHIDINH.T_MA).SingleOrDefault();
                CD_SOLUONG = SelectedCHIDINH.CD_SOLUONG;
                CD_CACHDUNG = SelectedCHIDINH.CD_CACHDUNG;
                CD_LIEUDUNG = SelectedCHIDINH.CD_LIEUDUNG;
            }
            );

            CommnadAddThuoc = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                Random r = new Random();
                var thuoc = new THUOC() { T_MA = ("T" + r.Next(1000, 9999).ToString()), T_TEN = T_TEN, NSX_MA = SelectedNSX.NSX_MA, HC_MA = SelectedBIETDUOCAdd.HC_MA, DVT_MA = SelectedDVT.DVT_MA };
                DataProvider.Ins.DB.THUOC.Add(thuoc);
                DataProvider.Ins.DB.SaveChanges();
            }
            );

            CommandLuuPhieu = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(PDT_STT) || string.IsNullOrEmpty(PDK_STT))
                    return false;

                var getTTPDT = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDT_STT == PDT_STT && x.PDK_STT == PDK_STT).Select(x=>x.PDT_TRANGTHAI).SingleOrDefault();
                if (getTTPDT == "Hoàn thành khám")
                    return false;

                return true;
            }, (p) =>
            {
                if(MessageBox.Show("Lưu phiếu điều trị?", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Information) == MessageBoxResult.OK)
                {
                    DAO_PhieuDieuTri.EditGhiNhanBenh(PDK_STT, PDT_STT, PDT_CHUANDOAN, PDT_LOIDAN, PDT_GHICHU);
                    MessageBox.Show("Đã lưu phiếu", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            );

            CommandInToaThuoc = new RelayCommand<Window>((p) =>
            {
                var getToaThuoc = DataProvider.Ins.DB.CHIDINH.Where(x => x.PDK_STT == PDK_STT && x.PDT_STT == PDT_STT).ToList();
                if (getToaThuoc.Count() == 0)
                    return false;

                return true;
            }, (p) =>
            {
                DanhSachChoViewModel.PDT_DATA = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDT_STT == PDT_STT && x.PDK_STT == PDK_STT).SingleOrDefault();
                W_InToaThuoc window = new W_InToaThuoc();
                window.ShowDialog();
            }
            );

            CommandDoiNgayKham = new RelayCommand<Window>((p) =>
            {
                var getTTPDT = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDT_STT == PDT_STT && x.PDK_STT == PDK_STT).Select(x => x.PDT_TRANGTHAI).SingleOrDefault();
                if (getTTPDT == "Hoàn thành khám")
                    return false;

                return true;
            }, (p) =>
            {
                DanhSachChoViewModel.PDT_DATA = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDT_STT == PDT_STT && x.PDK_STT == PDK_STT).SingleOrDefault();
                W_DoiNgayKham windowPage = new W_DoiNgayKham();
                windowPage.ShowDialog();
            }
            );

            CommandLichTrinhKham = new RelayCommand<Window>((p) =>
            {
                return true;
            }, (p) =>
            {
                LapPhieuDangKyViewModel.PDK_STT_DATA = PDK_STT;
                W_InLichTrinhDieuTri window = new W_InLichTrinhDieuTri();
                window.ShowDialog();
                LapPhieuDangKyViewModel.PDK_STT_DATA = null;
            }
            );

            CommandDichVuDaDangKy = new RelayCommand<Window>((p) =>
            {
                if (SelectedPHIEUDIEUTRI.PHIEUDANGKY.KH_MA != DanhSachChoViewModel.PDT_DATA.PHIEUDANGKY.KH_MA)
                    return false;

                return true;
            }, (p) =>
            {
                DanhSachChoViewModel.PDT_DATA = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDT_STT == PDT_STT && x.PDK_STT == PDK_STT).SingleOrDefault();
                W_LichSuDangKyDV window = new W_LichSuDangKyDV();
                window.ShowDialog();
            }
            );

            CommandHoanThanh = new RelayCommand<Window>((p) =>
            {
                return true;
            }, (p) =>
            {
                if(MessageBox.Show("Xác nhận hoàn thành khám cho phiếu điều trị", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
                {
                    DAO_PhieuDieuTri.EditGhiNhanBenh(PDK_STT, PDT_STT, "Hoàn thành khám");

                    FrameworkElement window = GetWindowParent(p);
                    var w = window as Window;
                    if (w != null)
                    {
                        w.Close();
                    }
                }
            }
            );
        }

        ObservableCollection<Thuoc> LoadThuoc()
        {
            var getListThuoc = DAO_Thuoc.GetListThuoc();
            var listThuoc = new ObservableCollection<Thuoc>();
            foreach(var item in getListThuoc)
            {
                var thuoc = new Thuoc();
                thuoc.T_MA = item.T_MA;
                thuoc.T_TEN = item.T_MA.Trim(' ') + " - " + item.T_TEN.Trim(' ') + " - " + item.DVT.DVT_TEN.Trim(' ');

                listThuoc.Add(thuoc);
            }

            return listThuoc;
        }

        void LoadDataGhiNhanBenh(PHIEUDIEUTRI phieuDieuTri)
        {
            KH_TEN = phieuDieuTri.PHIEUDANGKY.KHACHHANG.KH_HOTEN;
            KH_SDT = phieuDieuTri.PHIEUDANGKY.KHACHHANG.KH_SDT;
            KH_TUOI = Age(phieuDieuTri.PHIEUDANGKY.KHACHHANG.KH_NGAYSINH);
            KH_EMAIL = phieuDieuTri.PHIEUDANGKY.KHACHHANG.KH_EMAIL;
            KH_GIOITINH = phieuDieuTri.PHIEUDANGKY.KHACHHANG.KH_GIOITINH;
            KH_DIACHI = phieuDieuTri.PHIEUDANGKY.KHACHHANG.KH_DIACHI;
            GDV_TEN = phieuDieuTri.PHIEUDANGKY.GOIDICHVU.GDV_TEN;
            LGDV_TEN = phieuDieuTri.PHIEUDANGKY.GOIDICHVU.LOAIGOIDICHVU.LGDV_TEN;
            PDT_STT = phieuDieuTri.PDT_STT;
            PDK_STT = phieuDieuTri.PDK_STT;
            PDT_NGAYKHAM = phieuDieuTri.PDT_NGAYLAP;
            PDT_CHUANDOAN = phieuDieuTri.PDT_CHUANDOAN;
            PDT_LOIDAN = phieuDieuTri.PDT_LOIDAN;
            PDT_GHICHU = phieuDieuTri.PDT_GHICHU;
            

            if (phieuDieuTri.PHIEUDANGKY.GOIDICHVU.LOAIGOIDICHVU.LGDV_MA == 1)
            {
                // Lấy ngày khám tiếp theo
                var soPDT = Convert.ToInt32(phieuDieuTri.PDT_STT) + 1;
                var getNgayKhamToi = DataProvider.Ins.DB.LICHTRINHDIEUTRI.Where(x => x.LIEUTRINH.LT_STT == soPDT && x.PDK_STT == phieuDieuTri.PDK_STT && x.GDV_MA == phieuDieuTri.PHIEUDANGKY.GDV_MA).SingleOrDefault();
                if(getNgayKhamToi != null)
                {
                    LTDT_NGAY = getNgayKhamToi.LTDT_NGAYDT;
                    LTDT_THOIGIAN = getNgayKhamToi.LTDT_THOIGIANDEN;
                }

                int SOPDT = Convert.ToInt32(phieuDieuTri.PDT_STT);
                var lieuTrinh = DataProvider.Ins.DB.LIEUTRINH.Where(x => x.GDV_MA == phieuDieuTri.PHIEUDANGKY.GDV_MA && x.LT_STT == SOPDT).SingleOrDefault();
                LT_STT_MOTA = lieuTrinh.LT_STT + " - " + lieuTrinh.LT_MOTA;
            }
            else
            {
                LT_STT_MOTA = "";
            }

            GetListChiDinh(phieuDieuTri.PDT_STT, phieuDieuTri.PDK_STT);
        }

        void LoadListDonThuoc()
        {
            BIETDUOCAdd = new ObservableCollection<HOATCHAT>(DataProvider.Ins.DB.HOATCHAT);
            DVT = new ObservableCollection<DVT>(DataProvider.Ins.DB.DVT);
            NSX = new ObservableCollection<NHASX>(DataProvider.Ins.DB.NHASX);
        }
        static int i = 0;
        void GetListChiDinh (string PDT_STT, string PDK_STT)
        {
            var getListChiDinh = DAO_ChiDinh.GetListTheoPDT(PDT_STT, PDK_STT);
            ListCHIDINH = new ObservableCollection<ClassChiDinh>();
            
            foreach(var item in getListChiDinh)
            {
                ClassChiDinh classChiDinh = new ClassChiDinh();
                classChiDinh.STT = ++i;
                classChiDinh.T_MA = item.T_MA;
                classChiDinh.T_TEN = item.THUOC.T_TEN;
                classChiDinh.PDK_STT = item.PDK_STT;
                classChiDinh.PDT_STT = item.PDT_STT;
                classChiDinh.CD_CACHDUNG = item.CD_CACHDUNG;
                classChiDinh.CD_SOLUONG = item.CD_SOLUONG;
                classChiDinh.CD_LIEUDUNG = item.CD_LIEUDUNG;
                classChiDinh.HC_MA = item.THUOC.HOATCHAT.HC_MA;
                ListCHIDINH.Add(classChiDinh);
                
            }
            i = 0;
        }

        LIEUTRINH GetLieuTrinhPDT(PHIEUDIEUTRI phieuDieuTri)
        {
            LIEUTRINH getLieuTrinh = new LIEUTRINH();
            if (phieuDieuTri.PHIEUDANGKY.GOIDICHVU.LGDV_MA == 1)
            {
                int SOPDT = Convert.ToInt32(phieuDieuTri.PDT_STT);
                getLieuTrinh = DataProvider.Ins.DB.LIEUTRINH.Where(x => x.GDV_MA == phieuDieuTri.PHIEUDANGKY.GDV_MA && x.LT_STT == SOPDT).SingleOrDefault();
            }

            return getLieuTrinh;
        }

        string Age(DateTime birthday)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - birthday.Year;
            if (now < birthday.AddYears(age)) age--;

            return age.ToString();
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
