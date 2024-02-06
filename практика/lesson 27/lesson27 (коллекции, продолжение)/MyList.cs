using System.Collections;

namespace lesson27__коллекции__продолжение_
{
    public sealed class MyList<T> : IList<T>
    {
        private T[] _data = [];
        private int _actualCount = 0;
        private int _capacity = 0;
        private int _nextItemIdx = 0;
        public MyList()
        {
            _actualCount = 4;
            _data = new T[_capacity];
            _capacity = 0;
            _nextItemIdx = 0;
        }

        public MyList(int capacity) // capacity - вместительность
        {
            _capacity = capacity;
            _data = new T[_capacity];
            _actualCount = 0;
                
        }

        public T this[int index]
        {
            //get => _data[index];

            get
            {
                if (index > _data.Length - 1 || index < 0)
                    throw new IndexOutOfRangeException();
                return _data[index];
            }
            set
            {
                if (index > _data.Length - 1 || index < 0)
                    throw new IndexOutOfRangeException();
            }
        }

        public int Count => _actualCount;

        public int Capacity => _capacity;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            if(_actualCount == _capacity)
            {
                _capacity *= 2;
                ResizeArray(_capacity);
            }

            _data[_nextItemIdx] = item;
            _nextItemIdx++;
            _actualCount++;
        }

        private void ResizeArray(int capacity)
        {
            T[] newArray = new T[capacity];
            Array.Copy(_data, newArray, _actualCount);
            _data = newArray;
        }

        public void Clear()
        {
            _data = [];
            _actualCount = 0;
            _capacity = 0;
            _nextItemIdx = 0;
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _actualCount; i++)
            {
                yield return _data[i];
            }

        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
