//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LVTN_QLSpa.Model.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LVTN_HTQL_SPAEntities : DbContext
    {
        public LVTN_HTQL_SPAEntities()
            : base("name=LVTN_HTQL_SPAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CACHTHANHTOAN> CACHTHANHTOAN { get; set; }
        public virtual DbSet<CALAMVIEC> CALAMVIEC { get; set; }
        public virtual DbSet<CHIDINH> CHIDINH { get; set; }
        public virtual DbSet<CHITIETPHONG> CHITIETPHONG { get; set; }
        public virtual DbSet<CHUCNANG> CHUCNANG { get; set; }
        public virtual DbSet<CHUYENMON> CHUYENMON { get; set; }
        public virtual DbSet<CHUYENMONNHANVIEN> CHUYENMONNHANVIEN { get; set; }
        public virtual DbSet<DG_GDV> DG_GDV { get; set; }
        public virtual DbSet<DG_LT> DG_LT { get; set; }
        public virtual DbSet<DICHVU> DICHVU { get; set; }
        public virtual DbSet<DVT> DVT { get; set; }
        public virtual DbSet<GOIDICHVU> GOIDICHVU { get; set; }
        public virtual DbSet<GIAMGOIDICHVU> GIAMGOIDICHVU { get; set; }
        public virtual DbSet<GIAMGIA> GIAMGIA { get; set; }
        public virtual DbSet<GIAMGIA_PDK> GIAMGIA_PDK { get; set; }
        public virtual DbSet<HINHTHUCTHANHTOAN> HINHTHUCTHANHTOAN { get; set; }
        public virtual DbSet<HOATCHAT> HOATCHAT { get; set; }
        public virtual DbSet<HUYENQUAN> HUYENQUAN { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANG { get; set; }
        public virtual DbSet<LGG_GG> LGG_GG { get; set; }
        public virtual DbSet<LICHHEN> LICHHEN { get; set; }
        public virtual DbSet<LICHLAMVIEC> LICHLAMVIEC { get; set; }
        public virtual DbSet<LICHTRINHDIEUTRI> LICHTRINHDIEUTRI { get; set; }
        public virtual DbSet<LIEUTRINH> LIEUTRINH { get; set; }
        public virtual DbSet<LOAIGOIDICHVU> LOAIGOIDICHVU { get; set; }
        public virtual DbSet<LOAIGIAMGIA> LOAIGIAMGIA { get; set; }
        public virtual DbSet<NV_PDT> NV_PDT { get; set; }
        public virtual DbSet<NGAY> NGAY { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIEN { get; set; }
        public virtual DbSet<NHASX> NHASX { get; set; }
        public virtual DbSet<PT_PDT> PT_PDT { get; set; }
        public virtual DbSet<PHIEUDANGKY> PHIEUDANGKY { get; set; }
        public virtual DbSet<PHIEUDIEUTRI> PHIEUDIEUTRI { get; set; }
        public virtual DbSet<PHIEUTHU> PHIEUTHU { get; set; }
        public virtual DbSet<PHONG> PHONG { get; set; }
        public virtual DbSet<PHUONGPHAP> PHUONGPHAP { get; set; }
        public virtual DbSet<PHUTRACHGOI> PHUTRACHGOI { get; set; }
        public virtual DbSet<QUYEN> QUYEN { get; set; }
        public virtual DbSet<TINHTHANH> TINHTHANH { get; set; }
        public virtual DbSet<THUOC> THUOC { get; set; }
        public virtual DbSet<VAITRO> VAITRO { get; set; }
        public virtual DbSet<XAPHUONG> XAPHUONG { get; set; }
        public virtual DbSet<DICHVUPHONG> DICHVUPHONG { get; set; }
    }
}
