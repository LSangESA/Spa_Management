using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LVTN_QLSpa.ViewModel.NVQL_QuanTriHeThong
{
    public class KhachHang
    {
        public bool IsCheck { get; set; }
        public string KH_MA { get; set; }
        public string KH_TEN { get; set; }
        public string KH_SDT { get; set; }
        public string KH_EMAIL { get; set; }
        public string KH_TUOI { get; set; }
        public string KH_GIOITINH { get; set; }
        public string KH_DIACHI { get; set; }
        public string KH_ANH { get; set; }
    }

    public class GuiTinNhanViewModel : BaseViewModel
    {
        private bool _CheckGuiSMS;
        public bool CheckGuiSMS { get => _CheckGuiSMS; set { _CheckGuiSMS = value; OnPropertyChanged(); } }

        private bool _CheckGuiMail;
        public bool CheckGuiMail { get => _CheckGuiMail; set { _CheckGuiMail = value; OnPropertyChanged(); } }

        private string _GG_ANH;
        public string GG_ANH { get => _GG_ANH; set { _GG_ANH = value; OnPropertyChanged(); } }

        private string _GG_TEN;
        public string GG_TEN { get => _GG_TEN; set { _GG_TEN = value; OnPropertyChanged(); } }

        private DateTime _GG_NGAYBATDAU;
        public DateTime GG_NGAYBATDAU { get => _GG_NGAYBATDAU; set { _GG_NGAYBATDAU = value; OnPropertyChanged(); } }

        private DateTime _GG_NGAYKETTHUC;
        public DateTime GG_NGAYKETTHUC { get => _GG_NGAYKETTHUC; set { _GG_NGAYKETTHUC = value; OnPropertyChanged(); } }

        private int _GG_PHANTRAMGIAM;
        public int GG_PHANTRAMGIAM { get => _GG_PHANTRAMGIAM; set { _GG_PHANTRAMGIAM = value; OnPropertyChanged(); } }

        private string _GG_TRANGTHAI;
        public string GG_TRANGTHAI { get => _GG_TRANGTHAI; set { _GG_TRANGTHAI = value; OnPropertyChanged(); } }

        private string _GG_NOIDUNG;
        public string GG_NOIDUNG { get => _GG_NOIDUNG; set { _GG_NOIDUNG = value; OnPropertyChanged(); } }

        private string _GG_LOAIGIAM;
        public string GG_LOAIGIAM { get => _GG_LOAIGIAM; set { _GG_LOAIGIAM = value; OnPropertyChanged(); } }


        private ObservableCollection<KhachHang> _ListKhachHang;
        public ObservableCollection<KhachHang> ListKhachHang { get => _ListKhachHang; set { _ListKhachHang = value; OnPropertyChanged(); } }

        private KhachHang _SelectedKhachHang;
        public KhachHang SelectedKhachHang
        {
            get => _SelectedKhachHang;
            set
            {
                _SelectedKhachHang = value;
                OnPropertyChanged();
            }
        }


        public ICommand LoadWindow { get; set; }
        public ICommand CommandGuiSMS { get; set; }
        public ICommand CommandGuiGmail { get; set; }
        public ICommand CommandGuiGiamGia { get; set; }
        public ICommand CommandCheckAllKH { get; set; }
        public ICommand CommandUnCheckAllKH { get; set; }
        public ICommand CommandClose { get; set; }

        public GuiTinNhanViewModel()
        {
            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                CheckGuiSMS = true;
                CheckGuiMail = true;

                LoadGG();
                LoadKhachHang();
            }
            );

            CommandGuiGiamGia = new RelayCommand<object>((p) =>
            {
                if (CheckGuiMail == false && CheckGuiSMS == false)
                    return false;

                var giamGia = ChuongTrinhKhuyenMaiViewModel.GiamGia_DATA;
                if (giamGia.GG_TRANGTHAI == "Đã kết thúc" || giamGia.GG_TRANGTHAI == "Tạm ngưng")
                    return false;

                return true;
            }, (p) =>
            {
                var getListKHCheck = ListKhachHang.Where(x => x.IsCheck == true).ToList();

                if(CheckGuiMail == true)
                {
                    foreach(var item in getListKHCheck)
                    {
                        if (!string.IsNullOrEmpty(item.KH_EMAIL))
                            GuiMail("lqsang1807@gmail.com", item.KH_EMAIL, GG_TEN, GG_NOIDUNG);
                    }
                }

                if (CheckGuiSMS == true)
                {
                    string noiDung = GG_TEN + "\r\n" + GG_NOIDUNG;
                    foreach (var item in getListKHCheck)
                    {
                        if (!string.IsNullOrEmpty(item.KH_SDT))
                            GuiTinNhan(item.KH_SDT, noiDung);
                    }
                }
                
                MessageBox.Show("Gửi tin nhắn thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            );

            CommandCheckAllKH = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                var listKhachHang = DataProvider.Ins.DB.KHACHHANG.ToList();
                ListKhachHang = new ObservableCollection<KhachHang>();
                
                foreach(var item in listKhachHang)
                {
                    var khachHang = new KhachHang()
                    {
                        KH_MA = item.KH_MA,
                        KH_EMAIL = item.KH_EMAIL,
                        KH_SDT = item.KH_SDT,
                        KH_TEN = item.KH_HOTEN,
                        KH_GIOITINH = item.KH_GIOITINH,
                        KH_TUOI = Age(item.KH_NGAYSINH),
                        KH_DIACHI = item.KH_DIACHI + ", " + item.XAPHUONG.XP_TEN + ", " + item.XAPHUONG.HUYENQUAN.HQ_TEN + ", " + item.XAPHUONG.HUYENQUAN.TINHTHANH.TT_TEN,
                        KH_ANH = LayAnh(item.KH_GIOITINH),
                        IsCheck = true
                    };

                    ListKhachHang.Add(khachHang);
                }
            }
            );

            CommandUnCheckAllKH = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                var listKhachHang = DataProvider.Ins.DB.KHACHHANG.ToList();
                ListKhachHang = new ObservableCollection<KhachHang>();
                
                foreach(var item in listKhachHang)
                {
                    var khachHang = new KhachHang()
                    {
                        KH_MA = item.KH_MA,
                        KH_EMAIL = item.KH_EMAIL,
                        KH_SDT = item.KH_SDT,
                        KH_TEN = item.KH_HOTEN,
                        KH_GIOITINH = item.KH_GIOITINH,
                        KH_TUOI = Age(item.KH_NGAYSINH),
                        KH_DIACHI = item.KH_DIACHI + ", " + item.XAPHUONG.XP_TEN + ", " + item.XAPHUONG.HUYENQUAN.HQ_TEN + ", " + item.XAPHUONG.HUYENQUAN.TINHTHANH.TT_TEN,
                        KH_ANH = LayAnh(item.KH_GIOITINH),
                        IsCheck = false
                    };

                    ListKhachHang.Add(khachHang);
                }
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

        void LoadGG()
        {
            var giamGia = ChuongTrinhKhuyenMaiViewModel.GiamGia_DATA;

            if (giamGia.GG_TRANGTHAI == "Sắp diễn ra")
                GG_ANH = @"E:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Image\Discount\microphone.png";
            else if (giamGia.GG_TRANGTHAI == "Đang diễn ra")
                GG_ANH = @"E:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Image\Discount\sale-label.png";
            else if (giamGia.GG_TRANGTHAI == "Đã kết thúc")
                GG_ANH = @"E:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Image\Discount\discount-label.png";
            else if (giamGia.GG_TRANGTHAI == "Tạm ngưng")
                GG_ANH = @"E:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Image\Discount\discount (1).png";

            GG_TEN = giamGia.GG_TEN;
            GG_NGAYBATDAU = giamGia.GG_NGAYBATDAU;
            GG_NGAYKETTHUC = giamGia.GG_NGAYKETTHUC;
            GG_PHANTRAMGIAM = giamGia.GG_PHANTRAMGIAM;
            GG_TRANGTHAI = giamGia.GG_TRANGTHAI;
            GG_NOIDUNG = giamGia.GG_NOIDUNG;
            GG_LOAIGIAM = DAO_GiamGia.LayLoaiGiamGia(giamGia.GG_MA);
        }

        void LoadKhachHang()
        {
            var listKhachHang = DataProvider.Ins.DB.KHACHHANG;
            ListKhachHang = new ObservableCollection<KhachHang>();

            foreach(var item in listKhachHang)
            {
                var khachHang = new KhachHang()
                {
                    KH_MA = item.KH_MA,
                    KH_EMAIL = item.KH_EMAIL,
                    KH_SDT = item.KH_SDT,
                    KH_TEN = item.KH_HOTEN,
                    KH_GIOITINH = item.KH_GIOITINH,
                    KH_TUOI = Age(item.KH_NGAYSINH),
                    KH_DIACHI = item.KH_DIACHI + ", " + item.XAPHUONG.XP_TEN + ", " + item.XAPHUONG.HUYENQUAN.HQ_TEN + ", " + item.XAPHUONG.HUYENQUAN.TINHTHANH.TT_TEN,
                    KH_ANH = LayAnh(item.KH_GIOITINH)
                };

                ListKhachHang.Add(khachHang);
            }
        }

        string LayAnh(string gioiTinh)
        {
            if (gioiTinh == "Nam")
            {
                return @"E:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Avatars\Customer\man.png";
            }
            else
            {
                return @"E:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Avatars\Customer\woman.png";
            }
        }

        string Age(DateTime birthday)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - birthday.Year;
            if (now < birthday.AddYears(age)) age--;

            return age.ToString();
        }

        // Gửi theo các thông tin truyền vào
        void GuiMail(string from, string to, string subject, string message)
        {
            MailMessage mess = new MailMessage(from, to, subject, message);

            // Giúp để gửi mail
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("lqsang1807@gmail.com", "uchihaitachiqwe123");

            client.Send(mess);
        }

        const string APIKey = "092AC45AC37CE02E128C2C77E7E275";//Login to eSMS.vn to get this";//Dang ky tai khoan tai esms.vn de lay key//Register account at esms.vn to get key
        const string SecretKey = "C6E65F681EC9CAD507CD61474080B3";//Login to eSMS.vn to get this";

        void GuiTinNhan(string phone, string message)
        {
            // Create URL, method 1:
            string URL = "http://rest.esms.vn/MainService.svc/json/SendMultipleMessage_V4_get?Phone=" + phone + "&Content=" + message + "&ApiKey=" + APIKey + "&SecretKey=" + SecretKey + "&IsUnicode=0&SmsType=8";

            SendGetRequest(URL);
        }

        void SendGetRequest(string RequestUrl)
        {
            Uri address = new Uri(RequestUrl);
            HttpWebRequest request;
            HttpWebResponse response = null;
            if (address == null) { throw new ArgumentNullException("address"); }
            try
            {
                request = WebRequest.Create(address) as HttpWebRequest;
                request.UserAgent = ".NET Sample";
                request.KeepAlive = false;
                request.Timeout = 15 * 1000;
                response = request.GetResponse() as HttpWebResponse;
            }
            catch (WebException wex)
            {
                MessageBox.Show("Gửi thất bại");
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
