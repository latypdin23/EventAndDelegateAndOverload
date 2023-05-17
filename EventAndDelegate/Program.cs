using EventAndDelegate.Model;
using System;

namespace EventAndDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExampleWithDelegate();
            ExampleWithEvents();
        }
        /// <summary>
        /// Возвращает значение операнда, увеличенное на 13 процентов
        /// </summary>
        /// <param name="aValue"></param>
        /// <returns></returns>
        public static double SomeOperation(double aValue)
        {
            return aValue * 1.13;
        }        
        static void ExampleWithDelegate()
        {
            //Создание коллекции
            DoubleCollection someCollection = new DoubleCollection();

            //Добавление в неё элементов
            someCollection.Add(124.4);
            someCollection.Add(120.8);
            someCollection.Add(118.1);
            someCollection.Add(128.9);
            someCollection.Add(111.3);

            //Создание делегата на основе метода SomeOperation и присваивание его коллекции
            someCollection.Operation = new DoubleOperation(SomeOperation);

            //Выполнение операции
            someCollection.DoOperation();

            //Вывод результата в консоль
            for (int i = 0; i < someCollection.Count; i++)
            {
                Console.WriteLine(someCollection[i]);
            }
        }
        static void ExampleWithEvents()
        {
            ClassCounter Counter = new ClassCounter();
            Handler_I Handler1 = new Handler_I();
            Handler_II Handler2 = new Handler_II();

            //Подписались на событие
            Counter.onCount += Handler1.Message;
            Counter.onCount += Handler2.Message;

            //Запустили счетчик
            Counter.Count();
        }
    }
}
