namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            int age;
            string gender;
            string name;

            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter gender:");
            gender = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            age = Convert.ToInt32(Console.ReadLine());

            if (gender == "M" || gender == "m")
            {
                if (age >= 40)
                {
                    Console.WriteLine("Good Morning Uncle " + name);
                }
                else
                {

                    Console.WriteLine("Good Morning Mr." + name);
                }
            }
            else
            {
                if (gender == "F" || gender == "f")
                {
                    if (age >= 40)
                    {
                        Console.WriteLine("Good Morning Aunty " + name);
                        // Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Good Morning Ms." + name);
                        // Console.ReadLine();
                    }
                }
                else
                {

                    Console.WriteLine("Plz give gender ad 'm' or 'f' letter");
                    //Console.ReadLine();
                }

            }
            Console.ReadLine();
        }
    }
}