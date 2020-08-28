using System;

namespace Lesso2B
{
    class Program
    {
        static void Main(string[] args)
        {
            string dinhDanh = "";

            Console.Write("Input: ");
            dinhDanh =  Console.ReadLine();

            // dog, cat

            if ("dog" == dinhDanh) // không lên dùng dinhDanh == "dog"
            {
                Console.WriteLine("Go go go!");
            }
            else
            {
                if ("cat" == dinhDanh)
                {
                    Console.WriteLine("Meo meo meo!");
                }
                else
                {
                    Console.WriteLine("Khong phai cho cung khong phai meo");
                }
               
            }

        }
    }
}
