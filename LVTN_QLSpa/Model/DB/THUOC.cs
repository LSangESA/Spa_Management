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
    
    public partial class THUOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THUOC()
        {
            this.CHIDINH = new HashSet<CHIDINH>();
        }
    
        public string T_MA { get; set; }
        public string T_TEN { get; set; }
        public int NSX_MA { get; set; }
        public int DVT_MA { get; set; }
        public string HC_MA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHIDINH> CHIDINH { get; set; }
        public virtual DVT DVT { get; set; }
        public virtual HOATCHAT HOATCHAT { get; set; }
        public virtual NHASX NHASX { get; set; }
    }
}
