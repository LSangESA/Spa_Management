using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVTN_QLSpa.Model.DAO
{
    public static class DAO_VaiTro
    {
        public static ObservableCollection<VAITRO> GetList()
        {
            return new ObservableCollection<VAITRO>(DataProvider.Ins.DB.VAITRO);
        }

        public static VAITRO AddVaiTro(VAITRO vaitro)
        {
            DataProvider.Ins.DB.VAITRO.Add(vaitro);
            DataProvider.Ins.DB.SaveChanges();

            return vaitro;
        }

        public static void EditVaiTro(int idVaiTro, string VT_TEN)
        {
            var vaitro = DataProvider.Ins.DB.VAITRO.Where(x => x.VT_MA == idVaiTro).SingleOrDefault();
            vaitro.VT_TEN = VT_TEN;

            DataProvider.Ins.DB.SaveChanges();
        }

        public static void Delete(int idVaiTro)
        {
            var vaitro = DataProvider.Ins.DB.VAITRO.Where(x => x.VT_MA == idVaiTro).SingleOrDefault();
            DataProvider.Ins.DB.VAITRO.Remove(vaitro);
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
