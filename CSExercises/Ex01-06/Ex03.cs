using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            Double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("Squre of " + x + " is " + x * x);
            Console.ReadLine();   
        }
    }
}
