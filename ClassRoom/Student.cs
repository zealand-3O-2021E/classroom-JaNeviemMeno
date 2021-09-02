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
            _name = name;
            _birthDay = birthDay;
            _birthMonth = birthMonth;
        }

        public string Name
        { get;
            private set;
        }

        public int BirthMonth
        {
            get;
            private set;
        }

        public int BirthDay
        {
            get;
            private set;
        }

    }
}
