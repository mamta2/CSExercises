namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            double dblY = 0, dblTemp;

            //System.Console.WriteLine("\nY = 2X^2 - 4X + 3 \n\n");
            //System.Console.WriteLine("X\t\tY");
            //System.Console.WriteLine("---------------------");


            for (double dblX = -5; dblX <= 5; dblX++)
            {
                dblTemp = (dblX * dblX);
                dblY = ((2 * dblTemp) - (4 * dblX) + 3);

                for (double i = 1; i <= dblY; i++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
                //System.Console.WriteLine("{0:0.0##}\t\t{1:0.0##}",dblX,dblY);
            }
        }
    }
}
