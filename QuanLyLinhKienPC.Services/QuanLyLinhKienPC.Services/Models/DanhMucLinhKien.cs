using QuanLyLinhKienPC.Services.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLyLinhKienPC.Services.Models
{
    public class DanhMucLinhKien
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public StatusEnum Status { get; set; }

        [Required]
        public string GroupName { get; set; }

        public List<LinhKien> LinhKiens { get; set; }
    }
}
