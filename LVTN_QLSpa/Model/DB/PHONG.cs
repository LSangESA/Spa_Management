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
    
    public partial class PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONG()
        {
            this.CHITIETPHONG = new HashSet<CHITIETPHONG>();
            this.LICHLAMVIEC = new HashSet<LICHLAMVIEC>();
            this.DICHVUPHONG = new HashSet<DICHVUPHONG>();
        }
    
        public int P_MA { get; set; }
        public string P_SO { get; set; }
        public string P_TEN { get; set; }
        public string P_MOTA { get; set; }
        public int P_SOLUONGNHANVIEN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHONG> CHITIETPHONG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LICHLAMVIEC> LICHLAMVIEC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DICHVUPHONG> DICHVUPHONG { get; set; }
    }
}