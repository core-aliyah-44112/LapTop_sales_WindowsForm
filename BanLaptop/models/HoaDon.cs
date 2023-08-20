namespace BanLaptop.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [StringLength(20)]
        public string MaHD { get; set; }

        public int MaNV { get; set; }

        public int MaKhach { get; set; }

        public DateTime NgayLapHD { get; set; }

        [Required]
        [StringLength(220)]
        public string TriGia { get; set; }
    }
}
