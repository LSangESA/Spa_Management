using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVTN_QLSpa.Model.DAO
{
    public static class DAO_Address
    {
        public static ObservableCollection<TINHTHANH> GetListTinhThanh()
        {
            return new ObservableCollection<TINHTHANH>(DataProvider.Ins.DB.TINHTHANH);
        }

        public static ObservableCollection<HUYENQUAN> GetListHuyenQuan()
        {
            return new ObservableCollection<HUYENQUAN>(DataProvider.Ins.DB.HUYENQUAN);
        }

        public static ObservableCollection<HUYENQUAN> GetListHuyenQuan(int TT_MA)
        {
            return new ObservableCollection<HUYENQUAN>(DataProvider.Ins.DB.HUYENQUAN.Where(x=>x.TT_MA == TT_MA));
        }

        public static ObservableCollection<XAPHUONG> GetListXaPhuong()
        {
            return new ObservableCollection<XAPHUONG>(DataProvider.Ins.DB.XAPHUONG);
        }

        public static ObservableCollection<XAPHUONG> GetListXaPhuong(int HQ_MA)
        {
            return new ObservableCollection<XAPHUONG>(DataProvider.Ins.DB.XAPHUONG.Where(x=>x.HQ_MA == HQ_MA));
        }
    }
}
