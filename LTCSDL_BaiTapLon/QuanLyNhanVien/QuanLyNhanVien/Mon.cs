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
    
    public partial class Mon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mon()
        {
            this.Mon_Ban = new HashSet<Mon_Ban>();
        }
    
        public int Ma { get; set; }
        public string Ten { get; set; }
        public Nullable<decimal> Gia { get; set; }
        public string MoTa { get; set; }
        public string MaNhaCungCap { get; set; }
        public Nullable<int> MaLoai { get; set; }
        public Nullable<bool> HetHang { get; set; }
    
        public virtual Loai Loai { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mon_Ban> Mon_Ban { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}
