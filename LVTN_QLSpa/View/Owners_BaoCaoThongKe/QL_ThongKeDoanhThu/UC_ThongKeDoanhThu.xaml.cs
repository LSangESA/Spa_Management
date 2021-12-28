using Aspose.Cells;
using InteractiveDataDisplay.WPF;
using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using LVTN_QLSpa.Model.ModelClass;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
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
using System.Xml.Linq;

namespace LVTN_QLSpa.View.Owners_BaoCaoThongKe.QL_ThongKeDoanhThu
{
    /// <summary>
    /// Interaction logic for UC_ThongKeDoanhThu.xaml
    /// </summary>
    public partial class UC_ThongKeDoanhThu : UserControl, INotifyPropertyChanged
    {
        // Doanh thu
        LineGraph line1 = new LineGraph();

        // Khai báo biên
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
        }

        private int _SOPHIEUTHU;
        public int SOPHIEUTHU
        {
            get { return _SOPHIEUTHU; }
            set
            {
                _SOPHIEUTHU = value;
                OnPropertyChanged("SOPHIEUTHU");
            }
        }

        ObservableCollection<PHIEUTHU> listPhieuThu = new ObservableCollection<PHIEUTHU>();

        private string _TONGTIENPHIEUTHU;
        public string TONGTIENPHIEUTHU
        {
            get { return _TONGTIENPHIEUTHU; }
            set
            {
                _TONGTIENPHIEUTHU = value;
                OnPropertyChanged("TONGTIENPHIEUTHU");
            }
        }

        public UC_ThongKeDoanhThu()
        {
            InitializeComponent();
            this.DataContext = this;

            // Thiết lập các Combobox
            editYear.ItemsSource = editYearAll.ItemsSource = new string[] {
                "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2023", "2024", "2025" };
            editMonth.ItemsSource = new string[] {
                "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"
            };
            editMonth.SelectedIndex = DateTime.Now.Month - 1;
            editYear.SelectedIndex = 6;
            editYearAll.SelectedIndex = 6;
            
            // Đường doanh thu
            Lines.Children.Add(line1);
            line1.Stroke = new SolidColorBrush(Colors.Red);
            line1.Description = "Doanh thu";
            line1.StrokeThickness = 2;

            rdoDayMonth.IsChecked = true;
            LoadDuLieu();
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (rdoDayMonth.IsChecked == true)
            {
                editMonth.SelectedIndex = editMonth.SelectedIndex;
                editYear.SelectedIndex = editYear.SelectedIndex;

                // Chỉ thực hiện khi đã có dữ liệu
                if (editYear.SelectedIndex == -1 || editMonth.SelectedIndex == -1) return;

                // Lấy số ngày trong tháng
                int numOfDay = DateTime.DaysInMonth(int.Parse(editYear.SelectedItem as string), int.Parse(editMonth.SelectedItem as string));

                // Mảng ngày
                decimal[] months = new decimal[numOfDay];
                for (int i = 0; i < months.Length; i++) months[i] = i + 1;

                // Mảng doanh thu
                decimal[] profitByMonth = new decimal[numOfDay];

                var listPhieuThu = new ObservableCollection<PHIEUTHU>();
                for (int i = 0; i < numOfDay; i++)
                {
                    // Lấy ngày đang xét
                    DateTime day = new DateTime(int.Parse(editYear.SelectedItem as string), int.Parse(editMonth.SelectedItem as string), i + 1);

                    // Lấy tất cả hóa đơn trong ngày
                    var tmpBills = new ObservableCollection<PHIEUTHU>(DataProvider.Ins.DB.PHIEUTHU);
                    var Bills = new ObservableCollection<PHIEUTHU>();

                    for (int j = 0; j < tmpBills.Count; j++)
                    {
                        if (tmpBills[j].PT_NGAYLAP.Year == day.Year
                            && tmpBills[j].PT_NGAYLAP.Month == day.Month
                            && tmpBills[j].PT_NGAYLAP.Day == day.Day)
                        {
                            Bills.Add(tmpBills[j]);
                            listPhieuThu.Add(tmpBills[j]);
                        }
                    }

                    // Tính số tiền thu được trong các Bill trên
                    decimal y = Bills.Sum(x => x.PT_TONGTIEN);
                    profitByMonth[i] = y;
                }

                // Lấy danh sách phiếu thu
                lvwPHIEUTHU.ItemsSource = getPhieuThuTheoThangNam(listPhieuThu);
                SOPHIEUTHU = GetSoLuongPhieuThu(listPhieuThu);
                TONGTIENPHIEUTHU = GetTongTienPhieuThu(listPhieuThu);

                Plotter.BottomTitle = "Ngày (tháng " + editMonth.Text + "/" + editYear.Text + ")";
                line1.Plot(months, profitByMonth);
            }
            else
            {
                // Lấy ra năm cần lọc
                editYearAll.SelectedIndex = editYearAll.SelectedIndex;

                // Chỉ thực hiện khi đã có dữ liệu
                if (editYearAll.SelectedIndex == -1) return;

                // Mảng tháng
                double[] months = new double[12];
                for (int i = 0; i < months.Length; i++) months[i] = i + 1;

                // Mảng doanh thu
                decimal[] profitByMonth = new decimal[12];

                listPhieuThu = new ObservableCollection<PHIEUTHU>();
                for (int i = 0; i < 12; i++)
                {
                    // Lấy ngày đầu và ngày cuối của tháng
                    DateTime dayBegin = new DateTime(int.Parse(editYearAll.SelectedItem as string), i + 1, 1);
                    int numOfDay = DateTime.DaysInMonth(int.Parse(editYearAll.SelectedItem as string), i + 1);
                    DateTime dayEnd = new DateTime(int.Parse(editYearAll.SelectedItem as string), i + 1, numOfDay);

                    // Lấy tất cả hóa đơn trong tháng
                    var Bills = new ObservableCollection<PHIEUTHU>(DataProvider.Ins.DB.PHIEUTHU.Where(x => dayBegin <= x.PT_NGAYLAP && x.PT_NGAYLAP <= dayEnd));
                    foreach(var item in Bills.ToList())
                    {
                        listPhieuThu.Add(item);
                    }
                    // Tính số tiền thu được trong các Bill trên
                    profitByMonth[i] = Bills.Sum(x => x.PT_TONGTIEN);
                }

                lvwPHIEUTHU.ItemsSource = getPhieuThuTheoThangNam(listPhieuThu);
                SOPHIEUTHU = GetSoLuongPhieuThu(listPhieuThu);
                TONGTIENPHIEUTHU = GetTongTienPhieuThu(listPhieuThu);

                Plotter.BottomTitle = "Tháng (năm " + editYear.Text + ")";
                line1.Plot(months, profitByMonth);
            }
        }

