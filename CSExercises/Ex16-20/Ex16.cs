namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
             string name=Console.ReadLine();
             Console.WriteLine("Enter gender:");
             string gender=Console.ReadLine();

             if (gender == "M"||gender=="m")
             {
                 Console.WriteLine("Good Morning Mr." + name);
                 Console.ReadLine();
             }
             else

             {
                 if (gender == "F" || gender == "f")
                 {
                     Console.WriteLine("Good Morning Ms." + name);
                     Console.ReadLine();
                 }
                 else 
                 {

                     Console.WriteLine("Plz give gender ad 'm' or 'f' letter");
                     Console.ReadLine();
                 } 
            
        }
    }
}