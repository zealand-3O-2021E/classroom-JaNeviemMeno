using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom Class = new ClassRoom();
            Class.ClassName = "Zealanders";
            Class.SemesterStart = DateTime.Now;
            Class.ClassList.Add(new Student("Adriana",9,8));
            Class.ClassList.Add(new Student("Nohely", 10, 5));
            Class.ClassList.Add(new Student("Niko", 3, 15));
            Class.ClassList.Add(new Student("Sarah", 1, 30));
        }
    }
}
