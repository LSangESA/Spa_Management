using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVTN_QLSpa.Model.DAO
{
    public static class DAO_LieuTrinh
    {
        public static ObservableCollection<DG_LT> GetList()
        {
            return new ObservableCollection<DG_LT>(DataProvider.Ins.DB.DG_LT);
        }

        public static ObservableCollection<DG_LT> GetList(string GDV_MA)
        {
            return new ObservableCollection<DG_LT>(DataProvider.Ins.DB.DG_LT.Where(x=>x.GDV_MA == GDV_MA));
        }

        public static int Add(LIEUTRINH lieutrinh)
        {
            DataProvider.Ins.DB.LIEUTRINH.Add(lieutrinh);
            DataProvider.Ins.DB.SaveChanges();

            return lieutrinh.LT_MA;
        }

        public static void Add(DG_LT dongia_lt)
        {
            DataProvider.Ins.DB.DG_LT.Add(dongia_lt);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static void Edit(int LT_MA, int LT_STT, int? LT_NGAYTHU, string LT_THOIGIANTH, string LT_MOTA)
        {
            var lieutrinh = DataProvider.Ins.DB.LIEUTRINH.Where(x => x.LT_MA == LT_MA).SingleOrDefault();
            lieutrinh.LT_STT = LT_STT;
            lieutrinh.LT_NGAYTHU = LT_NGAYTHU;
            lieutrinh.LT_THOIGIANTH = LT_THOIGIANTH;
            lieutrinh.LT_MOTA = LT_MOTA;

            DataProvider.Ins.DB.SaveChanges();
        }

        public static void Edit(int LT_MA, string DONGIA)
        {
            var dongia_lt = DataProvider.Ins.DB.DG_LT.Where(x => x.LT_MA == LT_MA).SingleOrDefault();
            dongia_lt.DONGIA = DONGIA;

            DataProvider.Ins.DB.SaveChanges();
        }

        public static void Delete(int LT_MA)
        {
            var lieutrinh = DataProvider.Ins.DB.LIEUTRINH.Where(x => x.LT_MA == LT_MA).SingleOrDefault();
            DataProvider.Ins.DB.LIEUTRINH.Remove(lieutrinh);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static void Delete_DGLT(int LT_MA)
        {
            var dongia_lt = DataProvider.Ins.DB.DG_LT.Where(x => x.LT_MA == LT_MA).SingleOrDefault();
            DataProvider.Ins.DB.DG_LT.Remove(dongia_lt);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static LIEUTRINH LayLieuTrinhTuPhieuDieuTri(PHIEUDIEUTRI phieuDieuTri)
        {
            int soLieuTrinh = Convert.ToInt32(phieuDieuTri.PDT_STT);
            return DataProvider.Ins.DB.LIEUTRINH.Where(x => x.LT_STT == soLieuTrinh && x.GDV_MA == phieuDieuTri.PHIEUDANGKY.GDV_MA).SingleOrDefault();
        }
    }
}
