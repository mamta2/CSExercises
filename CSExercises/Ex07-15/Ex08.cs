using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Double C;
            Double F;
            Console.WriteLine("Input temprature in Centigrade:");
            C = Double.Parse(Console.ReadLine());
            Console.WriteLine("Convert {0:##.##} from centigrade to fahrenheit:\n {1:##.##}", C, F = 1.8 * C + 32);
            Console.ReadLine();
        }
    }
}
