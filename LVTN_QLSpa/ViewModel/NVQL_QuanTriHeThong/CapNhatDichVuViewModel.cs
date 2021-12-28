using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LVTN_QLSpa.ViewModel.NVQL_QuanTriHeThong
{
    public class CapNhatDichVuViewModel : BaseViewModel
    {
        private string _DV_MA;
        public string DV_MA { get => _DV_MA; set { _DV_MA = value; OnPropertyChanged(); } }

        private string _DV_TEN;
        public string DV_TEN { get => _DV_TEN; set { _DV_TEN = value; OnPropertyChanged(); } }

        private string _DV_MOTA;
        public string DV_MOTA { get => _DV_MOTA; set { _DV_MOTA = value; OnPropertyChanged(); } }

        private string _DV_ANH;
        public string DV_ANH { get => _DV_ANH; set { _DV_ANH = value; OnPropertyChanged(); } }

        private ObservableCollection<DICHVU> _ListDichVu;
        public ObservableCollection<DICHVU> ListDichVu { get => _ListDichVu; set { _ListDichVu = value; OnPropertyChanged(); } }

        private DICHVU _SelectedItemDV;
        public DICHVU SelectedItemDV
        {
            get => _SelectedItemDV;
            set
            {
                _SelectedItemDV = value;
                OnPropertyChanged();

                if (SelectedItemDV != null)
                {
                    DV_MA = SelectedItemDV.DV_MA;
                    DV_TEN = SelectedItemDV.DV_TEN;
                    DV_MOTA = SelectedItemDV.DV_MOTA;
                }
            }
        }

        public ICommand CommandAddIdCommandDV { get; set; }
        public ICommand CommandAddDichVu { get; set; }
        public ICommand CommandEditDichVu { get; set; }
        public ICommand CommandDeleteDichVu { get; set; }
        public ICommand CommandClearDichVu { get; set; }

        public CapNhatDichVuViewModel()
        {
            ListDichVu = DAO_DichVu.GetList();

            CommandAddIdCommandDV = new RelayCommand<object>((p) =>
            {
                if (SelectedItemDV != null || string.IsNullOrEmpty(DV_TEN))
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                Random r = new Random();
                DV_MA = LocDau(GetName(DV_TEN, "")) + r.Next(1, 99);
            }
            );

            CommandAddDichVu = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(DV_TEN) || string.IsNullOrEmpty(DV_MA))
                {
                    return false;
                }
                
                if (SelectedItemDV != null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                var dichvu = new DICHVU() { DV_MA = DV_MA, DV_TEN = DV_TEN, DV_ANH = DV_ANH, DV_MOTA = DV_MOTA };
                DAO_DichVu.Add(dichvu);
                ListDichVu.Add(dichvu);
            }
            );

            CommandEditDichVu = new RelayCommand<object>((p) =>
            {
                if (SelectedItemDV == null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                DAO_DichVu.Edit(DV_MA, DV_TEN, DV_MOTA);
                ListDichVu = DAO_DichVu.GetList();
            }
            );

            CommandDeleteDichVu = new RelayCommand<object>((p) =>
            {
                if (SelectedItemDV == null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                DAO_DichVu.Delete(SelectedItemDV.DV_MA);
                ListDichVu = DAO_DichVu.GetList();
            }
            );

            CommandClearDichVu = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                DV_MA = "";
                DV_TEN = "";
                DV_MOTA = "";
                SelectedItemDV = null;
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
}
