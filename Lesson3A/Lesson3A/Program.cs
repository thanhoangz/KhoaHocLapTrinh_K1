using System;

namespace Lesson3A
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]mangSoNguyen = new int[10];

            // Input

            for (int i = 0; i < mangSoNguyen.Length; i++)
            {
                Console.WriteLine("mangSoNguyen[" + i + "] = ");
                mangSoNguyen[i] = int.Parse(Console.ReadLine());
            }


            //int soNhoNhat = mangSoNguyen[mangSoNguyen.Length - 1];

            //for (int i = mangSoNguyen.Length - 2; i >= 0; i--)
            //{
            //    if(soNhoNhat > mangSoNguyen[i])
            //    {
            //        soNhoNhat = mangSoNguyen[i];
            //    }
            //}


            // n = 5 => 2 5 1 0 5
            // soNhoNhat = 0; i = 5
            int soNhoNhat = mangSoNguyen[0];
            for (int i = 1; i < mangSoNguyen.Length; i++)
            {
                if (soNhoNhat > mangSoNguyen[i])
                {
                    soNhoNhat = mangSoNguyen[i];
                }
            }
            int min2 = soNhoNhat;
            for (int i = 0; i < 10; i++)
            {
                if (mangSoNguyen[i]>min2 && mangSoNguyen[i] != soNhoNhat)
                {
                    min2 = mangSoNguyen[i];
                }

            }


            //Output 

            Console.WriteLine("Output: " + soNhoNhat);
            Console.WriteLine("Output: " + min2);
            //for (int i = 0; i < mangSoNguyen.Length; i++)
            //{
            //    Console.WriteLine("mangSoNguyen[" + i + "] = " + mangSoNguyen[i]);
            //}




        }
    }
}
