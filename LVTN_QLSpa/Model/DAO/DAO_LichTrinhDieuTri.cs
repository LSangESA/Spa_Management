using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVTN_QLSpa.Model.DAO
{
    public static class DAO_LichTrinhDieuTri
    {
        public static ObservableCollection<LICHTRINHDIEUTRI> GetList(string PDK_STT)
        {
            return new ObservableCollection<LICHTRINHDIEUTRI>(DataProvider.Ins.DB.LICHTRINHDIEUTRI.Where(x => x.PDK_STT == PDK_STT));
        }

        public static ObservableCollection<LICHTRINHDIEUTRI> GetListNgayHomNay()
        {
            var dauNgay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            var cuoiNgay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            var lichTrinhDieuTri = DataProvider.Ins.DB.LICHTRINHDIEUTRI.Where(x => x.LTDT_NGAYDT >= dauNgay && x.LTDT_NGAYDT <= cuoiNgay).OrderBy(x => x.LTDT_THOIGIANDEN).ToList();
            var phieuDieuTri = DataProvider.Ins.DB.PHIEUDIEUTRI.ToList();

            // Nếu như đã lập phiếu điều trị thì không tải lên
            foreach (var item in phieuDieuTri.ToList())
            {
                foreach (var item2 in lichTrinhDieuTri.ToList())
                {
                    if (item.PDK_STT == item2.PDK_STT)
                    {
                        if (Convert.ToInt32(item.PDT_STT) == item2.LIEUTRINH.LT_STT)
                        {
                            lichTrinhDieuTri.Remove(item2);
                        }
                    }
                }
            }

            return new ObservableCollection<LICHTRINHDIEUTRI>(lichTrinhDieuTri);
        }

        public static ObservableCollection<LICHTRINHDIEUTRI> GetListNgayHomNayTest()
        {
            var dauNgay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            var cuoiNgay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            var lichTrinhDieuTri = DataProvider.Ins.DB.LICHTRINHDIEUTRI.Where(x => x.LTDT_NGAYDT >= dauNgay && x.LTDT_NGAYDT <= cuoiNgay).OrderBy(x => x.LTDT_THOIGIANDEN).ToList();
            

            return new ObservableCollection<LICHTRINHDIEUTRI>(lichTrinhDieuTri);
        }

        public static void Add(string PDK_STT, string GDV_MA, int LT_MA, DateTime LTDT_NGAYDT, string LTDT_THOIGIANDEN)
        {
            var lichTrinhDieuTri = new LICHTRINHDIEUTRI()
            {
                PDK_STT = PDK_STT,
                GDV_MA = GDV_MA,
                LT_MA = LT_MA,
                LTDT_NGAYDT = LTDT_NGAYDT,
                LTDT_THOIGIANDEN = LTDT_THOIGIANDEN
            };

            DataProvider.Ins.DB.LICHTRINHDIEUTRI.Add(lichTrinhDieuTri);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static ObservableCollection<LICHTRINHDIEUTRI> Edit(LICHTRINHDIEUTRI ltdt, DateTime LTDT_NGAYDT, string LTDT_THOIGIANDEN = null)
        {
            var ngayBatDau = LTDT_NGAYDT;
            var getLTDT = DataProvider.Ins.DB.LICHTRINHDIEUTRI.Where(x => x.PDK_STT == ltdt.PDK_STT).ToList();
            foreach (var item in getLTDT)
            {
                if (item.LIEUTRINH.LT_STT >= ltdt.LIEUTRINH.LT_STT)
                {
                    var lichTrinhDieuTri = item;
                    lichTrinhDieuTri.LTDT_NGAYDT = ngayBatDau;

                    if(item.LIEUTRINH.LT_STT == ltdt.LIEUTRINH.LT_STT)
                    {
                        if (LTDT_THOIGIANDEN != null)
                            lichTrinhDieuTri.LTDT_THOIGIANDEN = LTDT_THOIGIANDEN;
                        else
                            lichTrinhDieuTri.LTDT_THOIGIANDEN = item.LTDT_THOIGIANDEN;
                    }

                    DataProvider.Ins.DB.SaveChanges();
                    ngayBatDau = ngayBatDau.AddDays((double)item.LIEUTRINH.LT_NGAYTHU);
                }
            }

            return new ObservableCollection<LICHTRINHDIEUTRI>(DataProvider.Ins.DB.LICHTRINHDIEUTRI.Where(x => x.PDK_STT == ltdt.PDK_STT));
        }

        public static bool KiemTraNgayLieuTrinhTiepTheo(string PDK_STT)
        {
            var ngayHomNay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            var layPhieuDieuTri = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDK_STT == PDK_STT).OrderBy(x => x.PDT_STT).ToList().LastOrDefault();

            var layPhieuDieuTriTiepTheo = Convert.ToInt32(layPhieuDieuTri.PDT_STT) + 1;
            var layLichTrinhDieuTri = DataProvider.Ins.DB.LICHTRINHDIEUTRI.Where(x => x.PDK_STT == PDK_STT && x.LIEUTRINH.LT_STT == layPhieuDieuTriTiepTheo).Select(x => x.LTDT_NGAYDT).SingleOrDefault();

            if (ngayHomNay == new DateTime(layLichTrinhDieuTri.Year, layLichTrinhDieuTri.Month, layLichTrinhDieuTri.Day))
                return true;
            else
                return false;
        }

        public static DateTime LayNgayLieuTrinhTiepTheo(string PDK_STT)
        {
            var ngayHomNay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            var layPhieuDieuTri = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDK_STT == PDK_STT).OrderBy(x => x.PDT_STT).ToList().LastOrDefault();

            var layPhieuDieuTriTiepTheo = Convert.ToInt32(layPhieuDieuTri.PDT_STT) + 1;
            var layLichTrinhDieuTri = DataProvider.Ins.DB.LICHTRINHDIEUTRI.Where(x => x.PDK_STT == PDK_STT && x.LIEUTRINH.LT_STT == layPhieuDieuTriTiepTheo).Select(x => x.LTDT_NGAYDT).SingleOrDefault();

            return layLichTrinhDieuTri;
        }
    }
}
