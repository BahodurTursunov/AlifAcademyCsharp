namespace lesson26_generic_обобщенность_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           
        }
    }

    public abstract class Fruit { }

    //public class Fruit { }
    public sealed class Apple : Fruit { }

    public sealed class Box<T> where T: Fruit
    {
        private T _item;

        public Box(T initialItem)
        {
            _item = initialItem;
        }

        public T GetItem()
        {
            Console.WriteLine("Получение: " + _item);
            return _item;
        }

        public void SetItem(T item)
        {
            Console.WriteLine("Установка: " + _item);
            _item = item;
        }
    }
}
