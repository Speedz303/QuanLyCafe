//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyNhanVien
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        public string userID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string MaNhanVien { get; set; }
    
        public virtual QLNhanVien QLNhanVien { get; set; }
    }
}
