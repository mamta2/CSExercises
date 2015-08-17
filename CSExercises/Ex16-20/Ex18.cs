namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Double marks;
            Console.WriteLine("Plz enter your marks:");
            marks = Convert.ToDouble(Console.ReadLine());


            if (marks >= 80 && marks <= 100)
                Console.WriteLine("You scored {0} marks which is A grade", marks);
            else
                if (marks >= 60 && marks <= 79)
                    Console.WriteLine("You scored {0} marks which is B grade", marks);
                else
                    if (marks >= 40 && marks <= 59)
                        Console.WriteLine("You scored {0} marks which is C grade", marks);
                    else
                        if (marks >= 0 && marks <= 40)
                            Console.WriteLine("You scored {0} marks which is F grade", marks);
                        else
                            if (marks < 0 || marks > 100)
                                Console.WriteLine("**Error**");

            Console.ReadLine();
        }
    }
}