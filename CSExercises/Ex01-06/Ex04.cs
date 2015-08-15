using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a double precision number:");
            Double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("Squre root of " + x + " is " + Math.Sqrt(x));
            Console.ReadLine();   
        }
    }
}
