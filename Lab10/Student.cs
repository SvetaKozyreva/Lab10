using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public class Student
    {
            public string Fullname { get; set; }
            public int Age { get; set; }
            public string University { get; set; }
            public string Specialty { get; set; }
            public double AverageGrade { get; set; }
            public int Course { get; set; }
            public bool Livedorm { get; set; }
            public bool PaidFree { get; set; }
            public bool Contract { get; set; }
            public List<int> Grades { get; private set; } = new List<int>();

            public double Average()
            {
                return Math.Round(Grades.Sum() / (double)Course);
            }

            public Student()
            {

            }

            public Student(string fullname, int age, string university, string specialty, int course, bool livedorm, bool paidFree, bool contract, double average)
            {
                Fullname = fullname;
                Age = age;
                University = university;
                Specialty = specialty;
                Course = course;
                Livedorm = livedorm;
                PaidFree = paidFree;
                Contract = contract;
                AverageGrade = average;
            }
        }
    }
