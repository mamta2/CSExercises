namespace CSExercises
{
    public class Ex42
    {
        public static void Main(string[] args)
        {
            string phrase = "My name is mamta";
            string token = "is";
            Console.WriteLine("the matching position is {0}", findSubStr(phrase, token));
            Console.ReadLine();

        }
        public static int findSubStr(string phrase, string token)
        {
            int x = 0;
            int matchpoint = 0;
            int match = 0;
            for (int i = 0; i < phrase.Length; i++)
            {
                ++x;
                for (int j = matchpoint; j < token.Length; j++)
                {
                    if (token[j] != phrase[i])
                    {
                        matchpoint = 0;
                        match = 0;
                        break;
                    }
                    else
                    {
                        matchpoint = j + 1;
                        match++;
                        break;
                    }


                }
                if (token.Length == match)
                {
                    x = x - match;
                    //Console.WriteLine(i);
                    break;
                }
            } if (match == 0)
            {
                return -1;

            }
            else
                if (token.Length == match) ;

            return x;

        }
    }
}




