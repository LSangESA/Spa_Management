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

namespace LVTN_QLSpa.ViewModel.NVQL_QuanTriHeThong
{
    public class ThemPhuTrachDichVuViewModel : BaseViewModel
    {
        #region Lập phụ trách cho từng nhân viên

        private bool _CheckAllGDVLoc;
        public bool CheckAllGDVLoc { get => _CheckAllGDVLoc; set { _CheckAllGDVLoc = value; OnPropertyChanged(); } }

        private bool _CheckCoLieuTrinh;
        public bool CheckCoLieuTrinh { get => _CheckCoLieuTrinh; set { _CheckCoLieuTrinh = value; OnPropertyChanged(); } }

        private bool _CheckKhongLieuTrinh;
        public bool CheckKhongLieuTrinh { get => _CheckKhongLieuTrinh; set { _CheckKhongLieuTrinh = value; OnPropertyChanged(); } }

        private string _NV_ANH;
        public string NV_ANH { get => _NV_ANH; set { _NV_ANH = value; OnPropertyChanged(); } }

        private string _NV_MA;
        public string NV_MA { get => _NV_MA; set { _NV_MA = value; OnPropertyChanged(); } }

        private string _NV_HOTEN;
        public string NV_HOTEN { get => _NV_HOTEN; set { _NV_HOTEN = value; OnPropertyChanged(); } }

        private DateTime _NV_NGAYSINH;
        public DateTime NV_NGAYSINH { get => _NV_NGAYSINH; set { _NV_NGAYSINH = value; OnPropertyChanged(); } }

        private string _NV_CCCD;
        public string NV_CCCD { get => _NV_CCCD; set { _NV_CCCD = value; OnPropertyChanged(); } }

        private string _NV_SDT;
        public string NV_SDT { get => _NV_SDT; set { _NV_SDT = value; OnPropertyChanged(); } }

        private string _NV_EMAIL;
        public string NV_EMAIL { get => _NV_EMAIL; set { _NV_EMAIL = value; OnPropertyChanged(); } }

        private string _NV_GIOITINH;
        public string NV_GIOITINH { get => _NV_GIOITINH; set { _NV_GIOITINH = value; OnPropertyChanged(); } }

        private string _VT_TEN;
        public string VT_TEN { get => _VT_TEN; set { _VT_TEN = value; OnPropertyChanged(); } }

        private string _CM_TEN;
        public string CM_TEN { get => _CM_TEN; set { _CM_TEN = value; OnPropertyChanged(); } }

        private ObservableCollection<NHANVIEN> _NHANVIEN;
        public ObservableCollection<NHANVIEN> NHANVIEN { get => _NHANVIEN; set { _NHANVIEN = value; OnPropertyChanged(); } }

        private ObservableCollection<CHUYENMON> _CHUYENMON;
        public ObservableCollection<CHUYENMON> CHUYENMON { get => _CHUYENMON; set { _CHUYENMON = value; OnPropertyChanged(); } }

        private ObservableCollection<VAITRO> _VAITRO;
        public ObservableCollection<VAITRO> VAITRO { get => _VAITRO; set { _VAITRO = value; OnPropertyChanged(); } }

        private ObservableCollection<ClassGoiDichVu> _ListGoiDichVuNhanVien;
        public ObservableCollection<ClassGoiDichVu> ListGoiDichVuNhanVien { get => _ListGoiDichVuNhanVien; set { _ListGoiDichVuNhanVien = value; OnPropertyChanged(); } }

        private ObservableCollection<ClassGoiDichVu> _ListGoiDichVu;
        public ObservableCollection<ClassGoiDichVu> ListGoiDichVu { get => _ListGoiDichVu; set { _ListGoiDichVu = value; OnPropertyChanged(); } }

        private ObservableCollection<DICHVU> _DICHVU;
        public ObservableCollection<DICHVU> DICHVU { get => _DICHVU; set { _DICHVU = value; OnPropertyChanged(); } }

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

        private CHUYENMON _SelectedCHUYENMON;
        public CHUYENMON SelectedCHUYENMON
        {
            get => _SelectedCHUYENMON;
            set
            {
                _SelectedCHUYENMON = value;
                OnPropertyChanged();

            }
        }

