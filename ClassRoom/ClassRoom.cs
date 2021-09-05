using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class ClassRoom
    {
        public string ClassName
        { get; set; }
        public DateTime SemesterStart
        {
            get;set;
        }
        public List<Student> ClassList
        {
            get;set;
        }
        public ClassRoom()
        {
            ClassList = new List<Student>();
        }
        public void SeasonCount()
        {
            var count = this.ClassList.GroupBy(s => s.Season(s.BirthMonth)).Select(group => new
            {
                Season = group.Key,
                Amount = group.Count()
            });
            foreach (var item in count)
            {
                Console.WriteLine($"Season {item.Season} has this many students {item.Amount}");
            }
        }
    }
}
