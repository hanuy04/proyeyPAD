//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proyekPAD
{
    using System;
    using System.Collections.Generic;
    
    public partial class diskon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public diskon()
        {
            this.barangs = new HashSet<barang>();
        }
    
        public string id_diskon { get; set; }
        public string jenis_diskon { get; set; }
        public Nullable<int> minimal_pembelian { get; set; }
        public Nullable<System.DateTime> tanggal_mulai { get; set; }
        public Nullable<System.DateTime> tanggal_berakhir { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<barang> barangs { get; set; }
    }
}
