//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentalMobil
{
    using System;
    using System.Collections.Generic;
    
    public partial class members
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public members()
        {
            this.orders = new HashSet<orders>();
        }
    
        public int id_member { get; set; }
        public string no_identitas { get; set; }
        public string nama { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string no_telp { get; set; }
        public string alamat { get; set; }
        public string password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orders> orders { get; set; }
    }
}
