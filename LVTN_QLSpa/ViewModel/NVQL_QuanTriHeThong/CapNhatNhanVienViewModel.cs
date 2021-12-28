using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using LVTN_QLSpa.Model.ModelClass;
using LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLNV;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;

namespace LVTN_QLSpa.ViewModel.NVQL_QuanTriHeThong
{
    public class CapNhatNhanVienViewModel : BaseViewModel
    {
        private static NHANVIEN nhanVien_DATA;
        public static NHANVIEN NhanVien_DATA
        {
            get { return CapNhatNhanVienViewModel.nhanVien_DATA; }
            set { CapNhatNhanVienViewModel.nhanVien_DATA = value; }
        }

        private string _KeySearchNV;
        public string KeySearchNV { get => _KeySearchNV; set { _KeySearchNV = value; OnPropertyChanged(); } }

        private string _NV_MA;
        public string NV_MA { get => _NV_MA; set { _NV_MA = value; OnPropertyChanged(); } }

        private string _NV_HOTEN;
        public string NV_HOTEN { get => _NV_HOTEN; set { _NV_HOTEN = value; OnPropertyChanged(); } }

        private DateTime _NV_NGAYSINH;
        public DateTime NV_NGAYSINH { get => _NV_NGAYSINH; set { _NV_NGAYSINH = value; OnPropertyChanged(); } }

        private string _NV_GIOITINHNAM;
        public string NV_GIOITINHNAM { get => _NV_GIOITINHNAM; set { _NV_GIOITINHNAM = value; OnPropertyChanged(); } }
        private string _NV_GIOITINHNU;
        public string NV_GIOITINHNU { get => _NV_GIOITINHNU; set { _NV_GIOITINHNU = value; OnPropertyChanged(); } }

        private string _NV_GIOITINH;
        public string NV_GIOITINH { get => _NV_GIOITINH; set { _NV_GIOITINH = value; OnPropertyChanged(); } }

        private string _NV_SDT;
        public string NV_SDT { get => _NV_SDT; set { _NV_SDT = value; OnPropertyChanged(); } }

        private string _NV_EMAIL;
        public string NV_EMAIL { get => _NV_EMAIL; set { _NV_EMAIL = value; OnPropertyChanged(); } }

        private string _NV_CCCD;
        public string NV_CCCD { get => _NV_CCCD; set { _NV_CCCD = value; OnPropertyChanged(); } }

        private string _NV_DIACHI;
        public string NV_DIACHI { get => _NV_DIACHI; set { _NV_DIACHI = value; OnPropertyChanged(); } }

        private string _NV_USERNAME;
        public string NV_USERNAME { get => _NV_USERNAME; set { _NV_USERNAME = value; OnPropertyChanged(); } }

        private string _NV_TRANGTHAI;
        public string NV_TRANGTHAI { get => _NV_TRANGTHAI; set { _NV_TRANGTHAI = value; OnPropertyChanged(); } }

        private string _NV_ANH;
        public string NV_ANH { get => _NV_ANH; set { _NV_ANH = value; OnPropertyChanged(); } }

        private Visibility _HiddenCalorZone;
        public Visibility HiddenCalorZone { get => _HiddenCalorZone; set { _HiddenCalorZone = value; OnPropertyChanged(); } }

        private ObservableCollection<NHANVIEN> _ListNhanVien;
        public ObservableCollection<NHANVIEN> ListNhanVien { get => _ListNhanVien; set { _ListNhanVien = value; OnPropertyChanged(); } }

        private ObservableCollection<XAPHUONG> _XAPHUONG;
        public ObservableCollection<XAPHUONG> XAPHUONG { get => _XAPHUONG; set { _XAPHUONG = value; OnPropertyChanged(); } }

        private ObservableCollection<HUYENQUAN> _HUYENQUAN;
        public ObservableCollection<HUYENQUAN> HUYENQUAN { get => _HUYENQUAN; set { _HUYENQUAN = value; OnPropertyChanged(); } }

        private ObservableCollection<TINHTHANH> _TINHTHANH;
        public ObservableCollection<TINHTHANH> TINHTHANH { get => _TINHTHANH; set { _TINHTHANH = value; OnPropertyChanged(); } }

