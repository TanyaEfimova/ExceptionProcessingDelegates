using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception[] exceptions = new Exception[]
            {
                new MyException() { },
                new FormatException(){ },
                new ArgumentException(){ },
                new FieldAccessException(){ },
                new IndexOutOfRangeException(){ }
            };

            foreach (Exception _exception in exceptions)
            {
                try
                {
                    if (_exception is MyException) throw new MyException("Всё ок");
                    if (_exception is FormatException) throw new FormatException("Недопустимый формат");
                    if (_exception is ArgumentException) throw new ArgumentException("Значение не попадает в ожидаемый диапазон");
                    if (_exception is FieldAccessException) throw new FieldAccessException("Поле не доступно");
                    if (_exception is IndexOutOfRangeException) throw new IndexOutOfRangeException("Индекс находится за пределами границ массива или коллекции");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
