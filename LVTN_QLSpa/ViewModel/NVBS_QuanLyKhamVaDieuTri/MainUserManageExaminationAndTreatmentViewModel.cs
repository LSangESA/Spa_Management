using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLNV;
using LVTN_QLSpa.ViewModel.NVQL_QuanTriHeThong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LVTN_QLSpa.ViewModel.NVBS_QuanLyKhamVaDieuTri
{
    public class MainUserManageExaminationAndTreatmentViewModel : BaseViewModel
    {
        private string _NV_ANH;
        public string NV_ANH { get => _NV_ANH; set { _NV_ANH = value; OnPropertyChanged(); } }

        private string _NV_TEN;
        public string NV_TEN { get => _NV_TEN; set { _NV_TEN = value; OnPropertyChanged(); } }

        private string _NV_MA;
        public string NV_MA { get => _NV_MA; set { _NV_MA = value; OnPropertyChanged(); } }

        public ICommand LoadWindow { get; set; }
        public ICommand CommandDoubleClickNhanVien { get; set; }

        public MainUserManageExaminationAndTreatmentViewModel()
        {
            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                var getNhanVien = DataProvider.Ins.DB.CHUYENMONNHANVIEN.Where(x => x.NV_MA == LoginViewModel.NV_DATA.NV_MA).Select(x => x.NHANVIEN).Distinct().SingleOrDefault();

                NV_ANH = getNhanVien.NV_ANH;
                NV_TEN = getNhanVien.NV_HOTEN;
                NV_MA = getNhanVien.NV_MA;
            }
            );

            CommandDoubleClickNhanVien = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                CapNhatNhanVienViewModel.NhanVien_DATA = DataProvider.Ins.DB.NHANVIEN.Where(x => x.NV_MA == NV_MA).SingleOrDefault();
                W_ThongTinNhanVien window = new W_ThongTinNhanVien();
                window.ShowDialog();
                CapNhatNhanVienViewModel.NhanVien_DATA = null;
            }
            );
        }
    }
}

