using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using LVTN_QLSpa.Model.ModelClass;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LVTN_QLSpa.ViewModel.NVQL_QuanTriHeThong
{
    public class CapNhatPhongViewModel : BaseViewModel
    {
        #region Khai bao thuoc tinh phong

        private int _P_MA;
        public int P_MA { get => _P_MA; set { _P_MA = value; OnPropertyChanged(); } }

        private string _P_SO;
        public string P_SO { get => _P_SO; set { _P_SO = value; OnPropertyChanged(); } }

        private string _P_TEN;
        public string P_TEN { get => _P_TEN; set { _P_TEN = value; OnPropertyChanged(); } }

        private int _P_SOLUONGNHANVIEN;
        public int P_SOLUONGNHANVIEN { get => _P_SOLUONGNHANVIEN; set { _P_SOLUONGNHANVIEN = value; OnPropertyChanged(); } }

        private string _P_MOTA;
        public string P_MOTA { get => _P_MOTA; set { _P_MOTA = value; OnPropertyChanged(); } }

        private ObservableCollection<PHONG> _ListPhong;
        public ObservableCollection<PHONG> ListPhong { get => _ListPhong; set { _ListPhong = value; OnPropertyChanged(); } }

        private ObservableCollection<DICHVU> _DICHVU;
        public ObservableCollection<DICHVU> DICHVU { get => _DICHVU; set { _DICHVU = value; OnPropertyChanged(); } }

        private ObservableCollection<ClassGoiDichVu> _ListGoiDichVu;
        public ObservableCollection<ClassGoiDichVu> ListGoiDichVu { get => _ListGoiDichVu; set { _ListGoiDichVu = value; OnPropertyChanged(); } }

        private ObservableCollection<ClassGoiDichVu> _ListGoiDichVuPhong;
        public ObservableCollection<ClassGoiDichVu> ListGoiDichVuPhong { get => _ListGoiDichVuPhong; set { _ListGoiDichVuPhong = value; OnPropertyChanged(); } }

        private PHONG _SelectedItemPhong;
        public PHONG SelectedItemPhong
        {
            get => _SelectedItemPhong;
            set
            {
                _SelectedItemPhong = value;
                OnPropertyChanged();
            }
        }

        private DICHVU _SelectedDICHVU;
        public DICHVU SelectedDICHVU
        {
            get => _SelectedDICHVU;
            set
            {
                _SelectedDICHVU = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Khai bao thuoc tinh chi tiet phong

        private int _CTP_SOLUONG;
        public int CTP_SOLUONG { get => _CTP_SOLUONG; set { _CTP_SOLUONG = value; OnPropertyChanged(); } }

        private ObservableCollection<VAITRO> _VAITRO;
        public ObservableCollection<VAITRO> VAITRO { get => _VAITRO; set { _VAITRO = value; OnPropertyChanged(); } }

        private ObservableCollection<PHONG> _PHONG;
        public ObservableCollection<PHONG> PHONG { get => _PHONG; set { _PHONG = value; OnPropertyChanged(); } }

        private ObservableCollection<CHITIETPHONG> _ListChiTietPhong;
        public ObservableCollection<CHITIETPHONG> ListChiTietPhong { get => _ListChiTietPhong; set { _ListChiTietPhong = value; OnPropertyChanged(); } }

        private VAITRO _SelectedVaiTro;
        public VAITRO SelectedVaiTro
        {
            get => _SelectedVaiTro;
            set
            {
                _SelectedVaiTro = value;
                OnPropertyChanged();
            }
        }

        private PHONG _SelectedPhong;
        public PHONG SelectedPhong
        {
            get => _SelectedPhong;
            set
            {
                _SelectedPhong = value;
                OnPropertyChanged();
            }
        }

        private CHITIETPHONG _SelectedItemCTP;
        public CHITIETPHONG SelectedItemCTP
        {
            get => _SelectedItemCTP;
            set
            {
                _SelectedItemCTP = value;
                OnPropertyChanged();
                if (SelectedItemCTP != null)
                {
                    SelectedPhong = SelectedItemCTP.PHONG;
                    SelectedVaiTro = SelectedItemCTP.VAITRO;
                    CTP_SOLUONG = SelectedItemCTP.CTP_SOLUONG;
                }
            }
        }

        #endregion

        #region ICommand

        public ICommand CommandAddP { get; set; }
        public ICommand CommandEditP { get; set; }
        public ICommand CommandDeleteP { get; set; }
        public ICommand CommandClearP { get; set; }
        public ICommand CommandSelectionPhong { get; set; }
        public ICommand CommandSelectionDICHVU { get; set; }
        public ICommand CommandAddPhuTrachDichVu { get; set; }
        public ICommand CommandDeletePhuTrach { get; set; }

        public ICommand CommandAddCTP { get; set; }
        public ICommand CommandEditCTP { get; set; }
        public ICommand CommandDeleteCTP { get; set; }
        public ICommand CommandClearCTP { get; set; }
        public ICommand SLPhongCommand { get; set; }

        #endregion

        public CapNhatPhongViewModel()
        {
            DICHVU = DAO_DichVu.GetList();
            ListPhong = DAO_Phong.GetList();
            ListChiTietPhong = new ObservableCollection<CHITIETPHONG>(DataProvider.Ins.DB.CHITIETPHONG);
            PHONG = new ObservableCollection<PHONG>(DataProvider.Ins.DB.PHONG);
            VAITRO = new ObservableCollection<VAITRO>(DataProvider.Ins.DB.VAITRO);

            SLPhongCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedPhong == null)
                    return false;
                return true;
            }, (p) =>
            {
                ListChiTietPhong = new ObservableCollection<CHITIETPHONG>(DataProvider.Ins.DB.CHITIETPHONG.Where(x=>x.P_MA == SelectedPhong.P_MA).ToList());
            }
            );

            CommandSelectionPhong = new RelayCommand<object>((p) =>
            {
                if (SelectedItemPhong == null)
                    return false;

                return true;
            }, (p) =>
            {
                P_MA = SelectedItemPhong.P_MA;
                P_SO = SelectedItemPhong.P_SO;
                P_TEN = SelectedItemPhong.P_TEN;
                P_SOLUONGNHANVIEN = SelectedItemPhong.P_SOLUONGNHANVIEN;
                P_MOTA = SelectedItemPhong.P_MOTA;

                var listGDVPhong = DAO_Phong.GetListGoiDichVuPhong(SelectedItemPhong.P_MA);
                ListGoiDichVuPhong = GetListGoiDichVuPhong(listGDVPhong);
            }
            );

            CommandSelectionDICHVU = new RelayCommand<object>((p) =>
            {
                if (SelectedItemPhong == null)
                    return false;
                return true;
            }, (p) =>
            {
                var listGDVPhong = DAO_Phong.GetListGoiDichVuPhong(SelectedItemPhong.P_MA);
                var listGDV = DAO_GoiDichVu.GetListDV(SelectedDICHVU.DV_MA);
                ListGoiDichVu = GetListGoiDichVu(listGDV, listGDVPhong);
            }
            );

            CommandAddPhuTrachDichVu = new RelayCommand<object>((p) =>
            {
                if (SelectedItemPhong == null || SelectedDICHVU == null)
                    return false;

                return true;
            }, (p) =>
            {
                AddGoiDichVuPhong(ListGoiDichVu, SelectedItemPhong);
                var listGDVPhong = DAO_Phong.GetListGoiDichVuPhong(SelectedItemPhong.P_MA);
                var listGDV = DAO_GoiDichVu.GetListDV(SelectedDICHVU.DV_MA);
                ListGoiDichVuPhong = GetListGoiDichVuPhong(listGDVPhong);
                ListGoiDichVu = GetListGoiDichVu(listGDV, listGDVPhong);
            }
            );

            CommandDeletePhuTrach = new RelayCommand<object>((p) =>
            {
                if (SelectedItemPhong == null)
                    return false;

                return true;
            }, (p) =>
            {
                DeleteGoiDichVuPhong(ListGoiDichVuPhong, SelectedItemPhong);
                var listGDVPhong = DAO_Phong.GetListGoiDichVuPhong(SelectedItemPhong.P_MA);
                var listGDV = DAO_GoiDichVu.GetListDV(SelectedDICHVU.DV_MA);
                ListGoiDichVuPhong = GetListGoiDichVuPhong(listGDVPhong);
                if(SelectedDICHVU != null)
                    ListGoiDichVu = GetListGoiDichVu(listGDV, listGDVPhong);
            }
            );

            CommandAddP = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(P_SO) || string.IsNullOrEmpty(P_TEN) || P_SOLUONGNHANVIEN <= 0 || SelectedItemPhong != null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                var phong = new PHONG() { P_MA = P_MA, P_SO = P_SO, P_SOLUONGNHANVIEN = P_SOLUONGNHANVIEN, P_TEN = P_TEN, P_MOTA = P_MOTA };

                DAO_Phong.Add(phong);

                ListPhong.Add(phong);
                P_MA = 0;
            }
            );

            CommandEditP = new RelayCommand<object>((p) =>
            {
                if (SelectedItemPhong == null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                DAO_Phong.Edit(P_MA, P_SO, P_TEN, P_SOLUONGNHANVIEN, P_MOTA);
                ListPhong = DAO_Phong.GetList();
            }
            );

            CommandDeleteP = new RelayCommand<object>((p) =>
            {
                if (SelectedItemPhong == null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                DAO_Phong.Delete(SelectedItemPhong.P_MA);
                ListPhong = DAO_Phong.GetList();
            }
            );

            CommandClearP = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                P_MA = 0;
                P_SO = "";
                P_TEN = "";
                P_MOTA = "";
                P_SOLUONGNHANVIEN = 0;
                SelectedItemPhong = null;
            }
            );

            CommandAddCTP = new RelayCommand<object>((p) =>
            {
                if (CTP_SOLUONG <= 0 || SelectedPhong == null || SelectedVaiTro == null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                var chitietphong = new CHITIETPHONG() { VT_MA = SelectedVaiTro.VT_MA, P_MA = SelectedPhong.P_MA, CTP_SOLUONG = CTP_SOLUONG };

                DAO_Phong.Add(chitietphong);

                ListChiTietPhong.Add(chitietphong);
            }
            );

            CommandEditCTP = new RelayCommand<object>((p) =>
            {
                if (SelectedItemCTP == null || SelectedPhong.P_MA != SelectedItemCTP.P_MA || SelectedVaiTro.VT_MA != SelectedItemCTP.VT_MA)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                DAO_Phong.Edit(SelectedVaiTro.VT_MA, SelectedPhong.P_MA, CTP_SOLUONG);
                ListChiTietPhong = DAO_Phong.GetListCTP();
            }
            );

            CommandDeleteCTP = new RelayCommand<object>((p) =>
            {
                if (SelectedItemCTP == null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                DAO_Phong.Delete(SelectedVaiTro.VT_MA, SelectedPhong.P_MA);
                ListChiTietPhong = DAO_Phong.GetListCTP();
            }
            );

            CommandClearCTP = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                SelectedPhong = null;
                SelectedVaiTro = null;
                CTP_SOLUONG = 0;
                SelectedItemCTP = null;
                ListChiTietPhong = new ObservableCollection<CHITIETPHONG>(DataProvider.Ins.DB.CHITIETPHONG);
            }
            );
        }

        void DeleteGoiDichVuPhong(ObservableCollection<ClassGoiDichVu> listGDV, PHONG phong)
        {
            if(listGDV != null)
            {
                var layGDVCheck = listGDV.Where(x => x.IsCheck == true).ToList();

                foreach (var item in layGDVCheck)
                {
                    var phongDichVu = DataProvider.Ins.DB.DICHVUPHONG.Where(x => x.GDV_MA == item.GDV_MA && x.P_MA == phong.P_MA).SingleOrDefault();
                    DataProvider.Ins.DB.DICHVUPHONG.Remove(phongDichVu);
                    DataProvider.Ins.DB.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Danh sách rỗng", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        void AddGoiDichVuPhong(ObservableCollection<ClassGoiDichVu> listGDV, PHONG phong)
        {
            if (listGDV != null)
            {
                var layGDVCheck = listGDV.Where(x => x.IsCheck == true).ToList();

                foreach (var item in layGDVCheck)
                {
                    var dichVuPhong = new DICHVUPHONG();
                    dichVuPhong.GDV_MA = item.GDV_MA;
                    dichVuPhong.P_MA = phong.P_MA;

                    DataProvider.Ins.DB.DICHVUPHONG.Add(dichVuPhong);
                    DataProvider.Ins.DB.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Danh sách rỗng", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        ObservableCollection<ClassGoiDichVu> GetListGoiDichVuPhong(ObservableCollection<GOIDICHVU> listGDV)
        {
            var listGoiDichVu = new ObservableCollection<ClassGoiDichVu>();
            foreach (var item in listGDV)
            {
                var goiDichVu = new ClassGoiDichVu()
                {
                    IsCheck = false,
                    GDV_ANH = item.GDV_ANH,
                    GDV_TEN = item.GDV_TEN,
                    GDV_MA = item.GDV_MA,
                    LGDV_TEN = item.LOAIGOIDICHVU.LGDV_TEN,
                };

                listGoiDichVu.Add(goiDichVu);
            }
            return listGoiDichVu;
        }

        ObservableCollection<ClassGoiDichVu> GetListGoiDichVu(ObservableCollection<GOIDICHVU> listGoiDichVu,ObservableCollection<GOIDICHVU> listGoiDichVuPhong)
        {
            foreach (var item in listGoiDichVuPhong.ToList())
            {
                foreach(var item2 in listGoiDichVu.ToList())
                {
                    if(item == item2)
                    {
                        listGoiDichVu.Remove(item2);
                    }
                }
            }

            var listGoiDV = new ObservableCollection<ClassGoiDichVu>();
            foreach (var item in listGoiDichVu)
            {
                var goiDichVu = new ClassGoiDichVu()
                {
                    IsCheck = false,
                    GDV_ANH = item.GDV_ANH,
                    GDV_TEN = item.GDV_TEN,
                    GDV_MA = item.GDV_MA,
                    LGDV_TEN = item.LOAIGOIDICHVU.LGDV_TEN,
                };

                listGoiDV.Add(goiDichVu);
            }
            return listGoiDV;
        }
    }
}
