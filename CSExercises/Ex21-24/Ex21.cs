namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int num;

            do
            {
                Console.WriteLine("Enter an integer number:");
                num = Convert.ToInt32(Console.ReadLine());
                if (num == 88)
                    Console.WriteLine("Lucky you...");
            } while (num == 88);
            
        }
    }
}
