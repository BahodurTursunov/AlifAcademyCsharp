namespace lesson26_generic_обобщенность_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<string> box = new("Apple");
            string item = box.GetItem();
            Console.WriteLine(item);

            Box<int> boxNumber = new(123);
            boxNumber.SetItem(32);
            int number = boxNumber.GetItem();
            Console.WriteLine(number);
        }
    }

    public sealed class Box<T>
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
