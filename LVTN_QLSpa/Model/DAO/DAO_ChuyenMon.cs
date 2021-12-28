using LVTN_QLSpa.Model.DB;
using LVTN_QLSpa.Model.ModelClass;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVTN_QLSpa.Model.DAO
{
    public static class DAO_ChuyenMon
    {
        public static ObservableCollection<CHUYENMON> GetList()
        {
            return new ObservableCollection<CHUYENMON>(DataProvider.Ins.DB.CHUYENMON);
        }

        public static ObservableCollection<CHUYENMON> GetList(int VT_MA)
        {
            return new ObservableCollection<CHUYENMON>(DataProvider.Ins.DB.CHUYENMON.Where(x=>x.VT_MA == VT_MA));
        }

        public static CHUYENMON AddChuyenMon(CHUYENMON chuyenmon)
        {
            DataProvider.Ins.DB.CHUYENMON.Add(chuyenmon);
            DataProvider.Ins.DB.SaveChanges();

            return chuyenmon;
        }

        public static void EditChuyenMon(int idChuyenMon, string CM_TEN, string CM_MOTA, int VT_MA)
        {
            var chuyenmon = DataProvider.Ins.DB.CHUYENMON.Where(x => x.CM_MA == idChuyenMon).SingleOrDefault();
            chuyenmon.CM_TEN = CM_TEN;
            chuyenmon.CM_MOTA = CM_MOTA;
            chuyenmon.VT_MA = VT_MA;

            DataProvider.Ins.DB.SaveChanges();
        }

        public static void DeleteChuyenMon(int idChuyenMon)
        {
            var chuyenmon = DataProvider.Ins.DB.CHUYENMON.Where(x => x.CM_MA == idChuyenMon).SingleOrDefault();
            DataProvider.Ins.DB.CHUYENMON.Remove(chuyenmon);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static string LayVaiTroNhanVien(string NV_MA)
        {
            string vaiTroNV = "";

            var getVaiTro = DataProvider.Ins.DB.CHUYENMONNHANVIEN.Where(x => x.NV_MA == NV_MA).Select(x => x.CHUYENMON.VAITRO).Distinct().ToList();

            foreach(var item in getVaiTro)
            {
                vaiTroNV += item.VT_TEN + ", ";
            }

            return vaiTroNV.TrimEnd().Substring(0, vaiTroNV.Length - 2);
        }

        public static string LayChuyenMonNhanVien(string NV_MA)
        {
            string chuyeMonNV = "";

            var getChuyenMon = DataProvider.Ins.DB.CHUYENMONNHANVIEN.Where(x => x.NV_MA == NV_MA).Select(x => x.CHUYENMON).ToList();

            foreach (var item in getChuyenMon)
            {
                chuyeMonNV += item.CM_TEN + ", ";
            }

            return chuyeMonNV.TrimEnd().Substring(0, chuyeMonNV.Length - 2);
        }

        public static bool LaBacSi(string NV_MA)
        {
            var getVaiTro = DataProvider.Ins.DB.CHUYENMONNHANVIEN.Where(x => x.NV_MA == NV_MA).Select(x => x.CHUYENMON.VAITRO).Distinct().ToList();

            foreach (var item in getVaiTro)
            {
                if (item.VT_MA == 2)
                    return true;
            }

            return false;
        }
    }
}
