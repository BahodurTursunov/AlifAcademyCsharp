namespace lesson26_generic_обобщенность_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Box<MyStruct> boxStruct = new(new MyStruct());  
        }
    }

    struct MyStruct
    {
        public int MyInt;
        public MyStruct()
        {
            MyInt = 100;
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
