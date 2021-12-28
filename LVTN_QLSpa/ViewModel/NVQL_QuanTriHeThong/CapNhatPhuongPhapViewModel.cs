using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using LVTN_QLSpa.Model.ModelClass;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LVTN_QLSpa.ViewModel.NVQL_QuanTriHeThong
{
    public class CapNhatPhuongPhapViewModel : BaseViewModel
    {
        private string _PP_MA;
        public string PP_MA { get => _PP_MA; set { _PP_MA = value; OnPropertyChanged(); } }

        private string _PP_TEN;
        public string PP_TEN { get => _PP_TEN; set { _PP_TEN = value; OnPropertyChanged(); } }

        private string _PP_MOTA;
        public string PP_MOTA { get => _PP_MOTA; set { _PP_MOTA = value; OnPropertyChanged(); } }

        private ObservableCollection<PHUONGPHAP> _ListPhuongPhap;
        public ObservableCollection<PHUONGPHAP> ListPhuongPhap { get => _ListPhuongPhap; set { _ListPhuongPhap = value; OnPropertyChanged(); } }

        private PHUONGPHAP _SelectedItemPP;
        public PHUONGPHAP SelectedItemPP
        {
            get => _SelectedItemPP;
            set
            {
                _SelectedItemPP = value;
                OnPropertyChanged();

                if (SelectedItemPP != null)
                {
                    PP_MA = SelectedItemPP.PP_MA;
                    PP_TEN = SelectedItemPP.PP_TEN;
                    PP_MOTA = SelectedItemPP.PP_MOTA;
                }
            }
        }

        public ICommand CommandAddIdCommandPP { get; set; }
        public ICommand CommandAddPhuongPhap { get; set; }
        public ICommand CommandEditPhuongPhap { get; set; }
        public ICommand CommandDeletePhuongPhap { get; set; }
        public ICommand CommandClearPhuongPhap { get; set; }

        public CapNhatPhuongPhapViewModel()
        {
            ListPhuongPhap = DAO_PhuongPhap.GetList();

            CommandAddIdCommandPP = new RelayCommand<object>((p) =>
            {
                if (SelectedItemPP != null || string.IsNullOrEmpty(PP_TEN))
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                Random r = new Random();
                PP_MA = ClassXuLyChuoi.LocDau(ClassXuLyChuoi.GetName(PP_TEN, "")) + r.Next(1, 99);
            }
            );

            CommandAddPhuongPhap = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(PP_TEN) || string.IsNullOrEmpty(PP_MA))
                {
                    return false;
                }

                if (SelectedItemPP != null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                var phuongphap = new PHUONGPHAP() { PP_MA = PP_MA, PP_TEN = PP_TEN, PP_MOTA = PP_MOTA };
                DAO_PhuongPhap.Add(phuongphap);
                ListPhuongPhap.Add(phuongphap);
            }
            );

            CommandEditPhuongPhap = new RelayCommand<object>((p) =>
            {
                if (SelectedItemPP == null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                DAO_PhuongPhap.Edit(PP_MA, PP_TEN, PP_MOTA);
                ListPhuongPhap = DAO_PhuongPhap.GetList();
            }
            );

            CommandDeletePhuongPhap = new RelayCommand<object>((p) =>
            {
                if (SelectedItemPP == null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                DAO_PhuongPhap.Delete(SelectedItemPP.PP_MA);
                ListPhuongPhap = DAO_PhuongPhap.GetList();
            }
            );

            CommandClearPhuongPhap = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                PP_MA = "";
                PP_TEN = "";
                PP_MOTA = "";
                SelectedItemPP = null;
            }
            );
        }
    }
}