        ObservableCollection<PHIEUTHU> getPhieuThuTheoThangNam(ObservableCollection<PHIEUTHU> phieuThu)
        {
            return new ObservableCollection<PHIEUTHU>(phieuThu.OrderByDescending(x=>x.PT_NGAYLAP).ToList());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            rdoDayMonth.IsChecked = true;
            editMonth.SelectedIndex = DateTime.Now.Month - 1;
            editYear.SelectedIndex = 6;
            editYearAll.SelectedIndex = 6;

            LoadDuLieu();
        }

        void LoadDuLieu()
        {
            // Load dữ liệu
            // Chỉ thực hiện khi đã có dữ liệu
            if (editYear.SelectedIndex == -1 || editMonth.SelectedIndex == -1) return;

            // Lấy số ngày trong tháng
            int numOfDay = DateTime.DaysInMonth(int.Parse(editYear.SelectedItem as string), int.Parse(editMonth.SelectedItem as string));

            // Mảng ngày
            decimal[] months = new decimal[numOfDay];
            for (int i = 0; i < months.Length; i++) months[i] = i + 1;

            // Mảng doanh thu
            decimal[] profitByMonth = new decimal[numOfDay];

            listPhieuThu = new ObservableCollection<PHIEUTHU>();
            for (int i = 0; i < numOfDay; i++)
            {
                // Lấy ngày đang xét
                DateTime day = new DateTime(int.Parse(editYear.SelectedItem as string), int.Parse(editMonth.SelectedItem as string), i + 1);

                // Lấy tất cả hóa đơn trong ngày
                var tmpBills = new ObservableCollection<PHIEUTHU>(DataProvider.Ins.DB.PHIEUTHU);
                var Bills = new ObservableCollection<PHIEUTHU>();

                for (int j = 0; j < tmpBills.Count; j++)
                {
                    if (tmpBills[j].PT_NGAYLAP.Year == day.Year
                        && tmpBills[j].PT_NGAYLAP.Month == day.Month
                        && tmpBills[j].PT_NGAYLAP.Day == day.Day)
                    {
                        Bills.Add(tmpBills[j]);
                        listPhieuThu.Add(tmpBills[j]);
                    }
                }

                // Tính số tiền thu được trong các Bill trên
                decimal y = Bills.Sum(x => x.PT_TONGTIEN);
                profitByMonth[i] = y;
            }

            // Lấy danh sách phiếu thu
            lvwPHIEUTHU.ItemsSource = getPhieuThuTheoThangNam(listPhieuThu);
            SOPHIEUTHU = GetSoLuongPhieuThu(listPhieuThu);
            TONGTIENPHIEUTHU = GetTongTienPhieuThu(listPhieuThu);

            Plotter.BottomTitle = "Ngày (tháng " + editMonth.Text + "/" + editYear.Text + ")";
            line1.Plot(months, profitByMonth);
        }

