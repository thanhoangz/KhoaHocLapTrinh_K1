using System;

namespace Lesson8A.Models
{
    public class ITClass
    {
        private string _id;
        private string _name;
        private int _quanity;
        private string _facultyId;

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public int Quanity { get => _quanity; set => _quanity = value; }
        public string FacultyId { get => _facultyId; set => _facultyId = value; }

        public ITClass(string name = "", int quanity = 0, string facultyId = "")
        {
            _id = Guid.NewGuid().ToString();
            _name = name;
            _quanity = quanity;
            _facultyId = facultyId;
        }
    }
}
