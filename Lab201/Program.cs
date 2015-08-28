//Natthapong Burakitphachai 570611011 SEC003
//ขอโทษนะครับ แต่ commit ไฟล์ student.cs ไม่ได้เพราะอาจารย์ลบไปแล้ว เลยขอรวมโคดไว้ในนี้แทน
using System;

namespace Lab201
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* Testing the Student class */
			Student[] stds = new Student[7];
			stds[0] = new Student ();
			stds[1] = new Student ("s1","57001");
			stds[2] = new Student ("s2","57002",1994);
			stds[3] = new Student ("s3","57003",1996);
			stds[4] = new Student ("s4","57004");
			stds[5] = new Student ("s5","57005",1993);
			stds[6] = new Student ("s6","57006");

			Console.WriteLine ("\n--- Initial Students' state ---");
			foreach (Student s in stds)
				Console.WriteLine (s);

			Console.WriteLine ("\n--- Playing with s4, s5, s6 objects ---");
			stds [4].Name = "Mario";        
			stds [5].YearOfBirth = 1900;
			stds [6].isActive = false;
			for (int i = 4; i < stds.Length; i++)
				Console.WriteLine (stds [i]);

		}

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
}
