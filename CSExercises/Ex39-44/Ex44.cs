namespace CSExercises
{
    public class Ex44
    {
        public static string Substitute(string s1, char c1, char c2)
        {

            string word = s1;
            //Console.WriteLine(c1);
            //Console.WriteLine(c2);               
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == c1)
                {
                    word = word.Substring(0, i) + Convert.ToString(c2) + word.Substring(i + 1, s1.Length - (i + 1));
                }
            }

            return word;
        }
    }
}
