namespace CSExercises
{
    public class Ex41
    {
        public static void Main(string[] args)
        {
            string phrase = "Ramo ro rhi hai";
            string token = "rami";
            Console.WriteLine(InString(phrase, token));
            Console.ReadLine();
        }

        public static bool InString(string phrase, string token)
        {       
       
        int matchPointInPhrase=0;
        int resetToken=0;
        int match=0;

    startOver:
        for (int i = resetToken; i < token.Length; i++ )
        {
            for (int j = matchPointInPhrase; j < phrase.Length; j++)
            {
                if (token[i] == phrase[j])
                {
                    match++;
                    matchPointInPhrase = ++j;
                    break;
                }else{
                    if(match>0){
                        resetToken=0;
                        matchPointInPhrase=j++;
                        match=0;
                        goto startOver;
                    }else{
                        continue;
                    }
                
                }

            }
        }

            if (match==token.Length)
                return true ;
            else
            return false;

        }
    }
}
