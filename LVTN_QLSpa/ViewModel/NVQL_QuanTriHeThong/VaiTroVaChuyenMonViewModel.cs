using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace LVTN_QLSpa.ViewModel.NVQL_QuanTriHeThong
{
    public class VaiTroVaChuyenMonViewModel : BaseViewModel
    {

        #region Khai bao thuoc tinh vai tro

        private int _VT_MA;
        public int VT_MA { get => _VT_MA; set { _VT_MA = value; OnPropertyChanged(); } }

        private string _VT_TEN;
        public string VT_TEN { get => _VT_TEN; set { _VT_TEN = value; OnPropertyChanged(); } }

        private ObservableCollection<VAITRO> _ListVaiTro;
        public ObservableCollection<VAITRO> ListVaiTro { get => _ListVaiTro; set { _ListVaiTro = value; OnPropertyChanged(); } }

        private VAITRO _SelectedItemVaiTro;
        public VAITRO SelectedItemVaiTro
        {
            get => _SelectedItemVaiTro;
            set
            {
                _SelectedItemVaiTro = value;
                OnPropertyChanged();
                if (SelectedItemVaiTro != null)
                {
                    VT_MA = SelectedItemVaiTro.VT_MA;
                    VT_TEN = SelectedItemVaiTro.VT_TEN;
                }
            }
        }
        #endregion

        #region Khai bao thuoc tinh chuyen mon

        private int _CM_MA;
        public int CM_MA { get => _CM_MA; set { _CM_MA = value; OnPropertyChanged(); } }

        private string _CM_TEN;
        public string CM_TEN { get => _CM_TEN; set { _CM_TEN = value; OnPropertyChanged(); } }

        private string _CM_MOTA;
        public string CM_MOTA { get => _CM_MOTA; set { _CM_MOTA = value; OnPropertyChanged(); } }

        private ObservableCollection<VAITRO> _VAITRO;
        public ObservableCollection<VAITRO> VAITRO { get => _VAITRO; set { _VAITRO = value; OnPropertyChanged(); } }

        private ObservableCollection<CHUYENMON> _ListChuyenMon;
        public ObservableCollection<CHUYENMON> ListChuyenMon { get => _ListChuyenMon; set { _ListChuyenMon = value; OnPropertyChanged(); } }

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

        private CHUYENMON _SelectedItemCM;
        public CHUYENMON SelectedItemCM
        {
            get => _SelectedItemCM;
            set
            {
                _SelectedItemCM = value;
                OnPropertyChanged();
                if (SelectedItemCM != null)
                {
                    CM_MA = SelectedItemCM.CM_MA;
                    CM_TEN = SelectedItemCM.CM_TEN;
                    CM_MOTA = SelectedItemCM.CM_MOTA;
                    SelectedVAITRO = SelectedItemCM.VAITRO;
                }
            }
        }

        #endregion

        #region ICommand
        public ICommand CommandAddVaiTro { get; set; }
        public ICommand CommandEditVaiTro { get; set; }
        public ICommand CommandDeleteVaiTro { get; set; }
        public ICommand CommandClearVaiTro { get; set; }

        public ICommand CommandAddChuyenMon { get; set; }
        public ICommand CommandEditChuyenMon { get; set; }
        public ICommand CommandDeleteChuyenMon { get; set; }
        public ICommand CommandClearChuyenMon { get; set; }

        #endregion

        public VaiTroVaChuyenMonViewModel()
        {
            ListVaiTro = new ObservableCollection<VAITRO>(DataProvider.Ins.DB.VAITRO);
            ListChuyenMon = new ObservableCollection<CHUYENMON>(DataProvider.Ins.DB.CHUYENMON);
            VAITRO = new ObservableCollection<VAITRO>(DataProvider.Ins.DB.VAITRO);

            #region Control VaiTro

            CommandAddVaiTro = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(VT_TEN) || SelectedItemVaiTro.VT_MA == VT_MA)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                var vaitro = new VAITRO() { VT_MA = VT_MA, VT_TEN = VT_TEN};

                DAO_VaiTro.AddVaiTro(vaitro);

                ListVaiTro.Add(vaitro);
            }
            );

            CommandEditVaiTro = new RelayCommand<object>((p) =>
            {
                if (SelectedItemVaiTro == null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                DAO_VaiTro.EditVaiTro(VT_MA, VT_TEN);
                ListVaiTro = new ObservableCollection<VAITRO>(DataProvider.Ins.DB.VAITRO);
            }
            );

            CommandDeleteVaiTro = new RelayCommand<object>((p) =>
            {
                if (SelectedItemVaiTro == null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                DAO_VaiTro.Delete(SelectedItemVaiTro.VT_MA);
                ListVaiTro = new ObservableCollection<VAITRO>(DataProvider.Ins.DB.VAITRO);
            }
            );

            CommandClearVaiTro = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                VT_MA = 0;
                VT_TEN = "";
                SelectedItemVaiTro = null;
            }
            );
            #endregion

            #region ChuyenMon

            CommandAddChuyenMon = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(CM_TEN) || SelectedItemCM.CM_MA == CM_MA || SelectedVAITRO == null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                var chuyenmon = new CHUYENMON() { CM_MA = CM_MA, CM_TEN = CM_TEN, CM_MOTA = CM_MOTA, VT_MA = SelectedVAITRO.VT_MA };

                DAO_ChuyenMon.AddChuyenMon(chuyenmon);

                ListChuyenMon.Add(chuyenmon);
            }
            );

            CommandEditChuyenMon = new RelayCommand<object>((p) =>
            {
                if (SelectedItemCM == null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                DAO_ChuyenMon.EditChuyenMon(CM_MA, CM_TEN, CM_MOTA, SelectedVAITRO.VT_MA);
                ListChuyenMon = new ObservableCollection<CHUYENMON>(DataProvider.Ins.DB.CHUYENMON);
            }
            );

            CommandDeleteChuyenMon = new RelayCommand<object>((p) =>
            {
                if (SelectedItemCM == null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                DAO_ChuyenMon.DeleteChuyenMon(SelectedItemCM.CM_MA);
                ListChuyenMon = new ObservableCollection<CHUYENMON>(DataProvider.Ins.DB.CHUYENMON);
            }
            );

            CommandClearChuyenMon = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                CM_MA = 0;
                CM_TEN = "";
                CM_MOTA = "";
                SelectedItemCM = null;
                SelectedVAITRO = null;
            }
            );

            #endregion
        }

    }
}
