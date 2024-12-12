
using System;

namespace Тумаков.Classes
{
    internal class Formattable
    {
        public static bool IsIFormattable(object obj)
        {
            //юзаем is
            if (obj is IFormattable)
            {
                Console.WriteLine("\nОбъект реалезует IFormattable");
                return true;
            }
            else
            {
                Console.WriteLine("\nОбъект не реалезует IFormattable");
                return false;
            }
        }

        public static void CheckAndFormat(object obj)
        {
            //юзаем as
            IFormattable formattableObj = obj as IFormattable;

            if (formattableObj != null)
            {
                Console.WriteLine("Объект реалезует IFormattable");
                try
                {
                    string formattedValue = formattableObj.ToString("C", null);
                    Console.WriteLine($"Отформатированное значение: {formattedValue}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Произошла ошибка: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("\nОбъект не реализует IFormattable");
            }

        }



    }
}
