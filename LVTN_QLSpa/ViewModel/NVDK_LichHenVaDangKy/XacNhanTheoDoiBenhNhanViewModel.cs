using LVTN_QLSpa.Model.DAO;
using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LVTN_QLSpa.ViewModel.NVDK_LichHenVaDangKy
{
    public class XacNhanTheoDoiBenhNhanViewModel : BaseViewModel
    {
        private bool _CheckLapLichBS;
        public bool CheckLapLichBS { get => _CheckLapLichBS; set { _CheckLapLichBS = value; OnPropertyChanged(); } }

        public ICommand LoadWindow { get; set; }
        public ICommand CommandLapLichBacSi { get; set; }
        public XacNhanTheoDoiBenhNhanViewModel()
        {
            LoadWindow = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                CheckLapLichBS = false;
            }
            );

            CommandLapLichBacSi = new RelayCommand<Window>((p) =>
            {
                return true;
            }, (p) =>
            {
                if(CheckLapLichBS == false)
                {
                    FrameworkElement window = GetWindowParent(p);
                    var w = window as Window;
                    if (w != null)
                    {
                        w.Close();
                    }
                }
                else
                {
                    /* Lấy số phiếu đăng ký vừa lập
                     * Lấy danh sách lịch trình điều trị từ phiếu đăng ký
                     * Cho vòng lập với danh sách lịch trình vừa lấy
                     * Tạo lịch làm việc cho nhân viên bác sĩ với ngày tương ứng
                     *      Kiểm tra xem buổi liệu trình của lịch trình đó là buổi nào, thêm lịch tương ứng buổi đó
                     *      Nếu như ngày và buổi đó đã có ca làm việc thì bỏ qua
                    */

                    var phieuDangKy = DataProvider.Ins.DB.PHIEUDANGKY.Where(x => x.PDK_STT == LapPhieuDangKyViewModel.PDK_STT_DATA).SingleOrDefault();

                    var lichTrinhDieuTri = DAO_LichTrinhDieuTri.GetList(phieuDangKy.PDK_STT);
                    foreach (var item in lichTrinhDieuTri)
                    {
                        // Lay ca lam viec tu buoi lich trinh
                        var caLamViec = LayCaLamViecTuongUngBuoiLieuTri(item.LTDT_THOIGIANDEN);

                        // Lay lich lam viec cua bac si trong ngay hom do
                        var layNgay = new DateTime(item.LTDT_NGAYDT.Year, item.LTDT_NGAYDT.Month, item.LTDT_NGAYDT.Day);
                        var lichLamViecBS = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.THOIGIAN == layNgay && x.NV_MA == phieuDangKy.NV_MA && x.CLV_MA == caLamViec.CLV_MA).SingleOrDefault();

                        // Nếu như lịch làm việc ngày hôm đó tồn tại lịch cả ngày thì không làm gì cả
                        if(DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.THOIGIAN == layNgay && x.NV_MA == phieuDangKy.NV_MA && x.CLV_MA == "CLV2765             ").SingleOrDefault() == null)
                        {
                            // Neu nhu ngay va buoi hom do bac si khong co lich thi lap lich lam viec cho buoi do
                            if (lichLamViecBS == null)
                            {
                                // Lấy ngày được chọn trên dtpk
                                layNgay = new DateTime(layNgay.Year, layNgay.Month, layNgay.Day);

                                // Nếu như thời gian đã tồn tạo trong csdl thì không cần thêm ngày
                                var getDate = DataProvider.Ins.DB.NGAY.Where(x => x.THOIGIAN == layNgay).Count();
                                if (getDate == 0)
                                {
                                    var ngay = new NGAY();
                                    ngay.THOIGIAN = layNgay;
                                    DAO_Ngay.Add(ngay);
                                }

                                string ghiChu = "Có lịch hẹn khám theo liệu trình";
                                DAO_LichLamViec.Add(phieuDangKy.NV_MA, caLamViec.CLV_MA, layNgay, null, ghiChu);
                            }
                        }
                    }

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

        CALAMVIEC LayCaLamViecTuongUngBuoiLieuTri(string buoiLieuTrinhKhacHang)
        {
            if (buoiLieuTrinhKhacHang == "Sáng")
                return DataProvider.Ins.DB.CALAMVIEC.Where(x => x.CLV_MA == "CLV7961             ").SingleOrDefault();
            else
                return DataProvider.Ins.DB.CALAMVIEC.Where(x => x.CLV_MA == "CLV8258             ").SingleOrDefault();
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
}
