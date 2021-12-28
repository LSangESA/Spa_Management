using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVTN_QLSpa.Model.DAO
{
    public static class DAO_Thuoc
    {
        // Get list
        public static ObservableCollection<THUOC> GetListThuoc()
        {
            return new ObservableCollection<THUOC>(DataProvider.Ins.DB.THUOC);
        }

        public static ObservableCollection<HOATCHAT> GetListHoatChat()
        {
            return new ObservableCollection<HOATCHAT>(DataProvider.Ins.DB.HOATCHAT);
        }

        public static ObservableCollection<NHASX> GetListNSX()
        {
            return new ObservableCollection<NHASX>(DataProvider.Ins.DB.NHASX);
        }

        public static ObservableCollection<DVT> GetListDVT()
        {
            return new ObservableCollection<DVT>(DataProvider.Ins.DB.DVT);
        }

        // Add
        public static THUOC AddThuoc(string T_MA,string T_TEN,int NSX_MA, int DVT_MA, string HC_MA)
        {
            var thuoc = new THUOC()
            {
                T_MA = T_MA,
                T_TEN = T_TEN,
                NSX_MA = NSX_MA,
                DVT_MA = DVT_MA,
                HC_MA = HC_MA
            };

            DataProvider.Ins.DB.THUOC.Add(thuoc);
            DataProvider.Ins.DB.SaveChanges();

            return thuoc;
        }

        public static HOATCHAT AddHoatChat(string HC_MA, string HC_TEN, string HC_HAMLUONG, string HC_CONGDUNG)
        {
            var hoatChat = new HOATCHAT()
            {
                HC_MA = HC_MA,
                HC_TEN = HC_TEN,
                HC_HAMLUONG = HC_HAMLUONG,
                HC_CONGDUNG = HC_CONGDUNG,
            };

            DataProvider.Ins.DB.HOATCHAT.Add(hoatChat);
            DataProvider.Ins.DB.SaveChanges();

            return hoatChat;
        }

        public static NHASX AddNSX(string NSX_TEN)
        {
            var nhaSX = new NHASX()
            {
                NSX_TEN = NSX_TEN
            };

            DataProvider.Ins.DB.NHASX.Add(nhaSX);
            DataProvider.Ins.DB.SaveChanges();

            return nhaSX;
        }

        public static DVT AddDVT(string DVT_TEN)
        {
            var dvt = new DVT()
            {
                DVT_TEN = DVT_TEN
            };

            DataProvider.Ins.DB.DVT.Add(dvt);
            DataProvider.Ins.DB.SaveChanges();

            return dvt;
        }

        // Edit
        public static void EditThuoc(THUOC thuoc, string T_TEN, int NSX_MA, int DVT_MA, string HC_MA)
        {
            var get = thuoc;
            get.T_TEN = T_TEN;
            get.NSX_MA = NSX_MA;
            get.DVT_MA = DVT_MA;
            get.HC_MA = HC_MA;

            DataProvider.Ins.DB.SaveChanges();
        }

        public static void EditHoatChat(HOATCHAT hoatChat, string HC_TEN, string HC_HAMLUONG, string HC_CONGDUNG)
        {
            var get = hoatChat;
            get.HC_TEN = HC_TEN;
            get.HC_HAMLUONG = HC_HAMLUONG;
            get.HC_CONGDUNG = HC_CONGDUNG;

            DataProvider.Ins.DB.SaveChanges();
        }

        public static void EditNSX(NHASX nhasx, string NSX_TEN)
        {
            var get = nhasx;
            get.NSX_TEN = NSX_TEN;

            DataProvider.Ins.DB.SaveChanges();
        }

        public static void EditDVT(DVT dvt, string DVT_TEN)
        {
            var get = dvt;
            get.DVT_TEN = DVT_TEN;

            DataProvider.Ins.DB.SaveChanges();
        }

        // Delete
        public static void DeleteThuoc(THUOC thuoc)
        {
            DataProvider.Ins.DB.THUOC.Remove(thuoc);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static void DeleteHoatChat(HOATCHAT hoatchat)
        {
            DataProvider.Ins.DB.HOATCHAT.Remove(hoatchat);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static void DeleteNSX(NHASX nsx)
        {
            DataProvider.Ins.DB.NHASX.Remove(nsx);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static void DeleteDVT(DVT dvt)
        {
            DataProvider.Ins.DB.DVT.Remove(dvt);
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