        private ObservableCollection<TrangThaiNhanVien> _TRANGTHAINV;
        public ObservableCollection<TrangThaiNhanVien> TRANGTHAINV { get => _TRANGTHAINV; set { _TRANGTHAINV = value; OnPropertyChanged(); } }

        private ObservableCollection<VAITRO> _VAITRO;
        public ObservableCollection<VAITRO> VAITRO { get => _VAITRO; set { _VAITRO = value; OnPropertyChanged(); } }

        private ObservableCollection<ClassChuyenMon> _ListChuyenMon;
        public ObservableCollection<ClassChuyenMon> ListChuyenMon { get => _ListChuyenMon; set { _ListChuyenMon = value; OnPropertyChanged(); } }

        private ObservableCollection<ClassChuyenMonNhanVien> _ListChuyenMonNhanVien;
        public ObservableCollection<ClassChuyenMonNhanVien> ListChuyenMonNhanVien { get => _ListChuyenMonNhanVien; set { _ListChuyenMonNhanVien = value; OnPropertyChanged(); } }

        private ObservableCollection<VAITRO> _VaiTroFilter;
        public ObservableCollection<VAITRO> VaiTroFilter { get => _VaiTroFilter; set { _VaiTroFilter = value; OnPropertyChanged(); } }

        private ObservableCollection<TrangThaiNhanVien> _TrangThaiFilter;
        public ObservableCollection<TrangThaiNhanVien> TrangThaiFilter { get => _TrangThaiFilter; set { _TrangThaiFilter = value; OnPropertyChanged(); } }

        private ObservableCollection<GioiTinh> _GioiTinhFilter;
        public ObservableCollection<GioiTinh> GioiTinhFilter { get => _GioiTinhFilter; set { _GioiTinhFilter = value; OnPropertyChanged(); } }

        private NHANVIEN _SelectedItemNhanVien;
        public NHANVIEN SelectedItemNhanVien
        {
            get => _SelectedItemNhanVien;
            set
            {
                _SelectedItemNhanVien = value;
                OnPropertyChanged();
                
                if (SelectedItemNhanVien != null)
                {
                    // Binding thông tin nhân viên khi chọn vào item
                    NV_MA = SelectedItemNhanVien.NV_MA;
                    NV_HOTEN = SelectedItemNhanVien.NV_HOTEN;
                    NV_NGAYSINH = SelectedItemNhanVien.NV_NGAYSINH;
                    NV_SDT = SelectedItemNhanVien.NV_SDT;
                    NV_EMAIL = SelectedItemNhanVien.NV_EMAIL;
                    NV_CCCD = SelectedItemNhanVien.NV_CCCD;
                    NV_DIACHI = SelectedItemNhanVien.NV_DIACHI;
                    NV_USERNAME = SelectedItemNhanVien.NV_USERNAME;
                    NV_ANH = SelectedItemNhanVien.NV_ANH;
                    if (SelectedItemNhanVien.NV_GIOITINH == "Nam")
                    {
                        NV_GIOITINHNAM = "True";
                        NV_GIOITINHNU = "False";
                    }
                    else
                    {
                        NV_GIOITINHNAM = "False";
                        NV_GIOITINHNU = "True";
                    }
                    SelectedXAPHUONG = SelectedItemNhanVien.XAPHUONG;
                    SelectedHUYENQUAN = SelectedItemNhanVien.XAPHUONG.HUYENQUAN;
                    SelectedTINHTHANH = SelectedItemNhanVien.XAPHUONG.HUYENQUAN.TINHTHANH;

                    if (!string.IsNullOrEmpty(NV_ANH))
                    {
                        HiddenCalorZone = Visibility.Hidden;
                    }
                    else
                    {
                        HiddenCalorZone = Visibility.Visible;
                    }

                    // Binding danh sách chuyên môn thuộc về nhân viên
                    ListChuyenMonNhanVien = new ObservableCollection<ClassChuyenMonNhanVien>();
                    var GetListChuyenMonNhanVien = DataProvider.Ins.DB.CHUYENMONNHANVIEN.Where(x => x.NV_MA == SelectedItemNhanVien.NV_MA).ToList();
                    foreach(var item in GetListChuyenMonNhanVien)
                    {
                        ClassChuyenMonNhanVien chuyenMonNhanVien = new ClassChuyenMonNhanVien();
                        chuyenMonNhanVien.NV_MA = item.NV_MA;
                        chuyenMonNhanVien.VT_MA = item.CHUYENMON.VT_MA;
                        chuyenMonNhanVien.VT_TEN = item.CHUYENMON.VAITRO.VT_TEN;
                        chuyenMonNhanVien.CM_MA = item.CM_MA;
                        chuyenMonNhanVien.CM_TEN = item.CHUYENMON.CM_TEN;
                        chuyenMonNhanVien.IsCheckDelete = false;

                        ListChuyenMonNhanVien.Add(chuyenMonNhanVien);
                    }
                }
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
                if(SelectedVAITRO != null)
                {
                    ListChuyenMon = new ObservableCollection<ClassChuyenMon>();
                    var getListCM = DataProvider.Ins.DB.CHUYENMON.Where(x => x.VT_MA == SelectedVAITRO.VT_MA).ToList();
                    foreach(var item in getListCM)
                    {
                        ClassChuyenMon cCM = new ClassChuyenMon();
                        cCM.IsSelected = false;
                        cCM.CM_MA = item.CM_MA;
                        cCM.CM_TEN = item.CM_TEN;
                        cCM.VT_TEN = item.VAITRO.VT_TEN;

                        ListChuyenMon.Add(cCM);
                    }
                }
            }
        }

