using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var p1 = new Student("Sean","4124 Whirlwid Dr","Coding C#",2018,2.5000);
            var p2 = new Staff("Brian", "123 Fake St.", "Grand Circus", 50000);
           


            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());


        }
    }
}
