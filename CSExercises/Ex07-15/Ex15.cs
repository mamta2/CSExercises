namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            int a, r, sum = 0, i;
            Console.WriteLine("Enter a number:");
            a = int.Parse(Console.ReadLine());
            for (i = a; i > 0; i = i / 10)
            {
                r = i % 10;
                sum = sum + r * r * r;

            }
            if (sum == a)
            {
                Console.WriteLine("entered number is armstrong number.");

            }
            else
            {

                Console.WriteLine("Entered number is not armstrong number");
            }

            Console.ReadLine();   
        }
    }
}