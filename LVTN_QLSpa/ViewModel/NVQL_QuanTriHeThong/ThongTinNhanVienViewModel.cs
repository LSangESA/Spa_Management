using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LVTN_QLSpa.ViewModel.NVQL_QuanTriHeThong
{
    public class ThongTinNhanVienViewModel : BaseViewModel
    {
        private static NHANVIEN nhanVien { get; set; }

        private string _NV_ANH;
        public string NV_ANH { get => _NV_ANH; set { _NV_ANH = value; OnPropertyChanged(); } }

        private string _NV_MA;
        public string NV_MA { get => _NV_MA; set { _NV_MA = value; OnPropertyChanged(); } }

        private string _NV_TEN;
        public string NV_TEN { get => _NV_TEN; set { _NV_TEN = value; OnPropertyChanged(); } }

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

        private string _NV_DIACHI;
        public string NV_DIACHI { get => _NV_DIACHI; set { _NV_DIACHI = value; OnPropertyChanged(); } }

        private string _NV_USERNAME;
        public string NV_USERNAME { get => _NV_USERNAME; set { _NV_USERNAME = value; OnPropertyChanged(); } }

        private string _NV_PASSWORD;
        public string NV_PASSWORD { get => _NV_PASSWORD; set { _NV_PASSWORD = value; OnPropertyChanged(); } }

        private string _NV_PASSWORDNEW;
        public string NV_PASSWORDNEW { get => _NV_PASSWORDNEW; set { _NV_PASSWORDNEW = value; OnPropertyChanged(); } }

        private string _VT_TEN;
        public string VT_TEN { get => _VT_TEN; set { _VT_TEN = value; OnPropertyChanged(); } }

        private string _NV_PHUTRACH;
        public string NV_PHUTRACH { get => _NV_PHUTRACH; set { _NV_PHUTRACH = value; OnPropertyChanged(); } }

        private ObservableCollection<LichLamViecNhanVien> _LICHLAMVIEC;
        public ObservableCollection<LichLamViecNhanVien> LICHLAMVIEC { get => _LICHLAMVIEC; set { _LICHLAMVIEC = value; OnPropertyChanged(); } }

        public ICommand LoadWindow { get; set; }
        public ICommand PasswordChangedCommand { get; set; }
        public ICommand PasswordNewChangedCommand { get; set; }
        public ICommand CommandDoiMatKhau { get; set; }
        public ICommand CommandClose { get; set; }

        public ThongTinNhanVienViewModel()
        {
            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { NV_PASSWORD = p.Password; });
            PasswordNewChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { NV_PASSWORDNEW = p.Password; });

            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                nhanVien = CapNhatNhanVienViewModel.NhanVien_DATA;

                NV_ANH = nhanVien.NV_ANH;
                NV_MA = nhanVien.NV_MA;
                NV_TEN = nhanVien.NV_HOTEN;
                NV_NGAYSINH = nhanVien.NV_NGAYSINH;
                NV_CCCD = nhanVien.NV_CCCD;
                NV_SDT = nhanVien.NV_SDT;
                NV_EMAIL = nhanVien.NV_EMAIL;
                NV_GIOITINH = nhanVien.NV_GIOITINH;
                NV_DIACHI = nhanVien.NV_DIACHI + ", " + nhanVien.XAPHUONG.XP_TEN + ", " + nhanVien.XAPHUONG.HUYENQUAN.HQ_TEN + ", " + nhanVien.XAPHUONG.HUYENQUAN.TINHTHANH.TT_TEN;

                if(!string.IsNullOrEmpty(nhanVien.NV_USERNAME))
                    NV_USERNAME = nhanVien.NV_USERNAME;

                VT_TEN = DAO_ChuyenMon.LayVaiTroNhanVien(nhanVien.NV_MA);

                if (DAO_ChuyenMon.LaBacSi(nhanVien.NV_MA))
                    NV_PHUTRACH = "Phụ trách DV: " + PhuTrachDichVu(nhanVien.NV_MA);

                var ngayHomNay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                LICHLAMVIEC = LoadLichLamViecNhanVien(nhanVien.NV_MA, ngayHomNay);
            }
            );

            CommandDoiMatKhau = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(nhanVien.NV_USERNAME))
                    return false;

                if (NV_PASSWORD != nhanVien.NV_PASSWORD || string.IsNullOrEmpty(NV_PASSWORDNEW))
                    return false;

                return true;
            }, (p) =>
            {
                var nv = nhanVien;
                nv.NV_PASSWORD = NV_PASSWORDNEW;

                DataProvider.Ins.DB.SaveChanges();

                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
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

        ObservableCollection<LichLamViecNhanVien> LoadLichLamViecNhanVien(string NV_MA, DateTime ngayTrongTuan)
        {
            var ngayDauTuan = GetFirstDayOfWeek(ngayTrongTuan);
            int i = 0;

            var listLLV = new ObservableCollection<LichLamViecNhanVien>();
            while (i < 7)
            {
                var ngayTiepTheo = ngayDauTuan.AddDays((double)i);
                var getLichLamViecTrongTuanNhanVien = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.NV_MA == NV_MA && x.THOIGIAN == ngayTiepTheo).ToList();

                var lichLamViec = new LichLamViecNhanVien();

                if(ngayTiepTheo == ngayTrongTuan)
                {
                    lichLamViec.NGAY = ngayTiepTheo;
                    lichLamViec.ColorDay = "Red";
                }
                else
                {
                    lichLamViec.NGAY = ngayTiepTheo;
                    lichLamViec.ColorDay = "Black";
                }
                foreach (var item in getLichLamViecTrongTuanNhanVien)
                {
                    if (item.CLV_MA == "CLV7961             ")
                    {
                        lichLamViec.ColorSang = "Black";
                        lichLamViec.SANG = item.P_MA == null ? "Chưa lập" : item.PHONG.P_SO;
                    }
                    else if (item.CLV_MA == "CLV8258             ")
                    {
                        lichLamViec.ColorChieu = "Black";
                        lichLamViec.CHIEU = item.P_MA == null ? "Chưa lập" : item.PHONG.P_SO;
                    }
                    else
                    {
                        lichLamViec.ColorCaNgay = "Black";
                        lichLamViec.CANGAY = item.P_MA == null ? "Chưa lập" : item.PHONG.P_SO;
                    }
                }
                listLLV.Add(lichLamViec);
                i++;
            }

            return listLLV;
        }

        DateTime GetFirstDayOfWeek(DateTime dayInWeek)
        {
            CultureInfo defaultCultureInfo = CultureInfo.CurrentCulture;
            return GetFirstDayOfWeek(dayInWeek, defaultCultureInfo);
        }

        DateTime GetFirstDayOfWeek(DateTime dayInWeek, CultureInfo cultureInfo)
        {
            DayOfWeek firstDay = cultureInfo.DateTimeFormat.FirstDayOfWeek;
            DateTime firstDayInWeek = dayInWeek.Date;
            while (firstDayInWeek.DayOfWeek != firstDay)
            {
                firstDayInWeek = firstDayInWeek.AddDays(-1);
            }
            return firstDayInWeek;
        }

        string PhuTrachDichVu (string NV_MA)
        {
            string phuTrach = "";

            var getPhuTrach = DataProvider.Ins.DB.PHUTRACHGOI.Where(x => x.NV_MA == NV_MA).Select(x => x.GOIDICHVU.GDV_TEN);

            foreach (var item in getPhuTrach)
            {
                phuTrach += item + ", ";
            }

            return phuTrach.TrimEnd().Substring(0, phuTrach.Length - 2);
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
