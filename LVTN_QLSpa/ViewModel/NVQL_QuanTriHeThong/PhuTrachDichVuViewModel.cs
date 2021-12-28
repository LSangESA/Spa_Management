using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLNV;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace LVTN_QLSpa.ViewModel.NVQL_QuanTriHeThong
{
    public class PhuTrachDichVuViewModel : BaseViewModel
    {
        private string _KeySearch;
        public string KeySearch { get => _KeySearch; set { _KeySearch = value; OnPropertyChanged(); } }

        private ObservableCollection<DICHVU> _DICHVU;
        public ObservableCollection<DICHVU> DICHVU { get => _DICHVU; set { _DICHVU = value; OnPropertyChanged(); } }

        private ObservableCollection<DG_GDV> _ListGDV;
        public ObservableCollection<DG_GDV> ListGDV { get => _ListGDV; set { _ListGDV = value; OnPropertyChanged(); } }

        private ObservableCollection<VAITRO> _VAITRO;
        public ObservableCollection<VAITRO> VAITRO { get => _VAITRO; set { _VAITRO = value; OnPropertyChanged(); } }

        private ObservableCollection<NHANVIEN> _ListNhanVien;
        public ObservableCollection<NHANVIEN> ListNhanVien { get => _ListNhanVien; set { _ListNhanVien = value; OnPropertyChanged(); } }

        private ObservableCollection<VAITRO> _VAITRO_NV;
        public ObservableCollection<VAITRO> VAITRO_NV { get => _VAITRO_NV; set { _VAITRO_NV = value; OnPropertyChanged(); } }

        private ObservableCollection<CHUYENMON> _CHUYENMON_NV;
        public ObservableCollection<CHUYENMON> CHUYENMON_NV { get => _CHUYENMON_NV; set { _CHUYENMON_NV = value; OnPropertyChanged(); } }

        private ObservableCollection<NHANVIEN> _ListNhanVienChuaPhuTrach;
        public ObservableCollection<NHANVIEN> ListNhanVienChuaPhuTrach { get => _ListNhanVienChuaPhuTrach; set { _ListNhanVienChuaPhuTrach = value; OnPropertyChanged(); } }

        private ObservableCollection<DICHVU> _DICHVU_NV;
        public ObservableCollection<DICHVU> DICHVU_NV { get => _DICHVU_NV; set { _DICHVU_NV = value; OnPropertyChanged(); } }

        private ObservableCollection<GOIDICHVU> _GOIDICHVU;
        public ObservableCollection<GOIDICHVU> GOIDICHVU { get => _GOIDICHVU; set { _GOIDICHVU = value; OnPropertyChanged(); } }

        private ObservableCollection<NHANVIEN> _ListNhanVienPhuTrach;
        public ObservableCollection<NHANVIEN> ListNhanVienPhuTrach { get => _ListNhanVienPhuTrach; set { _ListNhanVienPhuTrach = value; OnPropertyChanged(); } }

        private DICHVU _SelectedDV;
        public DICHVU SelectedDV
        {
            get => _SelectedDV;
            set
            {
                _SelectedDV = value;
                OnPropertyChanged();

                if(SelectedDV != null)
                {
                    ListGDV = new ObservableCollection<DG_GDV>(DataProvider.Ins.DB.DG_GDV.Where(x => x.GOIDICHVU.DV_MA == SelectedDV.DV_MA));
                }
            }
        }

        private DG_GDV _SelectedGDV;
        public DG_GDV SelectedGDV
        {
            get => _SelectedGDV;
            set
            {
                _SelectedGDV = value;
                OnPropertyChanged();
            }
        }

        private VAITRO _SelectedVAITRO;
        public VAITRO SelectedVAITRO
        {
            get => _SelectedVAITRO;
            set
            {
                _SelectedVAITRO = value;
                OnPropertyChanged();
            }
        }

        private NHANVIEN _SelectedItemNhanVien;
        public NHANVIEN SelectedItemNhanVien
        {
            get => _SelectedItemNhanVien;
            set
            {
                _SelectedItemNhanVien = value;
                OnPropertyChanged();
            }
        }

        private VAITRO _SelectedVAITRO_NV;
        public VAITRO SelectedVAITRO_NV
        {
            get => _SelectedVAITRO_NV;
            set
            {
                _SelectedVAITRO_NV = value;
                OnPropertyChanged();
                
            }
        }

        private CHUYENMON _SelectedCHUYENMON_NV;
        public CHUYENMON SelectedCHUYENMON_NV
        {
            get => _SelectedCHUYENMON_NV;
            set
            {
                _SelectedCHUYENMON_NV = value;
                OnPropertyChanged();
            }
        }

        private NHANVIEN _SelectedListNhanVienChuaPhuTrach;
        public NHANVIEN SelectedListNhanVienChuaPhuTrach
        {
            get => _SelectedListNhanVienChuaPhuTrach;
            set
            {
                _SelectedListNhanVienChuaPhuTrach = value;
                OnPropertyChanged();
            }
        }

        private DICHVU _SelectedDV_NV;
        public DICHVU SelectedDV_NV
        {
            get => _SelectedDV_NV;
            set
            {
                _SelectedDV_NV = value;
                OnPropertyChanged();

                if(SelectedDV_NV != null)
                {
                    GOIDICHVU = new ObservableCollection<GOIDICHVU>(DataProvider.Ins.DB.GOIDICHVU.Where(x => x.DV_MA == SelectedDV_NV.DV_MA));
                }
            }
        }

        private GOIDICHVU _SelectedGOIDICHVU;
        public GOIDICHVU SelectedGOIDICHVU
        {
            get => _SelectedGOIDICHVU;
            set
            {
                _SelectedGOIDICHVU = value;
                OnPropertyChanged();

                if(SelectedGOIDICHVU != null)
                {
                    ListNhanVienPhuTrach = new ObservableCollection<NHANVIEN>(DataProvider.Ins.DB.PHUTRACHGOI.Where(x => x.GDV_MA == SelectedGOIDICHVU.GDV_MA).Select(x => x.NHANVIEN));
                }
            }
        }

        private NHANVIEN _SelectedListNhanVienPhuTrach;
        public NHANVIEN SelectedListNhanVienPhuTrach
        {
            get => _SelectedListNhanVienPhuTrach;
            set
            {
                _SelectedListNhanVienPhuTrach = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoadWindow { get; set; }
        public ICommand CommandKeySearch { get; set; }
        public ICommand CommandLapPhuTrach { get; set; }
        public ICommand CommandSelectionGDV { get; set; }
        public ICommand CommandSelectionVaiTro { get; set; }
        public ICommand CommandAddPhuTrachDV { get; set; }
        public ICommand CommandMoveRight { get; set; }
        public ICommand CommandMoveLeft { get; set; }
        public ICommand CommandMoveRightAll { get; set; }
        public ICommand CommandMoveLeftAll { get; set; }
        public ICommand CommandSelectionVAITRO_NV { get; set; }
        public ICommand CommandSelectionCHUYENMON_NV { get; set; }
        public ICommand CommandSelectionGOIDICHVU { get; set; }

        private bool UserFilter(object item)
        {
            if (String.IsNullOrEmpty(KeySearch))
                return true;
            else
                return ((item as NHANVIEN).NV_MA.IndexOf(KeySearch, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as NHANVIEN).NV_HOTEN.IndexOf(KeySearch, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as NHANVIEN).NV_SDT.IndexOf(KeySearch, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as NHANVIEN).NV_EMAIL.IndexOf(KeySearch, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as NHANVIEN).NV_CCCD.IndexOf(KeySearch, StringComparison.OrdinalIgnoreCase) >= 0); /*|| (item as ListInvoice).NGAYLAP.ToString().IndexOf(TextFilter, StringComparison.OrdinalIgnoreCase) >= 0*/
        }

        public PhuTrachDichVuViewModel()
        {
            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                LoadListPhuTrachDV();

                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(ListNhanVien);
                view.Filter = UserFilter;
            }
            );

            CommandKeySearch = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                CollectionViewSource.GetDefaultView(ListNhanVien).Refresh();
            }
            );

            CommandLapPhuTrach = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                W_ThemPhuTrachDichVu window = new W_ThemPhuTrachDichVu();
                window.ShowDialog();
            }
            );

            CommandSelectionGDV = new RelayCommand<object>((p) =>
            {
                if (SelectedGDV == null)
                    return false;

                return true;
            }, (p) =>
            {
                ListNhanVien = new ObservableCollection<NHANVIEN>(DataProvider.Ins.DB.PHUTRACHGOI.Where(x => x.GDV_MA == SelectedGDV.GDV_MA).Select(x=>x.NHANVIEN));
            }
            );

            CommandSelectionVaiTro = new RelayCommand<object>((p) =>
            {
                if (SelectedGDV == null || SelectedVAITRO == null)
                    return false;

                return true;
            }, (p) =>
            {
                var getNhanVienVaiTro = DAO_NhanVien.GetList(SelectedVAITRO.VT_MA);
                var getNhanVienPhuTrachGDV = DataProvider.Ins.DB.PHUTRACHGOI.Where(x => x.GDV_MA == SelectedGDV.GDV_MA).Select(x=>x.NHANVIEN);
                

                foreach(var item in getNhanVienPhuTrachGDV.ToList())
                {
                    foreach(var item2 in getNhanVienVaiTro.ToList())
                    {
                        if(item == item2)
                        {
                            ListNhanVien.Add(item2);
                        }
                    }
                }
                ListNhanVien = new ObservableCollection<NHANVIEN>(ListNhanVien.ToList().Distinct());
            }
            );

            CommandAddPhuTrachDV = new RelayCommand<object>((p) =>
            {
                if (ListNhanVienPhuTrach == null || ListNhanVienPhuTrach.Count() == 0)
                    return false;

                return true;
            }, (p) =>
            {
                var getListPhuTrachGoi = DataProvider.Ins.DB.PHUTRACHGOI.Where(x => x.GDV_MA == SelectedGOIDICHVU.GDV_MA).ToList();
                foreach(var item in getListPhuTrachGoi)
                {
                    DataProvider.Ins.DB.PHUTRACHGOI.Remove(item);
                    DataProvider.Ins.DB.SaveChanges();
                }

                foreach(var item in ListNhanVienPhuTrach)
                {
                    var phuTrachGoi = new PHUTRACHGOI();
                    phuTrachGoi.GDV_MA = SelectedGOIDICHVU.GDV_MA;
                    phuTrachGoi.NV_MA = item.NV_MA;
                    phuTrachGoi.PTG_NGAY = DateTime.Now;
                    phuTrachGoi.PTG_TRANGTHAI = "Đang thực hiện";

                    DataProvider.Ins.DB.PHUTRACHGOI.Add(phuTrachGoi);
                    DataProvider.Ins.DB.SaveChanges();
                }
            }
            );

            CommandMoveRight = new RelayCommand<object>((p) =>
            {
                if (SelectedListNhanVienChuaPhuTrach == null)
                    return false;

                return true;
            }, (p) =>
            {
                ListNhanVienPhuTrach.Add(SelectedListNhanVienChuaPhuTrach);
                ListNhanVienChuaPhuTrach.Remove(SelectedListNhanVienChuaPhuTrach);
            }
            );

            CommandMoveLeft = new RelayCommand<object>((p) =>
            {
                if (SelectedListNhanVienPhuTrach == null)
                    return false;

                return true;
            }, (p) =>
            {
                ListNhanVienChuaPhuTrach.Add(SelectedListNhanVienPhuTrach);
                ListNhanVienPhuTrach.Remove(SelectedListNhanVienPhuTrach);
            }
            );

            CommandMoveRightAll = new RelayCommand<object>((p) =>
            {
                if (ListNhanVienPhuTrach == null || SelectedCHUYENMON_NV == null)
                    return false;

                return true;
            }, (p) =>
            {
                foreach (var item in ListNhanVienChuaPhuTrach.ToList())
                {
                    ListNhanVienPhuTrach.Add(item);
                    ListNhanVienChuaPhuTrach.Remove(item);
                }
            }
            );

            CommandMoveLeftAll = new RelayCommand<object>((p) =>
            {
                if (SelectedGOIDICHVU == null || ListNhanVienChuaPhuTrach == null)
                    return false;

                return true;
            }, (p) =>
            {
                foreach (var item in ListNhanVienPhuTrach.ToList())
                {
                    ListNhanVienChuaPhuTrach.Add(item);
                    ListNhanVienPhuTrach.Remove(item);
                }
            }
            );

            CommandSelectionVAITRO_NV = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                CHUYENMON_NV = DAO_ChuyenMon.GetList(SelectedVAITRO_NV.VT_MA);
            }
            );

            CommandSelectionCHUYENMON_NV = new RelayCommand<object>((p) =>
            {
                if (SelectedCHUYENMON_NV == null)
                    return false;

                return true;
            }, (p) =>
            {
                var getNVChuaPhuTrach = new ObservableCollection<NHANVIEN>(DataProvider.Ins.DB.CHUYENMONNHANVIEN.Where(x => x.CM_MA == SelectedCHUYENMON_NV.CM_MA).Select(x => x.NHANVIEN));
                ListNhanVienChuaPhuTrach = getNVChuaPhuTrach;

                if(ListNhanVienPhuTrach != null)
                {
                    foreach (var item in ListNhanVienPhuTrach.ToList())
                    {
                        foreach(var item2 in getNVChuaPhuTrach.ToList())
                        {
                            if(item == item2)
                            {
                                getNVChuaPhuTrach.Remove(item2);
                            }
                        }
                    }
                    ListNhanVienChuaPhuTrach = getNVChuaPhuTrach;
                }
            }
            );

            CommandSelectionGOIDICHVU = new RelayCommand<object>((p) =>
            {
                if (SelectedGOIDICHVU == null)
                    return false;

                return true;
            }, (p) =>
            {
                ListNhanVienPhuTrach = new ObservableCollection<NHANVIEN>(DataProvider.Ins.DB.PHUTRACHGOI.Where(x => x.GDV_MA == SelectedGOIDICHVU.GDV_MA).Select(x => x.NHANVIEN));

                if(ListNhanVienChuaPhuTrach != null)
                {
                    foreach(var item in ListNhanVienPhuTrach.ToList())
                    {
                        foreach(var item2 in ListNhanVienChuaPhuTrach.ToList())
                        {
                            if(item == item2)
                            {
                                ListNhanVienChuaPhuTrach.Remove(item2);
                            }
                        }
                    }
                }
            }
            );
        }

        void LoadListPhuTrachDV()
        {
            DICHVU = DAO_DichVu.GetList();
            VAITRO_NV = new ObservableCollection<VAITRO>(DataProvider.Ins.DB.VAITRO.Where(x => x.VT_MA == 2 || x.VT_MA == 3));
            DICHVU_NV = DAO_DichVu.GetList();
            ListNhanVien = new ObservableCollection<NHANVIEN>();

        }
    }
}
