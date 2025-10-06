namespace Task5
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            int[][] groups = new int[3][];
            Random rand = new Random();

            for (int i = 0; i < groups.Length; i++)
            {
                groups[i] = new int[rand.Next(10, 31)];
                for (int j = 0; j < groups[i].Length; j++)
                    groups[i][j] = rand.Next(50, 101);
            }

            PrintGroupStatistics(groups);
        }
        public static double GetAverage(int[] marks) => marks.Average();
        public static int GetMin(int[] marks) => marks.Min();
        public static int GetMax(int[] marks) => marks.Max();

        public static void PrintGroupStatistics(int[][] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                double avg = GetAverage(groups[i]);
                int min = GetMin(groups[i]);
                int max = GetMax(groups[i]);

                Console.WriteLine($"Група {i + 1}: Середній = {avg:F2}, Мінімальний = {min}, Максимальний = {max}");
            }
        }
    }

}