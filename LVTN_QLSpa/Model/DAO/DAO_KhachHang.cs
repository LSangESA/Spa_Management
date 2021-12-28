using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVTN_QLSpa.Model.DAO
{
    public static class DAO_KhachHang
    {
        public static KHACHHANG AddKH(string KH_MA,string KH_HOTEN, DateTime KH_NGAYSINH, string KH_GIOITINH, string KH_DIACHI, string KH_SDT, string KH_EMAIL, int XP_MA)
        {
            var khachHang = new KHACHHANG();
            khachHang.KH_MA = KH_MA;
            khachHang.KH_HOTEN = KH_HOTEN;
            khachHang.KH_NGAYSINH = KH_NGAYSINH;
            khachHang.KH_GIOITINH = KH_GIOITINH;
            khachHang.KH_DIACHI = KH_DIACHI;
            khachHang.KH_SDT = KH_SDT;
            khachHang.KH_EMAIL = KH_EMAIL;
            khachHang.XP_MA = XP_MA;

            DataProvider.Ins.DB.KHACHHANG.Add(khachHang);
            DataProvider.Ins.DB.SaveChanges();

            return khachHang;
        }

        public static void EditKH(string KH_MA, string KH_HOTEN, DateTime KH_NGAYSINH, string KH_GIOITINH, string KH_DIACHI, string KH_SDT, string KH_EMAIL, int XP_MA)
        {
            var khachHang = DataProvider.Ins.DB.KHACHHANG.Where(x => x.KH_MA == KH_MA).SingleOrDefault();
            khachHang.KH_MA = KH_MA;
            khachHang.KH_HOTEN = KH_HOTEN;
            khachHang.KH_NGAYSINH = KH_NGAYSINH;
            khachHang.KH_GIOITINH = KH_GIOITINH;
            khachHang.KH_DIACHI = KH_DIACHI;
            khachHang.KH_SDT = KH_SDT;
            khachHang.KH_EMAIL = KH_EMAIL;
            khachHang.XP_MA = XP_MA;

            DataProvider.Ins.DB.SaveChanges();
        }

        public static void DeleteKH(string KH_MA)
        {
            var khachHang = DataProvider.Ins.DB.KHACHHANG.Where(x => x.KH_MA == KH_MA).SingleOrDefault();
            DataProvider.Ins.DB.KHACHHANG.Remove(khachHang);
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
