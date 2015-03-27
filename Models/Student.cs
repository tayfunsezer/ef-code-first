using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstSample.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime ? BirthDate { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}