        private VAITRO _SelectedVaiTroFilter;
        public VAITRO SelectedVaiTroFilter
        {
            get => _SelectedVaiTroFilter;
            set
            {
                _SelectedVaiTroFilter = value;
                OnPropertyChanged();

                // Tim những nhân viên thuộc vai trò được chọn
                if (SelectedVaiTroFilter != null && ListNhanVien != null)
                {
                    if(SelectedVaiTroFilter.VT_MA == 0)
                    {
                        // Lấy toàn bộ danh sách nhân viên so sánh với danh sách nhân viên đã set chuyên môn để lấy ra những nhân viên chưa được set chuyên môn
                        var getListNhanVienDaSetChuyenMon = DataProvider.Ins.DB.CHUYENMONNHANVIEN.Select(x => x.NHANVIEN).ToList();
                        var getListAllNhanVien = DataProvider.Ins.DB.NHANVIEN.ToList();

                        var getListNhanVienChuaSetChuyenMon = getListAllNhanVien.Except(getListNhanVienDaSetChuyenMon).ToList();
                        ListNhanVien = new ObservableCollection<NHANVIEN>();
                        foreach(var item in getListNhanVienChuaSetChuyenMon)
                        {
                            ListNhanVien.Add(item);
                        }
                    }
                    else
                    {
                        var getListChuyenMonForVaiTro = DataProvider.Ins.DB.CHUYENMONNHANVIEN.Where(x => x.CHUYENMON.VAITRO.VT_MA == SelectedVaiTroFilter.VT_MA).Select(x => x.NHANVIEN).ToList();

                        ListNhanVien = new ObservableCollection<NHANVIEN>();
                        foreach (var item in getListChuyenMonForVaiTro.Distinct())
                        {
                            ListNhanVien.Add(item);
                        }
                    }
                    
                }
            }
        }

        private TrangThaiNhanVien _SelectedTrangThaiFilter;
        public TrangThaiNhanVien SelectedTrangThaiFilter
        {
            get => _SelectedTrangThaiFilter;
            set
            {
                _SelectedTrangThaiFilter = value;
                OnPropertyChanged();
                if (SelectedTrangThaiFilter != null && ListNhanVien != null)
                {
                    ListNhanVien = new ObservableCollection<NHANVIEN>(DataProvider.Ins.DB.NHANVIEN.Where(x => x.NV_TRANGTHAI == SelectedTrangThaiFilter.Name));
                }
            }
        }

        private GioiTinh _SelectedGioiTinhFilter;
        public GioiTinh SelectedGioiTinhFilter
        {
            get => _SelectedGioiTinhFilter;
            set
            {
                _SelectedGioiTinhFilter = value;
                OnPropertyChanged();
                if (SelectedGioiTinhFilter != null && ListNhanVien != null)
                {
                    ListNhanVien = new ObservableCollection<NHANVIEN>(DataProvider.Ins.DB.NHANVIEN.Where(x => x.NV_GIOITINH == SelectedGioiTinhFilter.Name));
                }
            }
        }

