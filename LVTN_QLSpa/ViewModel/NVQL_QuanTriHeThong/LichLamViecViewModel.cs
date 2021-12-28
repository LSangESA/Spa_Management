using Aspose.Cells;
using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using LVTN_QLSpa.Model.ModelClass;
using LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLLLV;
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
    public class LichLamViecViewModel : BaseViewModel
    {
        private static LICHLAMVIEC llv_DATA;
        public static LICHLAMVIEC LLV_DATA
        {
            get { return LichLamViecViewModel.llv_DATA; }
            set { LichLamViecViewModel.llv_DATA = value; }
        }

        // Khai bao bien

        private DateTime _thu2;
        public DateTime thu2 { get => _thu2; set { _thu2 = value; OnPropertyChanged(); } }
        private DateTime _thu3;
        public DateTime thu3 { get => _thu3; set { _thu3 = value; OnPropertyChanged(); } }
        private DateTime _thu4;
        public DateTime thu4 { get => _thu4; set { _thu4 = value; OnPropertyChanged(); } }
        private DateTime _thu5;
        public DateTime thu5 { get => _thu5; set { _thu5 = value; OnPropertyChanged(); } }
        private DateTime _thu6;
        public DateTime thu6 { get => _thu6; set { _thu6 = value; OnPropertyChanged(); } }
        private DateTime _thu7;
        public DateTime thu7 { get => _thu7; set { _thu7 = value; OnPropertyChanged(); } }
        private DateTime _chunhat;
        public DateTime chunhat { get => _chunhat; set { _chunhat = value; OnPropertyChanged(); } }

        private string _ColorT2;
        public string ColorT2 { get => _ColorT2; set { _ColorT2 = value; OnPropertyChanged(); } }

        private string _ColorT3;
        public string ColorT3 { get => _ColorT3; set { _ColorT3 = value; OnPropertyChanged(); } }

        private string _ColorT4;
        public string ColorT4 { get => _ColorT4; set { _ColorT4 = value; OnPropertyChanged(); } }

        private string _ColorT5;
        public string ColorT5 { get => _ColorT5; set { _ColorT5 = value; OnPropertyChanged(); } }

        private string _ColorT6;
        public string ColorT6 { get => _ColorT6; set { _ColorT6 = value; OnPropertyChanged(); } }

        private string _ColorT7;
        public string ColorT7 { get => _ColorT7; set { _ColorT7 = value; OnPropertyChanged(); } }

        private string _ColorCN;
        public string ColorCN { get => _ColorCN; set { _ColorCN = value; OnPropertyChanged(); } }

        private DateTime _LLV_NGAYDAUTUAN;
        public DateTime LLV_NGAYDAUTUAN { get => _LLV_NGAYDAUTUAN; set { _LLV_NGAYDAUTUAN = value; OnPropertyChanged(); } }

        private DateTime _LLV_NGAYCUOITUAN;
        public DateTime LLV_NGAYCUOITUAN { get => _LLV_NGAYCUOITUAN; set { _LLV_NGAYCUOITUAN = value; OnPropertyChanged(); } }

        private ObservableCollection<ClassListLichlamViec> _calendar;
        public ObservableCollection<ClassListLichlamViec> calendar { get => _calendar; set { _calendar = value; OnPropertyChanged(); } }

        private ObservableCollection<PHONG> _PHONG;
        public ObservableCollection<PHONG> PHONG { get => _PHONG; set { _PHONG = value; OnPropertyChanged(); } }

        private ObservableCollection<VAITRO> _VAITRO;
        public ObservableCollection<VAITRO> VAITRO { get => _VAITRO; set { _VAITRO = value; OnPropertyChanged(); } }


        private PHONG _SelectedPHONG;
        public PHONG SelectedPHONG
        {
            get => _SelectedPHONG;
            set
            {
                _SelectedPHONG = value;
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


        public ICommand LoadWindow { get; set; }
        public ICommand CommandBack { get; set; }
        public ICommand CommandNext { get; set; }
        public ICommand CommandToDay { get; set; }
        public ICommand CommandInLichLamViec { get; set; }
        public ICommand CommandAddLichLamViec { get; set; }
        public ICommand CommandShowInfoLLV { get; set; }
        public ICommand CommnadLoc { get; set; }
        public ICommand CommandXoaLoc { get; set; }
        
        public LichLamViecViewModel()
        {
            DateTime currentDay = new DateTime();
            DateTime dayNow = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                PHONG = DAO_Phong.GetList();
                VAITRO = DAO_VaiTro.GetList();

                currentDay = FindMondayOfTheWeek(dayNow);
                ViewCalander(currentDay);
            }
            );

            CommandBack = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                currentDay = currentDay.AddDays(Convert.ToDouble(-7));
                ViewCalander(currentDay);
            }
            );

            CommandNext = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                currentDay = currentDay.AddDays(Convert.ToDouble(7));
                ViewCalander(currentDay);
            }
            );

            CommandToDay = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                currentDay = FindMondayOfTheWeek(dayNow);
                ViewCalander(currentDay);
            }
            );

            CommandInLichLamViec = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                var List = calendar.Where(x=>x.CLV_MA == "CLV7961             ").ToList();
                var List2 = calendar.Where(x => x.CLV_MA == "CLV8258             ").ToList();
                var List3 = calendar.Where(x => x.CLV_MA == "CLV2765             ").ToList();

                // Mở hộp thoại lưu tập tin
                Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
                saveFileDialog.DefaultExt = ".xlsx";
                saveFileDialog.Filter = "Excel Workbook (.xlsx)|*.xlsx";

                if (false == saveFileDialog.ShowDialog()) return;
                string filename = saveFileDialog.FileName;

                Workbook workbook = new Workbook();
                Worksheet worksheet = workbook.Worksheets[0];
                worksheet.Name = "LichLamViec";

                // Ghi các cột
                worksheet.Cells["A1"].PutValue(thu2.ToString("dd/MM/yyyy"));
                worksheet.Cells["B1"].PutValue(thu3.ToString("dd/MM/yyyy"));
                worksheet.Cells["C1"].PutValue(thu4.ToString("dd/MM/yyyy"));
                worksheet.Cells["D1"].PutValue(thu5.ToString("dd/MM/yyyy"));
                worksheet.Cells["E1"].PutValue(thu6.ToString("dd/MM/yyyy"));
                worksheet.Cells["F1"].PutValue(thu7.ToString("dd/MM/yyyy"));
                worksheet.Cells["G1"].PutValue(chunhat.ToString("dd/MM/yyyy"));

                worksheet.Cells["A3"].PutValue("Sáng");

                for (int y = 0; y < List.Count; y++)
                {
                    worksheet.Cells[$"A{y + 4}"].PutValue(List[y].T2_NV_TEN + " - " + List[y].T2_P_TEN.Trim(' ') + " - " + List[y].T2_VT_TEN);
                    worksheet.Cells[$"B{y + 4}"].PutValue(List[y].T3_NV_TEN + " - " + List[y].T3_P_TEN.Trim(' ') + " - " + List[y].T3_VT_TEN);
                    worksheet.Cells[$"C{y + 4}"].PutValue(List[y].T4_NV_TEN + " - " + List[y].T4_P_TEN.Trim(' ') + " - " + List[y].T4_VT_TEN);
                    worksheet.Cells[$"D{y + 4}"].PutValue(List[y].T5_NV_TEN + " - " + List[y].T5_P_TEN.Trim(' ') + " - " + List[y].T5_VT_TEN);
                    worksheet.Cells[$"E{y + 4}"].PutValue(List[y].T6_NV_TEN + " - " + List[y].T6_P_TEN.Trim(' ') + " - " + List[y].T6_VT_TEN);
                    worksheet.Cells[$"F{y + 4}"].PutValue(List[y].T7_NV_TEN + " - " + List[y].T7_P_TEN.Trim(' ') + " - " + List[y].T7_VT_TEN);
                    worksheet.Cells[$"G{y + 4}"].PutValue(List[y].CN_NV_TEN + " - " + List[y].CN_P_TEN.Trim(' ') + " - " + List[y].CN_VT_TEN);
                }

                worksheet.Cells[$"A{List.Count + 4}"].PutValue("Chiều");

                for (int y = 0; y < List2.Count; y++)
                {
                    worksheet.Cells[$"A{y + List.Count + 5}"].PutValue(List2[y].T2_NV_TEN + " - " + List2[y].T2_P_TEN.Trim(' ') + " - " + List2[y].T2_VT_TEN);
                    worksheet.Cells[$"B{y + List.Count + 5}"].PutValue(List2[y].T3_NV_TEN + " - " + List2[y].T3_P_TEN.Trim(' ') + " - " + List2[y].T3_VT_TEN);
                    worksheet.Cells[$"C{y + List.Count + 5}"].PutValue(List2[y].T4_NV_TEN + " - " + List2[y].T4_P_TEN.Trim(' ') + " - " + List2[y].T4_VT_TEN);
                    worksheet.Cells[$"D{y + List.Count + 5}"].PutValue(List2[y].T5_NV_TEN + " - " + List2[y].T5_P_TEN.Trim(' ') + " - " + List2[y].T5_VT_TEN);
                    worksheet.Cells[$"E{y + List.Count + 5}"].PutValue(List2[y].T6_NV_TEN + " - " + List2[y].T6_P_TEN.Trim(' ') + " - " + List2[y].T6_VT_TEN);
                    worksheet.Cells[$"F{y + List.Count + 5}"].PutValue(List2[y].T7_NV_TEN + " - " + List2[y].T7_P_TEN.Trim(' ') + " - " + List2[y].T7_VT_TEN);
                    worksheet.Cells[$"G{y + List.Count + 5}"].PutValue(List2[y].CN_NV_TEN + " - " + List2[y].CN_P_TEN.Trim(' ') + " - " + List2[y].CN_VT_TEN);
                }

                worksheet.Cells[$"A{List.Count + List2.Count + 6}"].PutValue("Cả ngày");

                for (int y = 0; y < List3.Count; y++)
                {
                    worksheet.Cells[$"A{y + List2.Count + List.Count + 7}"].PutValue(List3[y].T2_NV_TEN + " - " + List3[y].T2_P_TEN.Trim(' ') + " - " + List3[y].T2_VT_TEN);
                    worksheet.Cells[$"B{y + List2.Count + List.Count + 7}"].PutValue(List3[y].T3_NV_TEN + " - " + List3[y].T3_P_TEN.Trim(' ') + " - " + List3[y].T3_VT_TEN);
                    worksheet.Cells[$"C{y + List2.Count + List.Count + 7}"].PutValue(List3[y].T4_NV_TEN + " - " + List3[y].T4_P_TEN.Trim(' ') + " - " + List3[y].T4_VT_TEN);
                    worksheet.Cells[$"D{y + List2.Count + List.Count + 7}"].PutValue(List3[y].T5_NV_TEN + " - " + List3[y].T5_P_TEN.Trim(' ') + " - " + List3[y].T5_VT_TEN);
                    worksheet.Cells[$"E{y + List2.Count + List.Count + 7}"].PutValue(List3[y].T6_NV_TEN + " - " + List3[y].T6_P_TEN.Trim(' ') + " - " + List3[y].T6_VT_TEN);
                    worksheet.Cells[$"F{y + List2.Count + List.Count + 7}"].PutValue(List3[y].T7_NV_TEN + " - " + List3[y].T7_P_TEN.Trim(' ') + " - " + List3[y].T7_VT_TEN);
                    worksheet.Cells[$"G{y + List2.Count + List.Count + 7}"].PutValue(List3[y].CN_NV_TEN + " - " + List3[y].CN_P_TEN.Trim(' ') + " - " + List3[y].CN_VT_TEN);
                }

                worksheet.AutoFitColumns();
                workbook.Save(filename);
            }
            );

            CommandAddLichLamViec = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                W_LapLichLamViec lapLichLamViec = new W_LapLichLamViec();
                lapLichLamViec.ShowDialog();
                ViewCalander(currentDay);
            }
            );

            CommandShowInfoLLV = new RelayCommand<ClassListLichlamViec>((p) =>
            {
                return true;
            }, (p) =>
            {
                var llv = CheckNullListLLV();
                LLV_DATA = GetLichLamViec(llv);

                if(LLV_DATA != null)
                {
                    W_InfoLichLamViecNhanVien window = new W_InfoLichLamViecNhanVien();
                    window.ShowDialog();
                    
                    ViewCalander(currentDay);
                }

                LLV_DATA = null;
            }
            );

            CommnadLoc = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                ViewCalander(currentDay);
            }
            );

            CommandXoaLoc = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                SelectedPHONG = null;
                SelectedVAITRO = null;

                ViewCalander(currentDay);
            }
            );
        }

        List<LICHLAMVIEC> GetDataFilter()
        {
            var lichLamViec = new List<LICHLAMVIEC>();

            if(SelectedPHONG != null && SelectedVAITRO != null)
            {
                var nhanVienVT = DAO_NhanVien.GetList(SelectedVAITRO.VT_MA).ToList();
                var lichTheoVT = DataProvider.Ins.DB.LICHLAMVIEC.ToList();

                foreach (var item in nhanVienVT.ToList())
                {
                    foreach (var item2 in lichTheoVT.ToList())
                    {
                        if (item == item2.NHANVIEN)
                            lichLamViec.Add(item2);
                    }
                }

                lichLamViec = lichLamViec.Where(x => x.P_MA == SelectedPHONG.P_MA).ToList();
            }
            else if(SelectedPHONG != null)
            {
                lichLamViec = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.P_MA == SelectedPHONG.P_MA).ToList();
            }
            else if(SelectedVAITRO != null)
            {
                var nhanVienVT = DAO_NhanVien.GetList(SelectedVAITRO.VT_MA).ToList();
                var lichTheoVT = DataProvider.Ins.DB.LICHLAMVIEC.ToList();

                foreach(var item in nhanVienVT.ToList())
                {
                    foreach(var item2 in lichTheoVT.ToList())
                    {
                        if (item == item2.NHANVIEN)
                            lichLamViec.Add(item2);
                    }
                }
            }
            else
            {
                lichLamViec = DataProvider.Ins.DB.LICHLAMVIEC.ToList();
            }

            return lichLamViec.ToList();
        }

        ClassListLichlamViec CheckNullListLLV()
        {
            var lichLamViec = new ClassListLichlamViec();

            var llv2 = this.calendar.Where(x => x.T2_Checked == true).SingleOrDefault();
            var llv3 = this.calendar.Where(x => x.T3_Checked == true).SingleOrDefault();
            var llv4 = this.calendar.Where(x => x.T4_Checked == true).SingleOrDefault();
            var llv5 = this.calendar.Where(x => x.T5_Checked == true).SingleOrDefault();
            var llv6 = this.calendar.Where(x => x.T6_Checked == true).SingleOrDefault();
            var llv7 = this.calendar.Where(x => x.T7_Checked == true).SingleOrDefault();
            var llvCN = this.calendar.Where(x => x.CN_Checked == true).SingleOrDefault();

            var Lich = new ClassListLichlamViec[] { llv2, llv3, llv4, llv5, llv6, llv7, llvCN };
            lichLamViec = Lich[0];

            int i = 0;
            while(Lich[i] == null)
            {
                lichLamViec = Lich[i + 1];
                i++;
            }

            return lichLamViec;
        }

        LICHLAMVIEC GetLichLamViec(ClassListLichlamViec llv)
        {
            LICHLAMVIEC lichLamViec = new LICHLAMVIEC();
            if(llv.T2_Checked == true)
            {
                if(!string.IsNullOrEmpty(llv.T2_NV_TEN))
                {
                    lichLamViec = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.THOIGIAN == llv.T2_THOIGIAN && x.NV_MA == llv.T2_NV_MA && x.CLV_MA == llv.CLV_MA).SingleOrDefault();
                }
                else
                {
                    return null;
                }
            }
            else if (llv.T3_Checked == true)
            {
                if (!string.IsNullOrEmpty(llv.T3_NV_TEN))
                {
                    lichLamViec = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.THOIGIAN == llv.T3_THOIGIAN && x.NV_MA == llv.T3_NV_MA && x.CLV_MA == llv.CLV_MA).SingleOrDefault();
                }
                else
                {
                    return null;
                }
            }
            else if (llv.T4_Checked == true)
            {
                if (!string.IsNullOrEmpty(llv.T4_NV_TEN))
                {
                    lichLamViec = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.THOIGIAN == llv.T4_THOIGIAN && x.NV_MA == llv.T4_NV_MA && x.CLV_MA == llv.CLV_MA).SingleOrDefault();
                }
                else
                {
                    return null;
                }
            }
            else if (llv.T5_Checked == true)
            {
                if (!string.IsNullOrEmpty(llv.T5_NV_TEN))
                {
                    lichLamViec = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.THOIGIAN == llv.T5_THOIGIAN && x.NV_MA == llv.T5_NV_MA && x.CLV_MA == llv.CLV_MA).SingleOrDefault();
                }
                else
                {
                    return null;
                }
            }
            else if (llv.T6_Checked == true)
            {
                if (!string.IsNullOrEmpty(llv.T6_NV_TEN))
                {
                    lichLamViec = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.THOIGIAN == llv.T6_THOIGIAN && x.NV_MA == llv.T6_NV_MA && x.CLV_MA == llv.CLV_MA).SingleOrDefault();
                }
                else
                {
                    return null;
                }
            }
            else if (llv.T7_Checked == true)
            {
                if (!string.IsNullOrEmpty(llv.T7_NV_TEN))
                {
                    lichLamViec = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.THOIGIAN == llv.T7_THOIGIAN && x.NV_MA == llv.T7_NV_MA && x.CLV_MA == llv.CLV_MA).SingleOrDefault();
                }
                else
                {
                    return null;
                }
            }
            else if (llv.CN_Checked == true)
            {
                if (!string.IsNullOrEmpty(llv.CN_NV_TEN))
                {
                    lichLamViec = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.THOIGIAN == llv.CN_THOIGIAN && x.NV_MA == llv.CN_NV_MA && x.CLV_MA == llv.CLV_MA).SingleOrDefault();
                }
                else
                {
                    return null;
                }
            }

            return lichLamViec;
        }

        void ViewCalander(DateTime selectedWeek)
        {
            SetDaysOfWeek(selectedWeek);
            GroupingCalendarByShift();
        }

        void GroupingCalendarByShift()
        {
            calendar = AddDataCalendar();

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(calendar);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("CLV_TEN");
            view.GroupDescriptions.Add(groupDescription);
        }

        void SetDaysOfWeek(DateTime dayMonday)
        {
            DateTime dayNow = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            thu2 = dayMonday;
            thu3 = dayMonday.AddDays(Convert.ToDouble(1));
            thu4 = dayMonday.AddDays(Convert.ToDouble(2));
            thu5 = dayMonday.AddDays(Convert.ToDouble(3));
            thu6 = dayMonday.AddDays(Convert.ToDouble(4));
            thu7 = dayMonday.AddDays(Convert.ToDouble(5));
            chunhat = dayMonday.AddDays(Convert.ToDouble(6));
            LLV_NGAYDAUTUAN = thu2;
            LLV_NGAYCUOITUAN = chunhat;

            if (thu2 == dayNow)
                ColorT2 = "Red";
            else
                ColorT2 = "Black";

            if (thu3 == dayNow)
                ColorT3 = "Red";
            else
                ColorT3 = "Black";

            if (thu4 == dayNow)
                ColorT4 = "Red";
            else
                ColorT4 = "Black";

            if (thu5 == dayNow)
                ColorT5 = "Red";
            else
                ColorT5 = "Black";

            if (thu6 == dayNow)
                ColorT6 = "Red";
            else
                ColorT6 = "Black";

            if (thu7 == dayNow)
                ColorT7 = "Red";
            else
                ColorT7 = "Black";

            if (chunhat == dayNow)
                ColorCN = "Red";
            else
                ColorCN = "Black";
        }

        DateTime FindMondayOfTheWeek(DateTime day)
        {

            var dayOfWeek = day.DayOfWeek.ToString();

            switch (dayOfWeek)
            {
                case "Monday":
                    return day;
                case "Tuesday":
                    return day.AddDays(Convert.ToDouble(-1));
                case "Wednesday":
                    return day.AddDays(Convert.ToDouble(-2));
                case "Thursday":
                    return day.AddDays(Convert.ToDouble(-3));
                case "Friday":
                    return day.AddDays(Convert.ToDouble(-4));
                case "Saturday":
                    return day.AddDays(Convert.ToDouble(-5));
                case "Sunday":
                    return day.AddDays(Convert.ToDouble(-6));
                default:
                    return day;
            }
        }

        int GetMaxListCalendar(int thu2, int thu3, int thu4, int thu5, int thu6, int thu7, int chunhat)
        {
            List<int> listDate = new List<int>();
            listDate.Add(thu2);
            listDate.Add(thu3);
            listDate.Add(thu4);
            listDate.Add(thu5);
            listDate.Add(thu6);
            listDate.Add(thu7);
            listDate.Add(chunhat);
            listDate.Sort();

            return listDate.LastOrDefault();
        }

        ObservableCollection<ClassListLichlamViec> AddDataCalendar()
        {
            ObservableCollection<ClassListLichlamViec> listCalendar = new ObservableCollection<ClassListLichlamViec>();
            var getCaLamViec = DataProvider.Ins.DB.CALAMVIEC.ToList();
            var getLichLamViec = GetDataFilter();

            foreach (var item in getCaLamViec)
            {
                var getListCalendar2 = getLichLamViec.Where(x => x.THOIGIAN == thu2 && x.CLV_MA == item.CLV_MA).ToList();
                var getListCalendar3 = getLichLamViec.Where(x => x.THOIGIAN == thu3 && x.CLV_MA == item.CLV_MA).ToList();
                var getListCalendar4 = getLichLamViec.Where(x => x.THOIGIAN == thu4 && x.CLV_MA == item.CLV_MA).ToList();
                var getListCalendar5 = getLichLamViec.Where(x => x.THOIGIAN == thu5 && x.CLV_MA == item.CLV_MA).ToList();
                var getListCalendar6 = getLichLamViec.Where(x => x.THOIGIAN == thu6 && x.CLV_MA == item.CLV_MA).ToList();
                var getListCalendar7 = getLichLamViec.Where(x => x.THOIGIAN == thu7 && x.CLV_MA == item.CLV_MA).ToList();
                var getListCalendarCN = getLichLamViec.Where(x => x.THOIGIAN == chunhat && x.CLV_MA == item.CLV_MA).ToList();

                int maxListCalendar = GetMaxListCalendar(getListCalendar2.Count(),
                                                        getListCalendar3.Count(),
                                                        getListCalendar4.Count(),
                                                        getListCalendar5.Count(),
                                                        getListCalendar6.Count(),
                                                        getListCalendar7.Count(),
                                                        getListCalendarCN.Count());

                for (int i = 0; i < maxListCalendar; i++)
                {
                    ClassListLichlamViec calendars = new ClassListLichlamViec();

                    // thu 2
                    calendars.T2_NV_TEN = (getListCalendar2.Count == 0 || i >= getListCalendar2.Count()) ? "" : getListCalendar2[i].NHANVIEN.NV_HOTEN;
                    calendars.T2_NV_ANH = (getListCalendar2.Count == 0 || i >= getListCalendar2.Count()) ? "" : getListCalendar2[i].NHANVIEN.NV_ANH;
                    calendars.T2_P_TEN = (getListCalendar2.Count == 0 || i >= getListCalendar2.Count() || getListCalendar2[i].P_MA == null) ? "" : getListCalendar2[i].PHONG.P_SO;
                    calendars.T2_NV_MA = (getListCalendar2.Count == 0 || i >= getListCalendar2.Count()) ? "" : getListCalendar2[i].NV_MA;
                    calendars.T2_VT_TEN = (getListCalendar2.Count == 0 || i >= getListCalendar2.Count()) ? "" : DAO_ChuyenMon.LayVaiTroNhanVien(getListCalendar2[i].NV_MA);
                    calendars.T2_THOIGIAN = (getListCalendar2.Count == 0 || i >= getListCalendar2.Count()) ? new DateTime() : getListCalendar2[i].THOIGIAN;

                    // thu 3
                    calendars.T3_NV_TEN = (getListCalendar3.Count == 0 || i >= getListCalendar3.Count()) ? "" : getListCalendar3[i].NHANVIEN.NV_HOTEN;
                    calendars.T3_NV_ANH = (getListCalendar3.Count == 0 || i >= getListCalendar3.Count()) ? "" : getListCalendar3[i].NHANVIEN.NV_ANH;
                    calendars.T3_P_TEN = (getListCalendar3.Count == 0 || i >= getListCalendar3.Count() || getListCalendar3[i].P_MA == null) ? "" : getListCalendar3[i].PHONG.P_SO;
                    calendars.T3_NV_MA = (getListCalendar3.Count == 0 || i >= getListCalendar3.Count()) ? "" : getListCalendar3[i].NV_MA;
                    calendars.T3_VT_TEN = (getListCalendar3.Count == 0 || i >= getListCalendar3.Count()) ? "" : DAO_ChuyenMon.LayVaiTroNhanVien(getListCalendar3[i].NV_MA);
                    calendars.T3_THOIGIAN = (getListCalendar3.Count == 0 || i >= getListCalendar3.Count()) ? new DateTime() : getListCalendar3[i].THOIGIAN;

                    // thu 4
                    calendars.T4_NV_TEN = (getListCalendar4.Count == 0 || i >= getListCalendar4.Count()) ? "" : getListCalendar4[i].NHANVIEN.NV_HOTEN;
                    calendars.T4_NV_ANH = (getListCalendar4.Count == 0 || i >= getListCalendar4.Count()) ? "" : getListCalendar4[i].NHANVIEN.NV_ANH;
                    calendars.T4_P_TEN = (getListCalendar4.Count == 0 || i >= getListCalendar4.Count() || getListCalendar4[i].P_MA == null) ? "" : getListCalendar4[i].PHONG.P_SO;
                    calendars.T4_NV_MA = (getListCalendar4.Count == 0 || i >= getListCalendar4.Count()) ? "" : getListCalendar4[i].NV_MA;
                    calendars.T4_VT_TEN = (getListCalendar4.Count == 0 || i >= getListCalendar4.Count()) ? "" : DAO_ChuyenMon.LayVaiTroNhanVien(getListCalendar4[i].NV_MA);
                    calendars.T4_THOIGIAN = (getListCalendar4.Count == 0 || i >= getListCalendar4.Count()) ? new DateTime() : getListCalendar4[i].THOIGIAN;

                    // thu 5
                    calendars.T5_NV_TEN = (getListCalendar5.Count == 0 || i >= getListCalendar5.Count()) ? "" : getListCalendar5[i].NHANVIEN.NV_HOTEN;
                    calendars.T5_NV_ANH = (getListCalendar5.Count == 0 || i >= getListCalendar5.Count()) ? "" : getListCalendar5[i].NHANVIEN.NV_ANH;
                    calendars.T5_P_TEN = (getListCalendar5.Count == 0 || i >= getListCalendar5.Count() || getListCalendar5[i].P_MA == null) ? "" : getListCalendar5[i].PHONG.P_SO;
                    calendars.T5_NV_MA = (getListCalendar5.Count == 0 || i >= getListCalendar5.Count()) ? "" : getListCalendar5[i].NV_MA;
                    calendars.T5_VT_TEN = (getListCalendar5.Count == 0 || i >= getListCalendar5.Count()) ? "" : DAO_ChuyenMon.LayVaiTroNhanVien(getListCalendar5[i].NV_MA);
                    calendars.T5_THOIGIAN = (getListCalendar5.Count == 0 || i >= getListCalendar5.Count()) ? new DateTime() : getListCalendar5[i].THOIGIAN;

                    // thu 6
                    calendars.T6_NV_TEN = (getListCalendar6.Count == 0 || i >= getListCalendar6.Count()) ? "" : getListCalendar6[i].NHANVIEN.NV_HOTEN;
                    calendars.T6_NV_ANH = (getListCalendar6.Count == 0 || i >= getListCalendar6.Count()) ? "" : getListCalendar6[i].NHANVIEN.NV_ANH;
                    calendars.T6_P_TEN = (getListCalendar6.Count == 0 || i >= getListCalendar6.Count() || getListCalendar6[i].P_MA == null) ? "" : getListCalendar6[i].PHONG.P_SO;
                    calendars.T6_NV_MA = (getListCalendar6.Count == 0 || i >= getListCalendar6.Count()) ? "" : getListCalendar6[i].NV_MA;
                    calendars.T6_VT_TEN = (getListCalendar6.Count == 0 || i >= getListCalendar6.Count()) ? "" : DAO_ChuyenMon.LayVaiTroNhanVien(getListCalendar6[i].NV_MA);
                    calendars.T6_THOIGIAN = (getListCalendar6.Count == 0 || i >= getListCalendar6.Count()) ? new DateTime() : getListCalendar6[i].THOIGIAN;

                    // thu 7
                    calendars.T7_NV_TEN = (getListCalendar7.Count == 0 || i >= getListCalendar7.Count()) ? "" : getListCalendar7[i].NHANVIEN.NV_HOTEN;
                    calendars.T7_NV_ANH = (getListCalendar7.Count == 0 || i >= getListCalendar7.Count()) ? "" : getListCalendar7[i].NHANVIEN.NV_ANH;
                    calendars.T7_P_TEN = (getListCalendar7.Count == 0 || i >= getListCalendar7.Count() || getListCalendar7[i].P_MA == null) ? "" : getListCalendar7[i].PHONG.P_SO;
                    calendars.T7_NV_MA = (getListCalendar7.Count == 0 || i >= getListCalendar7.Count()) ? "" : getListCalendar7[i].NV_MA;
                    calendars.T7_VT_TEN = (getListCalendar7.Count == 0 || i >= getListCalendar7.Count()) ? "" : DAO_ChuyenMon.LayVaiTroNhanVien(getListCalendar7[i].NV_MA);
                    calendars.T7_THOIGIAN = (getListCalendar7.Count == 0 || i >= getListCalendar7.Count()) ? new DateTime() : getListCalendar7[i].THOIGIAN;

                    // chu nhat
                    calendars.CN_NV_TEN = (getListCalendarCN.Count == 0 || i >= getListCalendarCN.Count()) ? "" : getListCalendarCN[i].NHANVIEN.NV_HOTEN;
                    calendars.CN_NV_ANH = (getListCalendarCN.Count == 0 || i >= getListCalendarCN.Count()) ? "" : getListCalendarCN[i].NHANVIEN.NV_ANH;
                    calendars.CN_P_TEN = (getListCalendarCN.Count == 0 || i >= getListCalendarCN.Count() || getListCalendarCN[i].P_MA == null) ? "" : getListCalendarCN[i].PHONG.P_SO;
                    calendars.CN_NV_MA = (getListCalendarCN.Count == 0 || i >= getListCalendarCN.Count()) ? "" : getListCalendarCN[i].NV_MA;
                    calendars.CN_VT_TEN = (getListCalendarCN.Count == 0 || i >= getListCalendarCN.Count()) ? "" : DAO_ChuyenMon.LayVaiTroNhanVien(getListCalendarCN[i].NV_MA);
                    calendars.CN_THOIGIAN = (getListCalendarCN.Count == 0 || i >= getListCalendarCN.Count()) ? new DateTime() : getListCalendarCN[i].THOIGIAN;

                    calendars.CLV_TEN = item.CLV_TEN + " (" + item.CLV_GIOBATDAU.ToString(@"hh\:mm") + " - " + item.CLV_GIOKETTHUC.ToString(@"hh\:mm") + ")";
                    calendars.CLV_MA = item.CLV_MA;

                    listCalendar.Add(calendars);
                }
            }
            return new ObservableCollection<ClassListLichlamViec>(listCalendar.OrderBy(x=> x.CLV_TEN));
        }
    }
}
