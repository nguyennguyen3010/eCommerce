﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ShoppingEntities : DbContext
    {
        public ShoppingEntities()
            : base("name=ShoppingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BanBe> BanBes { get; set; }
        public DbSet<ChiTietHD> ChiTietHDs { get; set; }
        public DbSet<ChuDe> ChuDes { get; set; }
        public DbSet<GopY> Gopies { get; set; }
        public DbSet<HangHoa> HangHoas { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoiDap> HoiDaps { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<Loai> Loais { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<YeuThich> YeuThiches { get; set; }
    }
}