        private TrangThaiNhanVien _SelectedTRANGTHAI;
        public TrangThaiNhanVien SelectedTRANGTHAI
        {
            get => _SelectedTRANGTHAI;
            set
            {
                _SelectedTRANGTHAI = value;
                OnPropertyChanged();
            }
        }

        private XAPHUONG _SelectedXAPHUONG;
        public XAPHUONG SelectedXAPHUONG
        {
            get => _SelectedXAPHUONG;
            set
            {
                _SelectedXAPHUONG = value;
                OnPropertyChanged();
            }
        }

        private HUYENQUAN _SelectedHUYENQUAN;
        public HUYENQUAN SelectedHUYENQUAN
        {
            get => _SelectedHUYENQUAN;
            set
            {
                _SelectedHUYENQUAN = value;
                OnPropertyChanged();
            }
        }

        private TINHTHANH _SelectedTINHTHANH;
        public TINHTHANH SelectedTINHTHANH
        {
            get => _SelectedTINHTHANH;
            set
            {
                _SelectedTINHTHANH = value;
                OnPropertyChanged();
            }
        }

        public ICommand CommandAddNhanVien { get; set; }
        public ICommand CommandEditNhanVien { get; set; }
        public ICommand CommandDeleteNhanVien { get; set; }
        public ICommand CommandClearNhanVien { get; set; }
        public ICommand CheckedChangeCommandNVGTNAM { get; set; }
        public ICommand CheckedChangeCommandNVGTNU { get; set; }
        public ICommand AddIdCommandNhanVien { get; set; }
        public ICommand CommandCreateUser { get; set; }
        public ICommand CommandSelectTinhThanh { get; set; }
        public ICommand CommandSelectHuyenQuan { get; set; }
        public ICommand CommandThemAnhNV { get; set; }
        public ICommand CommandVisibilityColorZone { get; set; }
        public ICommand CommandDeleteItemChuyenMon { get; set; }
        public ICommand CommandKeySearchNV { get; set; }
        public ICommand CommandDoubleClickNhanVien { get; set; }

        // Thuộc tính nhân viên có thể tìm 
        private bool UserFilterNV(object item)
        {
            if (String.IsNullOrEmpty(KeySearchNV))
                return true;
            else
                return ((item as NHANVIEN).NV_HOTEN.ToString().IndexOf(KeySearchNV, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as NHANVIEN).NV_SDT.ToString().IndexOf(KeySearchNV, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as NHANVIEN).NV_USERNAME.ToString().IndexOf(KeySearchNV, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as NHANVIEN).NV_CCCD.ToString().IndexOf(KeySearchNV, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as NHANVIEN).NV_EMAIL.ToString().IndexOf(KeySearchNV, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        public CapNhatNhanVienViewModel()
        {
            // Load du lieu trang cap nhat nhan vien
            TINHTHANH = DAO_Address.GetListTinhThanh();
            ListNhanVien = DAO_NhanVien.GetList();
            VAITRO = DAO_VaiTro.GetList();
            TRANGTHAINV = new ObservableCollection<TrangThaiNhanVien>();
            TRANGTHAINV.Add(new TrangThaiNhanVien { Name = "Hoạt động" });
            TRANGTHAINV.Add(new TrangThaiNhanVien { Name = "Đã nghỉ việc" });
            TRANGTHAINV.Add(new TrangThaiNhanVien { Name = "Khóa tài khoản" });

            // Them du lieu cho bo loc danh sach nhan vien
            VaiTroFilter = DAO_VaiTro.GetList();
            VaiTroFilter.Add(new VAITRO { VT_MA = 0, VT_TEN = "Chưa có vai trò" });

            TrangThaiFilter = new ObservableCollection<TrangThaiNhanVien>();
            TrangThaiFilter.Add(new TrangThaiNhanVien { Name = "Hoạt động" });
            TrangThaiFilter.Add(new TrangThaiNhanVien { Name = "Đã nghỉ việc" });
            TrangThaiFilter.Add(new TrangThaiNhanVien { Name = "Khóa tài khoản" });

            GioiTinhFilter = new ObservableCollection<GioiTinh>();
            GioiTinhFilter.Add(new GioiTinh { Name = "Nam" });
            GioiTinhFilter.Add(new GioiTinh { Name = "Nữ" });

            if (string.IsNullOrEmpty(NV_ANH))
            {
                HiddenCalorZone = Visibility.Visible;
            }

            // Tạo collectionView để tìm
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(ListNhanVien);
            view.Filter = UserFilterNV;
            CommandKeySearchNV = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                CollectionViewSource.GetDefaultView(ListNhanVien).Refresh();
            }
            );

            CommandCreateUser = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(NV_HOTEN) || SelectedItemNhanVien != null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                NV_USERNAME = NV_MA + "_SPA";
            }
            );

