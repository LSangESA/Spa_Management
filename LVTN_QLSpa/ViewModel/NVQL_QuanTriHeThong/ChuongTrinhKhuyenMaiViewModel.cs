using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using LVTN_QLSpa.Model.ModelClass;
using LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLCTKM;
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
    public class ChuongTrinhKhuyenMaiViewModel : BaseViewModel
    {
        private static GIAMGIA giamGia_DATA;
        public static GIAMGIA GiamGia_DATA
        {
            get { return ChuongTrinhKhuyenMaiViewModel.giamGia_DATA; }
            set { ChuongTrinhKhuyenMaiViewModel.giamGia_DATA = value; }
        }

        #region Khai bao bien binding
        private string _KeySearch;
        public string KeySearch { get => _KeySearch; set { _KeySearch = value; OnPropertyChanged(); } }

        private string _GG_MA;
        public string GG_MA { get => _GG_MA; set { _GG_MA = value; OnPropertyChanged(); } }

        private string _GG_TEN;
        public string GG_TEN { get => _GG_TEN; set { _GG_TEN = value; OnPropertyChanged(); } }

        private string _GG_NOIDUNG;
        public string GG_NOIDUNG { get => _GG_NOIDUNG; set { _GG_NOIDUNG = value; OnPropertyChanged(); } }

        private int _GG_PHANTRAMGIAM;
        public int GG_PHANTRAMGIAM { get => _GG_PHANTRAMGIAM; set { _GG_PHANTRAMGIAM = value; OnPropertyChanged(); } }

        private bool _CheckGG_GDV;
        public bool CheckGG_GDV { get => _CheckGG_GDV; set { _CheckGG_GDV = value; OnPropertyChanged(); } }

        private bool _CheckGG_LT;
        public bool CheckGG_LT { get => _CheckGG_LT; set { _CheckGG_LT = value; OnPropertyChanged(); } }

        private DateTime _GG_NGAYBATDAU;
        public DateTime GG_NGAYBATDAU { get => _GG_NGAYBATDAU; set { _GG_NGAYBATDAU = value; OnPropertyChanged(); } }

        private DateTime _GG_NGAYKETTHUC;
        public DateTime GG_NGAYKETTHUC { get => _GG_NGAYKETTHUC; set { _GG_NGAYKETTHUC = value; OnPropertyChanged(); } }

        private bool _CheckAllGDV;
        public bool CheckAllGDV { get => _CheckAllGDV; set { _CheckAllGDV = value; OnPropertyChanged(); } }

        private bool _CheckAllDeleteGG;
        public bool CheckAllDeleteGG { get => _CheckAllDeleteGG; set { _CheckAllDeleteGG = value; OnPropertyChanged(); } }

        private bool _CheckGuiSMS;
        public bool CheckGuiSMS { get => _CheckGuiSMS; set { _CheckGuiSMS = value; OnPropertyChanged(); } }

        private bool _CheckGuiMail;
        public bool CheckGuiMail { get => _CheckGuiMail; set { _CheckGuiMail = value; OnPropertyChanged(); } }

        private string _GG_TRANGTHAI;
        public string GG_TRANGTHAI { get => _GG_TRANGTHAI; set { _GG_TRANGTHAI = value; OnPropertyChanged(); } }

        private ObservableCollection<TrangThai> _TRANGTHAIGG;
        public ObservableCollection<TrangThai> TRANGTHAIGG { get => _TRANGTHAIGG; set { _TRANGTHAIGG = value; OnPropertyChanged(); } }

        private ObservableCollection<DichVu> _DICHVU;
        public ObservableCollection<DichVu> DICHVU { get => _DICHVU; set { _DICHVU = value; OnPropertyChanged(); } }

        private ObservableCollection<ClassGoiDichVu> _ListGDV;
        public ObservableCollection<ClassGoiDichVu> ListGDV { get => _ListGDV; set { _ListGDV = value; OnPropertyChanged(); } }

        private ObservableCollection<GIAMGIA> _ListGiamGia;
        public ObservableCollection<GIAMGIA> ListGiamGia { get => _ListGiamGia; set { _ListGiamGia = value; OnPropertyChanged(); } }

        private ObservableCollection<ClassGoiDichVu> _ListGiamGiaGDV;
        public ObservableCollection<ClassGoiDichVu> ListGiamGiaGDV { get => _ListGiamGiaGDV; set { _ListGiamGiaGDV = value; OnPropertyChanged(); } }

        private ObservableCollection<TrangThai> _TrangThaiFilter;
        public ObservableCollection<TrangThai> TrangThaiFilter { get => _TrangThaiFilter; set { _TrangThaiFilter = value; OnPropertyChanged(); } }

        private ObservableCollection<LOAIGIAMGIA> _LoaiGiamGiaFilter;
        public ObservableCollection<LOAIGIAMGIA> LoaiGiamGiaFilter { get => _LoaiGiamGiaFilter; set { _LoaiGiamGiaFilter = value; OnPropertyChanged(); } }

        private TrangThai _SelectedTRANGTHAIGG;
        public TrangThai SelectedTRANGTHAIGG
        {
            get => _SelectedTRANGTHAIGG;
            set
            {
                _SelectedTRANGTHAIGG = value;
                OnPropertyChanged();
            }
        }

        private DichVu _SelectedDV;
        public DichVu SelectedDV
        {
            get => _SelectedDV;
            set
            {
                _SelectedDV = value;
                OnPropertyChanged();

                if(SelectedDV != null)
                {
                    GetGDVByDV(SelectedDV, false);
                }
            }
        }

        private GIAMGIA _SelectedItemGiamGia;
        public GIAMGIA SelectedItemGiamGia
        {
            get => _SelectedItemGiamGia;
            set
            {
                _SelectedItemGiamGia = value;
                OnPropertyChanged();

                if(SelectedItemGiamGia != null)
                {
                    GG_MA = SelectedItemGiamGia.GG_MA;
                    GG_TEN = SelectedItemGiamGia.GG_TEN;
                    GG_NGAYBATDAU = SelectedItemGiamGia.GG_NGAYBATDAU;
                    GG_NGAYKETTHUC = SelectedItemGiamGia.GG_NGAYKETTHUC;
                    GG_NOIDUNG = SelectedItemGiamGia.GG_NOIDUNG;
                    GG_PHANTRAMGIAM = SelectedItemGiamGia.GG_PHANTRAMGIAM;
                    SelectedTRANGTHAIGG = TRANGTHAIGG.Where(x => x.Name == SelectedItemGiamGia.GG_TRANGTHAI).SingleOrDefault();

                    // Lấy loai giảm giá
                    var getLoaiGiamGia = DataProvider.Ins.DB.LGG_GG.Where(x => x.GG_MA == SelectedItemGiamGia.GG_MA).ToList();
                    if(getLoaiGiamGia.Count > 1)
                    {
                        CheckGG_GDV = true;
                        CheckGG_LT = true;
                    }
                    else if(getLoaiGiamGia.Count == 1)
                    {
                        if(getLoaiGiamGia.SingleOrDefault().LGG_MA == 1)
                        {
                            CheckGG_GDV = true;
                            CheckGG_LT = false;
                        }
                        else
                        {
                            CheckGG_GDV = false;
                            CheckGG_LT = true;
                        }
                    }
                    else
                    {
                        CheckGG_GDV = false;
                        CheckGG_LT = false;
                    }

                    ListGiamGiaGDV = new ObservableCollection<ClassGoiDichVu>();
                    var getListGDVByGG = DataProvider.Ins.DB.GIAMGOIDICHVU.Where(x => x.GG_MA == SelectedItemGiamGia.GG_MA).ToList();
                    foreach(var item in getListGDVByGG)
                    {
                        ClassGoiDichVu gdv = new ClassGoiDichVu();
                        gdv.DV_MA = item.GOIDICHVU.DV_MA;
                        gdv.DV_TEN = item.GOIDICHVU.DICHVU.DV_TEN;
                        gdv.GDV_MA = item.GDV_MA;
                        gdv.GDV_TEN = item.GOIDICHVU.GDV_TEN;
                        gdv.LGDV_TEN = item.GOIDICHVU.LOAIGOIDICHVU.LGDV_TEN;
                        gdv.IsCheck = false;

                        ListGiamGiaGDV.Add(gdv);
                    }
                }
            }
        }

        private TrangThai _SelectedTrangThaiFilter;
        public TrangThai SelectedTrangThaiFilter
        {
            get => _SelectedTrangThaiFilter;
            set
            {
                _SelectedTrangThaiFilter = value;
                OnPropertyChanged();
            }
        }

        private LOAIGIAMGIA _SelectedLoaiGiamGiaFilter;
        public LOAIGIAMGIA SelectedLoaiGiamGiaFilter
        {
            get => _SelectedLoaiGiamGiaFilter;
            set
            {
                _SelectedLoaiGiamGiaFilter = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region ICommand

        public ICommand CommandAddIdGG { get; set; }
        public ICommand CommandCheckAllGDV { get; set; }
        public ICommand CommandUnCheckAllGDV { get; set; }
        public ICommand CommandCheckAllDeleteGDV { get; set; }
        public ICommand CommandUnCheckAllDeleteGDV { get; set; }
        public ICommand CommandDeleteItemGDV { get; set; }
        public ICommand CommandShowGTN { get; set; }
        public ICommand CommandAddGiamGDV { get; set; }
        public ICommand CommandAddGG { get; set; }
        public ICommand CommandEditGG { get; set; }
        public ICommand CommandDeleteGG { get; set; }
        public ICommand CommandClearGG { get; set; }
        public ICommand LoadWindow { get; set; }
        public ICommand CommnadLoc { get; set; }
        public ICommand CommandXoaLoc { get; set; }
        public ICommand CommandKeySearch { get; set; }

        #endregion

        private bool UserFilter(object item)
        {
            if (String.IsNullOrEmpty(KeySearch))
                return true;
            else
                return ((item as GIAMGIA).GG_MA.IndexOf(KeySearch, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as GIAMGIA).GG_TEN.IndexOf(KeySearch, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as GIAMGIA).GG_NGAYBATDAU.ToString().IndexOf(KeySearch, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as GIAMGIA).GG_NGAYKETTHUC.ToString().IndexOf(KeySearch, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as GIAMGIA).GG_TRANGTHAI.IndexOf(KeySearch, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as GIAMGIA).GG_PHANTRAMGIAM.ToString().IndexOf(KeySearch, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        public ChuongTrinhKhuyenMaiViewModel()
        {
            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                // Load du lieu
                GG_PHANTRAMGIAM = 0;
                CheckGG_GDV = true;
                CheckGuiMail = true;
                CheckGuiSMS = true;
                CheckGG_LT = true;
                GG_NGAYBATDAU = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                GG_NGAYKETTHUC = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

                TRANGTHAIGG = new ObservableCollection<TrangThai>();
                TRANGTHAIGG.Add(new TrangThai() { Name = "Sắp diễn ra" });
                TRANGTHAIGG.Add(new TrangThai() { Name = "Đang diễn ra" });
                TRANGTHAIGG.Add(new TrangThai() { Name = "Đã kết thúc" });
                TRANGTHAIGG.Add(new TrangThai() { Name = "Tạm ngưng" });

                LoadDichVu();
                TrangThaiFilter = TRANGTHAIGG;
                LoaiGiamGiaFilter = new ObservableCollection<LOAIGIAMGIA>(DataProvider.Ins.DB.LOAIGIAMGIA);
                ListGiamGia = DAO_GiamGia.GetList();

                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(ListGiamGia);
                view.Filter = UserFilter;
            }
            );

            CommandKeySearch = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                CollectionViewSource.GetDefaultView(ListGiamGia).Refresh();
            }
            );

            CommandAddIdGG = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                Random r = new Random();
                GG_MA = ClassXuLyChuoi.LocDau(ClassXuLyChuoi.GetName(GG_TEN, ""));
            }
            );

            CommandCheckAllGDV = new RelayCommand<object>((p) =>
            {
                if (SelectedDV == null)
                    return false;

                return true;
            }, (p) =>
            {
                GetGDVByDV(SelectedDV, true);
            }
            );

            CommandUnCheckAllGDV = new RelayCommand<object>((p) =>
            {
                if (SelectedDV == null)
                    return false;

                return true;
            }, (p) =>
            {
                GetGDVByDV(SelectedDV, false);
            }
            );

            CommandCheckAllDeleteGDV = new RelayCommand<object>((p) =>
            {
                if (SelectedItemGiamGia == null)
                    return false;

                return true;
            }, (p) =>
            {
                ListGiamGiaGDV = new ObservableCollection<ClassGoiDichVu>();
                var getListGDVByGG = DataProvider.Ins.DB.GIAMGOIDICHVU.Where(x => x.GG_MA == SelectedItemGiamGia.GG_MA).ToList();
                foreach (var item in getListGDVByGG)
                {
                    ClassGoiDichVu gdv = new ClassGoiDichVu();
                    gdv.DV_MA = item.GOIDICHVU.DV_MA;
                    gdv.DV_TEN = item.GOIDICHVU.DICHVU.DV_TEN;
                    gdv.GDV_MA = item.GDV_MA;
                    gdv.GDV_TEN = item.GOIDICHVU.GDV_TEN;
                    gdv.LGDV_TEN = item.GOIDICHVU.LOAIGOIDICHVU.LGDV_TEN;
                    gdv.IsCheck = true;

                    ListGiamGiaGDV.Add(gdv);
                }
            }
            );

            CommandUnCheckAllDeleteGDV = new RelayCommand<object>((p) =>
            {
                if (SelectedItemGiamGia == null)
                    return false;

                return true;
            }, (p) =>
            {
                ListGiamGiaGDV = new ObservableCollection<ClassGoiDichVu>();
                var getListGDVByGG = DataProvider.Ins.DB.GIAMGOIDICHVU.Where(x => x.GG_MA == SelectedItemGiamGia.GG_MA).ToList();
                foreach (var item in getListGDVByGG)
                {
                    ClassGoiDichVu gdv = new ClassGoiDichVu();
                    gdv.DV_MA = item.GOIDICHVU.DV_MA;
                    gdv.DV_TEN = item.GOIDICHVU.DICHVU.DV_TEN;
                    gdv.GDV_MA = item.GDV_MA;
                    gdv.GDV_TEN = item.GOIDICHVU.GDV_TEN;
                    gdv.LGDV_TEN = item.GOIDICHVU.LOAIGOIDICHVU.LGDV_TEN;
                    gdv.IsCheck = false;

                    ListGiamGiaGDV.Add(gdv);
                }
            }
            );

            CommandDeleteItemGDV = new RelayCommand<object>((p) =>
            {
                if (SelectedItemGiamGia == null)
                    return false;

                var giamGoiDichVuDelete = ListGiamGiaGDV.Where(x => x.IsCheck == true).ToList();
                if (giamGoiDichVuDelete.Count() == 0)
                    return false;

                return true;
            }, (p) =>
            {
                try
                {
                    var giamGoiDichVuDelete = ListGiamGiaGDV.Where(x => x.IsCheck == true).ToList();

                    foreach (var item in giamGoiDichVuDelete)
                    {
                        DAO_GiamGia.DeleteGG_GDV(item.GDV_MA, GG_MA);
                    }
                    DataProvider.Ins.DB.SaveChanges();


                    ListGiamGiaGDV = new ObservableCollection<ClassGoiDichVu>();
                    var getListGDVByGG = DataProvider.Ins.DB.GIAMGOIDICHVU.Where(x => x.GG_MA == GG_MA).ToList();
                    foreach (var item in getListGDVByGG)
                    {
                        ClassGoiDichVu gdv = new ClassGoiDichVu();
                        gdv.DV_MA = item.GOIDICHVU.DV_MA;
                        gdv.DV_TEN = item.GOIDICHVU.DICHVU.DV_TEN;
                        gdv.GDV_MA = item.GDV_MA;
                        gdv.GDV_TEN = item.GOIDICHVU.GDV_TEN;
                        gdv.LGDV_TEN = item.GOIDICHVU.LOAIGOIDICHVU.LGDV_TEN;
                        gdv.IsCheck = false;

                        ListGiamGiaGDV.Add(gdv);
                    }
                }
                catch
                {
                    MessageBox.Show("Phải chọn gói dịch vụ muốn xóa");
                }
            }
            );

            CommandShowGTN = new RelayCommand<object>((p) =>
            {
                if (SelectedItemGiamGia == null)
                    return false;

                return true;
            }, (p) =>
            {
                GiamGia_DATA = SelectedItemGiamGia;
                W_GuiTinNhan window = new W_GuiTinNhan();
                window.ShowDialog();
            }
            );

            CommandAddGG = new RelayCommand<object>((p) =>
            {
                var day = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                if (SelectedItemGiamGia != null || string.IsNullOrEmpty(GG_MA) || string.IsNullOrEmpty(GG_TEN) || GG_NGAYBATDAU < day || GG_NGAYKETTHUC < GG_NGAYBATDAU || SelectedDV == null)
                    return false;

                if (CheckGG_GDV == false && CheckGG_LT == false)
                    return false;

                return true;
            }, (p) =>
            {
                
                // Nếu như không chọn trạng thái thì tự động set
                if (SelectedTRANGTHAIGG == null)
                {
                    // Lay ngay hien tai
                    var day = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    if (day < GG_NGAYBATDAU)
                        GG_TRANGTHAI = "Sắp diễn ra";
                    else if (day >= GG_NGAYBATDAU && day <= GG_NGAYKETTHUC)
                        GG_TRANGTHAI = "Đang diễn ra";
                }
                else
                    GG_TRANGTHAI = SelectedTRANGTHAIGG.Name;

                // Add giam gia
                var giamgia = new GIAMGIA() { GG_MA = GG_MA, GG_TEN = GG_TEN, GG_NGAYBATDAU = GG_NGAYBATDAU, GG_NGAYKETTHUC = GG_NGAYKETTHUC, GG_NOIDUNG = GG_NOIDUNG, GG_TRANGTHAI = GG_TRANGTHAI, GG_PHANTRAMGIAM = GG_PHANTRAMGIAM};
                DAO_GiamGia.Add(giamgia);
                DataProvider.Ins.DB.SaveChanges();
                ListGiamGia.Add(giamgia);

                
                // Add Goi dich vu duoc giam
                var GetListCheckGoiDichVu = ListGDV.Where(x => x.IsCheck == true).ToList();
                foreach (var item in GetListCheckGoiDichVu)
                {
                    DAO_GiamGia.Add(item.GDV_MA, giamgia.GG_MA);
                }
                DataProvider.Ins.DB.SaveChanges();
                
                // Add GG_LGG
                if (CheckGG_GDV == true && CheckGG_LT == true)
                {
                    DAO_GiamGia.Add(GG_MA, 1);
                    DAO_GiamGia.Add(GG_MA, 2);
                }
                else if (CheckGG_GDV == true)
                {
                    DAO_GiamGia.Add(GG_MA, 1);
                }
                else if(CheckGG_LT == true)
                {
                    DAO_GiamGia.Add(GG_MA, 2);
                }
                DataProvider.Ins.DB.SaveChanges();
            }
            );

            CommandEditGG = new RelayCommand<object>((p) =>
            {
                var day = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                if (SelectedItemGiamGia == null || string.IsNullOrEmpty(GG_MA) || string.IsNullOrEmpty(GG_TEN) || GG_NGAYKETTHUC < GG_NGAYBATDAU)
                    return false;

                return true;
            }, (p) =>
            {
                // Nếu như không chọn trạng thái thì tự động set
                if (SelectedTRANGTHAIGG == null)
                {
                    // Lay ngay hien tai
                    var day = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    if (day < GG_NGAYBATDAU)
                        GG_TRANGTHAI = "Sắp diễn ra";
                    else if (day >= GG_NGAYBATDAU && day <= GG_NGAYKETTHUC)
                        GG_TRANGTHAI = "Đang diễn ra";
                    else if (day > GG_NGAYKETTHUC)
                        GG_TRANGTHAI = "Đã kết thúc";
                }
                else
                    GG_TRANGTHAI = SelectedTRANGTHAIGG.Name;

                // Edit giam gia
                DAO_GiamGia.Edit(GG_MA, GG_TEN, GG_NGAYBATDAU, GG_NGAYKETTHUC, GG_TRANGTHAI, GG_NOIDUNG, GG_PHANTRAMGIAM);

                // Edit loai giam gia
                DAO_GiamGia.EditLGG(GG_MA, CheckGG_GDV, CheckGG_LT);
                
                if(ListGDV != null && SelectedDV != null)
                {
                    // Lấy danh sách chuyên môn được chọn và ds nhân viên đã thuộc chuyên môn
                    var GetListCheckGoiDichVu = ListGDV.Where(x => x.IsCheck == true).ToList();
                    var GetListGiamGiaGoiDichVu = DataProvider.Ins.DB.GIAMGOIDICHVU.Where(x => x.GG_MA == GG_MA).ToList();

                    // Kiểm tra xem trong danh sách chuyên môn chọn thì có chuyên môn nào đã thuộc về nhân viên đó không
                    foreach (var item in GetListGiamGiaGoiDichVu.ToList())
                    {
                        foreach (var item2 in GetListCheckGoiDichVu.ToList())
                        {
                            if (item2.GDV_MA == item.GDV_MA)
                            {
                                GetListCheckGoiDichVu.Remove(item2);
                            }
                        }
                    }
                    // Edit goi dich vu giam
                    if (GetListCheckGoiDichVu.Count() != 0)
                    {
                        // Thêm GIAMGOIDICHVU vào database
                        foreach (var item in GetListCheckGoiDichVu.ToList())
                        {
                            DAO_GiamGia.Add(item.GDV_MA, SelectedItemGiamGia.GG_MA);
                            DataProvider.Ins.DB.SaveChanges();
                        }
                    }
                }

                // Load giam goi dich vu
                ListGiamGiaGDV = new ObservableCollection<ClassGoiDichVu>();
                var getListGDVByGG = DataProvider.Ins.DB.GIAMGOIDICHVU.Where(x => x.GG_MA == GG_MA).ToList();
                foreach (var item in getListGDVByGG)
                {
                    ClassGoiDichVu gdv = new ClassGoiDichVu();
                    gdv.DV_MA = item.GOIDICHVU.DICHVU.DV_MA;
                    gdv.DV_TEN = item.GOIDICHVU.DICHVU.DV_TEN;
                    gdv.GDV_MA = item.GDV_MA;
                    gdv.GDV_TEN = item.GOIDICHVU.GDV_TEN;
                    gdv.LGDV_TEN = item.GOIDICHVU.LOAIGOIDICHVU.LGDV_TEN;
                    gdv.IsCheck = false;

                    ListGiamGiaGDV.Add(gdv);
                }

                // Load lai du lieu
                ListGiamGia = DAO_GiamGia.GetList();
            }
            );

            CommandDeleteGG = new RelayCommand<object>((p) =>
            {
                // Nếu giảm giá này đã tồn tại trong 1 phiếu đăng ký nào đó thì không thể xóa
                var getGG_PDT = DataProvider.Ins.DB.GIAMGIA_PDK.Where(x => x.GG_MA == SelectedItemGiamGia.GG_MA).ToList();
                if (getGG_PDT.Count() > 0)
                    return false;

                if (SelectedItemGiamGia == null)
                    return false;
                
                return true;
            }, (p) =>
            {
                //Delete giamgoidich
                DAO_GiamGia.DeleteGG_GDV(SelectedItemGiamGia.GG_MA);

                // Delete LGG_GG
                DAO_GiamGia.DeleteLGG_GG(SelectedItemGiamGia.GG_MA);

                // Delete giam gia
                DAO_GiamGia.Delete(GG_MA);
                
                // Load lai du lieu
                ListGiamGia = DAO_GiamGia.GetList();
            }
            );

            CommandClearGG = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                GG_MA = "";
                GG_TEN = "";
                GG_NOIDUNG = "";
                GG_PHANTRAMGIAM = 0;
                GG_NGAYBATDAU = DateTime.Now;
                GG_NGAYKETTHUC = DateTime.Now;
                CheckGG_GDV = true;
                CheckGG_LT = true;
                CheckAllGDV = false;
                CheckAllDeleteGG = false;
                CheckGuiSMS = true;
                CheckGuiMail = true;

                SelectedTRANGTHAIGG = null;
                SelectedDV = null;
                SelectedItemGiamGia = null;
                SelectedTrangThaiFilter = null;
                SelectedLoaiGiamGiaFilter = null;

                ListGDV = null;
                ListGiamGiaGDV = null;
            }
            );

            CommnadLoc = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                if(SelectedLoaiGiamGiaFilter != null && SelectedTrangThaiFilter != null)
                {
                    var getListGG = DataProvider.Ins.DB.LGG_GG.Where(x => x.LGG_MA == SelectedLoaiGiamGiaFilter.LGG_MA).Select(x=>x.GIAMGIA).Distinct().ToList();
                    ListGiamGia = new ObservableCollection<GIAMGIA>(getListGG.Where(x => x.GG_TRANGTHAI == SelectedTrangThaiFilter.Name));
                }
                else if(SelectedLoaiGiamGiaFilter != null)
                {
                    ListGiamGia = DAO_GiamGia.GetList(SelectedLoaiGiamGiaFilter.LGG_MA);
                }
                else if(SelectedTrangThaiFilter != null)
                {
                    ListGiamGia = DAO_GiamGia.GetList(SelectedTrangThaiFilter.Name);
                }
            }
            );

            CommandXoaLoc = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                ListGiamGia = DAO_GiamGia.GetList();
            }
            );
        }

        void GetGDVByDV(DichVu dichVu, bool check)
        {
            ListGDV = new ObservableCollection<ClassGoiDichVu>();

            if (dichVu.DV_MA == "0")
            {
                var getGDVByDV = DAO_GoiDichVu.GetList().Select(x => x.GOIDICHVU).Distinct().ToList();
                foreach (var item in getGDVByDV)
                {
                    ClassGoiDichVu gdv = new ClassGoiDichVu();
                    gdv.DV_MA = item.DV_MA;
                    gdv.DV_TEN = item.DICHVU.DV_TEN;
                    gdv.GDV_MA = item.GDV_MA;
                    gdv.GDV_TEN = item.GDV_TEN;
                    gdv.LGDV_TEN = item.LOAIGOIDICHVU.LGDV_TEN;
                    gdv.IsCheck = check;


                    ListGDV.Add(gdv);
                }
            }
            else
            {
                var getGDVByDV = DAO_GoiDichVu.GetList(dichVu.DV_MA).Select(x=>x.GOIDICHVU).Distinct().ToList();
                foreach (var item in getGDVByDV)
                {
                    ClassGoiDichVu gdv = new ClassGoiDichVu();
                    gdv.DV_MA = item.DV_MA;
                    gdv.DV_TEN = item.DICHVU.DV_TEN;
                    gdv.GDV_MA = item.GDV_MA;
                    gdv.GDV_TEN = item.GDV_TEN;
                    gdv.LGDV_TEN = item.LOAIGOIDICHVU.LGDV_TEN;
                    gdv.IsCheck = check;


                    ListGDV.Add(gdv);
                }
            }
        }

        void LoadDichVu()
        {
            var getListDV = DAO_DichVu.GetList();
            DICHVU = new ObservableCollection<DichVu>();
            DICHVU.Add(new DichVu() { DV_MA = "0", DV_TEN = "Tất cả" });

            foreach(var item in getListDV)
            {
                var dichVu = new DichVu()
                {
                    DV_MA = item.DV_MA,
                    DV_TEN = item.DV_TEN
                };

                DICHVU.Add(dichVu);
            }
        }
    }

    public class TrangThai
    {
        public string Name { get; set; }
    }

    public class DichVu
    {
        public string DV_MA { get; set; }
        public string DV_TEN { get; set; }
    }
}
