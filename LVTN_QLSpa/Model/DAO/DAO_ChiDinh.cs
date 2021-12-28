using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVTN_QLSpa.Model.DAO
{
    public static class DAO_ChiDinh
    {
        public static ObservableCollection<CHIDINH> GetListTheoPDT (string PDT_STT, string PDK_STT)
        {
            return new ObservableCollection<CHIDINH>(DataProvider.Ins.DB.CHIDINH.Where(x => x.PDT_STT == PDT_STT && x.PDK_STT == PDK_STT));
        }

        public static void AddCD(string PDT_STT, string PDK_STT, string T_MA, int CD_SOLUONG, string CD_LIEUDUNG, string CD_CACHDUNG)
        {
            var chiDinh = new CHIDINH();
            chiDinh.PDT_STT = PDT_STT;
            chiDinh.PDK_STT = PDK_STT;
            chiDinh.T_MA = T_MA;
            chiDinh.CD_SOLUONG = CD_SOLUONG;
            chiDinh.CD_LIEUDUNG = CD_LIEUDUNG;
            chiDinh.CD_CACHDUNG = CD_CACHDUNG;

            DataProvider.Ins.DB.CHIDINH.Add(chiDinh);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static void DeleteCD(string PDT_STT, string PDK_STT, string T_MA)
        {
            var chiDinh = DataProvider.Ins.DB.CHIDINH.Where(x => x.PDT_STT == PDT_STT && x.PDK_STT == PDK_STT && x.T_MA == T_MA).SingleOrDefault();
            DataProvider.Ins.DB.CHIDINH.Remove(chiDinh);
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