            CommandVisibilityColorZone = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(NV_ANH))
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                HiddenCalorZone = Visibility.Visible;
            }
            );

            CommandThemAnhNV = new RelayCommand<object>((p) =>
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
                        NV_ANH = filename;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Tập tin không hợp lệ");
                        return;
                    }
                    if(!string.IsNullOrEmpty(NV_ANH))
                    {
                        HiddenCalorZone = Visibility.Hidden;
                    }
                    else
                    {
                        HiddenCalorZone = Visibility.Visible;
                    }
                }
            }
            );

            AddIdCommandNhanVien = new RelayCommand<object>((p) =>
            {
                if (SelectedItemNhanVien != null || string.IsNullOrEmpty(NV_HOTEN))
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                Random r = new Random();

                NV_MA = LocDau(GetName(NV_HOTEN,"_")) + r.Next(1,99);
            }
            );

            CommandAddNhanVien = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(NV_MA) ||
                string.IsNullOrEmpty(NV_HOTEN) ||
                NV_NGAYSINH == null ||
                string.IsNullOrEmpty(NV_SDT) ||
                string.IsNullOrEmpty(NV_CCCD) ||
                string.IsNullOrEmpty(NV_DIACHI) ||
                SelectedTRANGTHAI == null||
                SelectedItemNhanVien != null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                if (NV_GIOITINHNAM == "True")
                {
                    NV_GIOITINH = "Nam";
                }
                else if (NV_GIOITINHNU == "True")
                {
                    NV_GIOITINH = "Nữ";
                }
                
                var nhanvien = new NHANVIEN() { NV_MA = NV_MA,
                                                NV_HOTEN = NV_HOTEN,
                                                NV_NGAYSINH = NV_NGAYSINH,
                                                NV_SDT = NV_SDT,
                                                NV_EMAIL = NV_EMAIL,
                                                NV_CCCD = NV_CCCD,
                                                NV_DIACHI = NV_DIACHI,
                                                NV_USERNAME = NV_USERNAME,
                                                NV_PASSWORD = "1",
                                                NV_ANH = NV_ANH,
                                                NV_GIOITINH = NV_GIOITINH,
                                                NV_TRANGTHAI = "Hoạt động",
                                                XP_MA = SelectedXAPHUONG.XP_MA
                };

                ListNhanVien.Add(DAO_NhanVien.Add(nhanvien));

                try
                {
                    // Lấy danh sách chuyên môn được chọn
                    var GetListCheckChuyenMon = ListChuyenMon.Where(x => x.IsSelected == true).ToList();

                    // Thêm CHUYENMONNHANVIEN vào database
                    if (GetListCheckChuyenMon.Count != 0)
                    {
                        foreach (var item in GetListCheckChuyenMon)
                        {
                            DAO_NhanVien.AddNV_CM(item.CM_MA, nhanvien.NV_MA);
                        }
                    }
                }
                catch { }
                
                    
            }
            );

            CommandDeleteItemChuyenMon = new RelayCommand<object>((p) =>
            {
                if (SelectedItemNhanVien == null)
                    return false;
                return true;
            }, (p) =>
            {
                var chuyenMonNhanVienDelete = ListChuyenMonNhanVien.Where(x => x.IsCheckDelete == true).ToList();

                foreach(var item in chuyenMonNhanVienDelete)
                {
                    DAO_NhanVien.DeleteNV_CM(item.NV_MA, item.CM_MA);
                }

                ListChuyenMonNhanVien = new ObservableCollection<ClassChuyenMonNhanVien>();
                var GetListChuyenMonNhanVien = DataProvider.Ins.DB.CHUYENMONNHANVIEN.Where(x => x.NV_MA == SelectedItemNhanVien.NV_MA).ToList();
                foreach (var item in GetListChuyenMonNhanVien)
                {
                    ClassChuyenMonNhanVien chuyenMonNhanVien = new ClassChuyenMonNhanVien();
                    chuyenMonNhanVien.NV_MA = item.NV_MA;
                    chuyenMonNhanVien.VT_MA = item.CHUYENMON.VT_MA;
                    chuyenMonNhanVien.VT_TEN = item.CHUYENMON.VAITRO.VT_TEN;
                    chuyenMonNhanVien.CM_MA = item.CM_MA;
                    chuyenMonNhanVien.CM_TEN = item.CHUYENMON.CM_TEN;
                    chuyenMonNhanVien.IsCheckDelete = false;

                    ListChuyenMonNhanVien.Add(chuyenMonNhanVien);
                }
            }
            );

            CommandEditNhanVien = new RelayCommand<object>((p) =>
            {
                if (SelectedItemNhanVien == null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                if (NV_GIOITINHNAM == "True")
                    NV_GIOITINH = "Nam";
                else if (NV_GIOITINHNU == "True")
                    NV_GIOITINH = "Nữ";

                if (SelectedTRANGTHAI == null)
                    NV_TRANGTHAI = SelectedItemNhanVien.NV_TRANGTHAI;
                else
                    NV_TRANGTHAI = SelectedTRANGTHAI.Name;

                DAO_NhanVien.Edit(NV_MA,NV_HOTEN,NV_NGAYSINH,NV_GIOITINH,NV_SDT,NV_EMAIL,NV_CCCD,NV_DIACHI,NV_USERNAME, NV_TRANGTHAI, NV_ANH,SelectedXAPHUONG.XP_MA);

                // Lấy danh sách chuyên môn được chọn và ds nhân viên đã thuộc chuyên môn
                var GetListCheckChuyenMon = ListChuyenMon.Where(x => x.IsSelected == true).ToList();
                var GetListNhanVienCoChuyenMon = DataProvider.Ins.DB.CHUYENMONNHANVIEN.Where(x => x.NV_MA == SelectedItemNhanVien.NV_MA).ToList();
                
                // Kiểm tra xem trong danh sách chuyên môn chọn thì có chuyên môn nào đã thuộc về nhân viên đó không
                foreach (var item in GetListNhanVienCoChuyenMon.ToList())
                {
                    foreach(var item2 in GetListCheckChuyenMon.ToList())
                    {
                        if(item2.CM_MA == item.CM_MA)
                        {
                            MessageBox.Show("Nhân viên đã có chuyên môn " + item2.CM_TEN);
                            GetListCheckChuyenMon.Remove(item2);
                        }
                    }
                }

                // Nếu như tất cả chuyên môn chọn thêm đều đã tồn tại với nhân viên này thì ko làm gì hết
                if(GetListCheckChuyenMon.Count() != 0)
                {
                    // Thêm CHUYENMONNHANVIEN vào database
                    foreach (var item in GetListCheckChuyenMon.ToList())
                    {
                        DAO_NhanVien.AddNV_CM(item.CM_MA, SelectedItemNhanVien.NV_MA);
                    }
                }

                ListChuyenMonNhanVien = new ObservableCollection<ClassChuyenMonNhanVien>();
                var GetListChuyenMonNhanVien = DataProvider.Ins.DB.CHUYENMONNHANVIEN.Where(x => x.NV_MA == SelectedItemNhanVien.NV_MA).ToList();
                foreach (var item in GetListChuyenMonNhanVien)
                {
                    ClassChuyenMonNhanVien chuyenMonNhanVien = new ClassChuyenMonNhanVien();
                    chuyenMonNhanVien.NV_MA = item.NV_MA;
                    chuyenMonNhanVien.VT_MA = item.CHUYENMON.VT_MA;
                    chuyenMonNhanVien.VT_TEN = item.CHUYENMON.VAITRO.VT_TEN;
                    chuyenMonNhanVien.CM_MA = item.CM_MA;
                    chuyenMonNhanVien.CM_TEN = item.CHUYENMON.CM_TEN;
                    chuyenMonNhanVien.IsCheckDelete = false;

                    ListChuyenMonNhanVien.Add(chuyenMonNhanVien);
                }

                ListNhanVien = DAO_NhanVien.GetList();
            }
            );

            CommandDeleteNhanVien = new RelayCommand<object>((p) =>
            {
                if (SelectedItemNhanVien == null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                DAO_NhanVien.Delete(NV_MA);
                ListNhanVien = DAO_NhanVien.GetList();
            }
            );

            CommandClearNhanVien = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                NV_MA = "";
                NV_HOTEN = "";
                NV_NGAYSINH = new DateTime(2021, 01, 01);
                NV_SDT = "";
                NV_EMAIL = "";
                NV_CCCD = "";
                NV_DIACHI = "";
                NV_USERNAME = "";
                NV_ANH = "";
                SelectedTRANGTHAI = null;
                SelectedXAPHUONG = null;
                SelectedTINHTHANH = null;
                SelectedHUYENQUAN = null;
                SelectedItemNhanVien = null;
                HiddenCalorZone = Visibility.Visible;

                SelectedGioiTinhFilter = null;
                SelectedVaiTroFilter = null;
                SelectedGioiTinhFilter = null;
                ListChuyenMonNhanVien = null;
                ListChuyenMon = null;

                ListNhanVien = DAO_NhanVien.GetList();
            }
            );

            CheckedChangeCommandNVGTNAM = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                if (NV_GIOITINHNAM == "True")
                    NV_GIOITINHNU = "False";
                else if (NV_GIOITINHNAM == "False")
                    NV_GIOITINHNU = "True";
            }
            );

            CheckedChangeCommandNVGTNU = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                if (NV_GIOITINHNU == "True")
                    NV_GIOITINHNAM = "False";
                else if (NV_GIOITINHNU == "False")
                    NV_GIOITINHNAM = "True";
            }
            );

            CommandSelectTinhThanh = new RelayCommand<object>((p) =>
            {
                if (SelectedTINHTHANH == null)
                    return false;
                return true;
            }, (p) =>
            {
                HUYENQUAN = DAO_Address.GetListHuyenQuan(SelectedTINHTHANH.TT_MA);
            }
            );

            CommandSelectHuyenQuan = new RelayCommand<object>((p) =>
            {
                if (SelectedHUYENQUAN == null)
                    return false;
                return true;
            }, (p) =>
            {
                XAPHUONG = DAO_Address.GetListXaPhuong(SelectedHUYENQUAN.HQ_MA);
            }
            );

            CommandDoubleClickNhanVien = new RelayCommand<object>((p) =>
            {
                if (SelectedItemNhanVien == null)
                    return false;

                return true;
            }, (p) =>
            {
                NhanVien_DATA = SelectedItemNhanVien;
                W_ThongTinNhanVien window = new W_ThongTinNhanVien();
                window.ShowDialog();
                NhanVien_DATA = null;
            }
            );
        }

        #region Lọc chuỗi có dấu thành không dấu
        private static readonly string[] VietNamChar = new string[]
        {
        "aAeEoOuUiIdDyY",
        "áàạảãâấầậẩẫăắằặẳẵ",
        "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
        "éèẹẻẽêếềệểễ",
        "ÉÈẸẺẼÊẾỀỆỂỄ",
        "óòọỏõôốồộổỗơớờợởỡ",
        "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
        "úùụủũưứừựửữ",
        "ÚÙỤỦŨƯỨỪỰỬỮ",
        "íìịỉĩ",
        "ÍÌỊỈĨ",
        "đ",
        "Đ",
        "ýỳỵỷỹ",
        "ÝỲỴỶỸ"
        };
        public static string LocDau(string str)
        {
            //Thay thế và lọc dấu từng char      
            for (int i = 1; i < VietNamChar.Length; i++)
            {
                for (int j = 0; j < VietNamChar[i].Length; j++)
                    str = str.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
            }
            return str;
        }
        #endregion

        #region Lấy ký tự đầu chuỗi họ tên lót thành 
        public static string GetName(string str, string kyHieuSau)
        {
            string res = "";
            string[] tu = str.Split(' ');
            int len = tu.Length;
            for (int i = 0; i < len - 1; i++)
            {
                res += tu[i].Substring(0, 1);
            }
            res += tu[len - 1];
            res += kyHieuSau;

            return res;
        }

        #endregion
    }

    public class TrangThaiNhanVien
    {
        public string Name { get; set; }
    }

    public class GioiTinh
    {
        public string Name { get; set; }
    }
}