        private NHANVIEN _SelectedNHANVIEN;
        public NHANVIEN SelectedNHANVIEN
        {
            get => _SelectedNHANVIEN;
            set
            {
                _SelectedNHANVIEN = value;
                OnPropertyChanged();

            }
        }

        private DICHVU _SelectedDICHVU;
        public DICHVU SelectedDICHVU
        {
            get => _SelectedDICHVU;
            set
            {
                _SelectedDICHVU = value;
                OnPropertyChanged();

            }
        }

        public ICommand LoadWindow { get; set; }
        public ICommand CommandSelectionVAITRO { get; set; }
        public ICommand CommandSelectionCHUYENMON { get; set; }
        public ICommand CommandSelectedNHANVIEN { get; set; }
        public ICommand CommandCheckAllGDVNV { get; set; }
        public ICommand CommandUnCheckAllGDVNV { get; set; }
        public ICommand CommandDeletePhuTrach { get; set; }
        public ICommand CommandSelectionDICHVU { get; set; }
        public ICommand CommandAllGoiDichVu { get; set; }
        public ICommand CommandCheckCoLieuTrinh { get; set; }
        public ICommand CommandCheckKhongLieuTrinh { get; set; }
        public ICommand CommandCheckAllGDV { get; set; }
        public ICommand CommandUnCheckAllGDV { get; set; }
        public ICommand CommandAddPhuTrachDichVu { get; set; }
        public ICommand CommandClose { get; set; }

        #endregion

        #region Lập phụ trách cho nhiều nhân viên

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

                if (SelectedGOIDICHVU != null)
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

        public ICommand CommandMoveRight { get; set; }
        public ICommand CommandMoveLeft { get; set; }
        public ICommand CommandMoveRightAll { get; set; }
        public ICommand CommandMoveLeftAll { get; set; }
        public ICommand CommandSelectionVAITRO_NV { get; set; }
        public ICommand CommandSelectionCHUYENMON_NV { get; set; }
        public ICommand CommandSelectionDICHVU_NV { get; set; }
        public ICommand CommandSelectionGOIDICHVU { get; set; }
        public ICommand CommandAddPhuTrachDV { get; set; }

        #endregion

        public ThemPhuTrachDichVuViewModel()
        {
            #region Chức năng lập phụ trách cho từng nhân viên

            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                VAITRO = new ObservableCollection<VAITRO>(DataProvider.Ins.DB.VAITRO.Where(x => x.VT_MA == 2 || x.VT_MA == 3));
                CHUYENMON = DAO_ChuyenMon.GetList();
                NHANVIEN = DAO_NhanVien.GetList();
                DICHVU = DAO_DichVu.GetList();
                CheckAllGDVLoc = true;

                LoadPhuTrachNhieuNhanVien();
            }
            );

            CommandSelectionVAITRO = new RelayCommand<object>((p) =>
            {
                if (SelectedVAITRO == null)
                    return false;

                return true;
            }, (p) =>
            {
                CHUYENMON = DAO_ChuyenMon.GetList(SelectedVAITRO.VT_MA);
            }
            );

            CommandSelectionCHUYENMON = new RelayCommand<object>((p) =>
            {
                if (SelectedCHUYENMON == null)
                    return false;

                return true;
            }, (p) =>
            {
                NHANVIEN = new ObservableCollection<NHANVIEN>(DataProvider.Ins.DB.CHUYENMONNHANVIEN.Where(x => x.CM_MA == SelectedCHUYENMON.CM_MA).Select(x => x.NHANVIEN));
            }
            );

            CommandSelectedNHANVIEN = new RelayCommand<object>((p) =>
            {
                if (SelectedNHANVIEN == null)
                    return false;

                return true;
            }, (p) =>
            {
                LoadThongTinNhanVien(SelectedNHANVIEN);
                ListGoiDichVuNhanVien = GetListGoiDichVuNhanVien(SelectedNHANVIEN.NV_MA, false);
                SelectedDICHVU = null;
                ListGoiDichVu = new ObservableCollection<ClassGoiDichVu>();
            }
            );

