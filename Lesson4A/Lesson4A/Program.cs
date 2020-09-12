using System;

namespace Lesson4A
{
    class Program
    {
        public static void SoSanhSoLonHon(int a, int b)
        {
            if (a > b)
                Console.WriteLine("So lon hon la: " + a);
            else
                Console.WriteLine("So lon hon la: " + b);
        }

        public static int SoLonHon(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        public static int SoLonNhatTrong3So(int a, int b, int c)
        {
            int min = a;

            if (min > b)
                min = b;

            if (min > c)
                min = c;

            return min;
        }

        // true - false
        public static bool KiemTraSoHoanHao(int soCanKiemTra)
        {

            if (soCanKiemTra < 0)
                return false;
            else
            {
                int sum = 0;
                for (int i = 1; i < soCanKiemTra; i++)
                {
                    if (0 == soCanKiemTra % i)
                    {
                        sum = sum + i;
                    }
                }

                if (soCanKiemTra == sum)
                    return true;
                else
                    return false;
            }
        }


        public static bool KiemTraCoSo2HayKhong(int[] mangSoNguyen)
        {
            for (int i = 0; i < mangSoNguyen.Length; i++)
            {
                if (mangSoNguyen[i] == 2)
                {
                    return true;
                }
            }

            return false;
        }

        public static void ViDuBeark()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }

            Console.WriteLine("Done!");
            
        }

        // string 
        //In ra các chữ số chẵn từ 1 đến 100

        static void Main(string[] args)
        {
            //int[] mangSoNguyen = new int[5] { 1, 53, 78, 2, 8 };

            //bool kiemTra = KiemTraCoSo2HayKhong(mangSoNguyen);
            //if (kiemTra == true)
            //    Console.WriteLine("Mang nay co so 2");
            //else
            //    Console.WriteLine("Mang nay KHONG co so 2");

            char[]  mangChuCai = new char[5] { 'h', 'o', 'a','n','g'};
            string mangChuCai1 = "hoang";
            Console.WriteLine(mangChuCai1);
        }




    }


}
