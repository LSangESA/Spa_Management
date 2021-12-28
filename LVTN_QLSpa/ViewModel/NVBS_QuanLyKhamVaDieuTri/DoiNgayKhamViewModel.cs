using LVTN_QLSpa.Model.DAO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LVTN_QLSpa.ViewModel.NVBS_QuanLyKhamVaDieuTri
{
    public class DoiNgayKhamViewModel : BaseViewModel
    {
        private DateTime _LTDT_NGAYDT;
        public DateTime LTDT_NGAYDT { get => _LTDT_NGAYDT; set { _LTDT_NGAYDT = value; OnPropertyChanged(); } }

        private ObservableCollection<BUOI> _BUOI;
        public ObservableCollection<BUOI> BUOI { get => _BUOI; set { _BUOI = value; OnPropertyChanged(); } }

        private BUOI _SelectedBUOI;
        public BUOI SelectedBUOI
        {
            get => _SelectedBUOI;
            set
            {
                _SelectedBUOI = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoadWindow { get; set; }
        public ICommand CommandDoiNgayKham { get; set; }

        public DoiNgayKhamViewModel()
        {
            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                LoadBuoi();
                if(DanhSachChoViewModel.PDT_DATA != null)
                {
                    LTDT_NGAYDT = DanhSachChoViewModel.PDT_DATA.PDT_NGAYLAP;
                }
            }
            );

            CommandDoiNgayKham = new RelayCommand<Window>((p) =>
            {
                if (LTDT_NGAYDT <= DateTime.Now)
                    return false;

                return true;
            }, (p) =>
            {
                if(MessageBox.Show("Ngày khám đã được dời đến ngày " + LTDT_NGAYDT.ToString(), "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Information) == MessageBoxResult.OK)
                {
                    var phieuDieuTri = DanhSachChoViewModel.PDT_DATA;
                    var SOPDT = Convert.ToInt32(phieuDieuTri.PDT_STT);
                    if (phieuDieuTri.PHIEUDANGKY.GOIDICHVU.LGDV_MA == 1)
                    {
                        var lieuTrinhDieuTri = DataProvider.Ins.DB.LICHTRINHDIEUTRI.Where(x => x.PDK_STT == phieuDieuTri.PDK_STT && x.LIEUTRINH.LT_STT == SOPDT).SingleOrDefault();
                        var ltdt = DAO_LichTrinhDieuTri.Edit(lieuTrinhDieuTri, LTDT_NGAYDT, SelectedBUOI.Name);
                    }

                    DAO_PhieuDieuTri.DoiNgayDieuTri(phieuDieuTri, LTDT_NGAYDT);

                    FrameworkElement window = GetWindowParent(p);
                    var w = window as Window;
                    if (w != null)
                    {
                        w.Close();
                    }
                }
                
            }
            );
        }
        void LoadBuoi()
        {
            BUOI = new ObservableCollection<BUOI>();
            BUOI.Add(new BUOI() { Name = "Sáng" });
            BUOI.Add(new BUOI() { Name = "Trưa" });
        }

        FrameworkElement GetWindowParent(Window p)
        {
            FrameworkElement parent = p;

            while (parent.Parent != null)
            {
                parent = parent.Parent as FrameworkElement;
            }

            return parent;
        }
    }
    public class BUOI
    {
        public string Name { get; set; }
    }
}
