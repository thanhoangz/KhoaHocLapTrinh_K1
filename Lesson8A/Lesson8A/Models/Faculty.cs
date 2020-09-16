using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8A.Models
{
    public class Faculty
    {
        private string _id;
        private string _name;

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }

        public Faculty(string name = "")
        {
            _id = Guid.NewGuid().ToString();
            _name = name;
        }
    }
}
