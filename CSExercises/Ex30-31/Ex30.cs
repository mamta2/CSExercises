namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            int num, k = 0;
            for (num = 5; num <= 10000; num++)
            {
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        k++;
                    }
                }
                if (k == 2)
                {
                    Console.WriteLine("{0} is a Prime Number", num);
                }
                k = 0;
            }
            Console.ReadLine();
        }
    }
}
