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
    
    public partial class Message
    {
        public int mid { get; set; }
        public string musername { get; set; }
        public string username { get; set; }
        public string mdate { get; set; }
        public string mtext { get; set; }
    
        public virtual MyUser MyUser { get; set; }
        public virtual MyUser MyUser1 { get; set; }
    }
}
