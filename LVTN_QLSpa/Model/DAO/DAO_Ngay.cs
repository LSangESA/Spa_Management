using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVTN_QLSpa.Model.DAO
{
    public static class DAO_Ngay
    {
        public static void Add(NGAY ngay)
        {
            DataProvider.Ins.DB.NGAY.Add(ngay);
            DataProvider.Ins.DB.SaveChanges();
        }
        public static void Add(DateTime THOIGIAN)
        {
            var ngay = new NGAY();
            ngay.THOIGIAN = THOIGIAN;

            DataProvider.Ins.DB.NGAY.Add(ngay);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static void Delete(DateTime THOIGIAN)
        {
            var ngay = DataProvider.Ins.DB.NGAY.Where(x => x.THOIGIAN == THOIGIAN).SingleOrDefault();
            DataProvider.Ins.DB.NGAY.Remove(ngay);
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
