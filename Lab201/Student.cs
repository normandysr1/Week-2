using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        private string Sname;
        private string Sid;
        private int Sage;
        private int Sbirth;
        private bool Sact;
        private int CurYear = DateTime.Now.Year;


        public Student()
        {
            this.Sname = "John Doe";
            this.Sid = "Unknow";
            this.Sact = true;
            this.Sage = CurYear - 1995;
        }

        public Student(string Name, string StudentID)
        {
            this.Sname = Name;
            this.Sid = StudentID;
            this.Sact = true;
            this.Sage = CurYear - 1995;
        }

        public Student(string Name, string StudentID, int YearOfBirth)
        {
            this.Sname = Name;
            this.Sid = StudentID;
            this.Sbirth = YearOfBirth;
            this.Sact = true;
            this.Sage = CurYear - YearOfBirth;
        }

        public Student(string Name, string StudentID, int YearOfBirth, bool isActive)
        {
            this.Sname = Name;
            this.Sid = StudentID;
            this.Sbirth = YearOfBirth;
            this.Sact = isActive;
            this.Sage = CurYear - YearOfBirth;
        }

        public string Name
        {
            get { return Sname; }
            set
            {
                Sname = value;
            }
        }

        public int YearOfBirth
        {
            get { return Sbirth; }
            set
            {
                int testAge = Sage;
                this.Sage = CurYear - value;
                if ((Sage >= 50) || (Sage <= 50))
                {
                    Console.WriteLine("{0}: error try setting invalid year-of-birth value!", this.Sid);
                    Sage = testAge;
                }


            }
        }

        public bool isActive
        {
            get { return Sact; }
            set
            {
                this.Sact = value;
            }
        }

        public int getAge(int Iage)     //sry not implement but usable...
        {

            int age = CurYear - Iage;
            return age;
        }

        public override string ToString()
        {
            if (Sact == true)
            {
                return "[Student: " + Sname + " (" + Sid + "), age=" + Sage + ", is active student]";
            }
            else
            {
                return "[Student: " + Sname + " (" + Sid + "), age=" + Sage + ", is NOT active student]";
            }
        }
    }
}
