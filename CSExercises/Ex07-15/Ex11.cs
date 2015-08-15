using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            Double d;
            Console.WriteLine("Enter Distance Covered:");
            d = Double.Parse(Console.ReadLine());
            Console.WriteLine("total fare of {0} kilometers is  ${1:.##} ", d, 2.40 + d * 0.40);
            Console.ReadLine();   
        }
    }
}
