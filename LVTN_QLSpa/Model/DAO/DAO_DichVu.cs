using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVTN_QLSpa.Model.DAO
{
    public static class DAO_DichVu
    {
        public static ObservableCollection<DICHVU> GetList()
        {
            return new ObservableCollection<DICHVU>(DataProvider.Ins.DB.DICHVU);
        }

        public static void Add(DICHVU dichvu)
        {
            DataProvider.Ins.DB.DICHVU.Add(dichvu);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static void Edit(string DV_MA, string DV_TEN, string DV_MOTA)
        {
            DICHVU dichvu = new DICHVU();
            dichvu.DV_TEN = DV_TEN;
            dichvu.DV_MOTA = DV_MOTA;

            DataProvider.Ins.DB.SaveChanges();
        }

        public static void Delete(string DV_MA)
        {
            var dichvu = DataProvider.Ins.DB.DICHVU.Where(x => x.DV_MA == DV_MA).SingleOrDefault();
            DataProvider.Ins.DB.DICHVU.Remove(dichvu);
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
