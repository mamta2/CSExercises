namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {

            //ex36a
            string s2 = "";
            string s2_reverse = "";
            Console.WriteLine("Plz enter a phrase");
            string s1 = Console.ReadLine();
            for (int i = 0; i < s1.Length; i++)
            {
                if ((s1[i] >= 'A' && s1[i] <= 'Z') || (s1[i] >= 'a' && s1[i] <= 'z') || (s1[i] >= 0 && s1[i] <= 9))
                    s2 = s2 + s1[i];

            }
            for (int j = s2.Length - 1; j >= 0; j--)
                s2_reverse += s2[j];

            if (s2_reverse.ToUpper() == s2.ToUpper())
                Console.WriteLine("This phrase is Palindrome:");
            else Console.WriteLine("This phrase is not Palindrome:");
            Console.ReadLine();
            
  
        }
    }
}
