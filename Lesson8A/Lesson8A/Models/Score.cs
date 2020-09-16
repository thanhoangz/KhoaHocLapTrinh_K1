using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8A.Models
{
    public class Score
    {
        private string _id;
        private string _studentId;
        private double _x;
        private double _y;
        private double _z;

        public string Id { get => _id; set => _id = value; }
        public string StudentId { get => _studentId; set => _studentId = value; }
        public double X { get => _x; set => _x = value; }
        public double Y { get => _y; set => _y = value; }
        public double Z { get => _z; set => _z = value; }

        public Score(string studentId = "", double x = 0, double y = 0, double z = 0)
        {
            _id = Guid.NewGuid().ToString();
            _studentId = studentId;
            _x = x;
            _y = y;
            _z = z;
        }
    }
}
