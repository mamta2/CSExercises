namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            int x, y;
            for (x = -4; x < 5; x++)
            {
                y = 2 * x * x - 4 * x + 3;
                Console.WriteLine("value of y for {0} is {1} ", x, y);
            }
            Console.ReadLine();
        }
    }
}
