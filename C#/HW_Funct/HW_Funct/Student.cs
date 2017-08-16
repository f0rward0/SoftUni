using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW_Funct
{
    class Student
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string FacultyNumber;
        public string Phone;
        public string Email;
        public List<int> Marks;
        public int GroupNumber;

        public Student(string FN,string LN,int AGE,string FNumber,string PhoneN,string EMAIL,List<int> MARKS,int GroupNumber)
        {
            this.FirstName=FN;
            this.LastName=LN;
            this.Age=AGE;
            this.FacultyNumber = FNumber;
            this.Phone = PhoneN;
            this.Email = EMAIL;
            this.Marks = MARKS;
            this.GroupNumber = GroupNumber;
        }
    }
}
