using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть число: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMessage(number));

        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }


        public static string GetMessage(int number)
        {
            return IsEven(number)
                ? "Двері відкриваються!"
                : "Двері зачинені...";
        }

    }

}