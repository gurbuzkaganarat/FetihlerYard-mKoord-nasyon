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
    
    public partial class tbl_Hastaliklar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Hastaliklar()
        {
            this.tbl_Kisiler = new HashSet<tbl_Kisiler>();
        }
    
        public int HastalikNo { get; set; }
        public string HastalikAdi { get; set; }
        public Nullable<bool> Aktiflik { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Kisiler> tbl_Kisiler { get; set; }
    }
}
