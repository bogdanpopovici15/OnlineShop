//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Specification { get; set; }
        public string Price { get; set; }
        public Nullable<int> ShopId { get; set; }
    
        public virtual Shop Shop { get; set; }
    }
}
