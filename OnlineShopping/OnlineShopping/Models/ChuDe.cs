//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineShopping.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChuDe
    {
        public ChuDe()
        {
            this.Gopies = new HashSet<GopY>();
        }
    
        public int MaCD { get; set; }
        public string TenCD { get; set; }
        public string MaNV { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
        public virtual ICollection<GopY> Gopies { get; set; }
    }
}
