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
    
    public partial class tbl_Koyler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Koyler()
        {
            this.tbl_Kisiler = new HashSet<tbl_Kisiler>();
        }
    
        public int KoyNo { get; set; }
        public string KoyAdi { get; set; }
        public string MuhtarAdi { get; set; }
        public string MuhtarCepTel { get; set; }
        public string YardimciAdi { get; set; }
        public string YardimciTel { get; set; }
        public string KoyDetay { get; set; }
        public Nullable<bool> Aktiflik { get; set; }
        public Nullable<bool> Sec { get; set; }
        public Nullable<int> Bolge { get; set; }
    
        public virtual tbl_Bolgeler tbl_Bolgeler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Kisiler> tbl_Kisiler { get; set; }
    }
}
