using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet3que1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();
            Console.WriteLine("Enter the Course Name:");
            course.courseName = Console.ReadLine();
            Console.WriteLine("Enter the instructor's name:");
            course.instructorName=Console.ReadLine();
             
        }
    }

    internal class Course
    {
        private string courseName;
        private string instructorName;
        private int grade;

        public readonly string CourseName;
        public readonly string Grade;


        public void SetInstructorName(string instructorName)
        {
            if(instructorName!=null)
            {
                Console.WriteLine("Please Enter the name:");
            }
            this.instructorName = instructorName;
        }

        private void CalculateLetterGrade()
        {
            if(grade>=90)
            {
                Console.WriteLine("A");
            }

            else if (grade >= 80)
            {
                Console.WriteLine("B");
            }

            else if (grade >= 70)
            {
                Console.WriteLine("C");
            }

            else if (grade >= 60)
            {
                Console.WriteLine("D");
            }

            else if (grade >= 50)
            {
                Console.WriteLine("E");
            }

            else
            {
                Console.WriteLine("F");
            }
        }

        public void PrintCourseInfo()
        {  
           Console.WriteLine("Course Name:"+courseName);
           Console.WriteLine("Instructor Name:"+instructorName);
           Console.WriteLine("Grade: " + grade);
        }

       
    }
}
