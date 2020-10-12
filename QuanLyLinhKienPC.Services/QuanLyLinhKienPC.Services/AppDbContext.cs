using Microsoft.EntityFrameworkCore;
using QuanLyLinhKienPC.Services.Models;

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
