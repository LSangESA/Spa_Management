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
    public class CapNhatHinhThucThanhToanViewModel : BaseViewModel
    {
        private int _HTTT_MA;
        public int HTTT_MA { get => _HTTT_MA; set { _HTTT_MA = value; OnPropertyChanged(); } }

        private string _HTTT_TEN;
        public string HTTT_TEN { get => _HTTT_TEN; set { _HTTT_TEN = value; OnPropertyChanged(); } }

        private string _HTTT_MOTA;
        public string HTTT_MOTA { get => _HTTT_MOTA; set { _HTTT_MOTA = value; OnPropertyChanged(); } }

        private ObservableCollection<HINHTHUCTHANHTOAN> _ListHTTT;
        public ObservableCollection<HINHTHUCTHANHTOAN> ListHTTT { get => _ListHTTT; set { _ListHTTT = value; OnPropertyChanged(); } }

        private HINHTHUCTHANHTOAN _SelectedItemHTTT;
        public HINHTHUCTHANHTOAN SelectedItemHTTT
        {
            get => _SelectedItemHTTT;
            set
            {
                _SelectedItemHTTT = value;
                OnPropertyChanged();

                if (SelectedItemHTTT != null)
                {
                    HTTT_MA = SelectedItemHTTT.HTTT_MA;
                    HTTT_TEN = SelectedItemHTTT.HTTT_TEN;
                    HTTT_MOTA = SelectedItemHTTT.HTTT_MOTA;
                }
            }
        }
        
        public ICommand CommandAddHTTT { get; set; }
        public ICommand CommandEditHTTT { get; set; }
        public ICommand CommandDeleteHTTT { get; set; }
        public ICommand CommandClearHTTT { get; set; }

        public CapNhatHinhThucThanhToanViewModel()
        {
            ListHTTT = DAO_HTTT.GetList();

            CommandAddHTTT = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(HTTT_TEN))
                {
                    return false;
                }

                if (SelectedItemHTTT != null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                var HINHTHUCTHANHTOAN = new HINHTHUCTHANHTOAN() { HTTT_MA = HTTT_MA, HTTT_TEN = HTTT_TEN, HTTT_MOTA = HTTT_MOTA };
                DAO_HTTT.Add(HINHTHUCTHANHTOAN);
                ListHTTT.Add(HINHTHUCTHANHTOAN);
            }
            );

            CommandEditHTTT = new RelayCommand<object>((p) =>
            {
                if (SelectedItemHTTT == null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                DAO_HTTT.Edit(HTTT_MA, HTTT_TEN, HTTT_MOTA);
                ListHTTT = DAO_HTTT.GetList();
            }
            );

            CommandDeleteHTTT = new RelayCommand<object>((p) =>
            {
                if (SelectedItemHTTT == null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                DAO_HTTT.Delete(SelectedItemHTTT.HTTT_MA);
                ListHTTT = DAO_HTTT.GetList();
            }
            );

            CommandClearHTTT = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                HTTT_MA = 0;
                HTTT_TEN = "";
                HTTT_MOTA = "";
                SelectedItemHTTT = null;
            }
            );
        }
    }
}
