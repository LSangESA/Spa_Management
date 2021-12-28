using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace LVTN_QLSpa.ViewModel.NVQL_QuanTriHeThong
{
    public class CapNhatLieuTrinhViewModel : BaseViewModel
    {
        private string _KeySearchLT;
        public string KeySearchLT { get => _KeySearchLT; set { _KeySearchLT = value; OnPropertyChanged(); } }

        private int _LT_STT;
        public int LT_STT { get => _LT_STT; set { _LT_STT = value; OnPropertyChanged(); } }

        private int? _LT_NGAYTHU;
        public int? LT_NGAYTHU { get => _LT_NGAYTHU; set { _LT_NGAYTHU = value; OnPropertyChanged(); } }

        private string _LT_THOIGIANTH;
        public string LT_THOIGIANTH { get => _LT_THOIGIANTH; set { _LT_THOIGIANTH = value; OnPropertyChanged(); } }

        private string _DONGIA;
        public string DONGIA { get => _DONGIA; set { _DONGIA = value; OnPropertyChanged(); } }

        private string _LT_MOTA;
        public string LT_MOTA { get => _LT_MOTA; set { _LT_MOTA = value; OnPropertyChanged(); } }

        private string _GDV_SOLAN;
        public string GDV_SOLAN { get => _GDV_SOLAN; set { _GDV_SOLAN = value; OnPropertyChanged(); } }


        private ObservableCollection<DG_LT> _LTList;
        public ObservableCollection<DG_LT> LTList { get => _LTList; set { _LTList = value; OnPropertyChanged(); } }

        private ObservableCollection<GOIDICHVU> _GOIDICHVU;
        public ObservableCollection<GOIDICHVU> GOIDICHVU { get => _GOIDICHVU; set { _GOIDICHVU = value; OnPropertyChanged(); } }

        private ObservableCollection<DICHVU> _DICHVULT;
        public ObservableCollection<DICHVU> DICHVULT { get => _DICHVULT; set { _DICHVULT = value; OnPropertyChanged(); } }

        private DG_LT _SelectedItemLT;
        public DG_LT SelectedItemLT
        {
            get => _SelectedItemLT;
            set
            {
                _SelectedItemLT = value;
                OnPropertyChanged();
                if (SelectedItemLT != null)
                {
                    LT_STT = SelectedItemLT.LIEUTRINH.LT_STT;
                    LT_NGAYTHU = SelectedItemLT.LIEUTRINH.LT_NGAYTHU;
                    LT_THOIGIANTH = SelectedItemLT.LIEUTRINH.LT_THOIGIANTH;
                    LT_MOTA = SelectedItemLT.LIEUTRINH.LT_MOTA;
                    DONGIA = SelectedItemLT.DONGIA;
                    SelectedGDV = SelectedItemLT.LIEUTRINH.GOIDICHVU;
                    SelectedDVLT = SelectedItemLT.LIEUTRINH.GOIDICHVU.DICHVU;
                }
            }
        }

        private GOIDICHVU _SelectedGDV;
        public GOIDICHVU SelectedGDV
        {
            get => _SelectedGDV;
            set
            {
                _SelectedGDV = value;
                OnPropertyChanged();

                if(SelectedGDV != null)
                {
                    GDV_SOLAN = SelectedGDV.GDV_SOLAN.ToString();
                }
            }
        }

        private DICHVU _SelectedDVLT;
        public DICHVU SelectedDVLT
        {
            get => _SelectedDVLT;
            set
            {
                _SelectedDVLT = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddLT { get; set; }
        public ICommand EditLT { get; set; }
        public ICommand DeleteLT { get; set; }
        public ICommand ClearLT { get; set; }
        public ICommand AddIdCommandLT { get; set; }
        public ICommand KeySearchCommandLT { get; set; }
        public ICommand CommandFilterGDV { get; set; }
        public ICommand CommandFilterDV { get; set; }


        private bool UserFilterLT(object item)
        {
            if (String.IsNullOrEmpty(KeySearchLT))
                return true;
            else
                return ((item as DG_LT).LIEUTRINH.LT_MOTA.IndexOf(KeySearchLT, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as DG_LT).LIEUTRINH.LT_THOIGIANTH.ToString().IndexOf(KeySearchLT, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as DG_LT).LIEUTRINH.LT_NGAYTHU.ToString().IndexOf(KeySearchLT, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as DG_LT).LIEUTRINH.LT_STT.ToString().IndexOf(KeySearchLT, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as DG_LT).DONGIA.ToString().IndexOf(KeySearchLT, StringComparison.OrdinalIgnoreCase) >= 0
                    || (item as DG_LT).LIEUTRINH.GOIDICHVU.GDV_TEN.IndexOf(KeySearchLT, StringComparison.OrdinalIgnoreCase) >= 0); /*|| (item as ListInvoice).NGAYLAP.ToString().IndexOf(TextFilter, StringComparison.OrdinalIgnoreCase) >= 0*/
        }

        public CapNhatLieuTrinhViewModel()
        {
            LT_STT = 0;
            GOIDICHVU = DAO_GoiDichVu.GetListGDV();
            DICHVULT = DAO_DichVu.GetList();

            KeySearchCommandLT = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                CollectionViewSource.GetDefaultView(LTList).Refresh();
            }
            );

            CommandFilterDV = new RelayCommand<object>((p) =>
            {
                if (SelectedDVLT == null)
                    return false;
                return true;
            }, (p) =>
            {
                GOIDICHVU = DAO_GoiDichVu.GetListForDV(SelectedDVLT.DV_MA);
            }
            );

            CommandFilterGDV = new RelayCommand<object>((p) =>
            {
                if (SelectedGDV == null)
                    return false;
                return true;
            }, (p) =>
            {
                LTList = DAO_LieuTrinh.GetList(SelectedGDV.GDV_MA);

                CollectionView viewlt = (CollectionView)CollectionViewSource.GetDefaultView(LTList);
                viewlt.Filter = UserFilterLT;
                
            }
            );

            AddLT = new RelayCommand<object>((p) =>
            {
                if (LT_NGAYTHU == null || LT_NGAYTHU <= 0 || string.IsNullOrEmpty(LT_THOIGIANTH) || SelectedGDV == null || string.IsNullOrEmpty(DONGIA) || LT_STT <= 0 || SelectedItemLT != null)
                {
                    return false;
                }

                // Nếu số liệu trình tạo cho gói dịch vụ bằng số lần đã tạo của gói thì không thể tạo thêm 
                var getSoLanLTGoiDichVu = DataProvider.Ins.DB.GOIDICHVU.Where(x => x.GDV_MA == SelectedGDV.GDV_MA).Select(x=>x.GDV_SOLAN).SingleOrDefault();
                var countLT_GDV = DataProvider.Ins.DB.LIEUTRINH.Where(x => x.GDV_MA == SelectedGDV.GDV_MA).Count();
                if (countLT_GDV >= getSoLanLTGoiDichVu)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                // Add lieu trinh
                var lieutrinh = new LIEUTRINH() { LT_STT = LT_STT, LT_NGAYTHU = LT_NGAYTHU, LT_THOIGIANTH = LT_THOIGIANTH, LT_MOTA = LT_MOTA, GDV_MA = SelectedGDV.GDV_MA };
                int LT_MA = DAO_LieuTrinh.Add(lieutrinh);

                // Add ngay
                var ngay = new NGAY() { THOIGIAN = DateTime.Now };
                DAO_Ngay.Add(ngay);

                // Add don gia lieu trinh
                var dongia_lt = new DG_LT { GDV_MA = SelectedGDV.GDV_MA, LT_MA = LT_MA, THOIGIAN = ngay.THOIGIAN, DONGIA = DONGIA };
                DAO_LieuTrinh.Add(dongia_lt);

                LTList = DAO_LieuTrinh.GetList(SelectedGDV.GDV_MA);
            }
            );

            EditLT = new RelayCommand<object>((p) =>
            {
                if (SelectedGDV == null || LT_STT <= 0 || SelectedItemLT == null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                // Edit lieu trinh
                DAO_LieuTrinh.Edit(SelectedItemLT.LT_MA, LT_STT, LT_NGAYTHU, LT_THOIGIANTH, LT_MOTA);

                // Edit Don gia
                if(SelectedItemLT.DONGIA != DONGIA)
                {
                    DAO_LieuTrinh.Edit(SelectedItemLT.LT_MA, DONGIA);
                }

                LTList = DAO_LieuTrinh.GetList(SelectedGDV.GDV_MA);
            }
            );

            DeleteLT = new RelayCommand<object>((p) =>
            {
                if (SelectedGDV == null || SelectedItemLT == null)
                {
                    return false;
                }

                return true;
            }, (p) =>
            {
                // Delete lieu trinh
                DAO_LieuTrinh.Delete_DGLT(SelectedItemLT.LT_MA);

                // Delete don gia lieu trinh
                DAO_LieuTrinh.Delete(SelectedItemLT.LT_MA);

                

                LTList = DAO_LieuTrinh.GetList(SelectedGDV.GDV_MA);
            }
            );

            ClearLT = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                SelectedDVLT = null;
                SelectedGDV = null;
                LT_STT = 0;
                LT_NGAYTHU = 0;
                LT_THOIGIANTH = "";
                LT_MOTA = "";
                DONGIA = "";
                GDV_SOLAN = "";

                SelectedGDV = null;
                SelectedDVLT = null;
            }
            );
        }
    }
}
