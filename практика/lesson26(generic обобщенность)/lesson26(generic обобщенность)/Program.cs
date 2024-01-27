namespace lesson26_generic_обобщенность_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<int> intBox = new(123);
            Box<string> stringBox = new(""); // Здесь мы задавать тип стринг не можем потому что string это класс, а у нас стоит ограничение 
        }
    }

    public sealed class Box<T> where T: struct 
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
