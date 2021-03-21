using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Many_to_Many
{
    class Program1
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Zubair", "101", "3.94");
            Student s2 = new Student("Sayem","102","3.44");
            Student s3 = new Student("Asif", "151", "3.5");
            Student s4 = new Student("Rakib", "201", "3.94");
            Student s5 = new Student("Sayemur", "12", "3.44");
            Student s6 = new Student("Akif", "11", "3.5");
            Student s7 = new Student("Naim", "10", "3.94");
            Student s8 = new Student("Saad", "2", "3.44");
            Student s9 = new Student("Tania", "15", "3.5");
            Student s10 = new Student("Rohan", "51", "3.94");
            Student s11 = new Student("Sayema", "302", "3.44");
            Student s12 = new Student("Asifur", "156", "3.5");

            Course c1 = new Course("OOP-2", "10256", "3");
            Course c2 = new Course("TOC", "14776", "3");
            Course c3 = new Course("SE", "10856", "3");
            Course c4 = new Course("English", "14786", "3");
            Course c5 = new Course("Physics-2", "21256", "3");
            Course c6 = new Course("Math", "189776", "3");


            /*s1.Courses = c3;
            c3.showCourseInfo();
            c3.StudentNumber(s1, s2, s5, s7);
            c3.PrintStudents();*/
            s1.ShowStudentInfo();
            s1.CoursesTaken(c1, c2, c5);
            s1.PrintCourses();
            Console.WriteLine("*********************");
            Console.WriteLine("After droping courses");
            s1.Drop(2);
            Console.WriteLine("After Adding courses");
            s1.Add(c3);


        }
    }
}
