namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            int TV_Q, DVD_Q, MP3_Q;
            Console.WriteLine("Enter quantity for Tv:");
            TV_Q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter quantity for DVD:");
            DVD_Q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter quantity for MP3:");
            MP3_Q = Convert.ToInt32(Console.ReadLine());

            int Tv_Dvd_TPrice = TV_Q * 900 + DVD_Q * 500;
            int MP3_TPrice = MP3_Q * 700;
            int tv_dvd_mp3_Tprice = Tv_Dvd_TPrice + MP3_TPrice;

            if (tv_dvd_mp3_Tprice > 10000)
            {
                tv_dvd_mp3_Tprice = MP3_TPrice + Tv_Dvd_TPrice - (Tv_Dvd_TPrice * 15) / 100;
                Console.WriteLine("1.Total order price is $ " + tv_dvd_mp3_Tprice);

            }
            else
                if (tv_dvd_mp3_Tprice > 5000)
                {
                    tv_dvd_mp3_Tprice = MP3_TPrice + Tv_Dvd_TPrice - (Tv_Dvd_TPrice * 10) / 100;
                    Console.WriteLine("2.Total order price is $ " + tv_dvd_mp3_Tprice);

                }
                else
                    if (tv_dvd_mp3_Tprice <= 5000)
                        Console.WriteLine("3.Total order price is $ " + tv_dvd_mp3_Tprice);

            Console.ReadLine(); 
        }
    }
}