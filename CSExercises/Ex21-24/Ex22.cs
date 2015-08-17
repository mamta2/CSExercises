namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int a, b;
            int maxVal, minVal;
            Console.WriteLine("Enter A:");
            maxVal = Convert.ToInt32(Console.ReadLine());
            a = maxVal;
            Console.WriteLine("Enter B:");
            minVal = Convert.ToInt32(Console.ReadLine());
            b = minVal;

            while (maxVal != minVal)
            {
                maxVal = Math.Max(maxVal, minVal);
                minVal = Math.Min(maxVal, minVal);
                maxVal = maxVal - minVal;

            }

            Console.WriteLine("HCF:" + maxVal);
            Console.WriteLine("LCM:{0}", (a * b) / maxVal);
            Console.ReadLine();
        }
    }
}
