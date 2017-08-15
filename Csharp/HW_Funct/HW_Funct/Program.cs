using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_Funct
{
    class Program
    {
        static void Main(string[] args)
        {
            Student pesho =
               new Student("Petar", "Peshev", 23, "10111400", "02/943-48-06",
                   "pesho_picha@abv.bg", new List<int>() { 2, 5, 5, 6, 6, 6, 6 }, 2);
            Student gosho =
                new Student("Georgi", "Goshev", 19, "13118795", "+359887894568",
                    "gosho.goshev@gmail.com", new List<int>() { 2, 2, 2, 2, 2, 3, 4 },1);
            Student stoqn =
                new Student("Stoqn", "Stoqnev", 56, "10111234", "+359279542357",
                    "stoqncho@abv.bg", new List<int>() { 6, 6, 6, 6, 6, 6, 6 }, 3);
            Student angel =
                new Student("Acho", "Stoqnov", 20, "12119874", "+359987456987",
                    "achkata@abv.bg", new List<int>() { 6, 6, 4, 6, 4, 2, 3 }, 2);

            Student angelA =
                new Student("Acho", "Angelov", 18, "14124568", "+359789654123",
                    "angelcho@gmail.com", new List<int>() { 5, 2, 4, 6, 4, 2, 3 }, 1);
            Student viki=
                new Student("Viktor","Marinov",20,"101214106","+353123123121",
                    "viki.gea@abv.bg",new List<int>{6,6,6,6,6,6,6},2);
            Student johny=
                new Student("Johny","Kitaeca",38,"101214106","+353123133121",
                    "johny.china@abv.bg",new List<int>{6,6,6,6,6,6,6},1);


            List<Student> students = new List<Student>();
            students.Add(pesho);
            students.Add(stoqn);
            students.Add(gosho);
            students.Add(angel);
            students.Add(angelA);
            students.Add(viki);
            students.Add(johny);

            var studentsFrom2Group =
                from Student in students
                where Student.GroupNumber== 2
                orderby Student.FirstName
                select Student;

            Console.WriteLine("_04_Student by Group: Group 2 \n");
            foreach (Student someone in studentsFrom2Group)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} :{7}", someone.FirstName,someone.LastName,someone.Age,someone.FacultyNumber,
                    someone.Phone,someone.Email,string.Join(" ",someone.Marks),someone.GroupNumber);
            }
            Console.WriteLine();

            var studentsByNameAndLastName =
                from student in students
                orderby student.FirstName, student.LastName
                select student;

            Console.WriteLine("_05_Students by First and Last Name: -------------------> \n");
            foreach (var someone in studentsByNameAndLastName)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} :{7}", someone.FirstName, someone.LastName, someone.Age, someone.FacultyNumber,
                    someone.Phone, someone.Email, string.Join(" ", someone.Marks), someone.GroupNumber);
            }
            Console.WriteLine();

            var studentsByAge =
                from student in students
                where student.Age <= 24 && student.Age >= 18
                select student;

            Console.WriteLine("_06_Student by Age: ----------------------------> \n ");
            foreach (Student item in studentsByAge)
            {
                Console.WriteLine("Student: ({0} {1} {2})", item.FirstName, item.LastName,item.Age);
            }
            Console.WriteLine();


            Console.WriteLine("\n_07_Sort Students with LAMBDA: -------------------------------> \n");
            students.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.LastName).ToList().
                ForEach(s => Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} :{7}", s.FirstName, s.LastName, s.Age, s.FacultyNumber,
                    s.Phone, s.Email, string.Join(" ", s.Marks), s.GroupNumber));

            var studentsInDescendingOrder =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;
            Console.WriteLine();

            Console.WriteLine("_07_Sort Students with LINQ: -----------------------------------> \n");
            foreach (Student someone in studentsInDescendingOrder)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} :{7}", someone.FirstName, someone.LastName, someone.Age, someone.FacultyNumber,
                    someone.Phone, someone.Email, string.Join(" ", someone.Marks), someone.GroupNumber);
            }
            Console.WriteLine();

            var studentsByEmail =
                from student in students
                where student.Email.Contains("@abv.bg")
                select student;
            foreach (Student someone in studentsByEmail)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} :{7}", someone.FirstName, someone.LastName, someone.Age, someone.FacultyNumber,
                    someone.Phone, someone.Email, string.Join(" ", someone.Marks), someone.GroupNumber);
            }
            Console.WriteLine();

            Console.WriteLine("_09_Students by Phone: -------------------------------------> \n");

            var studentsByPhone =
                from student in students
                where student.Phone.StartsWith("02") || student.Phone.StartsWith("+3592") || student.Phone.StartsWith("+359 2")
                select student;
            foreach (Student someone in studentsByPhone)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} :{7}", someone.FirstName, someone.LastName, someone.Age, someone.FacultyNumber,
                    someone.Phone, someone.Email, string.Join(" ", someone.Marks), someone.GroupNumber);
            }
            Console.WriteLine();

            Console.WriteLine("_10_Excellent Students: --------------------------------> \n");

            var studentExcellent =
                from student in students
                where student.Marks.Contains(6)
                select student;
            foreach (Student someone in studentExcellent)
            {
                Console.WriteLine("{0} {1} {2} ", someone.FirstName, someone.LastName,string.Join(" ", someone.Marks));
            }
            Console.WriteLine();

            Console.WriteLine("_11_Weak Stuents: --------------------------------------> \n");


            var weakStudents =
                from student in students
                where student.Marks.Where(s => s == 2).Count() == 2
                select student;
            foreach (Student someone in weakStudents)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} :{7}", someone.FirstName, someone.LastName, someone.Age, someone.FacultyNumber,
                    someone.Phone, someone.Email, string.Join(" ", someone.Marks), someone.GroupNumber);
            }
            Console.WriteLine();

            Console.WriteLine("_12_Students Endrolled in 2014: ------------------------------------------> \n");

            students.Where(s => s.FacultyNumber.ToString().Trim().Contains("14"))
                .ToList().ForEach(s =>
                    Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} :{7}", s.FirstName, s.LastName, s.Age, s.FacultyNumber,
                    s.Phone, s.Email, string.Join(" ", s.Marks), s.GroupNumber));



        }
    }
}
