namespace HomeWork
{
    using System;
    using System.Collections.Generic;

    public class BitArray64 : IEnumerable<ulong>
    {
        private ulong[] array;
        private int count;

        private int size;

        public BitArray64(int size)
        {
            this.array = new ulong[size];
            this.size = size;
            this.count = 0;
        }

        public BitArray64()
        {
            this.size = 2;
            this.count = 0;
            this.array = new ulong[size];
        }

        public int Count
        {
            get { return count; }
        }

        public int Size
        {
            get { return size; }
        }

        public ulong this[int index]
        {
            get
            {
                if (index > this.count && index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                return this.array[index];
            }
            set
            {
                if (index > size)
                {
                    throw new ArgumentExpetion();
                }
                this.array[index] = value;
            }
        }

        public void Add(ulong value)
        {
            if (this.count == this.size)
            {
                ResizeArray();
            }
            this.array[this.count++] = value;
        }

        public IEnumerator<ulong> GetEnumerator()
        {
            for (int i = 0; i < this.count; i++)
            {
                yield return array[i];
            }
        }

        public void Remove(ulong removeElement)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (this.array[i] == removeElement)
                {
                    RemoveAt(i);
                    return;
                }
            }
        }

        public void RemoveAll(ulong removeElement)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (this.array[i] == removeElement)
                {
                    RemoveAt(i);
                }
            }
        }

        public void RemoveAt(int position)
        {
            if (this.count > position && this.count < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                for (int i = position; i < this.count - 1; i++)
                {
                    this.array[position] = this.array[position + 1];
                }
                count--;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void ResizeArray()
        {
            ulong[] newArray = new ulong[this.size * 2];
            Array.Copy(this.array, newArray, this.size);
            this.array = newArray;
            this.size *= 2;
        }
    }
}