namespace CSExercises
{
    public class Ex39
    {
        public static long factorial(long n)
        {
            long fact = 1; // this  will be the result
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
