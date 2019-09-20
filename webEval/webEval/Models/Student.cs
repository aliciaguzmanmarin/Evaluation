using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webEval.Models
{
    public class Student
    {
        [key]
        public int StudentID { get; set; }
        [required]
        public string Name { get; set; }
        [required]
        public string gender { get; set; }
        [required]
        public string Birthday { get; set; }
    }
}