using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Double x;
            Double y;
            Console.WriteLine("Enter a double precision number:");
            x = Double.Parse(Console.ReadLine());
            y = Math.Sqrt(x);
            Console.WriteLine("Squre root of " + x + " is {1:####.###}", x, y);
            Console.ReadLine();
               
        }
    }
}
