﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class Student
    {
        string Name { get; set; }
        string DateOfBirth { get; set; }

        List<Student> AllStudents = new List<Student>();

        public override string ToString()
        {
            return string.Format($"{Name} {DateOfBirth} {AllStudents}");
        }
    }
}
