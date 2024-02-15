using System.Collections;
namespace HW27_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fibIterator = new FibonacciIterator(10);

            foreach (var item in fibIterator)
            {
                Console.WriteLine(item);
            }
        }

    }

    //// Класс FibonacciIterator реализует интерфейс IEnumerable<int>, что позволяет использовать его в цикле foreach для итерации по последовательности чисел Фибоначчи.
    public class FibonacciIterator : IEnumerable<int>
    {
        private int _count;

        // Конструктор класса, принимающий количество чисел Фибоначчи, которые нужно сгенерировать.
        public FibonacciIterator(int count)
        {
            _count = count;
        }

        // Метод GetEnumerator() возвращает объект IEnumerator<int>, который будет использоваться для итерации по последовательности чисел Фибоначчи.
        public IEnumerator<int> GetEnumerator()
        {
            int previous = 0; // Переменная для предыдущего числа в последовательности.
            int current = 1; // Переменная для текущего числа в последовательности.

            // Цикл, который будет проходить через count чисел в последовательности Фибоначчи.
            for (int i = 0; i < _count; i++)
            {
                yield return previous; // Возвращаем текущее число в последовательности.

                // Вычисляем следующее число Фибоначчи и обновляем переменные previous и current.
                int next = previous + current;
                previous = current;
                current = next;
            }
        }

        // Неявная реализация метода GetEnumerator() из интерфейса IEnumerable, возвращающая IEnumerator<int>.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
