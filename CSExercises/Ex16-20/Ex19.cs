namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Double distance_meter, distance, fare;
            Console.WriteLine("Enter the distance covered");
            distance = Convert.ToDouble(Console.ReadLine());
            distance_meter = distance * 1000;

            if (distance_meter < 500 && distance_meter > 0)
            {
                Console.WriteLine("Fare Charges are $2.40");
            }
            else
                if (distance_meter < 9000)
                {
                    fare = 2.40 + distance_meter * 0.0004;
                    Console.WriteLine("Fare Charges are ${0:0.00}", fare);

                }
                else
                    if (distance_meter > 9000)
                    {
                        fare = 2.40 + 8500 * 0.0004 + (distance_meter - 9000) * 0.0005;
                        Console.WriteLine("Fare Charges are ${0:0.00}", fare);

                    }
                    else
                        Console.WriteLine("Distance is not valid");


            Console.ReadLine();
        }
    }
}