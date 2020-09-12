using System;

namespace Lesson6B
{
    class Program
    {
        public static void A()
        {
            Console.WriteLine("1");
        }

        public static void A1(int a) //a = 2
        {
            if (a == 2)
                Console.WriteLine("1A");
            else
                Console.WriteLine("1");
        }

        public static int A2(int b) //b = 3 => 3
        {
            return (b + 1 > 16) ? 0 : b;
        }

        public static int A3(int a, int b)
        {
            if (a == b)
                return a;

            if (b > 2) // 5> 2 // a = 5, b = 5
                a = b;
            return b;
        }

        public static int A4(int a) //a =2 => 3
        {
            if (a == A3(a, 5)) // 2 == 5
                return a;
            return a + 1;
        }


        static void Main(string[] args)
        {
            int x = 2, y = 14, z = 17;
            A1(x);
            A();
            if (z > 2)  // z = 17 > 2
                y = A4(x); // A4(2) = 3, y= 3
            Console.WriteLine(A2(y)); // A2(3)
        }
    }

}
