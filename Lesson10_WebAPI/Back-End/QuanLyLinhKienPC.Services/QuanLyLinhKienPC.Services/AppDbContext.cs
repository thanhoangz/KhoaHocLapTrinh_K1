using Microsoft.EntityFrameworkCore;
using QuanLyLinhKienPC.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyLinhKienPC.Services
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<DanhMucLinhKien> DanhMucLinhKiens { get; set; }
        public DbSet<LinhKien> LinhKiens { get; set; }
    }
}
