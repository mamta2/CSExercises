namespace CSExercises
{
    public class Ex46
    {
        static void Main(string[] args)
        {

            int[] arr = new int[10];

            for (int i = 0; i < 50; i++)
            {
                Random r = new Random();
                int x = r.Next(0, 10);
                Console.WriteLine(x);

                switch (x)
                {
                    case 0: arr[0] = 1 + arr[0];
                        break;
                    case 1: arr[1] = 1 + arr[1];
                        break;
                    case 2: arr[2] = 1 + arr[2];
                        break;
                    case 3: arr[3] = 1 + arr[3];
                        break;
                    case 4: arr[4] = 1 + arr[4];
                        break;
                    case 5: arr[5] = 1 + arr[5];
                        break;
                    case 6: arr[6] = 1 + arr[6];
                        break;
                    case 7: arr[7] = 1 + arr[7];
                        break;
                    case 8: arr[8] = 1 + arr[8];
                        break;
                    case 9: arr[9] = 1 + arr[9];
                        break;
                    default: break;

                }

            }
            Console.WriteLine("Number".PadRight(15, ' ') + "Occurence".PadRight(6, ' '));
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}".PadRight(15, ' ') + "\t" + "{1}".PadRight(6, ' '), i, arr[i]);

            }

            Console.WriteLine("\n\n");
            Console.WriteLine("Number".PadRight(15, ' '));
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}".PadRight(15, ' ') + "\t" + "".PadRight(arr[i], '*'), i, arr[i]);

            }
            Console.ReadLine();
        }
    }
}
