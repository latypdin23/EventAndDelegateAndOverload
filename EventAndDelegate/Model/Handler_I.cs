using System;

namespace EventAndDelegate.Model
{
    internal class Handler_I //Это класс, реагирующий на событие (счет равен 71) записью строки в консоли.
    {
        /// <summary>
        /// Вывод сообщения на экран
        /// </summary>
        public void Message()
        {
            Console.WriteLine("Пора действовать, ведь уже 71!");
        }
    }
}
