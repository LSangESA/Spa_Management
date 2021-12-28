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
    public static class DAO_PhieuThu
    {
        public static PHIEUTHU AddPT(string PT_STT,string NV_MA,int HTTT_MA,DateTime PT_NGAYLAP,int PT_TONGTIEN)
        {
            var phieuThu = new PHIEUTHU()
            {
                PT_STT = PT_STT,
                NV_MA = NV_MA,
                HTTT_MA = HTTT_MA,
                PT_NGAYLAP = PT_NGAYLAP,
                PT_TONGTIEN = PT_TONGTIEN
            };

            DataProvider.Ins.DB.PHIEUTHU.Add(phieuThu);
            DataProvider.Ins.DB.SaveChanges();

            return phieuThu;
        }

        public static void AddPT_PDT(string PT_STT, string PDT_STT, string PDK_STT)
        {
            var PT_PDT = new PT_PDT()
            {
                PT_STT = PT_STT,
                PDT_STT = PDT_STT,
                PDK_STT = PDK_STT,
            };

            DataProvider.Ins.DB.PT_PDT.Add(PT_PDT);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static void DeletePhieuThu(string PT_STT)
        {
            var getPT = DataProvider.Ins.DB.PHIEUTHU.Where(x => x.PT_STT == PT_STT).SingleOrDefault();

            DataProvider.Ins.DB.PHIEUTHU.Remove(getPT);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static string TinhTongNoKhachHang(string KH_MA)
        {
            int totalMoney = 0;
            var getPT_PDT_KH = DataProvider.Ins.DB.PHIEUDIEUTRI.Where(x => x.PHIEUDANGKY.KH_MA == KH_MA && x.PDT_TRANGTHAINNO == true).ToList();

            foreach (var item in getPT_PDT_KH)
            {
                if (item.PHIEUDANGKY.CTT_MA == 2)
                {
                    int PDT_STT = Convert.ToInt32(item.PDT_STT);
                    var getMoneyLT = DataProvider.Ins.DB.DG_LT.Where(x => x.LIEUTRINH.LT_STT == PDT_STT && x.GDV_MA == item.PHIEUDANGKY.GDV_MA).Select(x => x.DONGIA).SingleOrDefault();
                    totalMoney += int.Parse(getMoneyLT.Replace(".", ""));

                }
                else if (item.PHIEUDANGKY.CTT_MA == 1)
                {
                    //int PDT_STT = Convert.ToInt32(item.PDT_STT);
                    var getMoneyGDV = DataProvider.Ins.DB.DG_GDV.Where(x => x.GDV_MA == item.PHIEUDANGKY.GDV_MA).Select(x => x.DONGIA).SingleOrDefault();
                    totalMoney += int.Parse(getMoneyGDV.Replace(".", ""));
                }
            }

            return ClassXuLyChuoi.ChuyenSoThanhTien(totalMoney);
        }

        public static KHACHHANG LayPhieuThuCuaKhachHang(string PT_STT)
        {
            return DataProvider.Ins.DB.PT_PDT.Where(x => x.PT_STT == PT_STT).Select(x => x.PHIEUDIEUTRI.PHIEUDANGKY.KHACHHANG).Distinct().SingleOrDefault();
        }

        public static int LayTongPhieuDieuTriCuaPhieuThu(string PT_STT)
        {
            return DataProvider.Ins.DB.PT_PDT.Where(x => x.PT_STT == PT_STT).Count();
        }

        public static ObservableCollection<ClassPhieuThu> ListPhieuThuReport(ObservableCollection<PHIEUTHU> ListPhieuThu)
        {
            int soTT = 0;
            var listPhieuThu = new ObservableCollection<ClassPhieuThu>();
            foreach(var item in ListPhieuThu)
            {
                soTT++;
                var phieuThu = new ClassPhieuThu()
                {
                    STT = soTT,
                    HTTT_TEN = item.HINHTHUCTHANHTOAN.HTTT_TEN,
                    NV_TEN = item.NHANVIEN.NV_HOTEN,
                    PT_NGAYLAP = item.PT_NGAYLAP,
                    PT_STT = item.PT_STT,
                    PT_TONGTIEN = ClassXuLyChuoi.ChuyenSoThanhTien(Convert.ToInt32(item.PT_TONGTIEN)),
                    KH_HOTEN = LayPhieuThuCuaKhachHang(item.PT_STT).KH_HOTEN,
                    KH_MA = LayPhieuThuCuaKhachHang(item.PT_STT).KH_MA,
                    PDT_THU = LayTongPhieuDieuTriCuaPhieuThu(item.PT_STT)
                };
                listPhieuThu.Add(phieuThu);
            }

            return listPhieuThu;
        }
    }
}
