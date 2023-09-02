namespace Problem01.List
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MyList<T> : IAbstractList<T>
    {
        private const int DEFAULT_CAPACITY = 4;
        private T[] items;

        public MyList()
            : this(DEFAULT_CAPACITY) {
        }

        public MyList(int capacity)
        {
            if (capacity < 0)
            { 
            throw new ArgumentOutOfRangeException(nameof(capacity));
            }

            items = new T[capacity];
        }

        public T this[int index] 
        {
            get
            { 
                this.ValidateIndex(index);
                return items[index];
            }
            set
            {
                this.ValidateIndex(index);
                this.items[index] = value;
            }        
        }

        public int Count { get; private set; }

        public void Add(T item)
        {
            this.GrowIfNecessary();
            this.items[this.Count++] = item;
        }

        private void GrowIfNecessary()
        {
            if (this.Count == this.items.Length)
            {
                this.items = this.Grow();
            }
        }

        private T[] Grow()
        {
            var newArr = new T[this.Count * 2];
            Array.Copy(this.items, newArr, this.items.Length);
            return newArr;
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
        }

        public bool Contains(T item)
        {
            if (this.IndexOf(item) == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.items[i];
            }
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.items[i]!.Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Insert(int index, T item)
        {
            this.ValidateIndex(index);
            this.GrowIfNecessary();

            for (int i = this.Count; i > index; i--)
            {
                this.items[i] = this.items[i - 1];
            }

            this.items[index] = item;
            this.Count++;
        }

        public bool Remove(T item)
        {
            int index = this.IndexOf(item);

            if (index == -1)
            {
                return false;
            }

            this.RemoveAt(index);

            return true;
        }

        public void RemoveAt(int index)
        {
            this.ValidateIndex(index);

            for (int i = index; i < this.Count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }
            this.items[this.Count - 1] = default;
            this.Count--;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}