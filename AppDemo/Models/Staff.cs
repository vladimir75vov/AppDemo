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
    
    public partial class Staff
    {
        public int ID { get; set; }
        public int IDrole { get; set; }
        public string SFMname { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string lastLogin { get; set; }
        public int IDtypeLogin { get; set; }
    
        public virtual RolesStaff RolesStaff { get; set; }
        public virtual TypeLoginsStaff TypeLoginsStaff { get; set; }
    }
}