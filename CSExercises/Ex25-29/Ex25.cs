namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            int num,i,fact=1;
             Console.WriteLine("plz enter positive integer number:");
             num = Convert.ToInt32(Console.ReadLine());
             for (i = 1; i <= num; i++)
             {
                 fact = fact * i;
             
             }
             Console.WriteLine("Factorial of {0} is {1}", num, fact);
             Console.ReadLine();
            
            /*
            
             //ex25b
            int num, i, fact = 1;
            Console.WriteLine("plz enter positive integer number:");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = num; i>=1; i--)
            {
                fact = fact * i;

            }
            Console.WriteLine("Factorial of {0} is {1}", num, fact);
            Console.ReadLine();
            
            */
        }
    }
}
