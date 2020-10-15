using System;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите строку");
                string message = Console.ReadLine();

                if (message.Length > 10)
                {
                    throw new Exception("Длина строки больше 10 символов");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Возникла ошибка:длина строки больше 10 символов");
            }
            finally
            {
                Console.WriteLine("Блок finally");
            }
            Console.WriteLine("Завершение программы");
            Console.Read();
        }
    }
}
