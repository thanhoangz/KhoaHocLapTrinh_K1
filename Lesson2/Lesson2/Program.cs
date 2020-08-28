using System;
using System.Runtime.CompilerServices;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f;
            Console.WriteLine("Input :");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            f = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Tong: " + (a + b + c + d + e + f).ToString());


            // 	72 79 65 78 71 => HOANG
            // ý thứ 2 : in tên từ các chữ số được nhập từ bàn phím
            string ketQua = ((char)a).ToString() + ((char)b).ToString() + ((char)c).ToString() + ((char)d).ToString() + ((char)e).ToString() + ((char)f).ToString();
            Console.WriteLine(ketQua.ToString());

        }
    }
}
