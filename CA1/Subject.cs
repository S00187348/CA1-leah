using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    public abstract class Subject
    {
        public string Name { get; set; }
        public string Lecturer { get; set; }
        public int Year { get; set; }

        #region Constructors
        public Subject(string name, string lecturer, int year)
        {
             Name = name;
            Lecturer = lecturer;
            Year =year;

        }
        public Subject(string name, string lecturer,int year)
               : this(name, lecturer, year.now)
        {

        }
        #endregion Constructors

        public override string ToString()
        {
            return string.Format($"{Name} {Lecturer} {Year}");
        }

    }
}
