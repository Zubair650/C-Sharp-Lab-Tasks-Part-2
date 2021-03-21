using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Many_to_Many
{
    class Course
    {
        string crName;
        string crID;
        string crCredit;

        private Student[] students;

        public void StudentNumber(params Student[] s)
        {
            foreach (Student s1 in s)
            {
                students[studentCount++] = s1;
                s1.Courses = this;
            }
        }

        public void PrintStudents()
        {
            for(int i=0; i < studentCount; i++)
            {
                students[i].ShowStudentInfo();
            }
        }

        private int studentCount;

        public int StudentCount
        {
            get { return studentCount; }
            set { studentCount = value; }
        }

        private Student student;

        public Student Student
        {
            get { return student; }
            set { student = value; }
        }
        public Course()
        {
            students = new Student[30];
        }
        public Course(string crName, string crID, string crCredit)
        {
            this.crName = crName;
            this.crID = crID;
            this.crCredit = crCredit;
            students = new Student[30];
            
        }

        public void showCourseInfo(/*string crName,string crID,string crCredit*/)
        {
            Console.WriteLine("Course Name: " + crName);
            Console.WriteLine("Course ID: " + crID);
            Console.WriteLine("Course Credit: " + crCredit);
        }
    }
}