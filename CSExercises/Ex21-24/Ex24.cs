namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Random numbergenerater = new Random();
            int num = numbergenerater.Next(1, 100);
            start:
            Console.WriteLine("Enter a guess number:");
            double guess = Convert.ToDouble(Console.ReadLine());
            if (num == guess * guess)
            {
                Console.WriteLine("guess number is square root of the {0}", num);

            }
            else
                guess = (guess + (num / guess)) / 2;
                Console.WriteLine("approx. square root is {0:0.000}", guess);

            Console.WriteLine("random number is {0}", num);
            goto start;
        }
    }
}
