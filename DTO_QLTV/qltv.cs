namespace DTO_QLTV
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class qltv : DbContext
    {
        public qltv()
            : base("name=qltv")
        {
        }

        public virtual DbSet<BAOCAOKIEMKE> BAOCAOKIEMKEs { get; set; }
        public virtual DbSet<D_KIEMKETAILIEU> D_KIEMKETAILIEU { get; set; }
        public virtual DbSet<D_SD_INTERNET> D_SD_INTERNET { get; set; }
        public virtual DbSet<D_SD_PHONGDOC> D_SD_PHONGDOC { get; set; }
        public virtual DbSet<D_THANHLYTAILIEU> D_THANHLYTAILIEU { get; set; }
        public virtual DbSet<DANHMUC> DANHMUCs { get; set; }
        public virtual DbSet<DAUTAILIEU> DAUTAILIEUx { get; set; }
        public virtual DbSet<DONHANG> DONHANGs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<HOSODOCGIA> HOSODOCGIAs { get; set; }
        public virtual DbSet<LICHSUTRUYCAP> LICHSUTRUYCAPs { get; set; }
        public virtual DbSet<MAYTINH> MAYTINHs { get; set; }
        public virtual DbSet<MUON> MUONs { get; set; }
        public virtual DbSet<NGUOIDUNG> NGUOIDUNGs { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<NHAXUATBAN> NHAXUATBANs { get; set; }
        public virtual DbSet<NHOMDOCGIA> NHOMDOCGIAs { get; set; }
        public virtual DbSet<PHIEUPHAT> PHIEUPHATs { get; set; }
        public virtual DbSet<SD_INTERNET> SD_INTERNET { get; set; }
        public virtual DbSet<SD_PHONGDOC> SD_PHONGDOC { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TACGIA> TACGIAs { get; set; }
        public virtual DbSet<TAILIEU> TAILIEUx { get; set; }
        public virtual DbSet<THANHLYTAILIEU> THANHLYTAILIEUx { get; set; }
        public virtual DbSet<TRA> TRAs { get; set; }
        public virtual DbSet<VITRILUUTRU> VITRILUUTRUs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BAOCAOKIEMKE>()
                .Property(e => e.MaBaoCao)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BAOCAOKIEMKE>()
                .Property(e => e.MaDauTaiLieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BAOCAOKIEMKE>()
                .HasMany(e => e.D_KIEMKETAILIEU)
                .WithRequired(e => e.BAOCAOKIEMKE)
                .HasForeignKey(e => new { e.MaBaoCao, e.MaDauTaiLieu })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<D_KIEMKETAILIEU>()
                .Property(e => e.MaBaoCao)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<D_KIEMKETAILIEU>()
                .Property(e => e.MaDauTaiLieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<D_KIEMKETAILIEU>()
                .Property(e => e.MaTaiLieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<D_SD_INTERNET>()
                .Property(e => e.MaSD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<D_SD_INTERNET>()
                .Property(e => e.MaMayTinh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<D_SD_INTERNET>()
                .Property(e => e.MaThe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<D_SD_PHONGDOC>()
                .Property(e => e.MaSD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<D_SD_PHONGDOC>()
                .Property(e => e.MaTaiLieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<D_SD_PHONGDOC>()
                .Property(e => e.MaThe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<D_THANHLYTAILIEU>()
                .Property(e => e.MaThanhLy)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<D_THANHLYTAILIEU>()
                .Property(e => e.MaTaiLieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DANHMUC>()
                .Property(e => e.MaDanhMuc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DANHMUC>()
                .Property(e => e.MaDauTaiLieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DANHMUC>()
                .Property(e => e.MaNCC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DAUTAILIEU>()
                .Property(e => e.MaDauTaiLieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DAUTAILIEU>()
                .Property(e => e.KhoGiay)
                .IsUnicode(false);

            modelBuilder.Entity<DAUTAILIEU>()
                .HasMany(e => e.BAOCAOKIEMKEs)
                .WithRequired(e => e.DAUTAILIEU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DAUTAILIEU>()
                .HasMany(e => e.DANHMUCs)
                .WithRequired(e => e.DAUTAILIEU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DAUTAILIEU>()
                .HasMany(e => e.DONHANGs)
                .WithRequired(e => e.DAUTAILIEU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DAUTAILIEU>()
                .HasMany(e => e.HOADONs)
                .WithRequired(e => e.DAUTAILIEU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DAUTAILIEU>()
                .HasMany(e => e.NHAXUATBANs)
                .WithRequired(e => e.DAUTAILIEU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DAUTAILIEU>()
                .HasMany(e => e.TACGIAs)
                .WithRequired(e => e.DAUTAILIEU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DONHANG>()
                .Property(e => e.MaDauTaiLieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DONHANG>()
                .Property(e => e.MaDonHang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DONHANG>()
                .Property(e => e.MaNCC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaHoaDon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaDauTaiLieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaNCC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaDonHang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.TAILIEUx)
                .WithOptional(e => e.HOADON)
                .HasForeignKey(e => new { e.MaHoaDon, e.MaDauTaiLieu });

            modelBuilder.Entity<HOSODOCGIA>()
                .Property(e => e.MaThe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOSODOCGIA>()
                .Property(e => e.Lop)
                .IsUnicode(false);

            modelBuilder.Entity<HOSODOCGIA>()
                .Property(e => e.KhoaHoc)
                .IsUnicode(false);

            modelBuilder.Entity<HOSODOCGIA>()
                .Property(e => e.SoCMND)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOSODOCGIA>()
                .Property(e => e.Masodocgia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOSODOCGIA>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<HOSODOCGIA>()
                .Property(e => e.Anh)
                .IsUnicode(false);

            modelBuilder.Entity<HOSODOCGIA>()
                .Property(e => e.Somavach)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOSODOCGIA>()
                .Property(e => e.MaNDG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOSODOCGIA>()
                .Property(e => e.Idnguoidung)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LICHSUTRUYCAP>()
                .Property(e => e.idLichSu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LICHSUTRUYCAP>()
                .Property(e => e.idNguoiDung)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MAYTINH>()
                .Property(e => e.MaMayTinh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MAYTINH>()
                .HasMany(e => e.D_SD_INTERNET)
                .WithRequired(e => e.MAYTINH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MUON>()
                .Property(e => e.MaMuon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MUON>()
                .Property(e => e.MaTaiLieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MUON>()
                .Property(e => e.idNguoiDung)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MUON>()
                .Property(e => e.MaThe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.idNguoidung)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.TenDN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.Matkhau)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .Property(e => e.MaNCC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .Property(e => e.SoFax)
                .IsUnicode(false);

            modelBuilder.Entity<NHAXUATBAN>()
                .Property(e => e.MaXB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHAXUATBAN>()
                .Property(e => e.MaDauTaiLieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHOMDOCGIA>()
                .Property(e => e.MaNDG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUPHAT>()
                .Property(e => e.MaPhieuPhat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUPHAT>()
                .Property(e => e.MaTaiLieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUPHAT>()
                .Property(e => e.idNguoiDung)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUPHAT>()
                .Property(e => e.MaThe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SD_INTERNET>()
                .Property(e => e.MaSD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SD_INTERNET>()
                .Property(e => e.MaThe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SD_PHONGDOC>()
                .Property(e => e.MaSD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SD_PHONGDOC>()
                .Property(e => e.MaThe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TACGIA>()
                .Property(e => e.MaTacGia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TACGIA>()
                .Property(e => e.MaDauTaiLieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TAILIEU>()
                .Property(e => e.MaTaiLieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TAILIEU>()
                .Property(e => e.MaVach)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TAILIEU>()
                .Property(e => e.MaDauTaiLieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TAILIEU>()
                .Property(e => e.MaHoaDon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TAILIEU>()
                .Property(e => e.MaViTri)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TAILIEU>()
                .HasMany(e => e.D_KIEMKETAILIEU)
                .WithRequired(e => e.TAILIEU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TAILIEU>()
                .HasMany(e => e.D_SD_PHONGDOC)
                .WithRequired(e => e.TAILIEU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TAILIEU>()
                .HasMany(e => e.D_THANHLYTAILIEU)
                .WithRequired(e => e.TAILIEU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TAILIEU>()
                .HasMany(e => e.MUONs)
                .WithRequired(e => e.TAILIEU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TAILIEU>()
                .HasMany(e => e.PHIEUPHATs)
                .WithRequired(e => e.TAILIEU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TAILIEU>()
                .HasMany(e => e.TRAs)
                .WithRequired(e => e.TAILIEU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THANHLYTAILIEU>()
                .Property(e => e.MaThanhLy)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THANHLYTAILIEU>()
                .HasMany(e => e.D_THANHLYTAILIEU)
                .WithRequired(e => e.THANHLYTAILIEU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRA>()
                .Property(e => e.MaTra)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRA>()
                .Property(e => e.MaTaiLieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRA>()
                .Property(e => e.idNguoiDung)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRA>()
                .Property(e => e.MaThe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VITRILUUTRU>()
                .Property(e => e.MaViTri)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
