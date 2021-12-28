using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVTN_QLSpa.Model.ModelClass
{
    public class ClassPhieuThu
    {
        public int STT { get; set; }
        public string PT_STT { get; set; }
        public DateTime PT_NGAYLAP { get; set; }
        public string PT_TONGTIEN { get; set; }
        public string NV_TEN { get; set; }
        public string HTTT_TEN { get; set; }
        public string KH_MA { get; set; }
        public string KH_HOTEN { get; set; }
        public int PDT_THU { get; set; }
    }
}
