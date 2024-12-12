using System;
using Тумаков.Classes;
using System.IO;
using System.Net.NetworkInformation;
using System.Globalization;

namespace Тумаков
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
        public static void Task1()
        {
            /*В класс банковский счет, созданный в упражнениях 7.1- 7.3 добавить
            метод, который переводит деньги с одного счета на другой. У метода два параметра: ссылка
            на объект класса банковский счет откуда снимаются деньги, второй параметр – сумма*/
            Console.WriteLine("Упражнение 8.1");
            BankAccount account = new BankAccount(100, BankAccType.Текущий);
            BankAccount taker = new BankAccount(300, BankAccType.Текущий);

            //информация о счете
            account.Info();

            //пополнение счета
            account.Deposit(234);

            //снимаем денюжку
            account.Withdraw(10);

            //перевод с одного аккаунта на другой
            account.Transfer(taker, 50);

            //обновленная информация после операций
            account.Info();
            Console.ReadLine();
        }
        public static void Task2()
        {
            /*Реализовать метод, который в качестве входного параметра принимает
            строку string, возвращает строку типа string, буквы в которой идут в обратном порядке.
            Протестировать метод
           
            Я не совсем поняла, разворачивать нужно было ТОЛЬКО буквы или все символы
            Решила разворачивать все символы*/
            
            Console.WriteLine("Упражнение 8.2");

            ReverseString input = new ReverseString();
            string testString1 = "Колобок повесился";
            string reversedString1 = ReverseString.ReverseTheString(testString1);
            Console.WriteLine($"Введенная строка: {testString1}");
            Console.WriteLine($"Перевернутая строка: {reversedString1}");

            string testString2 = null;
            string reversedString2 = ReverseString.ReverseTheString(testString2);
            Console.WriteLine($"\nИсходная строка: {testString2}");
            Console.WriteLine($"Перевернутая строка: {reversedString2}");

            string testString3 = "Madam, I'm Adam!";
            string reversedString3 = ReverseString.ReverseTheString(testString3);
            Console.WriteLine($"\nИсходная строка: {testString3}");
            Console.WriteLine($"Перевернутая строка: {reversedString3}");

            string testString4 = "1 2 3 4 5 Вышел зайчик погулять";
            string reversedString4 = ReverseString.ReverseTheString(testString4);
            Console.WriteLine($"\nИсходная строка: {testString4}");
            Console.WriteLine($"Перевернутая строка: {reversedString4}");

            Console.ReadLine();
        }
        public static void Task3()
        {
            /*Написать программу, которая спрашивает у пользователя имя файла. Если
            такого файла не существует, то программа выдает пользователю сообщение и заканчивает
            работу, иначе в выходной файл записывается содержимое исходного файла, но заглавными
            буквами.*/
            Console.WriteLine("Упражнение 8.3");

            Console.WriteLine("Введите имя входного файла:");
            string inputFileName = Console.ReadLine();

            Console.WriteLine("Введите имя выходного файла:");
            string outputFileName = Console.ReadLine();

            Console.WriteLine($"Проверяемый путь: {inputFileName}");
            try
            {
                if (!File.Exists(inputFileName))
                {
                    Console.WriteLine($"Файл {inputFileName} не найден.");
                }

                long fileSize = new FileInfo(inputFileName).Length;
                if (fileSize == 0)
                {
                    Console.WriteLine("Файл пустой");
                }

                string fileContent = File.ReadAllText(inputFileName);
                string upperCaseContent = fileContent.ToUpper();
                File.WriteAllText(outputFileName, upperCaseContent);

                Console.WriteLine($"Содержимое файла {inputFileName} записано в файл {outputFileName} заглавными буквами");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
            
            Console.ReadLine();

        }
        public static void Task4()
        {
            /*Реализовать метод, который проверяет реализует ли входной параметр
            метода интерфейс System.IFormattable. Использовать оператор is и as*/
            Console.WriteLine("Упражнение 8.4");

            Formattable.IsIFormattable(1234.56);
            Formattable.CheckAndFormat(1234.56);

            Formattable.IsIFormattable("Hello, world!");
            Formattable.CheckAndFormat("Hello, world!");

            Formattable.IsIFormattable(DateTime.Now);
            Formattable.CheckAndFormat(DateTime.Now); 

            Console.ReadLine();
        }
    }
}
