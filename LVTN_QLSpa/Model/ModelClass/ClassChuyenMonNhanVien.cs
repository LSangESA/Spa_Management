using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVTN_QLSpa.Model.ModelClass
{
    public class ClassChuyenMonNhanVien
    {
        public string NV_MA { get; set; }
        public int CM_MA { get; set; }
        public string CM_TEN { get; set; }
        public int VT_MA { get; set; }
        public string VT_TEN { get; set; }
        public bool IsCheckDelete { get; set; }
    }
}
