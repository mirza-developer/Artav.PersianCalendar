using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Artav.PersianCalendar.Logic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var calGen = new PersianCalendarGenerator();
            var cal = calGen.CreateYearCalendar(1398);
            Console.Read();
        }
    }
}
