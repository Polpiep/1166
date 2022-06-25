using System;

namespace _1166
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Здравствуйте. Я - Олег. Программа которая находит цифру, на которую оканчивается число A^B. Внимание! Программа не может обработать результат, если он написан с использованием не целых чисел и/или в буквенном виде. Исключительно цифры");
                Console.WriteLine("Введите число A");
                double a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число B");
                double b = Convert.ToInt32(Console.ReadLine());
                int d = (int)Math.Pow(a, b);

                Console.WriteLine("Результат: ");
                Console.WriteLine(d);

                int c = (d) % 10;
                Console.WriteLine("Ответ: ");
                Console.WriteLine(c);
            }
        }
    }
}
