using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using LVTN_QLSpa.Model.ModelClass;
using LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLLichHen;
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
    public class ThongTinKhachHangViewModel : BaseViewModel
    {
        private static KHACHHANG kh_DATA;
        public static KHACHHANG KH_DATA
        {
            get { return ThongTinKhachHangViewModel.kh_DATA; }
            set { ThongTinKhachHangViewModel.kh_DATA = value; }
        }

        private static PHIEUDIEUTRI pdt_DATA;
        public static PHIEUDIEUTRI PDT_DATA
        {
            get { return ThongTinKhachHangViewModel.pdt_DATA; }
            set { ThongTinKhachHangViewModel.pdt_DATA = value; }
        }

        private string _KH_MA;
        public string KH_MA { get => _KH_MA; set { _KH_MA = value; OnPropertyChanged(); } }

        private string _KH_HOTEN;
        public string KH_HOTEN { get => _KH_HOTEN; set { _KH_HOTEN = value; OnPropertyChanged(); } }

        private string _KH_SDT;
        public string KH_SDT { get => _KH_SDT; set { _KH_SDT = value; OnPropertyChanged(); } }

        private string _KH_EMAIL;
        public string KH_EMAIL { get => _KH_EMAIL; set { _KH_EMAIL = value; OnPropertyChanged(); } }

        private DateTime _KH_NGAYSINH;
        public DateTime KH_NGAYSINH { get => _KH_NGAYSINH; set { _KH_NGAYSINH = value; OnPropertyChanged(); } }

        private string _KH_DIACHI;
        public string KH_DIACHI { get => _KH_DIACHI; set { _KH_DIACHI = value; OnPropertyChanged(); } }

        private string _KeySearchKH;
        public string KeySearchKH { get => _KeySearchKH; set { _KeySearchKH = value; OnPropertyChanged(); } }

        private string _KeySearchPDK;
        public string KeySearchPDK { get => _KeySearchPDK; set { _KeySearchPDK = value; OnPropertyChanged(); } }

        private string _KH_GIOITINHNAM;
        public string KH_GIOITINHNAM { get => _KH_GIOITINHNAM; set { _KH_GIOITINHNAM = value; OnPropertyChanged(); } }

        private string _KH_GIOITINHNU;
        public string KH_GIOITINHNU { get => _KH_GIOITINHNU; set { _KH_GIOITINHNU = value; OnPropertyChanged(); } }

        private string _KH_GIOITINH;
        public string KH_GIOITINH { get => _KH_GIOITINH; set { _KH_GIOITINH = value; OnPropertyChanged(); } }

        private ObservableCollection<XAPHUONG> _XAPHUONG;
        public ObservableCollection<XAPHUONG> XAPHUONG { get => _XAPHUONG; set { _XAPHUONG = value; OnPropertyChanged(); } }

        private ObservableCollection<HUYENQUAN> _HUYENQUAN;
        public ObservableCollection<HUYENQUAN> HUYENQUAN { get => _HUYENQUAN; set { _HUYENQUAN = value; OnPropertyChanged(); } }

        private ObservableCollection<TINHTHANH> _TINHTHANH;
        public ObservableCollection<TINHTHANH> TINHTHANH { get => _TINHTHANH; set { _TINHTHANH = value; OnPropertyChanged(); } }

        private ObservableCollection<ClassKhachHang> _ListKhachHang;
        public ObservableCollection<ClassKhachHang> ListKhachHang { get => _ListKhachHang; set { _ListKhachHang = value; OnPropertyChanged(); } }

        private ObservableCollection<PHIEUDANGKY> _ListPhieuDangKy;
        public ObservableCollection<PHIEUDANGKY> ListPhieuDangKy { get => _ListPhieuDangKy; set { _ListPhieuDangKy = value; OnPropertyChanged(); } }

        private ObservableCollection<ClassPhieuDieuTriKH> _ListPhieuDieuTri;
        public ObservableCollection<ClassPhieuDieuTriKH> ListPhieuDieuTri { get => _ListPhieuDieuTri; set { _ListPhieuDieuTri = value; OnPropertyChanged(); } }

        private ObservableCollection<TrangThai> _TTDK;
        public ObservableCollection<TrangThai> TTDK { get => _TTDK; set { _TTDK = value; OnPropertyChanged(); } }

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

        private ClassKhachHang _SelectedKhachHang;
        public ClassKhachHang SelectedKhachHang
        {
            get => _SelectedKhachHang;
            set
            {
                _SelectedKhachHang = value;
                OnPropertyChanged();
                
            }
        }

        private PHIEUDANGKY _SelectedListPhieuDangKy;
        public PHIEUDANGKY SelectedListPhieuDangKy
        {
            get => _SelectedListPhieuDangKy;
            set
            {
                _SelectedListPhieuDangKy = value;
                OnPropertyChanged();

                if(SelectedListPhieuDangKy != null)
                {
                    LoadPhieuDieuTri(SelectedListPhieuDangKy.PDK_STT);
                }
            }
        }

        private ClassPhieuDieuTriKH _SelectedPhieuDieuTri;
        public ClassPhieuDieuTriKH SelectedPhieuDieuTri
        {
            get => _SelectedPhieuDieuTri;
            set
            {
                _SelectedPhieuDieuTri = value;
                OnPropertyChanged();

            }
        }

        private TrangThai _SelectedTTDK;
        public TrangThai SelectedTTDK
        {
            get => _SelectedTTDK;
            set
            {
                _SelectedTTDK = value;
                OnPropertyChanged();

            }
        }

        public ICommand LoadWindow { get; set; }
        public ICommand CommandKeySearchKH { get; set; }
        public ICommand AddIdCommandNhanVien { get; set; }
        public ICommand CommandSelectTinhThanh { get; set; }
        public ICommand CommandSelectHuyenQuan { get; set; }
        public ICommand CommandSelectedKhachHang { get; set; }
        public ICommand CheckedChangeCommandKHGTNAM { get; set; }
        public ICommand CheckedChangeCommandKHGTNU { get; set; }
        public ICommand CommandThanhToanNo { get; set; }
        public ICommand CommandDatLichHen { get; set; }
        public ICommand CommandDangKyDichVu { get; set; }
        public ICommand CommandAddKH { get; set; }
        public ICommand CommandEditKH { get; set; }
        public ICommand CommandDeleteKH { get; set; }
        public ICommand CommandClearKH { get; set; }
        public ICommand CommandKeySearchPDK { get; set; }
        public ICommand CommandXemLichTrinhDieuTri { get; set; }
        public ICommand CommandLapPhieuDieuTri { get; set; }
        public ICommand CommandEditTTDK { get; set; }

        public ThongTinKhachHangViewModel()
        {
            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                LoadTrangThai();
                LoadListClassKhachHang();
                TINHTHANH = DAO_Address.GetListTinhThanh();
            }
            );

            CommandKeySearchKH = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {

            }
            );

            AddIdCommandNhanVien = new RelayCommand<object>((p) =>
            {
                if (SelectedKhachHang != null || string.IsNullOrEmpty(KH_HOTEN))
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                Random r = new Random();

                KH_MA = ClassXuLyChuoi.LocDau(ClassXuLyChuoi.GetName(KH_HOTEN, "_")) + r.Next(100, 999);
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

            CommandSelectedKhachHang = new RelayCommand<object>((p) =>
            {
                if (SelectedKhachHang == null)
                    return false;
                return true;
            }, (p) =>
            {
                var getKhachHang = DataProvider.Ins.DB.KHACHHANG.Where(x => x.KH_MA == SelectedKhachHang.KH_MA).SingleOrDefault();

                KH_MA = getKhachHang.KH_MA;
                KH_HOTEN = getKhachHang.KH_HOTEN;
                KH_SDT = getKhachHang.KH_SDT;
                KH_NGAYSINH = getKhachHang.KH_NGAYSINH;
                KH_EMAIL = getKhachHang.KH_EMAIL;
                KH_DIACHI = getKhachHang.KH_DIACHI;
                SelectedXAPHUONG = getKhachHang.XAPHUONG;
                SelectedHUYENQUAN = getKhachHang.XAPHUONG.HUYENQUAN;
                SelectedTINHTHANH = getKhachHang.XAPHUONG.HUYENQUAN.TINHTHANH;
                if (getKhachHang.KH_GIOITINH == "Nam")
                {
                    KH_GIOITINHNAM = "True";
                    KH_GIOITINHNU = "False";
                }
                else
                {
                    KH_GIOITINHNAM = "False";
                    KH_GIOITINHNU = "True";
                }

                ListPhieuDangKy = DAO_PhieuDangKy.GetListKH(SelectedKhachHang.KH_MA);
                ListPhieuDieuTri = new ObservableCollection<ClassPhieuDieuTriKH>();
            }
            );

            CheckedChangeCommandKHGTNAM = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                if (KH_GIOITINHNAM == "True")
                    KH_GIOITINHNU = "False";
                else if (KH_GIOITINHNAM == "False")
                    KH_GIOITINHNU = "True";
            }
            );

            CheckedChangeCommandKHGTNU = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                if (KH_GIOITINHNU == "True")
                    KH_GIOITINHNAM = "False";
                else if (KH_GIOITINHNU == "False")
                    KH_GIOITINHNAM = "True";
            }
            );

            CommandThanhToanNo = new RelayCommand<object>((p) =>
            {
                if (SelectedKhachHang == null)
                    return false;

                return true;
            }, (p) =>
            {
                KH_DATA = DataProvider.Ins.DB.KHACHHANG.Where(x=>x.KH_MA == SelectedKhachHang.KH_MA).SingleOrDefault();

                W_LapPhieuThu window = new W_LapPhieuThu();
                window.ShowDialog();
            }
            );

            CommandDatLichHen = new RelayCommand<object>((p) =>
            {
                if (SelectedKhachHang == null)
                    return false;

                return true;
            }, (p) =>
            {
                KH_DATA = DataProvider.Ins.DB.KHACHHANG.Where(x=>x.KH_MA == SelectedKhachHang.KH_MA).SingleOrDefault();
                W_TaoLichHen window = new W_TaoLichHen();
                window.ShowDialog();
                KH_DATA = null;
            }
            );

            CommandDangKyDichVu = new RelayCommand<object>((p) =>
            {
                if (SelectedKhachHang == null)
                    return false;

                return true;
            }, (p) =>
            {
                KH_DATA = DataProvider.Ins.DB.KHACHHANG.Where(x => x.KH_MA == SelectedKhachHang.KH_MA).SingleOrDefault();
                W_LapPhieuDangKy window = new W_LapPhieuDangKy();
                window.ShowDialog();
                KH_DATA = null;
            }
            );

            CommandAddKH = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(KH_HOTEN) || string.IsNullOrEmpty(KH_MA) || string.IsNullOrEmpty(KH_SDT) || SelectedKhachHang != null)
                    return false;

                return true;
            }, (p) =>
            {
                if (KH_GIOITINHNAM == "True")
                {
                    KH_GIOITINH = "Nam";
                }
                else if (KH_GIOITINHNU == "True")
                {
                    KH_GIOITINH = "Nữ";
                }
                var getKhachHang = DAO_KhachHang.AddKH(KH_MA, KH_HOTEN, KH_NGAYSINH, KH_GIOITINH, KH_DIACHI, KH_SDT, KH_EMAIL, SelectedXAPHUONG.XP_MA);
                
                ListKhachHang.Add(GetClassKhachHang(getKhachHang));
            }
            );

            CommandEditKH = new RelayCommand<object>((p) =>
            {
                if (SelectedKhachHang.KH_MA == null)
                    return false;

                return true;
            }, (p) =>
            {
                if (KH_GIOITINHNAM == "True")
                {
                    KH_GIOITINH = "Nam";
                }
                else if (KH_GIOITINHNU == "True")
                {
                    KH_GIOITINH = "Nữ";
                }

                DAO_KhachHang.EditKH(KH_MA, KH_HOTEN, KH_NGAYSINH, KH_GIOITINH, KH_DIACHI, KH_SDT, KH_EMAIL, SelectedXAPHUONG.XP_MA);
                LoadListClassKhachHang();
            }
            );

            CommandDeleteKH = new RelayCommand<object>((p) =>
            {
                if (SelectedKhachHang.KH_MA == null)
                    return false;

                return true;
            }, (p) =>
            {
                DAO_KhachHang.DeleteKH(SelectedKhachHang.KH_MA);
                LoadListClassKhachHang();
            }
            );

            CommandClearKH = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                KH_MA = "";
                KH_HOTEN = "";
                KH_SDT = "";
                KH_EMAIL = "";
                KH_NGAYSINH = DateTime.Now;
                KH_DIACHI = "";
                KeySearchKH = "";
                KeySearchPDK = "";
                SelectedXAPHUONG = null;
                SelectedHUYENQUAN = null;
                SelectedTINHTHANH = null;
                SelectedKhachHang = null;

                SelectedListPhieuDangKy = null;
                SelectedPhieuDieuTri = null;
                SelectedKhachHang = null;
            }
            );

            CommandKeySearchPDK = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                
            }
            );

            CommandXemLichTrinhDieuTri = new RelayCommand<object>((p) =>
            {
                var getLoaiGDV = DataProvider.Ins.DB.PHIEUDANGKY.Where(x => x.PDK_STT == SelectedListPhieuDangKy.PDK_STT).SingleOrDefault();
                if (getLoaiGDV.GOIDICHVU.LGDV_MA == 2)
                    return false;

                if (SelectedListPhieuDangKy == null)
                    return false;

                return true;
            }, (p) =>
            {
                LapPhieuDangKyViewModel.PDK_STT_DATA = SelectedListPhieuDangKy.PDK_STT;
                W_InLichTrinhDieuTri window = new W_InLichTrinhDieuTri();
                window.ShowDialog();
                LapPhieuDangKyViewModel.PDK_STT_DATA = null;
            }
            );

            CommandEditTTDK = new RelayCommand<object>((p) =>
            {
                if (SelectedListPhieuDangKy == null)
                    return false;

                return true;
            }, (p) =>
            {
                DAO_PhieuDangKy.EditTrangThaiPDK(SelectedListPhieuDangKy.PDK_STT, SelectedTTDK.Name);
                MessageBox.Show("Chuyển trạng thái thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            );

            CommandLapPhieuDieuTri = new RelayCommand<object>((p) =>
            {
                if (SelectedListPhieuDangKy == null)
                    return false;

                var getLoaiGDV = DataProvider.Ins.DB.PHIEUDANGKY.Where(x => x.PDK_STT == SelectedListPhieuDangKy.PDK_STT).SingleOrDefault();
                if (getLoaiGDV.GOIDICHVU.LGDV_MA == 2)
                    return false;

                int? soLanLieuTrinhGDV = DataProvider.Ins.DB.LIEUTRINH.Where(x => x.GDV_MA == SelectedListPhieuDangKy.GDV_MA).Count();
                int tongSoPhieuDTcuaPDK = DAO_PhieuDieuTri.GetSoPDTInPDK(SelectedListPhieuDangKy.PDK_STT);

                if (soLanLieuTrinhGDV == tongSoPhieuDTcuaPDK)
                    return false;

                return true;
            }, (p) =>
            {
                /* Đầu tiên kiểm tra xem ngày hôm nay có phải là ngày điều trị tiếp theo không
                 *      Nếu đúng thì lập luôn phiếu điều trị
                 *      Nếu sai thì thông báo ra ngày liệu trình tiếp theo chưa đến và hiển thị ngày đúng liệu trình là ngày nào
                 *          Cho lựa chọn có lập phiếu điều trị sớm không
                 *              Nếu OK thì hiển thị lập phiếu
                 *              Ngược lại thì không làm gì cả
                */

                if(SelectedListPhieuDangKy.PDK_TRANGTHAI == "Tạm hoãn điều trị" || SelectedListPhieuDangKy.PDK_TRANGTHAI == "Hủy điều trị")
                {
                    MessageBox.Show("Phiếu đang " + SelectedListPhieuDangKy.PDK_TRANGTHAI + ". Không thể lập phiếu khám mới", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    if (DAO_LichTrinhDieuTri.KiemTraNgayLieuTrinhTiepTheo(SelectedListPhieuDangKy.PDK_STT))
                    {
                        var phieuDangKy = SelectedListPhieuDangKy;
                        LapPhieuDangKyViewModel.GDV_MA_DATA = phieuDangKy.GDV_MA;
                        LapPhieuDangKyViewModel.PDK_STT_DATA = phieuDangKy.PDK_STT;

                        W_LapPhieuDieuTri window = new W_LapPhieuDieuTri();
                        window.ShowDialog();

                        LapPhieuDangKyViewModel.GDV_MA_DATA = null;
                        LapPhieuDangKyViewModel.PDK_STT_DATA = null;

                        LoadPhieuDieuTri(SelectedListPhieuDangKy.PDK_STT);
                    }
                    else
                    {
                        var ngayLieuTrinhTiepTheo = DAO_LichTrinhDieuTri.LayNgayLieuTrinhTiepTheo(SelectedListPhieuDangKy.PDK_STT);

                        if (MessageBox.Show("Ngày khám tiếp theo vào " + ngayLieuTrinhTiepTheo.ToString("dd/MM/yyyy") + ". Bạn muốn đăng ký khám sớm?", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
                        {
                            var phieuDangKy = SelectedListPhieuDangKy;
                            LapPhieuDangKyViewModel.GDV_MA_DATA = phieuDangKy.GDV_MA;
                            LapPhieuDangKyViewModel.PDK_STT_DATA = phieuDangKy.PDK_STT;

                            W_LapPhieuDieuTri window = new W_LapPhieuDieuTri();
                            window.ShowDialog();

                            // Doi lich trinh dieu tri khi kham som
                            var soPDK = ThongTinKhachHangViewModel.PDT_DATA.PDK_STT;
                            var soPDT = Convert.ToInt32(ThongTinKhachHangViewModel.PDT_DATA.PDT_STT);
                            var lieuTrinhDieuTri = DataProvider.Ins.DB.LICHTRINHDIEUTRI.Where(x => x.PDK_STT == soPDK && x.LIEUTRINH.LT_STT == soPDT).SingleOrDefault();
                            var ltdt = DAO_LichTrinhDieuTri.Edit(lieuTrinhDieuTri, DateTime.Now, lieuTrinhDieuTri.LTDT_THOIGIANDEN);

                            ThongTinKhachHangViewModel.PDT_DATA = null;
                            LapPhieuDangKyViewModel.GDV_MA_DATA = null;
                            LapPhieuDangKyViewModel.PDK_STT_DATA = null;

                            LoadPhieuDieuTri(SelectedListPhieuDangKy.PDK_STT);
                        }
                    }
                }
            }
            );
        }

        ClassKhachHang GetClassKhachHang(KHACHHANG getKhachHang)
        {
            ClassKhachHang khachHang = new ClassKhachHang();
            khachHang.KH_MA = getKhachHang.KH_MA;
            khachHang.KH_TEN = getKhachHang.KH_HOTEN;
            khachHang.KH_NGAYSINH = getKhachHang.KH_NGAYSINH;
            khachHang.KH_SDT = getKhachHang.KH_SDT;
            if(getKhachHang.KH_GIOITINH == "Nam")
            {
                khachHang.KH_ANH = @"E:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Avatars\Customer\man.png";
            }
            else
            {
                khachHang.KH_ANH = @"E:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Avatars\Customer\woman.png";
            }

            return khachHang;
        }

        void LoadPhieuDieuTri(string PDK_STT)
        {
            var getPDTKH = DAO_PhieuDieuTri.GetList(PDK_STT);
            ListPhieuDieuTri = new ObservableCollection<ClassPhieuDieuTriKH>();
            foreach (var item in getPDTKH)
            {
                ClassPhieuDieuTriKH phieuDangKy = new ClassPhieuDieuTriKH();
                phieuDangKy.PDT_STT = item.PDT_STT;
                phieuDangKy.PDT_NGAYLAP = item.PDT_NGAYLAP;
                phieuDangKy.PDT_TRANGTHAI = item.PDT_TRANGTHAI;

                if (item.PDT_TRANGTHAINNO == true)
                    phieuDangKy.PDT_TRANGTHAINNO = "Chưa thanh toán";
                else
                    phieuDangKy.PDT_TRANGTHAINNO = "Đã thanh toán";

                ListPhieuDieuTri.Add(phieuDangKy);
            }

            SelectedTTDK = TTDK.Where(x=>x.Name == SelectedListPhieuDangKy.PDK_TRANGTHAI).SingleOrDefault();
        }

        void LoadListClassKhachHang()
        {
            var getListKhachHang = DataProvider.Ins.DB.KHACHHANG.ToList();
            ListKhachHang = new ObservableCollection<ClassKhachHang>();
            foreach(var item in getListKhachHang)
            {
                var khachHang = GetClassKhachHang(item);
                ListKhachHang.Add(khachHang);
            }
        }

        void LoadTrangThai()
        {
            TTDK = new ObservableCollection<TrangThai>();
            TTDK.Add(new TrangThai() { Name = "Đang điều trị" });
            TTDK.Add(new TrangThai() { Name = "Tạm hoãn điều trị" });
            TTDK.Add(new TrangThai() { Name = "Hủy điều trị" });
        }
    }

    public class TrangThai
    {
        public string Name { get; set; }
    }
}
