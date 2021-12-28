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

namespace LVTN_QLSpa.ViewModel.NVBS_QuanLyKhamVaDieuTri
{
    public class LichSuDangKyDVViewModel : BaseViewModel
    {
        private ObservableCollection<PHIEUDANGKY> _PDKList;
        public ObservableCollection<PHIEUDANGKY> PDKList { get => _PDKList; set { _PDKList = value; OnPropertyChanged(); } }

        private ObservableCollection<ClassPhieuDieuTriLichSuKham> _PDTList;
        public ObservableCollection<ClassPhieuDieuTriLichSuKham> PDTList { get => _PDTList; set { _PDTList = value; OnPropertyChanged(); } }

        private ObservableCollection<ClassChiDinh> _CDList;
        public ObservableCollection<ClassChiDinh> CDList { get => _CDList; set { _CDList = value; OnPropertyChanged(); } }

        private PHIEUDANGKY _SelectedItemPDK;
        public PHIEUDANGKY SelectedItemPDK
        {
            get => _SelectedItemPDK;
            set
            {
                _SelectedItemPDK = value;
                OnPropertyChanged();
                if (SelectedItemPDK != null)
                {
                    var getPDT = new ObservableCollection<PHIEUDIEUTRI>(DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDK_STT == SelectedItemPDK.PDK_STT));
                    PDTList = new ObservableCollection<ClassPhieuDieuTriLichSuKham>();
                    foreach(var item in getPDT)
                    {
                        var phieuDieuTri = new ClassPhieuDieuTriLichSuKham();
                        phieuDieuTri.PDK_STT = item.PDK_STT;
                        phieuDieuTri.PDT_STT = item.PDT_STT;
                        phieuDieuTri.PDT_CHUANDOAN = item.PDT_CHUANDOAN;
                        phieuDieuTri.PDT_GHICHU = item.PDT_GHICHU;
                        phieuDieuTri.PDT_LOIDAN = item.PDT_LOIDAN;
                        phieuDieuTri.PDT_NGAYLAP = item.PDT_NGAYLAP;
                        phieuDieuTri.PDT_TRANGTHAI = item.PDT_TRANGTHAI;
                        if (item.PHIEUDANGKY.GOIDICHVU.LOAIGOIDICHVU.LGDV_MA == 1)
                        {
                            int SOPDT = Convert.ToInt32(item.PDT_STT);
                            var lieuTrinh = DataProvider.Ins.DB.LIEUTRINH.Where(x => x.GDV_MA == item.PHIEUDANGKY.GDV_MA && x.LT_STT == SOPDT).SingleOrDefault();
                            phieuDieuTri.LT_MOTA = lieuTrinh.LT_STT + " - " + lieuTrinh.LT_MOTA;
                        }
                        else
                        {
                            phieuDieuTri.LT_MOTA = "";
                        }
                        PDTList.Add(phieuDieuTri);
                    }
                }
            }
        }

        private ClassPhieuDieuTriLichSuKham _SelectedItemPDT;
        public ClassPhieuDieuTriLichSuKham SelectedItemPDT
        {
            get => _SelectedItemPDT;
            set
            {
                _SelectedItemPDT = value;
                OnPropertyChanged();
                
            }
        }

        public ICommand LoadWindow { get; set; }
        public ICommand CommandSelectedItemPDT { get; set; }
        static int i = 0;
        public LichSuDangKyDVViewModel()
        {
            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                var phieuDieuTri = DanhSachChoViewModel.PDT_DATA;
                PDKList = new ObservableCollection<PHIEUDANGKY>(DataProvider.Ins.DB.PHIEUDANGKY.Where(x => x.KH_MA == phieuDieuTri.PHIEUDANGKY.KH_MA));
            }
            );
            
            CommandSelectedItemPDT = new RelayCommand<object>((p) =>
            {
                if (SelectedItemPDT == null)
                    return false;

                return true;
            }, (p) =>
            {
                var getListChiDinh = DAO_ChiDinh.GetListTheoPDT(SelectedItemPDT.PDT_STT, SelectedItemPDT.PDK_STT);
                CDList = new ObservableCollection<ClassChiDinh>();
                i = 0;
                foreach (var item in getListChiDinh)
                {
                    ClassChiDinh classChiDinh = new ClassChiDinh();
                    classChiDinh.STT = i++;
                    classChiDinh.T_MA = item.T_MA;
                    classChiDinh.T_TEN = item.THUOC.T_TEN;
                    classChiDinh.PDK_STT = item.PDK_STT;
                    classChiDinh.PDT_STT = item.PDT_STT;
                    classChiDinh.CD_CACHDUNG = item.CD_CACHDUNG;
                    classChiDinh.CD_SOLUONG = item.CD_SOLUONG;
                    classChiDinh.CD_LIEUDUNG = item.CD_LIEUDUNG;
                    classChiDinh.HC_MA = item.THUOC.HOATCHAT.HC_MA;
                    CDList.Add(classChiDinh);
                }
            }
            );
        }
    }
}
