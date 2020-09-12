using System;
using System.Collections.Generic;

namespace Lesson6C
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mangSoNguyen = new List<int>(); // 0 phần tử
            mangSoNguyen.Add(46);
            mangSoNguyen.Add(102);
            mangSoNguyen.Add(196);
            mangSoNguyen.Add(74);
            mangSoNguyen.Add(82);
            mangSoNguyen.Add(48);
            mangSoNguyen.Add(201);
            mangSoNguyen.Add(69);
            mangSoNguyen.Add(67);

            //mangSoNguyen.Add(2);
            //mangSoNguyen.Add(1);


            int hieuNhoNhat = Math.Abs(mangSoNguyen[0] - mangSoNguyen[1]);
            int soThuNhat = 0, soThuHai = 0;
            for (int i = 0; i < mangSoNguyen.Count; i++)
            {
                for (int j = i + 1; j < mangSoNguyen.Count; j++)
                {
                    int hieuHienTai = Math.Abs(mangSoNguyen[i] - mangSoNguyen[j]);
                    if (hieuHienTai < hieuNhoNhat)
                    {
                        hieuNhoNhat = hieuHienTai;
                        soThuNhat = mangSoNguyen[i];
                        soThuHai = mangSoNguyen[j];
                    }
                }
            } // độ phức tạp :n*n => n^2

            Console.WriteLine(soThuNhat + " " + soThuHai);
            //for (int i = 0; i < mangSoNguyen.Count; i++)
            //{
            //    for (int j = i + 1; j < mangSoNguyen.Count; j++)
            //    {
            //        if (hieuNhoNhat == Math.Abs(mangSoNguyen[i] - mangSoNguyen[j]))
            //        {
            //            Console.WriteLine(mangSoNguyen[i] + " " + mangSoNguyen[j]);
            //        }
            //    }
            //}

            // tổng hợp :  2.n^2 
        }
    }
}
