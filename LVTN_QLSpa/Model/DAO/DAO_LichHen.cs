using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVTN_QLSpa.Model.DAO
{
    public static class DAO_LichHen
    {
        public static ObservableCollection<LICHHEN> GetList()
        {
            return new ObservableCollection<LICHHEN>(DataProvider.Ins.DB.LICHHEN);
        }

        public static ObservableCollection<LICHHEN> GetList(string trangThai)
        {
            return new ObservableCollection<LICHHEN>(DataProvider.Ins.DB.LICHHEN.Where(x=>x.LH_TRANGTHAI == trangThai));
        }

        public static ObservableCollection<LICHHEN> GetList(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return new ObservableCollection<LICHHEN>(DataProvider.Ins.DB.LICHHEN.Where(x=>x.LH_NGAYDEN >= ngayBatDau && x.LH_NGAYDEN <= ngayKetThuc));
        }

        public static void Add(LICHHEN lichHen)
        {
            DataProvider.Ins.DB.LICHHEN.Add(lichHen);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static void EditTrangThai (int LH_ID, string LH_TRANGTHAI)
        {
            var getLichHen = DataProvider.Ins.DB.LICHHEN.Where(x => x.LH_ID == LH_ID).SingleOrDefault();
            getLichHen.LH_TRANGTHAI = LH_TRANGTHAI;

            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
