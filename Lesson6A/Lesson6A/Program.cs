using System;

namespace Lesson6A
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int preNumber = rnd.Next(1, 13);
            Console.WriteLine("Nguoi duoc CHON thu' 2: "+ preNumber);
        }
    }
}
