using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using LVTN_QLSpa.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LVTN_QLSpa.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        private static NHANVIEN nv_DATA;
        public static NHANVIEN NV_DATA
        {
            get { return LoginViewModel.nv_DATA; }
            set { LoginViewModel.nv_DATA = value; }
        }

        private string _UserName;
        public string UserName { get => _UserName; set { _UserName = value; OnPropertyChanged(); } }

        private string _Password;
        public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }

        private ObservableCollection<CHUCNANG> _CHUCNANG;
        public ObservableCollection<CHUCNANG> CHUCNANG { get => _CHUCNANG; set { _CHUCNANG = value; OnPropertyChanged(); } }

        private CHUCNANG _SelectedCHUCNANG;
        public CHUCNANG SelectedCHUCNANG
        {
            get => _SelectedCHUCNANG;
            set
            {
                _SelectedCHUCNANG = value;
                OnPropertyChanged();
            }
        }


        public ICommand PasswordChangedCommand { get; set; }
        public ICommand LoginCommand { get; set; }
        public ICommand ExitAppCommand { get; set; }

        FrameworkElement GetWindowParent(Window p)
        {
            FrameworkElement parent = p;

            while (parent.Parent != null)
            {
                parent = parent.Parent as FrameworkElement;
            }

            return parent;
        }

        public LoginViewModel()
        {
            CHUCNANG = new ObservableCollection<CHUCNANG>(DataProvider.Ins.DB.CHUCNANG);

            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { Password = p.Password; });

            LoginCommand = new RelayCommand<Window>((p) =>
            {
                if (SelectedCHUCNANG == null)
                    return false;

                return true;
            }, (p) =>
            {
                var nhanVien = DataProvider.Ins.DB.NHANVIEN.Where(x => x.NV_USERNAME == UserName && x.NV_PASSWORD == Password).SingleOrDefault();
                NV_DATA = nhanVien;

                if (nhanVien != null)
                {
                    var getVaiTroNV = DataProvider.Ins.DB.CHUYENMONNHANVIEN.Where(x => x.NV_MA == nhanVien.NV_MA).Select(x => x.CHUYENMON).Distinct().ToList();
                    foreach (var item in getVaiTroNV)
                    {
                        if (SelectedCHUCNANG.CN_MA == 1)
                        {
                            if (item.VAITRO.VT_MA == 4 || item.VAITRO.VT_MA == 5 || item.CM_TEN == "Admin")
                            {
                                MainUserManageAppointmentsAndRegistrationsWindow window = new MainUserManageAppointmentsAndRegistrationsWindow();
                                p.Hide();
                                window.ShowDialog();
                                p.Show();
                                return;
                            }
                            else
                                MessageBox.Show("Bạn không có quyên truy cập", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else if (SelectedCHUCNANG.CN_MA == 2)
                        {
                            if (item.VAITRO.VT_MA == 2 || item.CM_TEN == "Admin")
                            {
                                MainUserManageExaminationAndTreatmentWindow window = new MainUserManageExaminationAndTreatmentWindow();
                                p.Hide();
                                window.ShowDialog();
                                p.Show();
                                return;
                            }
                            else
                                MessageBox.Show("Bạn không có quyên truy cập", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else if (SelectedCHUCNANG.CN_MA == 3)
                        {
                            if (item.VAITRO.VT_MA == 1 || item.CM_TEN == "Admin")
                            {
                                MainUserManageWindow window = new MainUserManageWindow();
                                p.Hide();
                                window.ShowDialog();
                                p.Show();
                                return;
                            }
                            else
                                MessageBox.Show("Bạn không có quyên truy cập", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else if (SelectedCHUCNANG.CN_MA == 4)
                        {
                            if (item.VAITRO.VT_MA == 6 || item.CM_TEN == "Admin")
                            {
                                MainUserStatistic window = new MainUserStatistic();
                                p.Hide();
                                window.ShowDialog();
                                p.Show();
                                return;
                            }
                            else
                                MessageBox.Show("Bạn không có quyên truy cập", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin tài khoản hoặc mật khẩu sai", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            });

            ExitAppCommand = new RelayCommand<Window>((p) =>
            {
                return true;
            }, (p) =>
            {
                FrameworkElement window = GetWindowParent(p);
                var w = window as Window;
                if (w != null)
                {
                    if (MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
                    {
                        w.Close();
                    }

                }
            });

        }

    }
}
