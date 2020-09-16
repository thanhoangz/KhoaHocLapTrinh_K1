using Lesson8A.Models;
using System;
using System.Collections.Generic;

namespace Lesson8A
{
    class Program
    {
        public static List<int> SortNumber(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if(numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            return numbers;
        }
        static void Main(string[] args)
        {

            // Khai báo danh sách khoa
            List<Faculty> faculties = new List<Faculty>();
            var faculty = new Faculty("Công nghệ thông tin");

            // Chèn 1 khoa vào danh sách khoa
            faculties.Add(faculty);

            List<ITClass> iTClasses = new List<ITClass>()
            {
                new ITClass(){ Id = Guid.NewGuid().ToString(), Name ="K18", Quanity = 40, FacultyId = faculties[0].Id},
                new ITClass(){ Id = Guid.NewGuid().ToString(), Name ="K19", Quanity = 50, FacultyId = faculties[0].Id},
            };


            List<int> numbers = new List<int> { 4, 5, 73, 556, 57, 10, 5 };

            numbers = SortNumber(numbers);

        }
    }
}
