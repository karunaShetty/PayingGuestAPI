//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PGBusiness.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_pgsb_code_values
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_pgsb_code_values()
        {
            this.tbl_pgsb_code_values1 = new HashSet<tbl_pgsb_code_values>();
        }
    
        public int code { get; set; }
        public string code_value_type { get; set; }
        public string code_value { get; set; }
        public string code_value_desc { get; set; }
        public System.DateTime created_date { get; set; }
        public Nullable<decimal> created_by { get; set; }
        public byte delete_ind { get; set; }
        public byte active_ind { get; set; }
        public decimal code_value_id { get; set; }
        public Nullable<decimal> parent_code_value_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_pgsb_code_values> tbl_pgsb_code_values1 { get; set; }
        public virtual tbl_pgsb_code_values tbl_pgsb_code_values2 { get; set; }
    }
}