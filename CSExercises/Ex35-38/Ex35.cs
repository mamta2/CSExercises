namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            //ex35a

            int i = 0, count = 0;
            Console.WriteLine("Plz enter phrase:");
            string arr = Console.ReadLine();
            for (i = 0; i < arr.Length; i++)
            {
                switch (arr[i])
                {
                    case 'a': count++;
                        break;
                    case 'e': count++;
                        break;
                    case 'i': count++;
                        break;
                    case 'o': count++;
                        break;
                    case 'u': count++;
                        break;
                    default:
                        break;

                }

            }

            Console.WriteLine("total number of vowels : {0}", count);
            Console.ReadLine();


            /*

            //ex35b
            int i = 0;
            char[] vowel = { 'a', 'e', 'i', 'o', 'u' };
            int a1 = 0;
            int e1 = 0;
            int i1 = 0;
            int o1 = 0;
            int u1 = 0;
            
            Console.WriteLine("Plz enter phrase:");
            string arr = Console.ReadLine();
            for (i = 0; i < arr.Length; i++)
            {
                switch (arr[i])
                {
                    case 'a':a1++;                            
                        break;
                    case 'e': e1++;
                        break;
                    case 'i': i1++;
                        break;
                    case 'o': o1++;
                        break;
                    case 'u':u1++;
                        break;
                    default:
                        break;

                }

            }
            if(a1 > 0)
                Console.WriteLine("Number of a: {0}",a1);
            if (e1 > 0)
                Console.WriteLine("Number of e: {0}", e1);b
            if (i1 > 0)
                Console.WriteLine("Number of i: {0}", i1);
            if (o1 > 0)
                Console.WriteLine("Number of o: {0}", o1);
            if (u1 > 0)
                Console.WriteLine("Number of u: {0}", u1);
            Console.ReadLine();
              
              */
             
            
        }
    }
}
