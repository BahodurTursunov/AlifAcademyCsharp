using System.Collections;

namespace HW27_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class SimpleList : IList { 
        private readonly object[] contents = new object[8];

        private int count;

        public SimpleList()
        {
            count = 0;
        }

        #region IList Members

        /// <summary>
        /// Добавляет элемент в список IList
        /// </summary>
        /// <param name="value">Элемент который требуется поместить в коллекцию</param>
        /// <returns>Индекс элемента который помещен в коллекцию</returns>
        public int Add(object value)
        {
            if (count < contents.Length)
            {
                contents[count] = value;
                count++;
                return count - 1;
            }
            return - 1;
        }

        //Удаляет все элепменты из коллекции IList
        public void Clear()
        {
            count = 0;
        }

        // Определяет, содержится ли указанное значение в списке IList
        public bool Contains(object value)
        {
            return IndexOf(value) != -1;
        }

        // Определяет индекс заданного элемента в списке IList
        public int IndexOf(object value)
        {
            for (int i = 0; i < count; i++)
            {
                if (contents[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}