using System;

namespace Task2
{
    class NumberReader
    {
        public delegate void NumberEnteredDelegate(int number, string[] array);
        public event NumberEnteredDelegate NumberEnteredEvent;

        public void Read(string[] array)
        {
            Console.WriteLine();
            Console.WriteLine("Для сортировки списка фамилий:");

            foreach (string item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("необходимо ввести значение: либо 1(сортировка А-Я), либо 2(сортировка Я-А)");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number != 1 && number != 2) throw new FormatException();

            NumberEntered(number, array);
        }

        protected virtual void NumberEntered(int number, string[] array)
        {
            NumberEnteredEvent?.Invoke(number, array);
        }
    }
}
