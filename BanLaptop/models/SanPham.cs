namespace BanLaptop.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        [StringLength(10)]
        public string MaSP { get; set; }

        [Required]
        [StringLength(220)]
        public string TenSP { get; set; }

        public int MaLoai { get; set; }

        public int MaNCC { get; set; }

        public int SoLuong { get; set; }

        [Required]
        [StringLength(220)]
        public string DonGiaNhap { get; set; }

        [Required]
        [StringLength(255)]
        public string GhiChu { get; set; }
    }
}
