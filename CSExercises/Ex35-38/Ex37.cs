namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Plz enter a phrase:");
            string s = Console.ReadLine();
            string b = "";
            string c = "";
            string[] word = s.Split(new char[] { ' ' });
            for (int i = 0; i < word.Length; i++)
            {
                b = word[i].ToString().Substring(0, 1).ToUpper();
                word[i] = b + word[i].Substring(1, word[i].Length - 1) + " ";
                c = c + word[i];
            }

            Console.WriteLine(c);
            Console.ReadLine();

        }
    }
}
