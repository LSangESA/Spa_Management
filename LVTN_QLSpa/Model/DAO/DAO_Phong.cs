using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVTN_QLSpa.Model.DAO
{
    public class Phong
    {
        public int P_MA { get; set; }
        public string P_SO { get; set; }
        public string P_TEN { get; set; }
    }
    public static class DAO_Phong
    {
        public static ObservableCollection<PHONG> GetList()
        {
            return new ObservableCollection<PHONG>(DataProvider.Ins.DB.PHONG);
        }

        public static ObservableCollection<Phong> GetListPhong(ObservableCollection<PHONG> listPhong)
        {
            var dsPhong = new ObservableCollection<Phong>();
            foreach(var item in listPhong)
            {
                var phong = new Phong();
                phong.P_MA = item.P_MA;
                phong.P_SO = item.P_SO.Trim(' ');
                phong.P_TEN = item.P_TEN;

                dsPhong.Add(phong);
            }

            return dsPhong;
        }

        public static ObservableCollection<GOIDICHVU> GetListGoiDichVuPhong(int P_MA)
        {
            return new ObservableCollection<GOIDICHVU>(DataProvider.Ins.DB.DICHVUPHONG.Where(x=>x.P_MA == P_MA).Select(x=>x.GOIDICHVU));
        }

        public static PHONG Add(PHONG phong)
        {
            DataProvider.Ins.DB.PHONG.Add(phong);
            DataProvider.Ins.DB.SaveChanges();

            return phong;
        }

        public static void Edit(int P_MA, string P_SO, string P_TEN, int P_SOLUONGNHANVIEN, string P_MOTA)
        {
            var phong = DataProvider.Ins.DB.PHONG.Where(x => x.P_MA == P_MA).SingleOrDefault();
            phong.P_SO = P_SO;
            phong.P_TEN = P_TEN;
            phong.P_SOLUONGNHANVIEN = P_SOLUONGNHANVIEN;
            phong.P_MOTA = P_MOTA;

            DataProvider.Ins.DB.SaveChanges();
        }

        public static void Delete(int P_MA)
        {
            var phong = DataProvider.Ins.DB.PHONG.Where(x => x.P_MA == P_MA).SingleOrDefault();
            DataProvider.Ins.DB.PHONG.Remove(phong);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static ObservableCollection<CHITIETPHONG> GetListCTP()
        {
            return new ObservableCollection<CHITIETPHONG>(DataProvider.Ins.DB.CHITIETPHONG);
        }

        public static CHITIETPHONG Add(CHITIETPHONG chitietphong)
        {
            DataProvider.Ins.DB.CHITIETPHONG.Add(chitietphong);
            DataProvider.Ins.DB.SaveChanges();

            return chitietphong;
        }

        public static void Edit(int VT_MA, int P_MA, int CTP_SOLUONG)
        {
            var chitietphong = DataProvider.Ins.DB.CHITIETPHONG.Where(x => x.P_MA == P_MA && x.VT_MA == VT_MA).SingleOrDefault();
            chitietphong.CTP_SOLUONG = CTP_SOLUONG;

            DataProvider.Ins.DB.SaveChanges();
        }

        public static void Delete(int VT_MA, int P_MA)
        {
            var chitietphong = DataProvider.Ins.DB.CHITIETPHONG.Where(x => x.P_MA == P_MA && x.VT_MA == VT_MA).SingleOrDefault();
            DataProvider.Ins.DB.CHITIETPHONG.Remove(chitietphong);
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
