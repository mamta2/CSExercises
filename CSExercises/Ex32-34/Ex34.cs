namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int overall = 0;
            int[,] student_marks = new int[,] {
                {56,84,68,29},
                {94,73,31,89},
                {41,63,36,90},
                {99,9,18,17},
                {62,3,65,75},
                {40,96,53,23},
                {81,15,27,30},
                {21,70,100,22},
                {88,50,13,12},
                {48,54,52,78},
                {64,71,67,25},
                {16,93,46,72}               
            };
            for (int i = 0; i < student_marks.GetLength(0); i++)
            {
                int total = 0;
                for (int j = 0; j < student_marks.GetLength(1); j++)
                {
                    total = total + student_marks[i, j];
                }
                Console.WriteLine("Total marks for student {0} is {1}", i + 1, total);
            }
            for (int x = 0; x < student_marks.GetLength(0); x++)
            {
                for (int y = 0; y < student_marks.GetLength(1); y++)
                {
                    overall = overall + student_marks[x, y];
                }
            }
            Console.WriteLine("The overall average is {0:0.00}",
                overall / (student_marks.GetLength(0) * student_marks.GetLength(1)));
            Console.ReadLine();
             
        }
    }
}
