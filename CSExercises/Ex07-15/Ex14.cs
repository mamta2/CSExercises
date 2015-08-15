namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Double x, y, z, s;
            Console.WriteLine("Enter three sides length of triangle:");
            x = Double.Parse(Console.ReadLine());
            y = Double.Parse(Console.ReadLine());
            z = Double.Parse(Console.ReadLine());
            s = (x + y + z) / 2;
            Console.WriteLine("Area of triangle is {0:.##}", Math.Sqrt(s * (s - x) * (s - y) * (s - z)));
            Console.ReadLine(); 
                
        }
    }
}