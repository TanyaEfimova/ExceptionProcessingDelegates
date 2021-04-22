using System;

namespace Task2
{
    class Program
    {


        static void Main(string[] args)
        {

            NumberReader numberReader = new NumberReader();
            numberReader.NumberEnteredEvent += SortFamilies;

            while (true)
            {
                try
                {
                    string[] families = new string[5] { "Сидоров", "Иванов", "Петров", "Макаров", "Никитин" };
                    numberReader.Read(families);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено некорректное значение");
                }
                finally
                {
                    Console.WriteLine("_____________________________________________________________________");
                }
            }
        }
        static void SortFamilies(int number, string[] families)
        {
            Console.WriteLine("Полученный список:");
            switch (number)
            {
                case 1:
                    Array.Sort(families);
                    break;
                case 2:
                    Array.Sort(families);
                    Array.Reverse(families);
                    break;
            }
            foreach (string item in families)
            {
                Console.WriteLine(item);
            }
        }

    }
}
