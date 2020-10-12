using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyLinhKienPC.Services.Models;

namespace QuanLyLinhKienPC.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DanhMucLinhKienController : ControllerBase
    {
        private AppDbContext _context;
        public DanhMucLinhKienController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        [HttpPost]
        public string CreateDanhMucLinhKien(DanhMucLinhKien danhMucLinhKien)
        {
            _context.DanhMucLinhKiens.Add(danhMucLinhKien);
            int result = _context.SaveChanges();
            if (1 == result)
            {
                return "Lưu thành công!";
            }
            else
            {
                return "Thất bại!";
            }

        }

        [HttpPut]
        public string UpdateDanhMucLinhKien(DanhMucLinhKien danhMucLinhKien)
        {
            if (string.IsNullOrEmpty(danhMucLinhKien.Id.ToString()))
            {
                return "ID rỗng => cập nhật làm sao???";
            }

            var danhMuc = _context.DanhMucLinhKiens.FirstOrDefault(x => x.Id == danhMucLinhKien.Id);

            // = null tức là không tìm thấy, còn != null thì tức là tìm thấy 
            if (danhMuc == null)
            {
                return "ID này không tồn tại trong CSDL!";
            }

            danhMuc.Name = danhMucLinhKien.Name;
            danhMuc.Status = danhMucLinhKien.Status;
            danhMuc.GroupName = danhMucLinhKien.GroupName;
            danhMuc.Code = danhMucLinhKien.Code;

            int result = _context.SaveChanges();

            if (1 == result)
            {
                return "Lưu thành công!";
            }
            else
            {
                return "Thất bại!";
            }

        }

        [HttpDelete]
        public string DeleteDanhMucLinhKien(Guid id)
        {
            var danhMuc = _context.DanhMucLinhKiens.FirstOrDefault(danhMuc => danhMuc.Id == id);

            if (danhMuc == null)
            {
                return "Không tìm thấy ID mà xóa!";
            }

            _context.DanhMucLinhKiens.Remove(danhMuc);
            var result = _context.SaveChanges();

            if (1 == result)
            {
                return "Lưu thành công!";
            }
            else
            {
                return "Thất bại!";
            }
        }

        [HttpGet]
        public List<DanhMucLinhKien> FindByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return new List<DanhMucLinhKien>();
            }

            var danhMucs = _context.DanhMucLinhKiens.Where(x => x.Name.Contains(name) == true).ToList();

            if(null == danhMucs)
            {
                return new List<DanhMucLinhKien>();
            }
            else
            {
                return danhMucs;
            }
        }

    }
}
