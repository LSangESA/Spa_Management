using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using LVTN_QLSpa.Model.ModelClass;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeDichVu
{
    /// <summary>
    /// Interaction logic for UC_ThongKeDichVu.xaml
    /// </summary>
    public partial class UC_ThongKeDichVu : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
        }

        private int _LUOTDANGKYTOP;
        public int LUOTDANGKYTOP
        {
            get { return _LUOTDANGKYTOP; }
            set
            {
                _LUOTDANGKYTOP = value;
                OnPropertyChanged("LUOTDANGKYTOP");
            }
        }

        private string _DICHVUTOP;
        public string DICHVUTOP
        {
            get { return _DICHVUTOP; }
            set
            {
                _DICHVUTOP = value;
                OnPropertyChanged("DICHVUTOP");
            }
        }

        /// <summary>
        /// ViewModel cho biểu đồ
        /// </summary>
        public class ProductTypeStatistic
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public int NumOfProduct { get; set; }
            public int Density { get; set; }
            public double Sold { get; set; }
        }

        // Ngày bắt đầu và ngày kết thúc
        DateTime dayBegin = new DateTime(2021, 1, 1);
        DateTime dayEnd = new DateTime(2021, 12, 31);

        public UC_ThongKeDichVu()
        {
            InitializeComponent();
            this.DataContext = this;
            // Thiết lập các Combobox
            editYear.ItemsSource = new string[] {
                "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2023", "2024", "2025" };

            editMonth.ItemsSource = new string[] {
                "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"
            };

            rdoCuThe.IsChecked = true;
            editYear.SelectedIndex = 6;
            editMonth.SelectedIndex = DateTime.Now.Month - 1;

            refreshProductTypeStatistic();
        }

        /// <summary>
        /// Làm mới các biểu đồ
        /// </summary>
        public void refreshProductTypeStatistic()
        {
            // Trước tiên lấy thông tin lọc của người dùng
            GetDuration();

            // Sau đó chạy nền lấy dữ liệu và hiển thị
            Thread thread = new Thread(delegate ()
            {
                // Lấy CSDL
                var Bills = new ObservableCollection<PHIEUDIEUTRI>(DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => dayBegin <= x.PDT_NGAYLAP && x.PDT_NGAYLAP <= dayEnd && x.PDT_TRANGTHAINNO == false));
                var Products = new ObservableCollection<GOIDICHVU>(DataProvider.Ins.DB.GOIDICHVU);
                var ProductTypes = new ObservableCollection<DICHVU>(DataProvider.Ins.DB.DICHVU);

                // ViewModels để hiển thị lên Chart
                ObservableCollection<ProductTypeStatistic> viewModels = new ObservableCollection<ProductTypeStatistic>();

                // Chuoi so lượng thực hiện dịch vụ
                var chuoiSo = new int[ProductTypes.Count]; 
                var chuoiDemDV = new int[ProductTypes.Count]; 
                var chuoiTenDV = new string[ProductTypes.Count]; 

                // Tính tổng số sản phẩm bán được (của tất cả các loại)
                //int totalSell = 0;
                //try
                //{
                //    totalSell = db.Bills.Sum(x => x.Number) + db.Bills.Sum(x => x.NumberGiven);
                //}
                //catch (Exception) { }

                // Xét từng loại sản phẩm
                for (int i = 0; i < ProductTypes.Count; i++)
                {
                    try
                    {
                        // Liệt kê tất cả sản phẩm thuộc loại đang xét (chỉ trích lấy mã)
                        var ProductTypeId = ProductTypes[i].DV_MA;
                        var productIds = Products.Where(x => x.DV_MA == ProductTypeId).Select(x => x.GDV_MA);

                        // Xét tất cả hóa đơn có mã SP thuộc danh sách trên
                        var neededBills = Bills.Where(x => productIds.Contains(x.PHIEUDANGKY.GDV_MA));

                        // Tính tổng sản phẩm & tổng số tiền trong các hóa đơn trên
                        int sumProduct = neededBills.Select(x=>x.PHIEUDANGKY).Distinct().Count();
                        double sumMoneySold = TinhThanhTien(new ObservableCollection<PHIEUDIEUTRI>(neededBills)) - TinhGiamGia(new ObservableCollection<PHIEUDIEUTRI>(neededBills));
                        chuoiSo[i] = neededBills.Count();
                        chuoiDemDV[i] = i;
                        chuoiTenDV[i] = ProductTypes[i].DV_TEN;
                        // Tạo đối tượng ProductTypeStatistic => Đưa vào danh sách View Models
                        viewModels.Add(new ProductTypeStatistic()
                        {
                            Id = ProductTypes[i].DV_MA,
                            Name = ProductTypes[i].DV_TEN,
                            NumOfProduct = neededBills.Count(),
                            //Density = sumProduct * 100 / totalSell,
                            Sold = sumMoneySold
                        });
                    }
                    catch (Exception) { }
                }

                // Lấy dữ liệu top
                LUOTDANGKYTOP = TinhSoDVTop(chuoiSo);
                DICHVUTOP = chuoiTenDV[TinhChuoiDem(chuoiDemDV)];

                // Đưa lên UI
                Dispatcher.Invoke(() =>
                {
                    columnChart1.ItemsSource = viewModels;
                    columnChart2.ItemsSource = viewModels;
                });
            });
            thread.Start();
        }

        private void Click_ButtonLoc(object sender, RoutedEventArgs e)
        {
            refreshProductTypeStatistic();
        }

        private void Click_ButtonBoLoc(object sender, RoutedEventArgs e)
        {
            rdoCuThe.IsChecked = true;
            editYear.SelectedIndex = 6;
            editMonth.SelectedIndex = DateTime.Now.Month - 1;

            refreshProductTypeStatistic();
        }

        /// <summary>
        /// Lấy lại ngày bắt đầu và ngày kết thúc
        /// </summary>
        public void GetDuration()
        {
            // Nếu lọc theo thời gian tùy chọn của người dùng
            if (rdoOption.IsChecked == true)
            {
                // Kiểm tra 2 DatePicker có trống không
                if (editFromDate.Text.Length == 0 || editToDate.Text.Length == 0)
                {
                    MessageBox.Show("Không được bỏ trống!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else if (string.Compare(editFromDate.Text, editToDate.Text, true) > 0)
                {
                    MessageBox.Show("Ngày không hợp lệ!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                dayBegin = (DateTime)editFromDate.SelectedDate;
                dayEnd = (DateTime)editToDate.SelectedDate;
            }
            // Nếu lọc theo thời gian cụ thể
            else
            {
                // Kiểm tra tháng và năm có bỏ trống không
                if (editMonth.SelectedIndex != 0 && editYear.SelectedIndex != 0)
                {
                    dayBegin = new DateTime(int.Parse(editYear.SelectedItem as string), int.Parse(editMonth.SelectedItem as string), 1);            // Ngày đầu của tháng luôn là 1
                    int numOfDay = DateTime.DaysInMonth(int.Parse(editYear.SelectedItem as string), int.Parse(editMonth.SelectedItem as string));   // Tính số ngày của tháng
                    dayEnd = new DateTime(int.Parse(editYear.SelectedItem as string), int.Parse(editMonth.SelectedItem as string), numOfDay);       // Ngày cuối của tháng
                }
                // Xuất lỗi khi bỏ trống
                else
                {
                    MessageBox.Show("Không được bỏ trống!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
        }

        int TinhThanhTien(ObservableCollection<PHIEUDIEUTRI> listPhieuDieuTri)
        {
            int thanhTien = 0;
            int totalMoney = 0;

            var getPhieuDieuTriThanhToan = listPhieuDieuTri.ToList();

            foreach (var item in getPhieuDieuTriThanhToan)
            {
                if (item.PHIEUDANGKY.CTT_MA == 2)
                {
                    int PDT_STT = Convert.ToInt32(item.PDT_STT);
                    var getMoneyLT = DataProvider.Ins.DB.DG_LT.Where(x => x.LIEUTRINH.LT_STT == PDT_STT && x.GDV_MA == item.PHIEUDANGKY.GDV_MA).Select(x => x.DONGIA).SingleOrDefault();
                    totalMoney += int.Parse(getMoneyLT.Replace(".", ""));

                }
                else if (item.PHIEUDANGKY.CTT_MA == 1)
                {
                    //int PDT_STT = Convert.ToInt32(item.PDT_STT);
                    var getMoneyGDV = DataProvider.Ins.DB.DG_GDV.Where(x => x.GDV_MA == item.PHIEUDANGKY.GDV_MA).Select(x => x.DONGIA).SingleOrDefault();
                    totalMoney += int.Parse(getMoneyGDV.Replace(".", ""));
                }
            }

            thanhTien = totalMoney;

            return thanhTien;
        }

        int TinhGiamGia(ObservableCollection<PHIEUDIEUTRI> listPhieuDieuTri)
        {
            /*
                Xem gói dịch vụ đăng ký có nằm trong mục giảm giá hay không -> Nếu có
                Nếu phiếu đăng ký đó giảm theo gói
                    -> lấy ra giá gói -> tính số phần trăm được giảm của gói đó 
                Nếu phiếu đó giảm theo liệu trình
                    -> lấy ra giá liệu trình của phiếu điều trị đó -> tính phần trăm được giảm
            */
            int totalMoney = 0;
            int giaGiam = 0;

            var getPhieuDieuTriThanhToan = listPhieuDieuTri.ToList();

            foreach (var item in getPhieuDieuTriThanhToan)
            {
                var getPDK_GG = DataProvider.Ins.DB.GIAMGIA_PDK.Where(x => x.PDK_STT == item.PDK_STT).SingleOrDefault();
                if (getPDK_GG != null)
                {
                    if (item.PHIEUDANGKY.CTT_MA == 1)
                    {
                        //int PDT_STT = Convert.ToInt32(item.PDT_STT);
                        var getMoneyGDV = DataProvider.Ins.DB.DG_GDV.Where(x => x.GDV_MA == item.PHIEUDANGKY.GDV_MA).Select(x => x.DONGIA).SingleOrDefault();
                        totalMoney = int.Parse(getMoneyGDV.Replace(".", ""));
                        giaGiam += totalMoney * getPDK_GG.GIAMGIA.GG_PHANTRAMGIAM / 100;
                    }
                    else if (item.PHIEUDANGKY.CTT_MA == 2)
                    {
                        int PDT_STT = Convert.ToInt32(item.PDT_STT);
                        var getMoneyLT = DataProvider.Ins.DB.DG_LT.Where(x => x.LIEUTRINH.LT_STT == PDT_STT && x.GDV_MA == item.PHIEUDANGKY.GDV_MA).Select(x => x.DONGIA).SingleOrDefault();
                        totalMoney += int.Parse(getMoneyLT.Replace(".", ""));
                        giaGiam += totalMoney * getPDK_GG.GIAMGIA.GG_PHANTRAMGIAM / 100;
                    }
                }
            }

            return giaGiam;
        }
        
        int TinhSoDVTop(int[] chuoi)
        {
            int max = 0;

            for(int i=0; i < chuoi.Count(); i++)
            {
                if(max < chuoi[i])
                {
                    max = chuoi[i];
                }
            }

            return max;
        }

        int TinhChuoiDem(int[] chuoi)
        {
            int max = 0;

            for (int i = 0; i < chuoi.Count(); i++)
            {
                if (max < chuoi[i])
                {
                    max = i;
                }
            }

            return max;
        }
        
    }
}
