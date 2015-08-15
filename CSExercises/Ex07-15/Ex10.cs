using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Double x1, x2, y1, y2, result;
            Console.WriteLine("enter four numbers :");
            x1 = Double.Parse(Console.ReadLine());
            y1 = Double.Parse(Console.ReadLine());
            x2 = Double.Parse(Console.ReadLine());
            y2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Distance between ({0},{2}) and ({1},{3}) is {4:.##} ", x1, x2, y1, y2, result = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1))));
            Console.ReadLine();
                 
        }
    }
}
