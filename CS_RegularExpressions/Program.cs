/*
1. Написать приложение, проверяющее с помощью регулярного выражения корректность ввода фамилии и инициалов пользователя в следующем виде: Иванов И.И. либо Иванов ИИ
2. Написать приложение, проверяющее с помощью регулярного выражения корректность ввода адреса электронной почты. Адрес электронной почты должен иметь следующий вид: login@host, где login - последовательность из букв, цифр и символа "_", начинающаяся с буквы. Длина - от 3 до 16 символов. host - строка вида mail.ru или mail.odessa.ua и т.п. В конце host должен содержать от 2 до 3 символов (ua, com, net, ru и т.д.)
3. Написать приложение, проверяющее с помощью регулярного выражения корректность ввода даты в формате Число-Месяц-Год (например, 01-04-2015)
*/

using System.Text.RegularExpressions;

namespace Program
{
    class Task1
    {
        public void task()
        {
            try
            {
                Console.Write("\nВведите ФИО в формате Иванов И.И. : ");

                string input = Console.ReadLine();

                string pattern = @"^([А-Я])?$";

                    Regex regex = new Regex(pattern);

                if (regex.IsMatch(input))
                    Console.WriteLine("ФИО введены правильно!");
                else
                    Console.WriteLine("ФИО введены не правильно!");



            }
            catch (Exception)
            {

                throw;
            }

        }

    }

    class Task2
    {
        public void task()
        {
            try
            {
                Console.Write("\nВведите адрес электронной почты должен иметь следующий вид: login@host, где login - последовательность из букв, цифр и символа \"_\", начинающаяся с буквы. Длина - от 3 до 16 символов. host - строка вида mail.ru или mail.odessa.ua и т.п. В конце host должен содержать от 2 до 3 символов (ua, com, net, ru и т.д.) : ");

                string input = Console.ReadLine();

                string pattern = @"^([А-Я])?$";

                Regex regex = new Regex(pattern);

                if (regex.IsMatch(input))
                    Console.WriteLine("ФИО введены правильно!");
                else
                    Console.WriteLine("ФИО введены не правильно!");
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
    class Task3
    {
        public void task()
        {
            try
            {
                Console.Write("\nВвводите дату в формате Число-Месяц-Год (например, 01-04-2015) : ");

                string input = Console.ReadLine();

                string pattern = @"^(-|\+)?\d+(\.\d+)?$";

                Regex regex = new Regex(pattern);

                if (regex.IsMatch(input))
                    Console.WriteLine("ФИО введены правильно!");
                else
                    Console.WriteLine("ФИО введены не правильно!");
            }
            catch (Exception)
            {

                throw;
            }

        }

    }

    class MainClass
    {
        static void Main()
        {
            ConsoleKeyInfo answer;

            do
            {
                Console.Clear();

                Console.WriteLine("\nЗАДАНИЯ :" +
                    "\r\n\n1. Написать приложение, проверяющее с помощью регулярного выражения корректность ввода фамилии и инициалов пользователя в следующем виде: Иванов И.И. либо Иванов ИИ.\r\n\n2.Написать приложение, проверяющее с помощью регулярного выражения корректность ввода адреса электронной почты.Адрес электронной почты должен иметь следующий вид: login@host, где login - последовательность из букв, цифр и символа _, начинающаяся с буквы.Длина - от 3 до 16 символов.host - строка вида mail.ru или mail.odessa.ua и т.п.В конце host должен содержать от 2 до 3 символов(ua, com, net, ru и т.д.)\r\n\n3.Написать приложение, проверяющее с помощью регулярного выражения корректность ввода даты в формате Число - Месяц - Год(например, 01 - 04 - 2015)\r\n\n0. Выход");

                Console.Write("Введите номер задания: ");

                answer = Console.ReadKey();

                switch (answer.Key)
                {
                    case ConsoleKey.D1 :

                        Task1 obj1 = new Task1();

                        obj1.task();

                        break;

                    case ConsoleKey.D2 :

                        Console.WriteLine("\n2. Задание");

                        Task2 obj2 = new Task2();

                        obj2.task();

                        break;

                    case ConsoleKey.D3 :

                        Console.WriteLine("\n3. Задание");

                        Task3 obj3 = new Task3();

                        obj3.task();

                        break;

                    case ConsoleKey.D0 :

                        Console.WriteLine("\nДо встречи!");

                        return;

                    default:

                        Console.WriteLine("\nТакого задания нет!");

                        break;
                }
                Console.WriteLine("\nЕщё раз? y/n");

                answer = Console.ReadKey();

            } while (answer.Key == ConsoleKey.Y);


        }
    }


}