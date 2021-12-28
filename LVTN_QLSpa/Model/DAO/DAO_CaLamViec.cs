using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVTN_QLSpa.Model.DAO
{
    public static class DAO_CaLamViec
    {
        public static CALAMVIEC AddCaLamViec(CALAMVIEC calamviec)
        {
            DataProvider.Ins.DB.CALAMVIEC.Add(calamviec);
            DataProvider.Ins.DB.SaveChanges();

            return calamviec;
        }

        public static void EditCaLamViec(string CLV_MA, string CLV_TEN, TimeSpan CLV_GIOBATDAU, TimeSpan CLV_GIOKETTHUC)
        {
            var calamviec = DataProvider.Ins.DB.CALAMVIEC.Where(x => x.CLV_MA == CLV_MA).SingleOrDefault();
            calamviec.CLV_TEN = CLV_TEN;
            calamviec.CLV_GIOBATDAU = CLV_GIOBATDAU;
            calamviec.CLV_GIOKETTHUC = CLV_GIOKETTHUC;

            DataProvider.Ins.DB.SaveChanges();
        }

        public static void DeleteCaLamViec(string CLV_MA)
        {
            var calamviec = DataProvider.Ins.DB.CALAMVIEC.Where(x => x.CLV_MA == CLV_MA).SingleOrDefault();
            DataProvider.Ins.DB.CALAMVIEC.Remove(calamviec);
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
