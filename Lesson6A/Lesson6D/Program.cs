using System;

namespace Lesson6D
{
    class hinhchunhat
    {
        private int height;
        private int width;

        public hinhchunhat(int newHeight, int newWidth)
        {
            height = newHeight;
            width = newWidth;
        }

        public int tinhdientich()
        {
            return height * width;
        }

        public void HienGiaTri()
        {
            Console.WriteLine("Chieu dai: "+ height + "Chieu Rong: "+ width);
        }

        public void ThuNghiem()
        {
       
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Renekaton renekaton = new Renekaton();
            renekaton.Ten = "Ca sau Duong";

            renekaton.HienMang();

        }
    }


    public enum LoaiTuong
    {
        AD, Rung, SP, Mid, Top
    }
    class NhanVat
    {
        public string Ten;
        public LoaiTuong LoaiTuong;

        private string KiNangQ;
        private string KiNangW;
        private string KiNangE;
        private string KiNangR;

        public string BoTro1;
        public string BoTro2;

        public void HienThiKiNang(string kiNang)
        {
            Console.WriteLine(kiNang);
        }

        public void HienMang()
        {
            Console.WriteLine("Shutdown!");
        }

 
    }


    class Renekaton : NhanVat
    {
        private string DacDiemNgoaiHinh;
        public void HienMang()
        {
            Console.WriteLine("Shutdown Ca Sau !!");
        }

    }

    class Yasuo: NhanVat
    {
        private string ATMDiDong;

    }

}
