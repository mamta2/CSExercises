namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            int num2, c = 0;
            Random numbernenerator = new Random();
            int num1 = numbernenerator.Next(0, 10);
            Console.WriteLine("guess a number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            while (num1 != num2)
            {
                Console.WriteLine(" your guess is not right " + num1);
                c = c + 1;
                Console.WriteLine("guess a number again :");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Congrats,your guess is correct " + num1);
            Console.WriteLine("it was ur {0} attempt", c = c + 1);
            switch (c)
            {
                case 1:
                    Console.WriteLine("Yor are wizard");
                    break;
                case 2:
                    Console.WriteLine("You are good guess");
                    break;
                case 5:
                    Console.WriteLine("Yor are lousy");
                    break;
                default:
                    Console.WriteLine("try again");
                    break;
            }
            Console.ReadLine();
        }
    }
}
