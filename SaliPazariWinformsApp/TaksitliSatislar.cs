//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaliPazariWinformsApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaksitliSatislar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaksitliSatislar()
        {
            this.TaksitDetaylars = new HashSet<TaksitDetaylar>();
        }
    
        public int SatisID { get; set; }
        public Nullable<int> ToplamTaksitSayisi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaksitDetaylar> TaksitDetaylars { get; set; }
    }
}
