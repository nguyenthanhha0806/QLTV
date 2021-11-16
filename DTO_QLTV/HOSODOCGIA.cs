namespace DTO_QLTV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOSODOCGIA")]
    public partial class HOSODOCGIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOSODOCGIA()
        {
            D_SD_INTERNET = new HashSet<D_SD_INTERNET>();
            D_SD_PHONGDOC = new HashSet<D_SD_PHONGDOC>();
            MUONs = new HashSet<MUON>();
            PHIEUPHATs = new HashSet<PHIEUPHAT>();
            SD_INTERNET = new HashSet<SD_INTERNET>();
            SD_PHONGDOC = new HashSet<SD_PHONGDOC>();
            TRAs = new HashSet<TRA>();
        }

        [Key]
        [StringLength(8)]
        public string MaThe { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        [StringLength(20)]
        public string GioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHetHan { get; set; }

        [StringLength(20)]
        public string DanToc { get; set; }

        [StringLength(20)]
        public string TrinhDoVanhoa { get; set; }

        [StringLength(10)]
        public string Lop { get; set; }

        [StringLength(10)]
        public string KhoaHoc { get; set; }

        [StringLength(13)]
        public string SoCMND { get; set; }

        [StringLength(10)]
        public string Masodocgia { get; set; }

        [StringLength(20)]
        public string Khoa { get; set; }

        [StringLength(30)]
        public string Donvi { get; set; }

        [StringLength(20)]
        public string Chucvu { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Anh { get; set; }

        [StringLength(15)]
        public string Somavach { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaycap { get; set; }

        [StringLength(20)]
        public string Tinhtrang { get; set; }

        [StringLength(10)]
        public string MaNDG { get; set; }

        [StringLength(10)]
        public string Idnguoidung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<D_SD_INTERNET> D_SD_INTERNET { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<D_SD_PHONGDOC> D_SD_PHONGDOC { get; set; }

        public virtual NHOMDOCGIA NHOMDOCGIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MUON> MUONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUPHAT> PHIEUPHATs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SD_INTERNET> SD_INTERNET { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SD_PHONGDOC> SD_PHONGDOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRA> TRAs { get; set; }
        public HOSODOCGIA(string mathe, string Hoten, string gioitinh, string trinhdovanhoa, DateTime ngaysinh, string lop, string khoahoc, string Socmnd, string masodocgia, string khoa, string donvi, string chucvu, string email, string anh, string somavach, DateTime ngayhethan, DateTime ngaycap, string tinhtrang, string manhom, string idnguoidung)
        {
            this.MaThe = mathe;
            this.HoTen = Hoten;
            this.GioiTinh = gioitinh;
            this.TrinhDoVanhoa = trinhdovanhoa;
            this.NgaySinh = ngaysinh;
            this.Lop = lop;
            this.KhoaHoc = khoahoc;
            this.SoCMND = Socmnd;
            this.Masodocgia = masodocgia;
            this.Khoa = khoa;
            this.Donvi = donvi;
            this.Chucvu = chucvu;
            this.Email = email;
            this.Anh = anh;
            this.Somavach = somavach;
            this.NgayHetHan = ngayhethan;
            this.Ngaycap = ngaycap;
            this.Tinhtrang = tinhtrang;
            this.MaNDG = manhom;
            this.Idnguoidung = idnguoidung;
        }
        public HOSODOCGIA(string mathe, string Hoten, string gioitinh, DateTime ngaysinh, DateTime ngayhethan, DateTime ngaycap, string tinhtrang)
        {
            this.MaThe = mathe;
            this.HoTen = HoTen;
            this.GioiTinh = gioitinh;
            this.NgaySinh = ngaysinh;
            this.Tinhtrang = tinhtrang;
            this.Ngaycap = ngaycap;
            this.NgayHetHan = ngayhethan;
        }

    }

}
