namespace BanLaptop.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHD")]
    public partial class ChiTietHD
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaCTHD { get; set; }

        [Required]
        [StringLength(20)]
        public string MaHD { get; set; }

        [Required]
        [StringLength(10)]
        public string MaSP { get; set; }

        public int MaBH { get; set; }

        [Required]
        [StringLength(20)]
        public string DonVT { get; set; }

        public decimal DonGia { get; set; }

        public int SoLuong { get; set; }

        public decimal ThanhTien { get; set; }
    }
}
