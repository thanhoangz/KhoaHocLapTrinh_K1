using System;

namespace Bai1
{
    public enum Sex
    {
        male, female, lgbt
    }

    public class Human
    {
        public Human() 
        {

        }

        private string _hairColor;

        public double Height;

        public double Weight;

        public Sex Sex;

        public string Name;

    }


    class Program
    {
        static void Main(string[] args)
        {
           
            Human human = new Human();
            human.Name = "Phong";
            human.Height = 1.75;
            human.Weight = 54;
            human.Sex = (Sex)0;

            Console.WriteLine("Dong chi: \nName: {0}\tHeight: {1}\tWeight: {2}\tSex: {3}", human.Name, human.Height,human.Weight,human.Sex);
        }
    }
}
