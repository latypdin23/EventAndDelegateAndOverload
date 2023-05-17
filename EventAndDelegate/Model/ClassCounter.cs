namespace EventAndDelegate.Model
{
    internal class ClassCounter  //Это класс - в котором производится счет.
    {
        public delegate void MethodContainer();

        /// <summary>
        /// Событие OnCount c типом делегата MethodContainer.
        /// </summary>
        public event MethodContainer onCount;
        /// <summary>
        /// Реакция на число 71
        /// </summary>
        public void Count()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 71)
                {
                    onCount();
                }
            }
        }
    }
}
