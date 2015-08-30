//Natthapong Burakitphachai 570611011
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Course
    {

        private string CName;
        private string CID;
        private string CLec;
        private int CMax;
        private int Cnum;

        public Course()
        {
            Cnum = 0;
            CLec = "staff";
            CMax = 30;
        }

        public Course(string inName, string inID)
        {
            CName = inName;
            CID = inID;
            CLec = "staff";
            CMax = 30;
        }

        public Course(string inName, string inID, string inLec)
        {
            CName = inName;
            CID = inID;
            CLec = inLec;
            CMax = 30;
        }

        public Course(string inName, string inID, string inLec ,int inMax)
        {
            CLec = inLec;
            CName = inName;
            CID = inID;
            CMax = inMax;
        }

        public string Name
        {
            get { return CName; }
            set { CName = value; }
        }

        public string CourseID
        {
            get { return CID; }
            set
            {
                string temp = CID;
                CID = value;

                int n;
                bool isNumeric = int.TryParse(CID, out n);

                if ((CID.Length != 6) || isNumeric == false)
                {
                    CID = temp;
                    Console.WriteLine(CID + ": error try setting invalid CourseID!");    
                }
            }
        }

        public string Lecturer
        {
            get { return CLec; }
            set
            {
                CLec = value;
            }
        }
        public int NumStudents
        {
            get { return Cnum; }
            set
            {
                int temp = Cnum;
                Cnum = value;

                if ( (Cnum > CMax) || (Cnum < 0) )
                {
                    Console.WriteLine(CID + ": error try setting invalid No. Students!!");
                    Cnum = temp;
                }
            }
        }

        public int MaxStudents
        {
            get { return CMax; }
            set
            {
                int temp = CMax;
                CMax = value;

                if ( CMax < Cnum)
                {
                    Console.WriteLine(CID + ": error try setting invalid Max No. Students!");
                }
            }
        }

        public override string ToString()
        {
            return "[Course: " + Name + " (" + CID + "), Lecturer=" + CLec 
                    + ", has " + Cnum + " students, max=" + CMax + "]";
        }
    }

}
