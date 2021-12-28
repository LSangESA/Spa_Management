using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVTN_QLSpa.Model.ModelClass
{
    public static class ClassXuLyChuoi
    {
        #region Lọc chuỗi có dấu thành không dấu
        private static readonly string[] VietNamChar = new string[]
        {
            "aAeEoOuUiIdDyY",
            "áàạảãâấầậẩẫăắằặẳẵ",
            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
            "éèẹẻẽêếềệểễ",
            "ÉÈẸẺẼÊẾỀỆỂỄ",
            "óòọỏõôốồộổỗơớờợởỡ",
            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
            "úùụủũưứừựửữ",
            "ÚÙỤỦŨƯỨỪỰỬỮ",
            "íìịỉĩ",
            "ÍÌỊỈĨ",
            "đ",
            "Đ",
            "ýỳỵỷỹ",
            "ÝỲỴỶỸ"
        };
        public static string LocDau(string str)
        {
            //Thay thế và lọc dấu từng char      
            for (int i = 1; i < VietNamChar.Length; i++)
            {
                for (int j = 0; j < VietNamChar[i].Length; j++)
                    str = str.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
            }
            return str;
        }
        #endregion

        #region Lấy ký tự đầu chuỗi họ tên lót thành 
        public static string GetName(string str, string kyHieuSau)
        {
            string res = "";
            string[] tu = str.Split(' ');
            int len = tu.Length;
            for (int i = 0; i < len - 1; i++)
            {
                res += tu[i].Substring(0, 1);
            }
            res += tu[len - 1];
            res += kyHieuSau;

            return res;
        }

        #endregion

        public static int ChuyenTienThanhSo(string str)
        {
            int tienSo = int.Parse(str.Replace(".", ""));

            return tienSo;
        }

        public static string ChuyenSoThanhTien(int so)
        {
            string TienStr = so.ToString("#,#");

            return TienStr;
        }

        public static string XoaKhoanTrangKyTuCuoi(string str)
        {
            string strDaXoa = str.Trim(' ');

            return strDaXoa;
        }
    }
}
