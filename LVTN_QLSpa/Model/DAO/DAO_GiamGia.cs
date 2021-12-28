using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVTN_QLSpa.Model.DAO
{
    public static class DAO_GiamGia
    {
        public static ObservableCollection<GIAMGIA> GetList()
        {
            return new ObservableCollection<GIAMGIA>(DataProvider.Ins.DB.GIAMGIA.OrderByDescending(x => new {x.GG_NGAYBATDAU, x.GG_NGAYKETTHUC}));
        }

        public static ObservableCollection<GIAMGIA> GetList(string GG_TRANGTHAI)
        {
            return new ObservableCollection<GIAMGIA>(DataProvider.Ins.DB.GIAMGIA.Where(x => x.GG_TRANGTHAI == GG_TRANGTHAI));
        }

        public static ObservableCollection<GIAMGIA> GetList(int LGG_MA)
        {
            ObservableCollection<GIAMGIA> listGiamGia = new ObservableCollection<GIAMGIA>();

            var getGGByLGG = DataProvider.Ins.DB.LGG_GG.Where(x => x.LGG_MA == LGG_MA).Select(x=>x.GIAMGIA).ToList();
            foreach(var item in getGGByLGG)
            {
                listGiamGia.Add(item);
            }

            return listGiamGia;
        }

        public static void Add(GIAMGIA giamgia)
        {
            DataProvider.Ins.DB.GIAMGIA.Add(giamgia);
        }

        public static void Add(string GDV_MA, string GG_MA)
        {
            var giamgoidichvu = new GIAMGOIDICHVU();
            giamgoidichvu.GDV_MA = GDV_MA;
            giamgoidichvu.GG_MA = GG_MA;

            DataProvider.Ins.DB.GIAMGOIDICHVU.Add(giamgoidichvu);
        }

        public static void Add(string GG_MA, int LGG_MA)
        {
            var getGG = DataProvider.Ins.DB.GIAMGIA.Where(x => x.GG_MA == GG_MA).SingleOrDefault();
            var getLGG = DataProvider.Ins.DB.LOAIGIAMGIA.Where(x => x.LGG_MA == LGG_MA).SingleOrDefault();
            var gg_lgg = new LGG_GG() { GG_MA = GG_MA, LGG_MA = LGG_MA, GIAMGIA = getGG, LOAIGIAMGIA = getLGG };
            DataProvider.Ins.DB.LGG_GG.Add(gg_lgg);
        }

        public static void Edit(string GG_MA, string GG_TEN, DateTime GG_NGAYBATDAU, DateTime GG_NGAYKETTHUC, string GG_TRANGTHAI, string GG_NOIDUNG, int GG_PHANTRAMGIAM)
        {
            var giamgia = DataProvider.Ins.DB.GIAMGIA.Where(x => x.GG_MA == GG_MA).SingleOrDefault();
            giamgia.GG_TEN = GG_TEN;
            giamgia.GG_NGAYBATDAU = GG_NGAYBATDAU;
            giamgia.GG_NGAYKETTHUC = GG_NGAYKETTHUC;
            giamgia.GG_TRANGTHAI = GG_TRANGTHAI;
            giamgia.GG_NOIDUNG = GG_NOIDUNG;
            giamgia.GG_PHANTRAMGIAM = GG_PHANTRAMGIAM;

            DataProvider.Ins.DB.SaveChanges();
        }

        public static void EditLGG(string GG_MA, bool ggGDV, bool ggLT)
        {
            var getLGG_GG = DataProvider.Ins.DB.LGG_GG.Where(x => x.GG_MA == GG_MA).ToList();
            foreach(var item in getLGG_GG)
            {
                DataProvider.Ins.DB.LGG_GG.Remove(item);
                DataProvider.Ins.DB.SaveChanges();
            }

            if(ggGDV == true && ggLT == true)
            {
                Add(GG_MA, 1);
                DataProvider.Ins.DB.SaveChanges();
                Add(GG_MA, 2);
                DataProvider.Ins.DB.SaveChanges();
            }
            else if(ggGDV == true)
            {
                Add(GG_MA, 1);
                DataProvider.Ins.DB.SaveChanges();
            }
            else
            {
                Add(GG_MA, 2);
                DataProvider.Ins.DB.SaveChanges();
            }
        }

        public static void Delete(string GG_MA)
        {
            var giamgia = DataProvider.Ins.DB.GIAMGIA.Where(x => x.GG_MA == GG_MA).SingleOrDefault();
            DataProvider.Ins.DB.GIAMGIA.Remove(giamgia);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static void DeleteLGG_GG(string GG_MA)
        {
            var LGG_GG = DataProvider.Ins.DB.LGG_GG.Where(x => x.GG_MA == GG_MA).ToList();
            foreach (var item in LGG_GG)
            {
                DataProvider.Ins.DB.LGG_GG.Remove(item);
            }

            DataProvider.Ins.DB.SaveChanges();

        }

        public static void DeleteGG_GDV(string GDV_MA, string GG_MA)
        {
            var giamGoiDichVu = DataProvider.Ins.DB.GIAMGOIDICHVU.Where(x => x.GDV_MA == GDV_MA && x.GG_MA == GG_MA).SingleOrDefault();
            DataProvider.Ins.DB.GIAMGOIDICHVU.Remove(giamGoiDichVu);
            
        }

        public static void DeleteGG_GDV(string GG_MA)
        {
            var giamGoiDichVu = DataProvider.Ins.DB.GIAMGOIDICHVU.Where(x => x.GG_MA == GG_MA).ToList();
            foreach(var item in giamGoiDichVu)
            {
                DataProvider.Ins.DB.GIAMGOIDICHVU.Remove(item);
            }
            
            DataProvider.Ins.DB.SaveChanges();
        }

        public static string LayLoaiGiamGia(string GG_MA)
        {
            string loaiGiamGia = "";

            var getLoaiGG = DataProvider.Ins.DB.LGG_GG.Where(x => x.GG_MA == GG_MA).Select(x => x.LOAIGIAMGIA).ToList();

            foreach (var item in getLoaiGG)
            {
                loaiGiamGia += item.LGG_TEN + ", ";
            }

            return loaiGiamGia.TrimEnd().Substring(0, loaiGiamGia.Length - 2);
        }
    }
}
