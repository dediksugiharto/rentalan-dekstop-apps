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
    
    public partial class view_order_full
    {
        public string status { get; set; }
        public string nama_member { get; set; }
        public string nama_admin { get; set; }
        public int id_order { get; set; }
        public Nullable<System.DateTime> waktu_ambil { get; set; }
        public Nullable<System.DateTime> waktu_kembali { get; set; }
        public string invoice_number { get; set; }
        public int id_admin { get; set; }
        public int id_member { get; set; }
        public int id_order_car { get; set; }
        public int id_mobil { get; set; }
        public Nullable<int> id__member_on_order { get; set; }
        public Nullable<int> id_admin_on_orders { get; set; }
        public Nullable<decimal> denda1 { get; set; }
        public string nama_mobil { get; set; }
        public int id_payment { get; set; }
    }
}
