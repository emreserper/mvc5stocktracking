//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockTracking.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sales
    {
        public int id { get; set; }
        public Nullable<int> product { get; set; }
        public Nullable<int> employee { get; set; }
        public Nullable<int> customer { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<System.DateTime> date { get; set; }
    
        public virtual Customers Customers { get; set; }
        public virtual Employees Employees { get; set; }
        public virtual Products Products { get; set; }
    }
}
