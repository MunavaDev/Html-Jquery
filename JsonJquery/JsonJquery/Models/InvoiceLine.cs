//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JsonJquery.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvoiceLine
    {
        public int InvoiceLineID { get; set; }
        public int InvoiceID { get; set; }
        public int ProductID { get; set; }
        public Nullable<int> Quantity { get; set; }
    
        public virtual Invoice Invoice { get; set; }
        public virtual Product Product { get; set; }
    }
}
