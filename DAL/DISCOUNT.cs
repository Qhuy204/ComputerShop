//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class DISCOUNT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DISCOUNT()
        {
            this.SALEBILLs = new HashSet<SALEBILL>();
        }
    
        public string CODE { get; set; }
        public Nullable<double> DISCOUNT_PERCENT { get; set; }
        public Nullable<int> MAXIMUM_USE { get; set; }
        public Nullable<int> USED_COUNT { get; set; }
        public Nullable<double> MAXIMUM_DISCOUNT_AMOUNT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SALEBILL> SALEBILLs { get; set; }
    }
}
