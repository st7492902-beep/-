namespace Task2
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            int[] arr = GenerateRandomArray(10, 1, 100);
            Console.WriteLine("Масив: " + string.Join(", ", arr));
            Console.WriteLine("Сума = " + GetSum(arr));
            Console.WriteLine("Середнє = " + GetAverage(arr));
            Console.WriteLine("Мінімум = " + GetMin(arr));
            Console.WriteLine("Максимум = " + GetMax(arr));
        }
        private static Random rand = new Random();

        public static int[] GenerateRandomArray(int size, int min, int max)
        {
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
                arr[i] = rand.Next(min, max + 1);
            return arr;
        }

        public static int GetSum(int[] numbers) => numbers.Sum();
        public static double GetAverage(int[] numbers) => numbers.Average();
        public static int GetMin(int[] numbers) => numbers.Min();
        public static int GetMax(int[] numbers) => numbers.Max();
    }

}