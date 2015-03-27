﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstSample.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}