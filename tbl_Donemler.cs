//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FethlerV2
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Donemler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Donemler()
        {
            this.tbl_Erzaklar = new HashSet<tbl_Erzaklar>();
        }
    
        public int DonemNo { get; set; }
        public string DonemAdi { get; set; }
        public Nullable<int> PaketAgirligi { get; set; }
        public Nullable<bool> Aktiflik { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Erzaklar> tbl_Erzaklar { get; set; }
    }
}
