namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] a = { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };
            int i, j;
            for (i = 0; i < a.Length; i++)
            {
                for (j = 0; j < a.Length; j++)
                {
                    if (a[j] > a[i])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }

            }
            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }
    }
}
