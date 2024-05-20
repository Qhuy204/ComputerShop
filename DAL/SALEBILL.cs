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
    
    public partial class SALEBILL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SALEBILL()
        {
            this.SALEBILL_DETAIL = new HashSet<SALEBILL_DETAIL>();
        }
    
        public string SL_ID { get; set; }
        public System.DateTime SL_DATE { get; set; }
        public string CUS_ID { get; set; }
        public string EMP_ID { get; set; }
        public string DISCOUNT_CODE { get; set; }
        public string PROMOTION_ID { get; set; }
        public Nullable<double> TOTAL_MONEY { get; set; }
        public string PAYMENT { get; set; }
        public string NOTE { get; set; }
        public Nullable<double> MONEY_CUSTOMER_GIVE { get; set; }
        public Nullable<double> REFUND { get; set; }
        public string STATUS { get; set; }
    
        public virtual CUSTOMER CUSTOMER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SALEBILL_DETAIL> SALEBILL_DETAIL { get; set; }
    }
}
