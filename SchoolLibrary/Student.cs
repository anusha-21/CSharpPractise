using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Student : Person
    {
        public enum GradeLevels { Ninth, Tenth, PlusOne, PlusTwo }
        public GradeLevels GradeLevel { get; set; }
    }
}
