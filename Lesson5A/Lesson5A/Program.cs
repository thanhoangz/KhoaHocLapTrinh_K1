using System;

namespace Lesson5A
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //double soThuNhat = 2.4;
            //int soChia = 2;

            //var ketQua = (soThuNhat / soChia);

            int[] intArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    Console.WriteLine(intArray[i]);
            //}

            foreach (int item in intArray)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
