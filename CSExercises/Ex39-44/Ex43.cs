namespace CSExercises
{
    public class Ex43
    {
        public static void Main(string[] args)
        {

            for (int i = 1; i <= 100; i++)
            {

                string s = hex(i);
                Console.WriteLine(s);

            }
            Console.ReadLine();
        }

        public static string hex(int num)
        {
            int r = 0;
            string s = "";
            int div = 0;            
            while (num != 0)
            {
                div = num;
                num = div / 16;

                r = div % 16;
                if (r > 9)
                {
                    switch (r)
                    {
                        case 10: s = s + "A";
                            break;
                        case 11: s = s + "B";
                            break;
                        case 12: s = s + "C";
                            break;
                        case 13: s = s + "D";
                            break;
                        case 14: s = s + "E";
                            break;
                        case 15: s = s + "F";
                            break;
                        default: break;
                    }
                }
                else
                {                   
                    s =  Convert.ToString(r)+s;
                }

            }
            
            return s;
        }
    }
}
