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
    
    public partial class TSepet
    {
        public int SepetID { get; set; }
        public Nullable<int> Musteri { get; set; }
        public Nullable<int> Urun { get; set; }
        public Nullable<int> Adet { get; set; }
        public Nullable<int> ToplamMiktar { get; set; }
    
        public virtual TMusteri TMusteri { get; set; }
        public virtual TUrun TUrun { get; set; }
    }
}
