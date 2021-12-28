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
    public static class DAO_LichLamViec
    {
        public static ObservableCollection<ClassNhanVien> GetListNhanVienBSVaKTVTheoNgay(DateTime THOIGIAN, string GDV_MA)
        {
            /*
                1. Lay ra danh sach nhan vien co vai tro bac si va ky thuat vien
                2. Lay ra nhan vien phu trach goi dich vu duoc chon
                3. Tao vong lap cho 2 danh sach lay ra nhan vien bac si va ky thuat vien phu trach goi dich vu duoc chon va them danh sach nhan vien do vao 1 list
                4. Lay ra danh sach nhan vien co lich lam viec theo ngay duoc chon
                5. Tao vong lap cho 2 danh sach lay ra danh sach nhan vien cho lich hen
             */
            // 1
            var getNhanVienBSvaKTV = DataProvider.Ins.DB.CHUYENMONNHANVIEN.Where(x => x.CHUYENMON.VT_MA == 2 || x.CHUYENMON.VT_MA == 3).Select(x => new { x.NHANVIEN, x.CHUYENMON.VAITRO.VT_TEN }).Distinct().OrderBy(x => x.VT_TEN).ToList();

            // 2
            var getNhanVienPhuTrachDichVu = DataProvider.Ins.DB.PHUTRACHGOI.Where(x => x.GDV_MA == GDV_MA).Select(x => x.NHANVIEN).ToList();

            // 3
            var nhanVienPhuTrach = new ObservableCollection<ClassNhanVien>();
            foreach (var item in getNhanVienPhuTrachDichVu)
            {
                foreach (var item2 in getNhanVienBSvaKTV)
                {
                    if (item == item2.NHANVIEN)
                    {
                        var nhanVien = new ClassNhanVien();
                        nhanVien.NV_MA = item2.NHANVIEN.NV_MA;
                        nhanVien.NV_ANH = item2.NHANVIEN.NV_ANH;
                        nhanVien.NV_TEN = item2.NHANVIEN.NV_HOTEN;
                        nhanVien.VT_TEN = item2.VT_TEN;
                        nhanVienPhuTrach.Add(nhanVien);
                    }
                }
            }

            // 4
            var getNhanVienLamTheoNgay = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.THOIGIAN == THOIGIAN).ToList();

            var listNhanVien = new ObservableCollection<ClassNhanVien>();
            foreach (var item in nhanVienPhuTrach)
            {
                foreach (var item2 in getNhanVienLamTheoNgay)
                {
                    if (item.NV_MA == item2.NV_MA)
                    {
                        var nhanVien = new ClassNhanVien();
                        nhanVien.NV_MA = item2.NV_MA;
                        nhanVien.NV_ANH = item2.NHANVIEN.NV_ANH;
                        nhanVien.NV_TEN = item2.NHANVIEN.NV_HOTEN;
                        nhanVien.VT_TEN = item.VT_TEN;
                        nhanVien.CLV_MA = item2.CALAMVIEC.CLV_MA;
                        nhanVien.CLV_TEN = item2.CALAMVIEC.CLV_TEN;
                        listNhanVien.Add(nhanVien);
                    }
                }
            }
            return new ObservableCollection<ClassNhanVien>(listNhanVien.OrderBy(x => x.NV_TEN));
        }

        public static ObservableCollection<ClassNhanVien> GetListNhanVienBSTheoNgay(DateTime THOIGIAN, string GDV_MA)
        {
            /*
                1. Lay ra danh sach nhan vien co vai tro bac si va ky thuat vien
                2. Lay ra nhan vien phu trach goi dich vu duoc chon
                3. Tao vong lap cho 2 danh sach lay ra nhan vien bac si va ky thuat vien phu trach goi dich vu duoc chon va them danh sach nhan vien do vao 1 list
                4. Lay ra danh sach nhan vien co lich lam viec theo ngay duoc chon
                5. Tao vong lap cho 2 danh sach lay ra danh sach nhan vien cho lich hen
             */
            // 1
            var getNhanVienBSvaKTV = DataProvider.Ins.DB.CHUYENMONNHANVIEN.Where(x => x.CHUYENMON.VT_MA == 2).Select(x => new { x.NHANVIEN, x.CHUYENMON.VAITRO.VT_TEN }).Distinct().OrderBy(x => x.VT_TEN).ToList();

            // 2
            var getNhanVienPhuTrachDichVu = DataProvider.Ins.DB.PHUTRACHGOI.Where(x => x.GDV_MA == GDV_MA).Select(x => x.NHANVIEN).ToList();

            // 3
            var nhanVienPhuTrach = new ObservableCollection<ClassNhanVien>();
            foreach (var item in getNhanVienPhuTrachDichVu)
            {
                foreach(var item2 in getNhanVienBSvaKTV)
                {
                    if(item == item2.NHANVIEN)
                    {
                        var nhanVien = new ClassNhanVien();
                        nhanVien.NV_MA = item2.NHANVIEN.NV_MA;
                        nhanVien.NV_ANH = item2.NHANVIEN.NV_ANH;
                        nhanVien.NV_TEN = item2.NHANVIEN.NV_HOTEN;
                        nhanVien.VT_TEN = item2.VT_TEN;
                        nhanVienPhuTrach.Add(nhanVien);
                    }
                }
            }

            // 4
            var getNhanVienLamTheoNgay = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.THOIGIAN == THOIGIAN).ToList();

            var listNhanVien = new ObservableCollection<ClassNhanVien>();
            foreach(var item in nhanVienPhuTrach)
            {
                foreach(var item2 in getNhanVienLamTheoNgay)
                {
                    if(item.NV_MA == item2.NV_MA)
                    {
                        var nhanVien = new ClassNhanVien();
                        nhanVien.NV_MA = item2.NV_MA;
                        nhanVien.NV_ANH = item2.NHANVIEN.NV_ANH;
                        nhanVien.NV_TEN = item2.NHANVIEN.NV_HOTEN;
                        nhanVien.VT_TEN = item.VT_TEN;
                        nhanVien.CLV_MA = item2.CALAMVIEC.CLV_MA;
                        nhanVien.CLV_TEN = item2.CALAMVIEC.CLV_TEN;
                        listNhanVien.Add(nhanVien);
                    }
                }
            }
            return new ObservableCollection<ClassNhanVien>(listNhanVien.OrderBy(x => x.NV_TEN));
        }

        public static ObservableCollection<ClassNhanVien> GetListNhanVienBSTrongNgayTheoPhong(DateTime THOIGIAN, string GDV_MA, int P_MA)
        {
            /*
                1. Lay ra danh sach nhan vien co vai tro bac si va ky thuat vien
                2. Lay ra nhan vien phu trach goi dich vu duoc chon
                3. Tao vong lap cho 2 danh sach lay ra nhan vien bac si va ky thuat vien phu trach goi dich vu duoc chon va them danh sach nhan vien do vao 1 list
                4. Lay ra danh sach nhan vien co lich lam viec theo ngay duoc chon
                5. Tao vong lap cho 2 danh sach lay ra danh sach nhan vien cho lich hen
             */
            // 1
            var getNhanVienBSvaKTV = DataProvider.Ins.DB.CHUYENMONNHANVIEN.Where(x => x.CHUYENMON.VT_MA == 2).Select(x => new { x.NHANVIEN, x.CHUYENMON.VAITRO.VT_TEN }).Distinct().OrderBy(x => x.VT_TEN).ToList();

            // 2
            var getNhanVienPhuTrachDichVu = DataProvider.Ins.DB.PHUTRACHGOI.Where(x => x.GDV_MA == GDV_MA).Select(x => x.NHANVIEN).ToList();

            // 3
            var nhanVienPhuTrach = new ObservableCollection<ClassNhanVien>();
            foreach (var item in getNhanVienPhuTrachDichVu)
            {
                foreach (var item2 in getNhanVienBSvaKTV)
                {
                    if (item == item2.NHANVIEN)
                    {
                        var nhanVien = new ClassNhanVien();
                        nhanVien.NV_MA = item2.NHANVIEN.NV_MA;
                        nhanVien.NV_ANH = item2.NHANVIEN.NV_ANH;
                        nhanVien.NV_TEN = item2.NHANVIEN.NV_HOTEN;
                        nhanVien.VT_TEN = item2.VT_TEN;
                        nhanVienPhuTrach.Add(nhanVien);
                    }
                }
            }

            // 4
            var getNhanVienLamTheoNgay = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.THOIGIAN == THOIGIAN && x.P_MA == P_MA).ToList();

            var listNhanVien = new ObservableCollection<ClassNhanVien>();
            foreach (var item in nhanVienPhuTrach)
            {
                foreach (var item2 in getNhanVienLamTheoNgay)
                {
                    if (item.NV_MA == item2.NV_MA)
                    {
                        var nhanVien = new ClassNhanVien();
                        nhanVien.NV_MA = item2.NV_MA;
                        nhanVien.NV_ANH = item2.NHANVIEN.NV_ANH;
                        nhanVien.NV_TEN = item2.NHANVIEN.NV_HOTEN;
                        nhanVien.VT_TEN = item.VT_TEN;
                        nhanVien.CLV_MA = item2.CALAMVIEC.CLV_MA;
                        nhanVien.CLV_TEN = item2.CALAMVIEC.CLV_TEN;
                        listNhanVien.Add(nhanVien);
                    }
                }
            }
            return new ObservableCollection<ClassNhanVien>(listNhanVien.OrderBy(x => x.NV_TEN));
        }

        public static ObservableCollection<ClassNhanVien> GetListNhanVienKTVTheoNgay(DateTime THOIGIAN, string GDV_MA)
        {
            /*
                1. Lay ra danh sach nhan vien co vai tro bac si va ky thuat vien
                2. Lay ra nhan vien phu trach goi dich vu duoc chon
                3. Tao vong lap cho 2 danh sach lay ra nhan vien bac si va ky thuat vien phu trach goi dich vu duoc chon va them danh sach nhan vien do vao 1 list
                4. Lay ra danh sach nhan vien co lich lam viec theo ngay duoc chon
                5. Tao vong lap cho 2 danh sach lay ra danh sach nhan vien cho lich hen
             */
            // 1
            var getNhanVienBSvaKTV = DataProvider.Ins.DB.CHUYENMONNHANVIEN.Where(x => x.CHUYENMON.VT_MA == 3).Select(x => new { x.NHANVIEN, x.CHUYENMON.VAITRO.VT_TEN }).Distinct().OrderBy(x => x.VT_TEN).ToList();

            // 2
            var getNhanVienPhuTrachDichVu = DataProvider.Ins.DB.PHUTRACHGOI.Where(x => x.GDV_MA == GDV_MA).Select(x => x.NHANVIEN).ToList();

            // 3
            var nhanVienPhuTrach = new ObservableCollection<ClassNhanVien>();
            foreach (var item in getNhanVienPhuTrachDichVu)
            {
                foreach (var item2 in getNhanVienBSvaKTV)
                {
                    if (item == item2.NHANVIEN)
                    {
                        var nhanVien = new ClassNhanVien();
                        nhanVien.NV_MA = item2.NHANVIEN.NV_MA;
                        nhanVien.NV_ANH = item2.NHANVIEN.NV_ANH;
                        nhanVien.NV_TEN = item2.NHANVIEN.NV_HOTEN;
                        nhanVien.VT_TEN = item2.VT_TEN;
                        nhanVienPhuTrach.Add(nhanVien);
                    }
                }
            }

            // 4
            var getNhanVienLamTheoNgay = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.THOIGIAN == THOIGIAN).ToList();

            var listNhanVien = new ObservableCollection<ClassNhanVien>();
            foreach (var item in nhanVienPhuTrach)
            {
                foreach (var item2 in getNhanVienLamTheoNgay)
                {
                    if (item.NV_MA == item2.NV_MA)
                    {
                        var nhanVien = new ClassNhanVien();
                        nhanVien.NV_MA = item2.NV_MA;
                        nhanVien.NV_ANH = item2.NHANVIEN.NV_ANH;
                        nhanVien.NV_TEN = item2.NHANVIEN.NV_HOTEN;
                        nhanVien.VT_TEN = item.VT_TEN;
                        nhanVien.CLV_MA = item2.CALAMVIEC.CLV_MA;
                        nhanVien.CLV_TEN = item2.CALAMVIEC.CLV_TEN;
                        listNhanVien.Add(nhanVien);
                    }
                }
            }
            return new ObservableCollection<ClassNhanVien>(listNhanVien.OrderBy(x => x.NV_TEN));
        }

        public static void Add(string NV_MA, string CLV_MA, DateTime THOIGIAN, int? P_MA, string LLV_GHICHU)
        {
            LICHLAMVIEC lichlamviec = new LICHLAMVIEC();
            lichlamviec.CLV_MA = CLV_MA;
            lichlamviec.NV_MA = NV_MA;
            lichlamviec.THOIGIAN = THOIGIAN;
            lichlamviec.P_MA = P_MA;
            lichlamviec.LLV_GHICHU = LLV_GHICHU;

            DataProvider.Ins.DB.LICHLAMVIEC.Add(lichlamviec);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static LICHLAMVIEC AddInfo(string NV_MA, string CLV_MA, DateTime THOIGIAN, int? P_MA, string LLV_GHICHU)
        {
            LICHLAMVIEC lichlamviec = new LICHLAMVIEC();
            lichlamviec.CLV_MA = CLV_MA;
            lichlamviec.NV_MA = NV_MA;
            lichlamviec.THOIGIAN = THOIGIAN;
            lichlamviec.P_MA = P_MA;
            lichlamviec.LLV_GHICHU = LLV_GHICHU;

            DataProvider.Ins.DB.LICHLAMVIEC.Add(lichlamviec);
            DataProvider.Ins.DB.SaveChanges();

            return lichlamviec;
        }

        public static LICHLAMVIEC EditPhong(LICHLAMVIEC llv, int P_MA, string LLV_GHICHU)
        {
            var lichLamViec = llv;
            lichLamViec.P_MA = P_MA;
            lichLamViec.LLV_GHICHU = LLV_GHICHU;

            DataProvider.Ins.DB.SaveChanges();

            return lichLamViec;
        }

        public static void EditGhiChu(LICHLAMVIEC llv, string LLV_GHICHU)
        {
            var lichLamViec = llv;
            lichLamViec.LLV_GHICHU = LLV_GHICHU;

            DataProvider.Ins.DB.SaveChanges();
        }

        public static void Delete(string NV_MA, string CLV_MA, DateTime THOIGIAN)
        {
            var getLLV = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.NV_MA == NV_MA && x.CLV_MA == CLV_MA && x.THOIGIAN == THOIGIAN).SingleOrDefault();
            DataProvider.Ins.DB.LICHLAMVIEC.Remove(getLLV);
            DataProvider.Ins.DB.SaveChanges();
        }

        public static void GomNhanVienCoHaiCaVaoCaNgay()
        {
            /*
             * Lay ra danh sach lich lam viec
             * Lay ra tung doi tuong nhan vien co lich lam viec cua ngay hom do
             * Kiem tra xem nhan vien do co hon 2 ca lam viec khong
             * Neu co thi xoa het cac ca lam viec cua nhan vien do
             * Sau do them moi nhan vien voi ca lam viec la ca ngay
            */

            var listLichLamViecNhanVien = DataProvider.Ins.DB.LICHLAMVIEC.Select(x => x.NHANVIEN).Distinct().ToList();

            foreach (var item in listLichLamViecNhanVien.ToList())
            {
                // Danh sách lịch làm việc của đối tượng nhân viên
                var lichLamViecNhanVien = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.NV_MA == item.NV_MA).Select(x => new { x.NHANVIEN, x.THOIGIAN }).Distinct().ToList();
                foreach (var item2 in lichLamViecNhanVien.ToList())
                {
                    // Lấy ra các ca làm việc của nhân viên đó theo ngày
                    var lichLamViecNhanVienTheoNgay = DataProvider.Ins.DB.LICHLAMVIEC.Where(x => x.THOIGIAN == item2.THOIGIAN && x.NV_MA == item2.NHANVIEN.NV_MA).ToList();

                    // Nếu trong ngày hôm đó có 2 ca làm việc cùng 1 phòng thì gôm lại làm lịch cho cả ngày
                    if (lichLamViecNhanVienTheoNgay.Count() == 2)
                    {
                        if(lichLamViecNhanVienTheoNgay[0].P_MA == lichLamViecNhanVienTheoNgay[1].P_MA)
                        {
                            var phong = lichLamViecNhanVienTheoNgay[0].P_MA;
                            string ghiChu = "";
                            foreach (var item3 in lichLamViecNhanVienTheoNgay.ToList())
                            {
                                ghiChu = ghiChu + item3.LLV_GHICHU + ", ";
                                Delete(item3.NV_MA, item3.CLV_MA, item3.THOIGIAN);
                            }
                            Add(item2.NHANVIEN.NV_MA, "CLV2765             ", item2.THOIGIAN, phong, ghiChu.TrimEnd().Substring(0, ghiChu.Length - 2));
                            ghiChu = "";
                        }
                    }
                }
            }
        }
    }
}
