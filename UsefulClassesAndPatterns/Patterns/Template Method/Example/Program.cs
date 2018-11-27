using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Template_Method.Example
{
    class Program
    {
        void Main()
        {
            School school = new School();
            University university = new University();

            school.Learn();
            university.Learn();


            AbstractEducation education = school;
            education.Learn();
            education = university;
            education.Learn();
        }
    }
}
