using System;
using BrushUp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBrushUp
{
    [TestClass]
    public class TestStudent
    {
        private Student student;
        [TestInitialize]
        public void Init()
        {
            student = new Student("Jacob","Herlev",3,Person.gender.Male);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestName()
        {
            student.Name = "b  ";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddress()
        {
            student.Address = null;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSemester()
        {
            student.Semester = 0;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSemester2()
        {
            student.Semester = 9;
        }
    }
}
