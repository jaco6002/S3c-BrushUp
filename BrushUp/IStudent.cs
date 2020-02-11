namespace BrushUp
{
    public interface IStudent
    {
        /// <summary>
        /// Semester must is an int between 1 and 8
        /// </summary>
        int Semester { get; set; }

        /// <summary>
        /// Name must be at least 2 charecters
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// address cant be null
        /// </summary>
        string Address { get; set; }

        /// <summary>
        /// must be male,female,
        /// </summary>
        Person.gender Gender { get; set; }

        string ToString();
        bool Equals(object obj);
        int GetHashCode();
    }
}