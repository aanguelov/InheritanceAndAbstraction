using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HumanStudentAndWorker
{
    class Student : Human
    {
        public Student(string firstName, string lastName, int facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public int FacultyNumber { get; set; }

        //public int CompareTo(Student other)
        //{
        //    return this.FacultyNumber.CompareTo(other.FacultyNumber);
        //}

        public override string ToString()
        {
            return string.Format("Name: {0} {1}, Faculty No: {2}", this.FirstName, this.LastName, this.FacultyNumber);
        }
    }
}
