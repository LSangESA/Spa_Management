using LVTN_QLSpa.Model.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVTN_QLSpa.Model.DAO
{
    public static class DAO_PhieuDieuTri
    {
        public static ObservableCollection<PHIEUDIEUTRI> GetList()
        {
            return new ObservableCollection<PHIEUDIEUTRI>(DataProvider.Ins.DB.PHIEUDIEUTRI);
        }

        public static ObservableCollection<PHIEUDIEUTRI> GetList(string PDK_STT)
        {
            return new ObservableCollection<PHIEUDIEUTRI>(DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x=>x.PDK_STT == PDK_STT).OrderBy(x=>x.PDT_NGAYLAP));
        }

        public static PHIEUDIEUTRI GetLastPhieuDieuTri(string PDK_STT)
        {
            var phieuDieuTri = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDK_STT == PDK_STT).ToList().LastOrDefault();
            return phieuDieuTri;
        }

        public static PHIEUDIEUTRI GetPhieuDieuTri(string PDK_STT, string PDT_STT)
        {
            var phieuDieuTri = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDK_STT == PDK_STT && x.PDT_STT == PDT_STT).SingleOrDefault();
            return phieuDieuTri;
        }

        public static int GetSoPDTInPDK(string PDK_STT)
        {
            return DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDK_STT == PDK_STT).Count();
        }

        public static PHIEUDIEUTRI Add(string PDK_STT, string PDT_STT, DateTime PDT_NGAYLAP, string PDT_TRANGTHAI, bool PDT_TRANGTHAINNO)
        {
            var phieuDieuTri = new PHIEUDIEUTRI()
            {
                PDT_STT = PDT_STT,
                PDK_STT = PDK_STT,
                PDT_NGAYLAP = PDT_NGAYLAP,
                PDT_TRANGTHAI = PDT_TRANGTHAI,
                PDT_TRANGTHAINNO = PDT_TRANGTHAINNO
            };

            DataProvider.Ins.DB.PHIEUDIEUTRI.Add(phieuDieuTri);
            DataProvider.Ins.DB.SaveChanges();
            return phieuDieuTri;
        }

        public static void EditTrangThaiNo(string PDK_STT, string PDT_STT, bool PDT_TRANGTHAINO)
        {
            var phieuDieuTri = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x=>x.PDK_STT == PDK_STT && x.PDT_STT == PDT_STT).SingleOrDefault();
            phieuDieuTri.PDT_TRANGTHAINNO = PDT_TRANGTHAINO;
            DataProvider.Ins.DB.SaveChanges();
        }

        public static void EditGhiNhanBenh(string PDK_STT, string PDT_STT, string PDT_CHUANDOAN, string PDT_LOIDAN, string PDT_GHICHU)
        {
            var phieuDieuTri = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDK_STT == PDK_STT && x.PDT_STT == PDT_STT).SingleOrDefault();
            phieuDieuTri.PDT_CHUANDOAN = PDT_CHUANDOAN;
            phieuDieuTri.PDT_LOIDAN = PDT_LOIDAN;
            phieuDieuTri.PDT_GHICHU = PDT_GHICHU;
            DataProvider.Ins.DB.SaveChanges();
        }

        public static void EditGhiNhanBenh(string PDK_STT, string PDT_STT, string PDT_TRANGTHAI)
        {
            var phieuDieuTri = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDK_STT == PDK_STT && x.PDT_STT == PDT_STT).SingleOrDefault();
            phieuDieuTri.PDT_TRANGTHAI = PDT_TRANGTHAI;
            DataProvider.Ins.DB.SaveChanges();
        }

        public static void Add_NVDT(string NV_MA, string PDK_STT, string PDT_STT)
        {
            var nhanVienDieuTri = new NV_PDT()
            {
                NV_MA = NV_MA,
                PDT_STT = PDT_STT,
                PDK_STT = PDK_STT
            };

            DataProvider.Ins.DB.NV_PDT.Add(nhanVienDieuTri);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static void DeletePDT(string PDT_STT, string PDK_STT)
        {
            var getPDT = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PDK_STT == PDK_STT && x.PDT_STT == PDT_STT).SingleOrDefault();
            
            DataProvider.Ins.DB.PHIEUDIEUTRI.Remove(getPDT);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static void Delete_NVPDT(NV_PDT nv_pdt)
        {
            DataProvider.Ins.DB.NV_PDT.Remove(nv_pdt);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static void DoiNgayDieuTri(PHIEUDIEUTRI pdt, DateTime NgayDoi)
        {
            var phieuDieuTri = pdt;
            phieuDieuTri.PDT_NGAYLAP = NgayDoi;
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
