using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LVTN_QLSpa.Model.DAO
{
    public static class DAO_GoiDichVu
    {
        public static ObservableCollection<GOIDICHVU> GetListGDV()
        {
            return new ObservableCollection<GOIDICHVU>(DataProvider.Ins.DB.GOIDICHVU);
        }
        public static ObservableCollection<DG_GDV> GetList()
        {
            return new ObservableCollection<DG_GDV>(DataProvider.Ins.DB.DG_GDV);
        }

        public static ObservableCollection<DG_GDV> GetList(int LGDV_MA)
        {
            return new ObservableCollection<DG_GDV>(DataProvider.Ins.DB.DG_GDV.Where(x=>x.GOIDICHVU.LOAIGOIDICHVU.LGDV_MA == LGDV_MA));
        }

        public static ObservableCollection<DG_GDV> GetList(string DV_MA)
        {
            return new ObservableCollection<DG_GDV>(DataProvider.Ins.DB.DG_GDV.Where(x=>x.GOIDICHVU.DICHVU.DV_MA == DV_MA));
        }

        public static ObservableCollection<GOIDICHVU> GetListDV(string DV_MA)
        {
            return new ObservableCollection<GOIDICHVU>(DataProvider.Ins.DB.GOIDICHVU.Where(x => x.DV_MA == DV_MA));
        }

        public static ObservableCollection<GOIDICHVU> GetListForDV(string DV_MA)
        {
            return new ObservableCollection<GOIDICHVU>(DataProvider.Ins.DB.GOIDICHVU.Where(x => x.DICHVU.DV_MA == DV_MA && x.LGDV_MA == 1));
        }

        public static int? GetSoLanLieuTrinhGDV(string GDV_MA)
        {
            return DataProvider.Ins.DB.GOIDICHVU.Where(x => x.GDV_MA == GDV_MA).Select(x => x.GDV_SOLAN).SingleOrDefault();
        }


        public static void Add(GOIDICHVU goidichvu)
        {
            DataProvider.Ins.DB.GOIDICHVU.Add(goidichvu);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static void Add(DG_GDV gongia_gdv)
        {
            DataProvider.Ins.DB.DG_GDV.Add(gongia_gdv);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static void Edit(string GDV_MA, string GDV_TEN, int? GDV_SOLAN, string GDV_MOTA, string GDV_ANH, int LGDV_MA, string DV_MA, string PP_MA)
        {
            var goidichvu = DataProvider.Ins.DB.GOIDICHVU.Where(x => x.GDV_MA == GDV_MA).SingleOrDefault();
            goidichvu.GDV_TEN = GDV_TEN;
            goidichvu.GDV_SOLAN = GDV_SOLAN;
            goidichvu.GDV_MOTA = GDV_MOTA;
            goidichvu.GDV_ANH = GDV_ANH;
            goidichvu.LGDV_MA = LGDV_MA;
            goidichvu.DV_MA = DV_MA;
            goidichvu.PP_MA = PP_MA;

            DataProvider.Ins.DB.SaveChanges();
        }

        public static void Edit(string GDV_MA, DateTime THOIGIAN, string DONGIA)
        {
            var dongia_gdv = DataProvider.Ins.DB.DG_GDV.Where(x => x.GDV_MA == GDV_MA && x.THOIGIAN == THOIGIAN).SingleOrDefault();
            dongia_gdv.DONGIA = DONGIA;
            DataProvider.Ins.DB.SaveChanges();
        }

        public static void Delete(string GDV_MA)
        {
            var goidichvu = DataProvider.Ins.DB.GOIDICHVU.Where(x => x.GDV_MA == GDV_MA).SingleOrDefault();
            DataProvider.Ins.DB.GOIDICHVU.Remove(goidichvu);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static void DeleteDG_GDV(string GDV_MA)
        {
            var gongia_gdv = DataProvider.Ins.DB.DG_GDV.Where(x => x.GDV_MA == GDV_MA).ToList().LastOrDefault();
            DataProvider.Ins.DB.DG_GDV.Remove(gongia_gdv);

            DataProvider.Ins.DB.SaveChanges();
            
        }

        public static string GetDonGiaGDV(string GDV_MA)
        {
            return DataProvider.Ins.DB.DG_GDV.Where(x => x.GDV_MA == GDV_MA).Select(x => x.DONGIA).ToList().LastOrDefault();
        }
    }
}