            CommandCheckAllGDVNV = new RelayCommand<object>((p) =>
            {
                if (ListGoiDichVuNhanVien == null || SelectedNHANVIEN == null)
                    return false;

                return true;
            }, (p) =>
            {
                ListGoiDichVuNhanVien = GetListGoiDichVuNhanVien(SelectedNHANVIEN.NV_MA, true);
            }
            );

            CommandUnCheckAllGDVNV = new RelayCommand<object>((p) =>
            {
                if (ListGoiDichVuNhanVien == null || SelectedNHANVIEN == null)
                    return false;

                return true;
            }, (p) =>
            {
                ListGoiDichVuNhanVien = GetListGoiDichVuNhanVien(SelectedNHANVIEN.NV_MA, false);
            }
            );

            CommandDeletePhuTrach = new RelayCommand<object>((p) =>
            {
                if (ListGoiDichVuNhanVien == null || SelectedNHANVIEN == null)
                    return false;

                return true;
            }, (p) =>
            {
                DeletePhuTrachDichVuNhanVien(ListGoiDichVuNhanVien, SelectedNHANVIEN);
                ListGoiDichVuNhanVien = GetListGoiDichVuNhanVien(SelectedNHANVIEN.NV_MA, false);
                
                if(SelectedDICHVU != null && ListGoiDichVu != null)
                {
                    ListGoiDichVu = GetListGoiDichVu(SelectedNHANVIEN.NV_MA, SelectedDICHVU.DV_MA, false, CheckAllGDVLoc, CheckCoLieuTrinh, CheckKhongLieuTrinh);
                }
            }
            );

            CommandSelectionDICHVU = new RelayCommand<object>((p) =>
            {
                if (SelectedDICHVU == null)
                    return false;

                return true;
            }, (p) =>
            {
                ListGoiDichVu = GetListGoiDichVu(SelectedNHANVIEN.NV_MA, SelectedDICHVU.DV_MA, false, CheckAllGDVLoc, CheckCoLieuTrinh, CheckKhongLieuTrinh);
            }
            );

            CommandAllGoiDichVu = new RelayCommand<object>((p) =>
            {
                if (SelectedDICHVU == null)
                    return false;

                return true;
            }, (p) =>
            {
                ListGoiDichVu = GetListGoiDichVu(SelectedNHANVIEN.NV_MA, SelectedDICHVU.DV_MA, false, CheckAllGDVLoc, CheckCoLieuTrinh, CheckKhongLieuTrinh);
            }
            );

            CommandCheckCoLieuTrinh = new RelayCommand<object>((p) =>
            {
                if (SelectedDICHVU == null)
                    return false;

                return true;
            }, (p) =>
            {
                ListGoiDichVu = GetListGoiDichVu(SelectedNHANVIEN.NV_MA, SelectedDICHVU.DV_MA, false, CheckAllGDVLoc, CheckCoLieuTrinh, CheckKhongLieuTrinh);
            }
            );

            CommandCheckKhongLieuTrinh = new RelayCommand<object>((p) =>
            {
                if (SelectedDICHVU == null)
                    return false;

                return true;
            }, (p) =>
            {
                ListGoiDichVu = GetListGoiDichVu(SelectedNHANVIEN.NV_MA, SelectedDICHVU.DV_MA, false, CheckAllGDVLoc, CheckCoLieuTrinh, CheckKhongLieuTrinh);
            }
            );

            CommandCheckAllGDV = new RelayCommand<object>((p) =>
            {
                if (SelectedDICHVU == null)
                    return false;

                return true;
            }, (p) =>
            {
                ListGoiDichVu = GetListGoiDichVu(SelectedNHANVIEN.NV_MA, SelectedDICHVU.DV_MA, true, CheckAllGDVLoc, CheckCoLieuTrinh, CheckKhongLieuTrinh);
            }
            );

            CommandUnCheckAllGDV = new RelayCommand<object>((p) =>
            {
                if (SelectedDICHVU == null)
                    return false;

                return true;
            }, (p) =>
            {
                ListGoiDichVu = GetListGoiDichVu(SelectedNHANVIEN.NV_MA, SelectedDICHVU.DV_MA, false, CheckAllGDVLoc, CheckCoLieuTrinh, CheckKhongLieuTrinh);
            }
            );

