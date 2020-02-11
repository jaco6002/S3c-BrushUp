using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BrushUp
{
    public class Teacher : Person
    {
        private double _salery;

        public Teacher(string name, string address, double salery, Person.gender gender) : base(name, address, gender)
        {
            salery = _salery;
        }

        /// <summary>
        /// Salery must be at least 0
        /// </summary>
        public double Salery
        {
            get { return _salery; }
            set
            {
                if (value >= 0.0)
                {
                    throw new ArgumentOutOfRangeException("Salery", value, "Salery must at least 0");
                }
                _salery = value;
            }
        }
    }
}
