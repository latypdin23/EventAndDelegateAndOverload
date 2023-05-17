using System.Collections.Generic;

namespace EventAndDelegate.Model
{
    delegate double DoubleOperation(double anAgr);
    internal class DoubleCollection
    {
        /// <summary>
        /// Хранилище элементов
        /// </summary>
        private List<double> collection = new List<double>();
        /// <summary>
        /// Делегат, для хранения ссылки на метод, который укажет пользователь класса
        /// </summary>
        private DoubleOperation operation = null;
        /// <summary>
        /// Добавляет элемент в коллекцию
        /// </summary>
        /// <param name="anItem"></param>
        public void Add(double anItem)
        {
            collection.Add(anItem);
        }
        /// <summary>
        /// Удаляет элемент из коллекции по заданному индексу
        /// </summary>
        /// <param name="anIndex"></param>
        public void RemoveAt(int anIndex)
        {
            collection.RemoveAt(anIndex);
        }
        /// <summary>
        /// Вызывает метод, на который ссылается делегат для всех элементов коллекции
        /// </summary>
        public void DoOperation()
        {
            //Если делегат задан
            if (operation != null)
            {
                //Перебрать все элементы коллекции
                for (int i = 0; i < collection.Count; i++)
                {
                    //Выполнить операцию над текущим элементом
                    collection[i] = operation(collection[i]);
                }
            }
        }
        /// <summary>
        /// Устанавливает или возвращает значение делегата
        /// </summary>
        public DoubleOperation Operation
        {
            get { return operation; }
            set { operation = value; }
        }
        /// <summary>
        /// возвращает или устанавливает значение элемента по индексу
        /// </summary>
        /// <param name="anIndex"></param>
        /// <returns></returns>
        public double this[int anIndex]
        {
            get { return collection[anIndex]; }
            set { collection[anIndex] = value; }
        }
        /// <summary>
        /// Возвращает количество элементов
        /// </summary>
        public int Count
        {
            get
            {
                return collection.Count;
            }
        }


    }
}
