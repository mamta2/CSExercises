namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            int num, sum = 0;
            Console.Write("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0 && i != num)
                {
                    sum = sum + i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine("\n Entered number is a Perfect Number");
            }
            else
            {
                Console.WriteLine("\n Entered number is not a Perfect Number");
            }
            Console.ReadLine();
        }
    }
}