            CommandAddPhuTrachDichVu = new RelayCommand<object>((p) =>
            {
                if (SelectedNHANVIEN == null || ListGoiDichVu == null || SelectedDICHVU == null)
                    return false;

                return true;
            }, (p) =>
            {
                AddPhuTrachDichVuNhanVien(ListGoiDichVu, SelectedNHANVIEN);
                ListGoiDichVu = GetListGoiDichVu(SelectedNHANVIEN.NV_MA, SelectedDICHVU.DV_MA, false, CheckAllGDVLoc, CheckCoLieuTrinh, CheckKhongLieuTrinh);
                ListGoiDichVuNhanVien = GetListGoiDichVuNhanVien(SelectedNHANVIEN.NV_MA, false);
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

            #endregion

            #region Chức năng lập phụ trách cho nhiều nhân viên

            CommandMoveRight = new RelayCommand<object>((p) =>
            {
                if (SelectedListNhanVienChuaPhuTrach == null || SelectedCHUYENMON_NV == null || SelectedGOIDICHVU == null)
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
                if (SelectedListNhanVienPhuTrach == null || SelectedCHUYENMON_NV == null || SelectedGOIDICHVU == null)
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
                if (ListNhanVienPhuTrach == null || SelectedCHUYENMON_NV == null || SelectedGOIDICHVU == null)
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
                if (SelectedGOIDICHVU == null || ListNhanVienChuaPhuTrach == null || SelectedGOIDICHVU == null)
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

            CommandSelectionDICHVU_NV = new RelayCommand<object>((p) =>
            {
                if (SelectedDV_NV == null)
                    return false;
                return true;
            }, (p) =>
            {
                GOIDICHVU = new ObservableCollection<GOIDICHVU>(DataProvider.Ins.DB.GOIDICHVU.Where(x => x.DV_MA == SelectedDV_NV.DV_MA));
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

                if (ListNhanVienChuaPhuTrach != null)
                {
                    foreach (var item in ListNhanVienPhuTrach.ToList())
                    {
                        foreach (var item2 in ListNhanVienChuaPhuTrach.ToList())
                        {
                            if (item == item2)
                            {
                                ListNhanVienChuaPhuTrach.Remove(item2);
                            }
                        }
                    }
                }
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
                foreach (var item in getListPhuTrachGoi)
                {
                    DataProvider.Ins.DB.PHUTRACHGOI.Remove(item);
                    DataProvider.Ins.DB.SaveChanges();
                }

                foreach (var item in ListNhanVienPhuTrach)
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

            CommandSelectionVAITRO_NV = new RelayCommand<object>((p) =>
            {
                if (SelectedVAITRO_NV == null)
                    return false;

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
                SelectedDV_NV = null;
                SelectedGOIDICHVU = null;
                ListNhanVienPhuTrach = new ObservableCollection<NHANVIEN>();

                var getNVChuaPhuTrach = new ObservableCollection<NHANVIEN>(DataProvider.Ins.DB.CHUYENMONNHANVIEN.Where(x => x.CM_MA == SelectedCHUYENMON_NV.CM_MA).Select(x => x.NHANVIEN));
                ListNhanVienChuaPhuTrach = getNVChuaPhuTrach;

                if (ListNhanVienPhuTrach != null)
                {
                    foreach (var item in ListNhanVienPhuTrach.ToList())
                    {
                        foreach (var item2 in getNVChuaPhuTrach.ToList())
                        {
                            if (item == item2)
                            {
                                getNVChuaPhuTrach.Remove(item2);
                            }
                        }
                    }
                    ListNhanVienChuaPhuTrach = getNVChuaPhuTrach;
                }
            }
            );

            #endregion
        }

        void LoadPhuTrachNhieuNhanVien()
        {
            VAITRO_NV = new ObservableCollection<VAITRO>(DataProvider.Ins.DB.VAITRO.Where(x => x.VT_MA == 2 || x.VT_MA == 3));
            CHUYENMON_NV = DAO_ChuyenMon.GetList();
            DICHVU_NV = DAO_DichVu.GetList();
            GOIDICHVU = new ObservableCollection<GOIDICHVU>(DataProvider.Ins.DB.GOIDICHVU);
        }

        void LoadThongTinNhanVien(NHANVIEN nhanVien)
        {
            NV_ANH = nhanVien.NV_ANH;
            NV_MA = nhanVien.NV_MA;
            NV_HOTEN = nhanVien.NV_HOTEN;
            NV_NGAYSINH = nhanVien.NV_NGAYSINH;
            NV_CCCD = nhanVien.NV_CCCD;
            NV_SDT = nhanVien.NV_SDT;
            NV_EMAIL = nhanVien.NV_EMAIL;
            NV_GIOITINH = nhanVien.NV_GIOITINH;
            VT_TEN = DAO_ChuyenMon.LayVaiTroNhanVien(nhanVien.NV_MA);
            CM_TEN = DAO_ChuyenMon.LayChuyenMonNhanVien(nhanVien.NV_MA);
        }

        ObservableCollection<ClassGoiDichVu> GetListGoiDichVuNhanVien(string NV_MA, bool trangThaiChon)
        {
            var nhanVienPhuTrach = DataProvider.Ins.DB.PHUTRACHGOI.Where(x => x.NV_MA == NV_MA).ToList();
            var goiDichVuNhanVien = new ObservableCollection<ClassGoiDichVu>();

            foreach(var item in nhanVienPhuTrach)
            {
                var goiDichVu = new ClassGoiDichVu()
                {
                    IsCheck = trangThaiChon,
                    GDV_ANH = item.GOIDICHVU.GDV_ANH,
                    GDV_TEN = item.GOIDICHVU.GDV_TEN,
                    GDV_MA = item.GOIDICHVU.GDV_MA,
                    LGDV_TEN = item.GOIDICHVU.LOAIGOIDICHVU.LGDV_TEN,
                    DONGIA = DAO_GoiDichVu.GetDonGiaGDV(item.GDV_MA)
                };

                goiDichVuNhanVien.Add(goiDichVu);
            }

            return goiDichVuNhanVien;
        }

        ObservableCollection<ClassGoiDichVu> GetListGoiDichVu(string NV_MA, string DV_MA, bool trangThaiChon, bool checkAllGDV, bool chonCoLieuTrinh, bool chonKhongLieuTrinh)
        {
            var listGoiDichVu = new ObservableCollection<ClassGoiDichVu>();
            if (checkAllGDV == true)
            {
                var getGoiDichVu = DataProvider.Ins.DB.GOIDICHVU.Where(x => x.DV_MA == DV_MA).ToList();
                var getGoiDichVuDaPhuTrach = GetDanhSachGoiDichVuNhanVienPhuTrach(NV_MA).ToList();

                // Lay ra nhung goi dich vu ma nhan vien do chua phu trach
                foreach(var item in getGoiDichVuDaPhuTrach.ToList())
                {
                    foreach(var item2 in getGoiDichVu.ToList())
                    {
                        if (item == item2)
                            getGoiDichVu.Remove(item2);
                    }
                }

                foreach (var item in getGoiDichVu)
                {
                    var goiDichVu = new ClassGoiDichVu()
                    {
                        IsCheck = trangThaiChon,
                        GDV_ANH = item.GDV_ANH,
                        GDV_TEN = item.GDV_TEN,
                        GDV_MA = item.GDV_MA,
                        LGDV_TEN = item.LOAIGOIDICHVU.LGDV_TEN,
                        DONGIA = DAO_GoiDichVu.GetDonGiaGDV(item.GDV_MA)
                    };

                    listGoiDichVu.Add(goiDichVu);
                }
            }
            else if (chonCoLieuTrinh == true)
            {
                var getGoiDichVu = DataProvider.Ins.DB.GOIDICHVU.Where(x => x.DV_MA == DV_MA && x.LGDV_MA == 1).ToList();
                var getGoiDichVuDaPhuTrach = GetDanhSachGoiDichVuNhanVienPhuTrach(NV_MA).ToList();

                // Lay ra nhung goi dich vu ma nhan vien do chua phu trach
                foreach (var item in getGoiDichVuDaPhuTrach.ToList())
                {
                    foreach (var item2 in getGoiDichVu.ToList())
                    {
                        if (item == item2)
                            getGoiDichVu.Remove(item2);
                    }
                }

                foreach (var item in getGoiDichVu)
                {
                    var goiDichVu = new ClassGoiDichVu()
                    {
                        IsCheck = trangThaiChon,
                        GDV_ANH = item.GDV_ANH,
                        GDV_TEN = item.GDV_TEN,
                        GDV_MA = item.GDV_MA,
                        LGDV_TEN = item.LOAIGOIDICHVU.LGDV_TEN,
                        DONGIA = DAO_GoiDichVu.GetDonGiaGDV(item.GDV_MA)
                    };

                    listGoiDichVu.Add(goiDichVu);
                }
            }
            else if(chonKhongLieuTrinh == true)
            {
                var getGoiDichVu = DataProvider.Ins.DB.GOIDICHVU.Where(x => x.DV_MA == DV_MA && x.LGDV_MA == 2).ToList();
                var getGoiDichVuDaPhuTrach = GetDanhSachGoiDichVuNhanVienPhuTrach(NV_MA).ToList();

                // Lay ra nhung goi dich vu ma nhan vien do chua phu trach
                foreach (var item in getGoiDichVuDaPhuTrach.ToList())
                {
                    foreach (var item2 in getGoiDichVu.ToList())
                    {
                        if (item == item2)
                            getGoiDichVu.Remove(item2);
                    }
                }

                foreach (var item in getGoiDichVu)
                {
                    var goiDichVu = new ClassGoiDichVu()
                    {
                        IsCheck = trangThaiChon,
                        GDV_ANH = item.GDV_ANH,
                        GDV_TEN = item.GDV_TEN,
                        GDV_MA = item.GDV_MA,
                        LGDV_TEN = item.LOAIGOIDICHVU.LGDV_TEN,
                        DONGIA = DAO_GoiDichVu.GetDonGiaGDV(item.GDV_MA)
                    };

                    listGoiDichVu.Add(goiDichVu);
                }
            }

            return listGoiDichVu;
        }

        public ObservableCollection<GOIDICHVU> GetDanhSachGoiDichVuNhanVienPhuTrach(string NV_MA)
        {
            return new ObservableCollection<GOIDICHVU>(DataProvider.Ins.DB.PHUTRACHGOI.Where(x => x.NV_MA == NV_MA).Select(x => x.GOIDICHVU));
        }

        public void DeletePhuTrachDichVuNhanVien(ObservableCollection<ClassGoiDichVu> listGDVNhanVien, NHANVIEN nhanVien)
        {
            if(listGDVNhanVien != null)
            {
                var layGoiDichVuChonXoa = listGDVNhanVien.Where(x => x.IsCheck == true).ToList();

                foreach (var item in layGoiDichVuChonXoa)
                {
                    var phuTrachDichVu = DataProvider.Ins.DB.PHUTRACHGOI.Where(x => x.GDV_MA == item.GDV_MA && x.NV_MA == nhanVien.NV_MA).SingleOrDefault();
                    DataProvider.Ins.DB.PHUTRACHGOI.Remove(phuTrachDichVu);
                    DataProvider.Ins.DB.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Danh sách rỗng", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void AddPhuTrachDichVuNhanVien(ObservableCollection<ClassGoiDichVu> listGDVNhanVien, NHANVIEN nhanVien)
        {
            if (listGDVNhanVien != null)
            {
                var layGoiDichVuChonXoa = listGDVNhanVien.Where(x => x.IsCheck == true).ToList();

                foreach (var item in layGoiDichVuChonXoa)
                {
                    var phuTrachGoi = new PHUTRACHGOI();
                    phuTrachGoi.GDV_MA = item.GDV_MA;
                    phuTrachGoi.NV_MA = nhanVien.NV_MA;
                    phuTrachGoi.PTG_NGAY = DateTime.Now;
                    phuTrachGoi.PTG_TRANGTHAI = "Đang thực hiện";

                    DataProvider.Ins.DB.PHUTRACHGOI.Add(phuTrachGoi);
                    DataProvider.Ins.DB.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Danh sách rỗng", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
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
    }
}
