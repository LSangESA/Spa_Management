using LVTN_QLSpa.Model.DB;
using LVTN_QLSpa.Model.ModelClass;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LVTN_QLSpa.Model.DAO
{
    public class DAO_NhanVien
    {
        public static ObservableCollection<NHANVIEN> GetList()
        {
            return new ObservableCollection<NHANVIEN>(DataProvider.Ins.DB.NHANVIEN);
        }

        public static ObservableCollection<NHANVIEN> GetList(int VT_MA)
        {
            var getListNhanVien = new ObservableCollection<NHANVIEN>(DataProvider.Ins.DB.CHUYENMONNHANVIEN.Where(x => x.CHUYENMON.VAITRO.VT_MA == VT_MA).Select(x=>x.NHANVIEN).Distinct());
            return getListNhanVien;
        }

        public static NHANVIEN Add(NHANVIEN nhanvien)
        {
            DataProvider.Ins.DB.NHANVIEN.Add(nhanvien);
            DataProvider.Ins.DB.SaveChanges();

            return nhanvien;
        }

        public static void Edit(string NV_MA, 
            string NV_HOTEN, 
            DateTime NV_NGAYSINH, 
            string NV_GIOITINH, 
            string NV_SDT,
            string NV_EMAIL, 
            string NV_CCCD, 
            string NV_DIACHI, 
            string NV_USERNAME, 
            string NV_TRANGTHAI, 
            string NV_ANH, 
            int XP_MA)
        {
            try
            {
                var nhanvien = DataProvider.Ins.DB.NHANVIEN.Where(x => x.NV_MA == NV_MA).SingleOrDefault();
                nhanvien.NV_HOTEN = NV_HOTEN;
                nhanvien.NV_NGAYSINH = NV_NGAYSINH;
                nhanvien.NV_GIOITINH = NV_GIOITINH;
                nhanvien.NV_SDT = NV_SDT;
                nhanvien.NV_EMAIL = NV_EMAIL;
                nhanvien.NV_CCCD = NV_CCCD;
                nhanvien.NV_DIACHI = NV_DIACHI;
                nhanvien.NV_USERNAME = NV_USERNAME;
                nhanvien.NV_ANH = NV_ANH;
                nhanvien.XP_MA = XP_MA;
                nhanvien.NV_TRANGTHAI = NV_TRANGTHAI;

                DataProvider.Ins.DB.SaveChanges();
            }
            catch { }
        }

        public static void Delete(string NV_MA)
        {
            var nhanvien = DataProvider.Ins.DB.NHANVIEN.Where(x => x.NV_MA == NV_MA).SingleOrDefault();
            DataProvider.Ins.DB.NHANVIEN.Remove(nhanvien);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static ObservableCollection<CHUYENMONNHANVIEN> GetList_CMNV(string NV_MA)
        {
            return new ObservableCollection<CHUYENMONNHANVIEN>(DataProvider.Ins.DB.CHUYENMONNHANVIEN.Where(x=>x.NV_MA == NV_MA));
        }

        public static void AddNV_CM(int CM_MA, string NV_MA)
        {
            CHUYENMONNHANVIEN cmnv = new CHUYENMONNHANVIEN();
            cmnv.CM_MA = CM_MA;
            cmnv.NV_MA = NV_MA;
            DataProvider.Ins.DB.CHUYENMONNHANVIEN.Add(cmnv);
            DataProvider.Ins.DB.SaveChanges();
            
        }

        public static void DeleteNV_CM(string NV_MA, int CM_MA)
        {
            var chuyenMonNhanVien = DataProvider.Ins.DB.CHUYENMONNHANVIEN.Where(x => x.NV_MA == NV_MA && x.CM_MA == CM_MA).SingleOrDefault();
            DataProvider.Ins.DB.CHUYENMONNHANVIEN.Remove(chuyenMonNhanVien);
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
