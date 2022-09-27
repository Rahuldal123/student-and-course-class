using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp15
{
    public class Student
    {
        public string Studname { get; set; }
        public string City { get; set; }

    }
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }
        public Student[] Students { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Student[] stud1 = new Student[]
            {
                new Student {Studname="Rahul",City="pune"},
                new Student{Studname="Rohan",City="mumbai"}
            };
            Student[] stud2 = new Student[]
            {
                new Student{Studname="Mahesh",City="Kolhapur"},
                new Student{Studname="akash",City="sangali"},
                new Student{Studname="Rohit",City="Nagpur"}

            };
            Student[] stud3 = new Student[]
            {
                new Student {Studname="rakesh",City="Miraj"},
                new Student{Studname="Omkar",City="jalgaon"},
                new Student {Studname="ganesh",City="Amaravati"}

            };
            Course[]courses = new Course[]
            {
                new Course{Id =1,Name="c#",Fees=45000,Students=stud1},
                new Course{Id =2,Name="java",Fees=55000,Students=stud2},
                new Course{Id =3,Name="python",Fees=47000,Students=stud3}
            };
            foreach( Course c in courses)
            {
                Console.WriteLine($"{c.Id} {c.Name} {c.Fees}");
                foreach(Student s in c. Students)
                {
                    Console.WriteLine($"\t{s.Studname}->{s.City}");
                }
            }
        }
    }
}
