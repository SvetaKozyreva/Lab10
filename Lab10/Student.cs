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
            public int Course { get; set; }
            public double AverageGrade { get; set; }
            public bool Livedorm { get; set; }
            public bool PaidFree { get; set; }
            public bool Contract { get; set; }
            public List<int> Grades = new List<int>();

            public double Average()
            {
                /*int sum = 0;
                for (int i = 1; i <= Course; i++)
                {
                    int x;
                    do
                    {
                        Console.Write($"Ітогова оцінка по дисципліні No{i}(від 2 до 5): ");
                        x = int.Parse(Console.ReadLine());
                    } while (x < 2 || x > 5);
                    sum += x;
                    Grades.Add(x);
                }*/
                return Grades.Sum() / Course;
            }

            public Student()
            {

            }

            public Student(string fullname, int age, string university, string specialty, int course, bool livedorm, bool paidFree, bool contract)
            {
                Fullname = fullname;
                Age = age;
                University = university;
                Specialty = specialty;
                Course = course;
                Livedorm = livedorm;
                PaidFree = paidFree;
                Contract = contract;
            }
        }
    }
