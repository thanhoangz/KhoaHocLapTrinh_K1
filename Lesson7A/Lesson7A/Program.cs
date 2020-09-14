using Lesson7A.Models;
using System;
using System.Text;

namespace Lesson7A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            PhanSo phanSoA = new PhanSo(7, 24); 
            PhanSo phanSoB = new PhanSo(8, 24);

            PhanSo ketQua = new PhanSo();

            ketQua = ketQua.CongPhanSo(phanSoA, phanSoB);

            ketQua = ketQua.RutGon(ketQua);

            ketQua.XuatPhanSo();

        }
    }
}
