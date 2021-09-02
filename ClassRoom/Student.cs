using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Student
    {
        private string _name;
        private int _birthMonth;
        private int _birthDay;

        public Student(string name, int birthMonth, int birthDay)
        {
            Name = name;
            BirthDay = birthDay;
            BirthMonth = birthMonth;
        }

        public string Name
        { get;
            private set;
        }

        public int BirthMonth
        {
            get { return _birthMonth; }
            private set {
                if (value < 1 || value > 12)
                    throw new ArgumentException("The month is out of range");
            }
        }

        public int BirthDay
        {
            get;
            private set;
        }
        public string Season(int birthMonth)
        {
            if (birthMonth == 12 || birthMonth == 1 || birthMonth == 2)
            {
                return "Winter";
            }
            else if (birthMonth == 3 || birthMonth == 4 || birthMonth == 5)
            {
                return "Spring";
            }
            else if (birthMonth == 6 || birthMonth == 7 || birthMonth == 8)
            {
                return "Summer";
            }
            else if (birthMonth == 9 || birthMonth == 10 || birthMonth == 11)
            {
                return "Autumn";
            }
            else return "invalid month";
        }
    }
}
