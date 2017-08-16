using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_FunctionalProgramming

{
    public class Student
    {
        string FirstName;
        string LastName;
        int Age;
        string FacultyNumber;
        string Phone;
        List<int> Marks;
        int Group;
    }
    class Program
    {
        static void Main()
        {
            


            List<Student> students = new List<Student>();
            students.Add(pesho);
            students.Add(stoqn);
            students.Add(gosho);
            students.Add(angel);
            students.Add(angelA);
            students.Add(viki);

            var studentsFrom2Group =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            Console.WriteLine("_04_Student by Group: ----------------------------> \n");
            foreach (var item in studentsFrom2Group)
            {
                Console.WriteLine(item);
            }

        }
    }
}
