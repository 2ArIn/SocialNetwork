//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SN.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class MyLike
    {
        public int lid { get; set; }
        public int pid { get; set; }
        public string lusername { get; set; }
        public string ldate { get; set; }
    
        public virtual MyUser MyUser { get; set; }
        public virtual Post Post { get; set; }
    }
}