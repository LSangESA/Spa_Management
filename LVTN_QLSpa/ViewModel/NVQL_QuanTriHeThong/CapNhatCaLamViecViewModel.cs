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
    public class CapNhatCaLamViecViewModel : BaseViewModel
    {
        private string _CLV_MA;
        public string CLV_MA { get => _CLV_MA; set { _CLV_MA = value; OnPropertyChanged(); } }

        private string _CLV_TEN;
        public string CLV_TEN { get => _CLV_TEN; set { _CLV_TEN = value; OnPropertyChanged(); } }

        private TimeSpan _CLV_GIOBATDAU;
        public TimeSpan CLV_GIOBATDAU { get => _CLV_GIOBATDAU; set { _CLV_GIOBATDAU = value; OnPropertyChanged(); } }

        private TimeSpan _CLV_GIOKETTHUC;
        public TimeSpan CLV_GIOKETTHUC { get => _CLV_GIOKETTHUC; set { _CLV_GIOKETTHUC = value; OnPropertyChanged(); } }

        private ObservableCollection<CALAMVIEC> _ListCaLamViec;
        public ObservableCollection<CALAMVIEC> ListCaLamViec { get => _ListCaLamViec; set { _ListCaLamViec = value; OnPropertyChanged(); } }

        private CALAMVIEC _SelectedItemCaLamViec;
        public CALAMVIEC SelectedItemCaLamViec
        {
            get => _SelectedItemCaLamViec;
            set
            {
                _SelectedItemCaLamViec = value;
                OnPropertyChanged();
                if (SelectedItemCaLamViec != null)
                {
                    CLV_MA = SelectedItemCaLamViec.CLV_MA;
                    CLV_TEN = SelectedItemCaLamViec.CLV_TEN;
                    CLV_GIOBATDAU = SelectedItemCaLamViec.CLV_GIOBATDAU;
                    CLV_GIOKETTHUC = SelectedItemCaLamViec.CLV_GIOKETTHUC;
                }
            }
        }

        public ICommand AddIdCommand { get; set; }
        public ICommand CommandAddCLV { get; set; }
        public ICommand CommandEdiCLV { get; set; }
        public ICommand CommandDeleteCLV { get; set; }
        public ICommand CommandClearCLV { get; set; }

        public CapNhatCaLamViecViewModel()
        {
            ListCaLamViec = new ObservableCollection<CALAMVIEC>(DataProvider.Ins.DB.CALAMVIEC);

            AddIdCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItemCaLamViec.CLV_MA == CLV_MA && !string.IsNullOrEmpty(CLV_TEN))
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                //var listCountCLV = DataProvider.Ins.DB.CALAMVIEC.Select(x=>x.CLV_MA).LastOrDefault().ToList();

                if (!string.IsNullOrEmpty(CLV_TEN))
                {
                    Random r = new Random();
                    string idCLV = "CLV" + (r.Next(1,10000));
                    CLV_MA = idCLV;
                }
                else if (string.IsNullOrEmpty(CLV_TEN))
                {
                    CLV_MA = "";
                }
            }
            );

            CommandAddCLV = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(CLV_TEN) || SelectedItemCaLamViec.CLV_MA == CLV_MA)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                var calamviec = new CALAMVIEC() { CLV_MA = CLV_MA, CLV_TEN = CLV_TEN, CLV_GIOBATDAU = CLV_GIOBATDAU, CLV_GIOKETTHUC = CLV_GIOKETTHUC };

                DAO_CaLamViec.AddCaLamViec(calamviec);

                ListCaLamViec.Add(calamviec);
            }
            );

            CommandEdiCLV = new RelayCommand<object>((p) =>
            {
                if (SelectedItemCaLamViec == null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                DAO_CaLamViec.EditCaLamViec(CLV_MA, CLV_TEN, CLV_GIOBATDAU, CLV_GIOKETTHUC);
                ListCaLamViec = new ObservableCollection<CALAMVIEC>(DataProvider.Ins.DB.CALAMVIEC);
            }
            );

            CommandDeleteCLV = new RelayCommand<object>((p) =>
            {
                if (SelectedItemCaLamViec == null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                DAO_CaLamViec.DeleteCaLamViec(SelectedItemCaLamViec.CLV_MA);
                ListCaLamViec = new ObservableCollection<CALAMVIEC>(DataProvider.Ins.DB.CALAMVIEC);
            }
            );

            CommandClearCLV = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                CLV_MA = "";
                CLV_TEN = "";
                CLV_GIOBATDAU = new TimeSpan(0,0,0);
                CLV_GIOKETTHUC = new TimeSpan(0, 0, 0);
                SelectedItemCaLamViec = null;
            }
            );
        }
    }
}
