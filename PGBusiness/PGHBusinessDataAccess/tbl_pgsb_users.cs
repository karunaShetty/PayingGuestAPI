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
    
    public partial class tbl_pgsb_users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_pgsb_users()
        {
            this.tbl_pgdb_users_info = new HashSet<tbl_pgdb_users_info>();
            this.tbl_pgsb_paying_guest_homestay = new HashSet<tbl_pgsb_paying_guest_homestay>();
        }
    
        public string user_id { get; set; }
        public decimal login_id { get; set; }
        public string user_login_key { get; set; }
        public Nullable<int> user_type_code { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<System.DateTime> modified_date { get; set; }
        public byte delete_ind { get; set; }
        public byte active_ind { get; set; }
        public byte modfied_ind { get; set; }
        public Nullable<decimal> created_by { get; set; }
        public Nullable<decimal> modified_by { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_pgdb_users_info> tbl_pgdb_users_info { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_pgsb_paying_guest_homestay> tbl_pgsb_paying_guest_homestay { get; set; }
    }
}
