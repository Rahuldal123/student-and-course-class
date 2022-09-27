using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{

    public abstract class Displaydeatials
    {
        public abstract string details();
    }
    public  class Course:Displaydeatials
    {
        public string coursename;
        public int fees;


        public Course(string coursename, int fees)
        {
            this.coursename = coursename;
            this.fees = fees;
        }

        public override string details()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Course name ={coursename},fees={fees}";
        }
    }
    public class Student : Displaydeatials
    {
        public int id;
        public string name;
        public string city;


        public Student(int id, string name, string city)
        {
            this.id = id;
            this.name = name;
            this.city = city;
        }

        public override string details()
        {
            throw new NotImplementedException();
        }

        public string displaydetails()
        {
            return $"student ID={id}, Name={name},City={city}";
        }





    }


}
