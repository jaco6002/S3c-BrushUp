using System;
using System.Text.RegularExpressions;

namespace BrushUp
{
    public class Person
    {
        private string _name;
        private string _address;
        private gender _gender;

        public enum gender
        {
            Male,
            Female,
            Other
        }

        public Person(string name, string address, gender gender)
        {
            _name = name;
            _address = address;
            _gender = gender;
        }

        /// <summary>
        /// Name must be at least 2 charecters
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                value = Regex.Replace(value, " ", "");
                if (value.Length < 2)
                {
                    throw new ArgumentException("Name not long enough");
                }
                _name = value;
            }
        }

        /// <summary>
        /// address cant be null
        /// </summary>
        public string Address
        {
            get { return _address; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(Address, "Address is empty");
                }
                _address = value;
            }
        }

        /// <summary>
        /// must be male,female,
        /// </summary>
        public gender Gender { get; set; }

        public override string ToString()
        {
            return "name: " + Name + "\taddress: " + Address + "\tgender: " + Gender;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}