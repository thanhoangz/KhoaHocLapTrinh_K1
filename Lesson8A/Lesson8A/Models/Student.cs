using Lesson8A.Enums;
using System;
using System.Collections.Generic;

namespace Lesson8A.Models
{
    public class Student
    {
        private string _id;
        private string _name;
        private string _code;
        private SexEnum _sex;
        private string _address;
        private string _facultyId;
        private string _classId;
        private string _phone;
        private StatusEnum _statusEnum;

        private List<Score> _scores;
        
        public string Name { get => _name; set => _name = value; }
        public string Code { get => _code; set => _code = value; }
        public SexEnum Sex { get => _sex; set => _sex = value; }
        public string Address { get => _address; set => _address = value; }
        public string FacultyId { get => _facultyId; set => _facultyId = value; }
        public string ClassId { get => _classId; set => _classId = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public StatusEnum StatusEnum { get => _statusEnum; set => _statusEnum = value; }
        public string Id { get => _id; set => _id = value; }
        public List<Score> Scores { get => _scores; set => _scores = value; }

        public Student(string name = "", string code = "", SexEnum sex = SexEnum.None,
            string address = "", string facultyId = "", string classId = "",
            string phone = "", StatusEnum statusEnum = StatusEnum.Deactivated)
        {
            _id = Guid.NewGuid().ToString();
            _name = name;
            _code = code;
            _sex = sex;
            _address = address;
            _facultyId = facultyId;
            _classId = classId;
            _phone = phone;
            _statusEnum = statusEnum;
        }

        public void Input()
        {
            Console.Write("Name: ");
            _name = Console.ReadLine();

            Console.Write("Code: ");
            _code = Console.ReadLine();

            Console.Write("Phone: ");
            _phone = Console.ReadLine();

            Console.Write("Address: ");
            _address = Console.ReadLine();

            Console.Write("Faculty: ");
            _facultyId = Console.ReadLine();

            Console.Write("ITClass: ");
            _classId = Console.ReadLine();

            Console.Write("Sex: ");
            _sex = (SexEnum)int.Parse(Console.ReadLine());

            Console.Write("Sex: ");
            _statusEnum = (StatusEnum)int.Parse(Console.ReadLine());
        }

        public static List<int> SortNumber(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            return numbers;
        }

        public List<Student> SortByScore(List<Student> students, List<Score> scores)
        {
            // Tìm danh sách điểm của mỗi sinh viên và gắn giá trị 
            // vào danh sách điểm của sinh viên đó

            foreach (var student in students)
            {
                List<Score> scoresOfStudent = new List<Score>();

                foreach (var score in scores)
                {
                    if(student.Id == score.StudentId)
                    {
                        scoresOfStudent.Add(score);
                    }
                }

                student.Scores = scoresOfStudent;
            }

            // Sắp xếp
            for (int i = 0; i < students.Count - 1; i++)
            {
                for (int j = i + 1; j < students.Count; j++)
                {
                    double tb1 = 0;
                    foreach (var diem in students[i].Scores)
                    {
                        tb1 += diem.Z;
                    }

                    tb1 /= students[i].Scores.Count;

                    double tb2 = 0;
                    foreach (var diem in students[j].Scores)
                    {
                        tb2 += diem.Z;
                    }

                    tb2 /= students[j].Scores.Count;

                    // so sánh 2 điểm trung bình các môn của 2 sinh viên này

                    if (tb1 > tb2)
                    {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }

            return students;
        }
    }
}