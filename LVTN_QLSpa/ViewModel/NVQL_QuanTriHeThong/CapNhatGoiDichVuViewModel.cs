using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using LVTN_QLSpa.Model.ModelClass;
using LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLDV;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace LVTN_QLSpa.ViewModel.NVQL_QuanTriHeThong
{
    public class CapNhatGoiDichVuViewModel : BaseViewModel
    {
        private static DG_GDV gdv_DATA;
        public static DG_GDV GDV_DATA
        {
            get { return CapNhatGoiDichVuViewModel.gdv_DATA; }
            set { CapNhatGoiDichVuViewModel.gdv_DATA = value; }
        }

        private string _KeySearchGDV;
        public string KeySearchGDV { get => _KeySearchGDV; set { _KeySearchGDV = value; OnPropertyChanged(); } }

        private string _GDV_MA;
        public string GDV_MA { get => _GDV_MA; set { _GDV_MA = value; OnPropertyChanged(); } }

        private string _GDV_TEN;
        public string GDV_TEN { get => _GDV_TEN; set { _GDV_TEN = value; OnPropertyChanged(); } }

        private int? _GDV_SOLAN;
        public int? GDV_SOLAN { get => _GDV_SOLAN; set { _GDV_SOLAN = value; OnPropertyChanged(); } }

        private string _GDV_DONGIA;
        public string GDV_DONGIA { get => _GDV_DONGIA; set { _GDV_DONGIA = value; OnPropertyChanged(); } }

        private string _GDV_ANH;
        public string GDV_ANH { get => _GDV_ANH; set { _GDV_ANH = value; OnPropertyChanged(); } }

        private string _GDV_MOTA;
        public string GDV_MOTA { get => _GDV_MOTA; set { _GDV_MOTA = value; OnPropertyChanged(); } }

        private bool _CheckedCoLieuTrinh;
        public bool CheckedCoLieuTrinh { get => _CheckedCoLieuTrinh; set { _CheckedCoLieuTrinh = value; OnPropertyChanged(); } }

        private bool _CheckedKhongLieuTrinh;
        public bool CheckedKhongLieuTrinh { get => _CheckedKhongLieuTrinh; set { _CheckedKhongLieuTrinh = value; OnPropertyChanged(); } }

        private int _GDV_LOAIGDV;
        public int GDV_LOAIGDV { get => _GDV_LOAIGDV; set { _GDV_LOAIGDV = value; OnPropertyChanged(); } }

        private Visibility _HiddenSoLanLieuTrinh;
        public Visibility HiddenSoLanLieuTrinh { get => _HiddenSoLanLieuTrinh; set { _HiddenSoLanLieuTrinh = value; OnPropertyChanged(); } }

        private ObservableCollection<DG_GDV> _ListGoiDichVu;
        public ObservableCollection<DG_GDV> ListGoiDichVu { get => _ListGoiDichVu; set { _ListGoiDichVu = value; OnPropertyChanged(); } }

        private ObservableCollection<PHUONGPHAP> _PHUONGPHAP;
        public ObservableCollection<PHUONGPHAP> PHUONGPHAP { get => _PHUONGPHAP; set { _PHUONGPHAP = value; OnPropertyChanged(); } }

        private ObservableCollection<DICHVU> _DICHVU;
        public ObservableCollection<DICHVU> DICHVU { get => _DICHVU; set { _DICHVU = value; OnPropertyChanged(); } }

        private ObservableCollection<DICHVU> _DVFilter;
        public ObservableCollection<DICHVU> DVFilter { get => _DVFilter; set { _DVFilter = value; OnPropertyChanged(); } }

        private ObservableCollection<LOAIGOIDICHVU> _LDVFilter;
        public ObservableCollection<LOAIGOIDICHVU> LDVFilter { get => _LDVFilter; set { _LDVFilter = value; OnPropertyChanged(); } }

        private DG_GDV _SelectedItemGDV;
        public DG_GDV SelectedItemGDV
        {
            get => _SelectedItemGDV;
            set
            {
                _SelectedItemGDV = value;
                OnPropertyChanged();
                if (SelectedItemGDV != null)
                {
                    GDV_MA = SelectedItemGDV.GOIDICHVU.GDV_MA;
                    GDV_TEN = SelectedItemGDV.GOIDICHVU.GDV_TEN;
                    GDV_SOLAN = SelectedItemGDV.GOIDICHVU.GDV_SOLAN;
                    GDV_DONGIA = SelectedItemGDV.DONGIA;
                    GDV_MOTA = SelectedItemGDV.GOIDICHVU.GDV_MOTA;
                    GDV_ANH = SelectedItemGDV.GOIDICHVU.GDV_ANH;
                    SelectedPP = SelectedItemGDV.GOIDICHVU.PHUONGPHAP;
                    SelectedDV = SelectedItemGDV.GOIDICHVU.DICHVU;

                    if(SelectedItemGDV.GOIDICHVU.LGDV_MA == 1)
                        CheckedCoLieuTrinh = true;
                    else
                        CheckedKhongLieuTrinh = true;
                }
            }
        }

        private PHUONGPHAP _SelectedPP;
        public PHUONGPHAP SelectedPP
        {
            get => _SelectedPP;
            set
            {
                _SelectedPP = value;
                OnPropertyChanged();
            }
        }

        private DICHVU _SelectedDV;
        public DICHVU SelectedDV
        {
            get => _SelectedDV;
            set
            {
                _SelectedDV = value;
                OnPropertyChanged();
            }
        }

        private DICHVU _SelectedDVFilter;
        public DICHVU SelectedDVFilter
        {
            get => _SelectedDVFilter;
            set
            {
                _SelectedDVFilter = value;
                OnPropertyChanged();

                if (SelectedDVFilter != null)
                    ListGoiDichVu = DAO_GoiDichVu.GetList(SelectedDVFilter.DV_MA);
            }
        }

        private LOAIGOIDICHVU _SelectedLDVFilter;
        public LOAIGOIDICHVU SelectedLDVFilter
        {
            get => _SelectedLDVFilter;
            set
            {
                _SelectedLDVFilter = value;
                OnPropertyChanged();
                if (SelectedLDVFilter != null)
                    ListGoiDichVu = DAO_GoiDichVu.GetList(SelectedLDVFilter.LGDV_MA);
            }
        }

        public ICommand CommandAddGDV { get; set; }
        public ICommand CommandEditGDV { get; set; }
        public ICommand CommandDeleteGDV { get; set; }
        public ICommand CommandClearGDV { get; set; }
        public ICommand AddIdCommandGDV { get; set; }
        public ICommand KeySearchCommandGDV { get; set; }
        public ICommand CommandAddImageGDV { get; set; }
        public ICommand CommandCheckKhongLieuTrinh { get; set; }
        public ICommand CommandUnCheckKhongLieuTrinh { get; set; }
        public ICommand CommandFormatPriceGDV { get; set; }
        public ICommand CommandInThongTinGDV { get; set; }
        public ICommand LoadWindow { get; set; }

        // Thuộc tính gói dịch vụ có thể tìm 
        private bool UserFilterGDV(object item)
        {
            if (String.IsNullOrEmpty(KeySearchGDV))
                return true;
            else
                return ((item as DG_GDV).GOIDICHVU.GDV_TEN.IndexOf(KeySearchGDV, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as DG_GDV).DONGIA.IndexOf(KeySearchGDV, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as DG_GDV).GOIDICHVU.GDV_SOLAN.ToString().IndexOf(KeySearchGDV, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as DG_GDV).GOIDICHVU.DICHVU.DV_TEN.IndexOf(KeySearchGDV, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as DG_GDV).GOIDICHVU.PHUONGPHAP.PP_TEN.IndexOf(KeySearchGDV, StringComparison.OrdinalIgnoreCase) >= 0); /*|| (item as ListInvoice).NGAYLAP.ToString().IndexOf(TextFilter, StringComparison.OrdinalIgnoreCase) >= 0*/
        }

        public CapNhatGoiDichVuViewModel()
        {
            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                //List Load
                ListGoiDichVu = DAO_GoiDichVu.GetList();

                PHUONGPHAP = DAO_PhuongPhap.GetList();
                DICHVU = DAO_DichVu.GetList();

                //List Filter
                DVFilter = DAO_DichVu.GetList();
                LDVFilter = new ObservableCollection<LOAIGOIDICHVU>(DataProvider.Ins.DB.LOAIGOIDICHVU);

                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(ListGoiDichVu);
                view.Filter = UserFilterGDV;
            }
            );
            
            KeySearchCommandGDV = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                CollectionViewSource.GetDefaultView(ListGoiDichVu).Refresh();
            }
            );

            CommandAddImageGDV = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();

                if (true == openFileDialog.ShowDialog())
                {
                    string filename = openFileDialog.FileName;
                    try
                    {
                        GDV_ANH = filename;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Tập tin không hợp lệ");
                        return;
                    }
                }
            }
            );

            AddIdCommandGDV = new RelayCommand<object>((p) =>
            {
                if (SelectedItemGDV != null || string.IsNullOrEmpty(GDV_TEN))
                {
                    return false;
                }
                return true;
            }, (p) =>
            {
                Random r = new Random();
                GDV_MA = ClassXuLyChuoi.LocDau(ClassXuLyChuoi.GetName(GDV_TEN, "")) + r.Next(1, 99);
            }
            );

            // Nếu như gói dịch vụ này không có liệu trình thì hidden thuộc tính số lần liệu trình không có nhập liệu
            CommandCheckKhongLieuTrinh = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                HiddenSoLanLieuTrinh = Visibility.Hidden;
            }
            );

            CommandUnCheckKhongLieuTrinh = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                HiddenSoLanLieuTrinh = Visibility.Visible;
            }
            );

            CommandAddGDV = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(GDV_TEN) || string.IsNullOrEmpty(GDV_MA) || string.IsNullOrEmpty(GDV_DONGIA) || SelectedDV == null)
                {
                    return false;
                }

                if (SelectedItemGDV != null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                // Add GoiDichVu
                if(CheckedCoLieuTrinh == true)
                    GDV_LOAIGDV = 1;
                else
                    GDV_LOAIGDV = 2;

                if (CheckedKhongLieuTrinh == true)
                    GDV_SOLAN = 0;

                var goidichvu = new GOIDICHVU()
                {
                    GDV_MA = GDV_MA,
                    GDV_TEN = GDV_TEN,
                    GDV_SOLAN = GDV_SOLAN,
                    GDV_ANH = GDV_ANH,
                    GDV_MOTA = GDV_MOTA,
                    LGDV_MA = GDV_LOAIGDV,
                    DV_MA = SelectedDV.DV_MA,
                    PP_MA = SelectedPP.PP_MA
                };
                DAO_GoiDichVu.Add(goidichvu);

                // Add Ngay
                var thoiGian = new NGAY() { THOIGIAN = DateTime.Now };
                DAO_Ngay.Add(thoiGian);

                // Add DG_GDV
                var dongia_gdv = new DG_GDV() { GDV_MA = GDV_MA, THOIGIAN = thoiGian.THOIGIAN, DONGIA = GDV_DONGIA };
                DAO_GoiDichVu.Add(dongia_gdv);

                ListGoiDichVu = DAO_GoiDichVu.GetList();
            }
            );

            CommandEditGDV = new RelayCommand<object>((p) =>
            {
                if (SelectedItemGDV == null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                // Edit GoiDichVu
                if (CheckedCoLieuTrinh == true)
                    GDV_LOAIGDV = 1;
                else
                    GDV_LOAIGDV = 2;

                if (GDV_SOLAN == 0 || GDV_SOLAN == null)
                    GDV_SOLAN = 0;

                DAO_GoiDichVu.Edit(GDV_MA,GDV_TEN,GDV_SOLAN,GDV_MOTA,GDV_ANH,GDV_LOAIGDV,SelectedDV.DV_MA,SelectedPP.PP_MA);

                // Nếu đơn giá thay đổi thì add giá mới
                if(SelectedItemGDV.DONGIA != GDV_DONGIA)
                {
                    // Edit DG_GDV
                    DAO_GoiDichVu.Edit(SelectedItemGDV.GDV_MA, SelectedItemGDV.THOIGIAN, GDV_DONGIA);
                }

                ListGoiDichVu = DAO_GoiDichVu.GetList();
            }
            );

            CommandDeleteGDV = new RelayCommand<object>((p) =>
            {
                if (SelectedItemGDV == null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                // Delete Don gia gói
                DAO_GoiDichVu.DeleteDG_GDV(SelectedItemGDV.GDV_MA);

                // Delete ngay
                DAO_Ngay.Delete(SelectedItemGDV.THOIGIAN);

                // Delete goi dich vụ
                DAO_GoiDichVu.Delete(SelectedItemGDV.GDV_MA);

                ListGoiDichVu = DAO_GoiDichVu.GetList();
            }
            );

            CommandClearGDV = new RelayCommand<object>((p) =>
            {
                
                return true;
            }, (p) =>
            {
                GDV_MA = "";
                GDV_TEN = "";
                GDV_SOLAN = 0;
                GDV_DONGIA = "";
                GDV_MOTA = "";
                GDV_ANH = "";
                CheckedCoLieuTrinh = false;
                CheckedKhongLieuTrinh = false;
                CheckedKhongLieuTrinh = false;
                HiddenSoLanLieuTrinh = Visibility.Visible;
                SelectedDV = null;
                SelectedPP = null;
                SelectedItemGDV = null;

                ListGoiDichVu = DAO_GoiDichVu.GetList();
            }
            );

            CommandInThongTinGDV = new RelayCommand<object>((p) =>
            {
                if (SelectedItemGDV == null || SelectedItemGDV.GOIDICHVU.LGDV_MA == 2)
                    return false;

                return true;
            }, (p) =>
            {
                GDV_DATA = SelectedItemGDV;
                W_InThongTinGoiDichVu window = new W_InThongTinGoiDichVu();
                window.ShowDialog();
                GDV_DATA = null;
            }
            );
        }
    }
}
