namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            
            int coin = 0;

            Console.WriteLine("Enter the amount:");            
            int amount = Convert.ToInt32(Console.ReadLine());
            if (amount >= 100)
            {

                coin = amount / 100;
                amount = amount % 100;
                for(int i=1;i<=coin;i++){
                 Console.WriteLine("100c");
                } 
            } 
            if(amount>=50)
            {
            coin=amount/50;
            amount=amount%50;
            for (int i = 1; i <= coin; i++)
            {
                Console.WriteLine("50c");
            }

            }
            if (amount >= 20) {

                coin = amount / 20;
                amount = amount % 20;
                for (int i = 1; i <= coin; i++)
                {
                    Console.WriteLine("20c");
                }

            } 
            if (amount >= 10)
            {
                coin = amount / 10;
                amount = amount %10;
                for (int i = 1; i <= coin; i++)
                {
                    Console.WriteLine("10c");
                }

            } 
            if (amount >= 5)
            {
                coin = amount / 5;
                amount = amount % 5;
                for (int i = 1; i <= coin; i++)
                {
                    Console.WriteLine("5c");
                }
                
            }
          Console.ReadLine();
       
        }
    }
}
