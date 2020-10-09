using QuanLyLinhKienPC.Services.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyLinhKienPC.Services.Models
{
    public class LinhKien
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public LinhKienStatusEnum LinhKienStatusEnum { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string ImageUrl { get; set; }


        [ForeignKey("DanhMucLinhKienId")]
        public Guid DanhMucLinhKienId { get; set; }

        public DanhMucLinhKien DanhMucLinhKien { get; set; }
    }
}
