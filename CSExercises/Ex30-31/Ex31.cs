namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            int num, sum = 0;
            for (num = 1; num <= 1000; num++)
            {
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0 && i != num)
                    {
                        sum = sum + i;

                    }
                }

                if (sum == num)
                {
                    Console.WriteLine("\n {0} number is a Perfect Number", num);
                }
                sum = 0;
            }
            Console.ReadLine();
        }
    }
}
