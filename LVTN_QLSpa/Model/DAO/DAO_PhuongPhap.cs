using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVTN_QLSpa.Model.DAO
{
    public static class DAO_PhuongPhap
    {
        public static ObservableCollection<PHUONGPHAP> GetList()
        {
            return new ObservableCollection<PHUONGPHAP>(DataProvider.Ins.DB.PHUONGPHAP);
        }

        public static void Add(PHUONGPHAP dichvu)
        {
            DataProvider.Ins.DB.PHUONGPHAP.Add(dichvu);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static void Edit(string DV_MA, string PP_TEN, string PP_MOTA)
        {
            PHUONGPHAP phuongphap = new PHUONGPHAP();
            phuongphap.PP_TEN = PP_TEN;
            phuongphap.PP_MOTA = PP_MOTA;

            DataProvider.Ins.DB.SaveChanges();
        }

        public static void Delete(string PP_MA)
        {
            var dichvu = DataProvider.Ins.DB.PHUONGPHAP.Where(x => x.PP_MA == PP_MA).SingleOrDefault();
            DataProvider.Ins.DB.PHUONGPHAP.Remove(dichvu);
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
