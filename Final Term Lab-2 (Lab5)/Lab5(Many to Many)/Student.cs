using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Many_to_Many
{
    class Student
    {
        string sName;
        string sID;
        string sCGPA;

        private Course[] course;

        public void CoursesTaken(params Course[] c)
        {
            foreach(Course c1 in c)
            {
                course[courseCount++] = c1;
                c1.Student = this;
                /*if(courseCount <= 5)
                {
                    Console.WriteLine("Number of Courses Taken: " + courseCount);
                }*/
            }
        }
        public void PrintCourses()
        {
            for (int i = 0; i < courseCount; i++)
            {
                course[i].showCourseInfo();
            }
        }
        private int courseCount;

        public int CourseCount
        {
            get { return courseCount; }
            set { courseCount = value; }
        }

        private Course courses;

        public Course Courses
        {
            get { return courses; }
            set { courses = value; }
        }
        
        public void Drop(int i)
        {
                for( i=i; i < courseCount+1; i++ )
                {
                    course[i] = course[i+1];
                    
                }
                for(i = 0; i< courseCount; i++)
                {
                course[i].showCourseInfo();
                }
                
        }

        public void Add(params Course[] course)
        {
            foreach (Course c2 in course)
            {
                course[courseCount++] = c2;
                c2.Student = this;
                for (int j = 0; j < courseCount; j++)
                {
                    course[j].showCourseInfo();
                }

            }
        }

        public Student() { course = new Course[5]; }

        public Student(string sName, string sID, string sCGPA)
        {
            this.sName = sName;
            this.sID = sID;
            this.sCGPA = sCGPA;
            course = new Course[5];

        }

        public void ShowStudentInfo()
        {
            Console.WriteLine("Student Name: " + sName);
            Console.WriteLine("Student ID: " + sID);
            Console.WriteLine("Student CGPA: " + sCGPA);
        }
    }
}