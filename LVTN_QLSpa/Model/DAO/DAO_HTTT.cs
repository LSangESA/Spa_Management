using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVTN_QLSpa.Model.DAO
{
    public static class DAO_HTTT
    {
        public static ObservableCollection<HINHTHUCTHANHTOAN> GetList()
        {
            return new ObservableCollection<HINHTHUCTHANHTOAN>(DataProvider.Ins.DB.HINHTHUCTHANHTOAN);
        }

        public static void Add(HINHTHUCTHANHTOAN dichvu)
        {
            DataProvider.Ins.DB.HINHTHUCTHANHTOAN.Add(dichvu);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static void Edit(int HTTT_MA, string HTTT_TEN, string HTTT_MOTA)
        {
            HINHTHUCTHANHTOAN httt = new HINHTHUCTHANHTOAN();
            httt.HTTT_TEN = HTTT_TEN;
            httt.HTTT_MOTA = HTTT_MOTA;

            DataProvider.Ins.DB.SaveChanges();
        }

        public static void Delete(int HTTT_MA)
        {
            var httt = DataProvider.Ins.DB.HINHTHUCTHANHTOAN.Where(x => x.HTTT_MA == HTTT_MA).SingleOrDefault();
            DataProvider.Ins.DB.HINHTHUCTHANHTOAN.Remove(httt);
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
