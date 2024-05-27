using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public class Student
    {
            public string Fullname;
            public int Age;
            public string University;
            public string Specialty;
            public int Course;
            public double AverageGrade;
            public bool Livedorm;
            public bool PaidFree;
            public bool Contract;
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

            public Student(string fullname, int age, string university, string specialty, int course, double averageGrade, bool livedorm, bool paidFree, bool contract)
            {
                Fullname = fullname;
                Age = age;
                University = university;
                Specialty = specialty;
                Course = course;
                AverageGrade = averageGrade;
                Livedorm = livedorm;
                PaidFree = paidFree;
                Contract = contract;
            }
        }
    }