        string GetTongTienPhieuThu(ObservableCollection<PHIEUTHU> phieuThu)
        {
            decimal tongTienPhieuThu = 0;
            if (phieuThu.Count() > 0)
            {
                foreach (var item in phieuThu)
                {
                    tongTienPhieuThu += item.PT_TONGTIEN;
                }
                return ClassXuLyChuoi.ChuyenSoThanhTien(Convert.ToInt32(tongTienPhieuThu));
            }

            return ClassXuLyChuoi.ChuyenSoThanhTien(Convert.ToInt32(tongTienPhieuThu));
        }

        int GetSoLuongPhieuThu(ObservableCollection<PHIEUTHU> phieuThu)
        {
            int soLuongPhieu = 0;
            if (phieuThu.Count() > 0)
            {
                soLuongPhieu = phieuThu.Count();
                return soLuongPhieu;
            }
            return soLuongPhieu;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var List = DAO_PhieuThu.ListPhieuThuReport(new ObservableCollection<PHIEUTHU>(listPhieuThu));

            // Mở hộp thoại lưu tập tin
            Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            saveFileDialog.DefaultExt = ".xlsx";
            saveFileDialog.Filter = "Excel Workbook (.xlsx)|*.xlsx";

            if (false == saveFileDialog.ShowDialog()) return;
            string filename = saveFileDialog.FileName;

            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets[0];
            worksheet.Name = "DoanhThu";

            // Ghi các cột
            worksheet.Cells["A1"].PutValue("STT");
            worksheet.Cells["B1"].PutValue("SỐ PHIẾU THU");
            worksheet.Cells["C1"].PutValue("NGÀY LẬP");
            worksheet.Cells["D1"].PutValue("MÃ KHÁCH HÀNG");
            worksheet.Cells["E1"].PutValue("HỌ TÊN KHÁCH HÀNG");
            worksheet.Cells["F1"].PutValue("HÌNH THỨC THANH TOÁN");
            worksheet.Cells["G1"].PutValue("NHÂN VIÊN LẬP PHIẾU");
            worksheet.Cells["H1"].PutValue("SỐ PHIẾU ĐIÊU TRỊ THU");
            worksheet.Cells["I1"].PutValue("TỔNG TIỀN");
            for (int y = 0; y < List.Count; y++)
            {
                worksheet.Cells[$"A{y + 2}"].PutValue(List[y].STT);
                worksheet.Cells[$"B{y + 2}"].PutValue(List[y].PT_STT);
                worksheet.Cells[$"C{y + 2}"].PutValue(List[y].PT_NGAYLAP.ToString("dd/MM/yyyy hh:mm"));
                worksheet.Cells[$"D{y + 2}"].PutValue(List[y].KH_MA);
                worksheet.Cells[$"E{y + 2}"].PutValue(List[y].KH_HOTEN);
                worksheet.Cells[$"F{y + 2}"].PutValue(List[y].HTTT_TEN);
                worksheet.Cells[$"G{y + 2}"].PutValue(List[y].NV_TEN);
                worksheet.Cells[$"H{y + 2}"].PutValue(List[y].PDT_THU);
                worksheet.Cells[$"I{y + 2}"].PutValue(List[y].PT_TONGTIEN);
            }

            worksheet.Cells[$"H{List.Count + 3}"].PutValue("TỔNG SỐ PHIẾU:");
            worksheet.Cells[$"I{List.Count + 3}"].PutValue(SOPHIEUTHU);
            worksheet.Cells[$"H{List.Count + 4}"].PutValue("TỔNG TIỀN:");
            worksheet.Cells[$"I{List.Count + 4}"].PutValue(TONGTIENPHIEUTHU);

            worksheet.AutoFitColumns();
            workbook.Save(filename);
        }
    }
}
