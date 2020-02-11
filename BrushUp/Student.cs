using System;
using System.Text.RegularExpressions;

namespace BrushUp
{
    public class Student:Person, IStudent
    {
        private string _name;
        private string _address;
        private int _semester;
        private Person.gender _gender;

        public Student(string name, string address, int semester, Person.gender gender) : base(name, address, gender)
        {
            _name = name;
            _address = address;
            _semester = semester;
            _gender = gender;
        }

        /// <summary>
        /// Semester must is an int between 1 and 8
        /// </summary>
        public int Semester
        {
            get { return _semester; }
            set
            {
                if (1 >= value || value >= 8)
                {
                    throw new ArgumentOutOfRangeException("Semester",value,"Semester must be '1 <= semester <= 8'");
                }
                _semester = value;
            }
        }
    }
}
