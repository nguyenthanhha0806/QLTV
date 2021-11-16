namespace DTO_QLTV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VITRILUUTRU")]
    public partial class VITRILUUTRU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VITRILUUTRU()
        {
            TAILIEUx = new HashSet<TAILIEU>();
        }

        [Key]
        [StringLength(8)]
        public string MaViTri { get; set; }

        public int? Ke { get; set; }

        public int? Ngan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAILIEU> TAILIEUx { get; set; }
    }
}
