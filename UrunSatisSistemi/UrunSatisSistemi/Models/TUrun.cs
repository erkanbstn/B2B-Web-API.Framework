//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UrunSatisSistemi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TUrun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TUrun()
        {
            this.TSepet = new HashSet<TSepet>();
        }
    
        public int UrunID { get; set; }
        public string Urun { get; set; }
        public string Kod { get; set; }
        public Nullable<int> Fiyat { get; set; }
        public string Stok { get; set; }
        public Nullable<int> Kategori { get; set; }
    
        public virtual TKategori TKategori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSepet> TSepet { get; set; }
    }
}
