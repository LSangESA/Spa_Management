//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LVTN_QLSpa.Model.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHITIETPHONG
    {
        public int VT_MA { get; set; }
        public int P_MA { get; set; }
        public int CTP_SOLUONG { get; set; }
    
        public virtual VAITRO VAITRO { get; set; }
        public virtual PHONG PHONG { get; set; }
    }
}
