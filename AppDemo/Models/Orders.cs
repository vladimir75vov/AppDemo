//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppDemo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int ID { get; set; }
        public string codeOrder { get; set; }
        public System.DateTime dateCreate { get; set; }
        public System.TimeSpan timeCreate { get; set; }
        public int IDclient { get; set; }
        public string service { get; set; }
        public int IDstatus { get; set; }
        public Nullable<System.DateTime> dateClose { get; set; }
        public int timeRent { get; set; }
    
        public virtual StatusOrders StatusOrders { get; set; }
        public virtual Сlients Сlients { get; set; }
    }
}
