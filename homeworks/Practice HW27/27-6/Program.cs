using System.Collections;
namespace _27_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyEnumerable myEnumerable = new(new int[] { 1, 2, 3, 4, 5, 6, 7 });

            foreach (var item in myEnumerable)
            {
                Console.WriteLine(item);
            }
        }
    }

    class MyEnumerable : IEnumerable<int>
    {
        private int[] _data;

        public MyEnumerable(int[] data)
        {
            _data = data;
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in _data)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
