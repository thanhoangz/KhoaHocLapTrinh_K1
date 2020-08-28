using System;

namespace Lesson2C
{
    class Program
    {
        static void Main(string[] args)
        {
            int kw = 0;
            int tongTien = 0;
            Console.WriteLine("Moi nhap so Kw: ");
            kw = int.Parse(Console.ReadLine());

            if (kw >= 1 && kw <= 50)
            {
                tongTien = kw * 1200;
                Console.WriteLine("Tong tien: " + tongTien);
                return;
            }
            else
            {
                if (kw >= 51 && kw <= 100)
                {
                    tongTien = 50 * 1200 + (kw - 50) * 3600;
                    Console.WriteLine("Tong tien: " + tongTien);
                    return;
                }
                else
                {
                    if (kw >= 101 && kw <= 200)
                    {
                        tongTien = 50 * 1200 + 50 * 3600 + (kw - 100) * 5000;
                        Console.WriteLine("Tong tien: " + tongTien);
                        return;
                    }
                    else
                    {
                        tongTien = 50 * 1200 + 50 * 3600 + 100 * 5000 + (kw - 200) * 1000;
                        Console.WriteLine("Tong tien: " + tongTien);
                        return;
                    }

                }
            }
        }
    }
}
