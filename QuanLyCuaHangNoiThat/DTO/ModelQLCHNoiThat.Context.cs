﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyCuaHangNoiThatEntities : DbContext
    {
        public QuanLyCuaHangNoiThatEntities()
            : base("name=QuanLyCuaHangNoiThatEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ANHMINHHOASP> ANHMINHHOASP { get; set; }
        public virtual DbSet<CONGNO> CONGNO { get; set; }
        public virtual DbSet<CTNHAPHANGTUNPP> CTNHAPHANGTUNPP { get; set; }
        public virtual DbSet<CTHOADONBANHANG> CTHOADONBANHANG { get; set; }
        public virtual DbSet<CHITIETNHAPHANG> CHITIETNHAPHANG { get; set; }
        public virtual DbSet<HOADONBANHANG> HOADONBANHANG { get; set; }
        public virtual DbSet<HOADONNHAPHANG> HOADONNHAPHANG { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANG { get; set; }
        public virtual DbSet<LICHSUHETHONG> LICHSUHETHONG { get; set; }
        public virtual DbSet<LICHSUTRANO> LICHSUTRANO { get; set; }
        public virtual DbSet<LOAISANPHAM> LOAISANPHAM { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIEN { get; set; }
        public virtual DbSet<NHAPHANPHOI> NHAPHANPHOI { get; set; }
        public virtual DbSet<QUYENHAN> QUYENHAN { get; set; }
        public virtual DbSet<SANPHAM> SANPHAM { get; set; }
        public virtual DbSet<DOIDONVINEN> DOIDONVINEN { get; set; }
        public virtual DbSet<DOIDONVITUONG> DOIDONVITUONG { get; set; }
    }
}
