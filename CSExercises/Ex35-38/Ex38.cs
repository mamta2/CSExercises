namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[] name = { "john", "venkat", "Mary", "Victor", "Betty" };
            int[] marks = { 63, 29, 75, 82, 55 };
            string temp_n = "";
            int temp_m = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                for (int j = i + 1; j < marks.Length; j++)
                {
                    if (marks[i] < marks[j])
                    {
                        temp_m = marks[j];
                        marks[j] = marks[i];
                        marks[i] = temp_m;
                        temp_n = name[j];
                        name[j] = name[i];
                        name[i] = temp_n;

                    }
                }

            }
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i] + "\t" + name[i]);

            }

            for (int i = 0; i < name.Length; i++)
            {
                for (int j = i + 1; j < name.Length; j++)
                {
                    if (name[i].CompareTo(name[j]) < 0)
                    {
                        temp_n = name[j];
                        name[j] = name[i];
                        name[i] = temp_n;
                        temp_m = marks[j];
                        marks[j] = marks[i];
                        marks[i] = temp_m;
                    }
                }


            }
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i] + "\t" + marks[i]);

            }
            Console.ReadLine();
                      
            
        }
    }
}
