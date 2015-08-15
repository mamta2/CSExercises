using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Double salary;
            Console.WriteLine("Enter Salary employee:");
            salary = Double.Parse(Console.ReadLine());
            Console.WriteLine("Total income is ${0:######.#0}", (salary + salary * 10 / 100 + salary * 3 / 100));
            Console.ReadLine();   
        }
    }
}
