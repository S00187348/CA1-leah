using System;
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

        List<Subject> AllSubjects = new List<Subject>();

    }
}
