namespace BanLaptop.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Khach")]
    public partial class Khach
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaKhach { get; set; }

        [Required]
        [StringLength(220)]
        public string TenKhach { get; set; }

        [Required]
        [StringLength(220)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(220)]
        public string DienThoai { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(220)]
        public string GioiTinh { get; set; }
    }
}
