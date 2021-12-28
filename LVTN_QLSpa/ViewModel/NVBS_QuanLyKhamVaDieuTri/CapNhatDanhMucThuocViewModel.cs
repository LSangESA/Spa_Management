using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LVTN_QLSpa.ViewModel.NVBS_QuanLyKhamVaDieuTri
{
    public class CapNhatDanhMucThuocViewModel : BaseViewModel
    {
        #region Binding

        #region DVT

        private int _DVT_MA;
        public int DVT_MA { get => _DVT_MA; set { _DVT_MA = value; OnPropertyChanged(); } }
        private string _DVT_TEN;
        public string DVT_TEN { get => _DVT_TEN; set { _DVT_TEN = value; OnPropertyChanged(); } }

        private ObservableCollection<DVT> _DVTList;
        public ObservableCollection<DVT> DVTList { get => _DVTList; set { _DVTList = value; OnPropertyChanged(); } }

        private DVT _SelectedItemDVT;
        public DVT SelectedItemDVT
        {
            get => _SelectedItemDVT;
            set
            {
                _SelectedItemDVT = value;
                OnPropertyChanged();
                if (SelectedItemDVT != null)
                {
                    DVT_MA = SelectedItemDVT.DVT_MA;
                    DVT_TEN = SelectedItemDVT.DVT_TEN;
                }
            }
        }

        #endregion

        #region NHASX

        private int _NSX_MA;
        public int NSX_MA { get => _NSX_MA; set { _NSX_MA = value; OnPropertyChanged(); } }
        private string _NSX_TEN;
        public string NSX_TEN { get => _NSX_TEN; set { _NSX_TEN = value; OnPropertyChanged(); } }

        private ObservableCollection<NHASX> _NHASXList;
        public ObservableCollection<NHASX> NHASXList { get => _NHASXList; set { _NHASXList = value; OnPropertyChanged(); } }

        private NHASX _SelectedItemNHASX;
        public NHASX SelectedItemNHASX
        {
            get => _SelectedItemNHASX;
            set
            {
                _SelectedItemNHASX = value;
                OnPropertyChanged();
                if (SelectedItemNHASX != null)
                {
                    NSX_MA = SelectedItemNHASX.NSX_MA;
                    NSX_TEN = SelectedItemNHASX.NSX_TEN;
                }
            }
        }

        #endregion

        #region HOATCHAT

        private string _HC_MA;
        public string HC_MA { get => _HC_MA; set { _HC_MA = value; OnPropertyChanged(); } }
        private string _HC_TEN;
        public string HC_TEN { get => _HC_TEN; set { _HC_TEN = value; OnPropertyChanged(); } }
        private string _HC_HAMLUONG;
        public string HC_HAMLUONG { get => _HC_HAMLUONG; set { _HC_HAMLUONG = value; OnPropertyChanged(); } }
        private string _HC_CONGDUNG;
        public string HC_CONGDUNG { get => _HC_CONGDUNG; set { _HC_CONGDUNG = value; OnPropertyChanged(); } }

        private ObservableCollection<HOATCHAT> _HOATCHATList;
        public ObservableCollection<HOATCHAT> HOATCHATList { get => _HOATCHATList; set { _HOATCHATList = value; OnPropertyChanged(); } }

        private HOATCHAT _SelectedItemHOATCHAT;
        public HOATCHAT SelectedItemHOATCHAT
        {
            get => _SelectedItemHOATCHAT;
            set
            {
                _SelectedItemHOATCHAT = value;
                OnPropertyChanged();
                if (SelectedItemHOATCHAT != null)
                {
                    HC_MA = SelectedItemHOATCHAT.HC_MA;
                    HC_TEN = SelectedItemHOATCHAT.HC_TEN;
                    HC_HAMLUONG = SelectedItemHOATCHAT.HC_HAMLUONG;
                    HC_CONGDUNG = SelectedItemHOATCHAT.HC_CONGDUNG;
                }
            }
        }

        #endregion

        #region THUOC

        private string _T_MA;
        public string T_MA { get => _T_MA; set { _T_MA = value; OnPropertyChanged(); } }
        private string _T_TEN;
        public string T_TEN { get => _T_TEN; set { _T_TEN = value; OnPropertyChanged(); } }

        private ObservableCollection<THUOC> _THUOCList;
        public ObservableCollection<THUOC> THUOCList { get => _THUOCList; set { _THUOCList = value; OnPropertyChanged(); } }
        private ObservableCollection<HOATCHAT> _HOATCHAT;
        public ObservableCollection<HOATCHAT> HOATCHAT { get => _HOATCHAT; set { _HOATCHAT = value; OnPropertyChanged(); } }
        private ObservableCollection<DVT> _DVT;
        public ObservableCollection<DVT> DVT { get => _DVT; set { _DVT = value; OnPropertyChanged(); } }
        private ObservableCollection<NHASX> _NHASX;
        public ObservableCollection<NHASX> NHASX { get => _NHASX; set { _NHASX = value; OnPropertyChanged(); } }

        private THUOC _SelectedItemTHUOC;
        public THUOC SelectedItemTHUOC
        {
            get => _SelectedItemTHUOC;
            set
            {
                _SelectedItemTHUOC = value;
                OnPropertyChanged();
                if (SelectedItemTHUOC != null)
                {
                    T_MA = SelectedItemTHUOC.T_MA;
                    T_TEN = SelectedItemTHUOC.T_TEN;
                    SelectedHOATCHAT = SelectedItemTHUOC.HOATCHAT;
                    SelectedDVT = SelectedItemTHUOC.DVT;
                    SelectedNHASX = SelectedItemTHUOC.NHASX;
                }
            }
        }

        private HOATCHAT _SelectedHOATCHAT;
        public HOATCHAT SelectedHOATCHAT
        {
            get => _SelectedHOATCHAT;
            set
            {
                _SelectedHOATCHAT = value;
                OnPropertyChanged();
            }
        }

        private DVT _SelectedDVT;
        public DVT SelectedDVT
        {
            get => _SelectedDVT;
            set
            {
                _SelectedDVT = value;
                OnPropertyChanged();
            }
        }

        private NHASX _SelectedNHASX;
        public NHASX SelectedNHASX
        {
            get => _SelectedNHASX;
            set
            {
                _SelectedNHASX = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #endregion

        #region ICommand

        #region ICommand DVT

        public ICommand AddDVT { get; set; }
        public ICommand DeleteDVT { get; set; }
        public ICommand ClearDVT { get; set; }

        #endregion

        #region ICommand NHASX

        public ICommand AddNHASX { get; set; }
        public ICommand DeleteNHASX { get; set; }
        public ICommand ClearNHASX { get; set; }

        #endregion

        #region ICommand HOATCHAT

        public ICommand AddHOATCHAT { get; set; }
        public ICommand DeleteHOATCHAT { get; set; }
        public ICommand ClearHOATCHAT { get; set; }

        #endregion

        #region ICommand THUOC

        public ICommand AddTHUOC { get; set; }
        public ICommand DeleteTHUOC { get; set; }
        public ICommand ClearTHUOC { get; set; }

        #endregion


        #endregion

        public CapNhatDanhMucThuocViewModel()
        {
            #region ICommand Control THUOC

            THUOCList = DAO_Thuoc.GetListThuoc();
            HOATCHAT = DAO_Thuoc.GetListHoatChat();
            NHASX = DAO_Thuoc.GetListNSX();
            DVT = DAO_Thuoc.GetListDVT();

            AddTHUOC = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                var thuoc = DataProvider.Ins.DB.THUOC.Where(x => x.T_MA == T_MA).Count();
                if (thuoc != 0)
                {
                    DAO_Thuoc.EditThuoc(SelectedItemTHUOC, T_TEN, SelectedNHASX.NSX_MA, SelectedDVT.DVT_MA, SelectedHOATCHAT.HC_MA);

                    THUOCList = DAO_Thuoc.GetListThuoc();
                }
                else
                {
                    string id = "T1";
                    var getIdT = DataProvider.Ins.DB.THUOC.Select(x => x.T_MA).ToList();
                    if (getIdT.Count() == 0)
                    {
                        id = "T1";
                    }
                    else
                    {
                        int idFormat = Convert.ToInt32(getIdT.LastOrDefault().Substring(1));
                        id = "T" + (idFormat + 1).ToString();
                    }
                    var addThuoc = DAO_Thuoc.AddThuoc(id, T_TEN, SelectedNHASX.NSX_MA, SelectedDVT.DVT_MA, SelectedHOATCHAT.HC_MA);

                    THUOCList.Add(addThuoc);
                }
                LoadDuLieuThuoc();
            }
            );

            DeleteTHUOC = new RelayCommand<object>((p) =>
            {
                if (T_MA == null || SelectedItemTHUOC == null)
                {
                    return false;
                }

                var displayList = DataProvider.Ins.DB.THUOC.Where(x => x.T_MA == T_MA);

                if (displayList.Count() == 0)
                {
                    return false;
                }
                return true;
            }, (p) =>
            {
                DAO_Thuoc.DeleteThuoc(SelectedItemTHUOC);
                THUOCList = DAO_Thuoc.GetListThuoc();
                LoadDuLieuThuoc();
            }
            );

            ClearTHUOC = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                T_MA = "";
                T_TEN = "";
                SelectedDVT = null;
                SelectedItemHOATCHAT = null;
                SelectedNHASX = null;
                SelectedItemTHUOC = null;
            }
            );

            #endregion

            #region ICommand Control HOATCHAT

            HOATCHATList = DAO_Thuoc.GetListHoatChat();

            AddHOATCHAT = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                var biecduoc = DataProvider.Ins.DB.HOATCHAT.Where(x => x.HC_MA == HC_MA).Count();
                if (biecduoc != 0)
                {
                    HOATCHATList = DAO_Thuoc.GetListHoatChat();
                    DAO_Thuoc.EditHoatChat(SelectedItemHOATCHAT, HC_TEN, HC_HAMLUONG, HC_CONGDUNG);
                }
                else
                {
                    string id = "HC1";
                    var getIdHC = DataProvider.Ins.DB.HOATCHAT.Select(x => x.HC_MA).ToList();
                    if (getIdHC.Count() == 0)
                    {
                        id = "HC1";
                    }
                    else
                    {
                        int idFormat = Convert.ToInt32(getIdHC.LastOrDefault().Substring(2));
                        id = "HC" + (idFormat + 1).ToString();
                    }
                    var hoatChat = DAO_Thuoc.AddHoatChat(id, HC_TEN, HC_HAMLUONG, HC_CONGDUNG);

                    HOATCHATList.Add(hoatChat);
                }
                LoadDuLieuThuoc();
            }
            );

            DeleteHOATCHAT = new RelayCommand<object>((p) =>
            {
                if (HC_MA == null || SelectedItemHOATCHAT == null)
                {
                    return false;
                }
                
                return true;
            }, (p) =>
            {
                DAO_Thuoc.DeleteHoatChat(SelectedItemHOATCHAT);
                HOATCHATList = DAO_Thuoc.GetListHoatChat();
                LoadDuLieuThuoc();
            }
            );

            ClearHOATCHAT = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                HC_MA = "";
                HC_TEN = "";
                HC_CONGDUNG = "";
                HC_HAMLUONG = "";
                SelectedItemHOATCHAT = null;
            }
            );

            #endregion

            #region ICommand Control DVT

            DVTList = new ObservableCollection<DVT>(DataProvider.Ins.DB.DVT);

            AddDVT = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                var dvt = DataProvider.Ins.DB.DVT.Where(x => x.DVT_MA == DVT_MA).Count();
                if (dvt != 0)
                {
                    DAO_Thuoc.EditDVT(SelectedItemDVT, DVT_TEN);
                    DVTList = DAO_Thuoc.GetListDVT();
                }
                else
                {
                    var donvt = DAO_Thuoc.AddDVT(DVT_TEN);
                    DVTList.Add(donvt);
                }
                LoadDuLieuThuoc();
            }
            );

            DeleteDVT = new RelayCommand<object>((p) =>
            {
                if (DVT_MA == 0 || SelectedItemDVT == null)
                {
                    return false;
                }

                var displayList = DataProvider.Ins.DB.DVT.Where(x => x.DVT_MA == DVT_MA);

                if (displayList.Count() == 0)
                {
                    return false;
                }
                return true;
            }, (p) =>
            {
                DAO_Thuoc.DeleteDVT(SelectedItemDVT);
                DVTList = DAO_Thuoc.GetListDVT();
                LoadDuLieuThuoc();
            }
            );

            ClearDVT = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                DVT_MA = 0;
                DVT_TEN = "";
                SelectedItemDVT = null;
            }
            );

            #endregion

            #region ICommand Control NHASX

            NHASXList = new ObservableCollection<NHASX>(DataProvider.Ins.DB.NHASX);

            AddNHASX = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                try
                {
                    var nhasx = DataProvider.Ins.DB.NHASX.Where(x => x.NSX_MA == NSX_MA).Count();
                    if (nhasx != 0)
                    {
                        DAO_Thuoc.EditNSX(SelectedItemNHASX, NSX_TEN);
                        NHASXList = DAO_Thuoc.GetListNSX();
                    }
                    else
                    {
                        var nhaSX = DAO_Thuoc.AddNSX(NSX_TEN);
                        NHASXList.Add(nhaSX);
                    }
                }
                catch (Exception x)
                { }

                LoadDuLieuThuoc();
            }
            );

            DeleteNHASX = new RelayCommand<object>((p) =>
            {
                if (SelectedItemNHASX == null)
                {
                    return false;
                }

                var displayList = DataProvider.Ins.DB.NHASX.Where(x => x.NSX_MA == NSX_MA);

                if (displayList.Count() == 0)
                {
                    return false;
                }
                return true;
            }, (p) =>
            {
                DAO_Thuoc.DeleteNSX(SelectedItemNHASX);
                NHASXList = DAO_Thuoc.GetListNSX();
                LoadDuLieuThuoc();
            }
            );

            ClearNHASX = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                NSX_MA = 0;
                NSX_TEN = "";
                SelectedItemNHASX = null;
            }
            );

            #endregion
        }
        public void LoadDuLieuThuoc()
        {
            HOATCHAT = DAO_Thuoc.GetListHoatChat();
            NHASX = DAO_Thuoc.GetListNSX();
            DVT = DAO_Thuoc.GetListDVT();
        }
    }
}
