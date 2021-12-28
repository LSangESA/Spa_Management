using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVTN_QLSpa.Model.DAO
{
    public static class DAO_PhieuDangKy
    {
        public static ObservableCollection<PHIEUDANGKY> GetList()
        {
            return new ObservableCollection<PHIEUDANGKY>(DataProvider.Ins.DB.PHIEUDANGKY);
        }

        public static ObservableCollection<PHIEUDANGKY> GetList(string GDV_MA)
        {
            return new ObservableCollection<PHIEUDANGKY>(DataProvider.Ins.DB.PHIEUDANGKY.Where(x => x.GDV_MA == GDV_MA).OrderByDescending(x => x.PDK_NGAYDK));
        }

        public static ObservableCollection<PHIEUDANGKY> GetListKH(string KH_MA)
        {
            return new ObservableCollection<PHIEUDANGKY>(DataProvider.Ins.DB.PHIEUDANGKY.Where(x => x.KH_MA == KH_MA).OrderByDescending(x => x.PDK_NGAYDK));
        }

        public static ObservableCollection<PHIEUDANGKY> GetList(int CTT_MA)
        {
            return new ObservableCollection<PHIEUDANGKY>(DataProvider.Ins.DB.PHIEUDANGKY.Where(x => x.CTT_MA == CTT_MA).OrderByDescending(x => x.PDK_NGAYDK));
        }

        public static PHIEUDANGKY Add(string PDK_STT, DateTime PDK_NGAYDK, DateTime PDK_NGAYBATDAU, string PDK_TRANGTHAI, string GDV_MA, string KH_MA, int CTT_MA, string NV_MA = null)
        {
            var phieuDangKy = new PHIEUDANGKY()
            {
                PDK_STT = PDK_STT,
                PDK_NGAYDK = PDK_NGAYDK,
                PDK_NGAYBATDAU = PDK_NGAYBATDAU,
                PDK_TRANGTHAI = PDK_TRANGTHAI,
                NV_MA = NV_MA,
                GDV_MA = GDV_MA,
                KH_MA = KH_MA,
                CTT_MA = CTT_MA
            };

            DataProvider.Ins.DB.PHIEUDANGKY.Add(phieuDangKy);
            DataProvider.Ins.DB.SaveChanges();
            return phieuDangKy;
        }

        public static void EditTrangThaiPDK(string PDK_STT, string PDK_TRANGTHAI)
        {
            var phieuDangKy = DataProvider.Ins.DB.PHIEUDANGKY.Where(x => x.PDK_STT == PDK_STT).SingleOrDefault();
            phieuDangKy.PDK_TRANGTHAI = PDK_TRANGTHAI;

            DataProvider.Ins.DB.SaveChanges();
        }

        public static void DeletePDK(string PDK_STT)
        {
            var phieuDangKy = DataProvider.Ins.DB.PHIEUDANGKY.Where(x => x.PDK_STT == PDK_STT).SingleOrDefault();
            DataProvider.Ins.DB.PHIEUDANGKY.Remove(phieuDangKy);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static void Delete_GGPDK(string PDK_STT)
        {
            var giamGiaPDK = DataProvider.Ins.DB.GIAMGIA_PDK.Where(x => x.PDK_STT == PDK_STT).SingleOrDefault();
            DataProvider.Ins.DB.GIAMGIA_PDK.Remove(giamGiaPDK);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static bool KiemTraPDKDaTonTaiPDT(string PDK_STT)
        {
            var getPDTInPDK = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDK_STT == PDK_STT).Count();

            if (getPDTInPDK > 0)
                return true;
            else
                return false;
        }
    }
}
