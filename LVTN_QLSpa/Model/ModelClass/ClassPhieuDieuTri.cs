using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVTN_QLSpa.Model.ModelClass
{
    public class ClassPhieuDieuTri
    {
        public string PDT_STT { get; set; }
        public string PDK_STT { get; set; }
        public DateTime PDT_NGAYLAP { get; set; }
        public string GDV_MA { get; set; }
        public int CTT_MA { get; set; }
        public string GDV_TEN { get; set; }
        public bool IsSelected { get; set; }
    }
}
