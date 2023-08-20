namespace BanLaptop.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiSP")]
    public partial class LoaiSP
    {
        [Key]
        public int MaLoai { get; set; }

        [StringLength(255)]
        public string TenLoai { get; set; }

        [Column(TypeName = "text")]
        public string ChiTiet { get; set; }
    }
}
