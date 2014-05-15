//5. Write a generic class GenericList<T> that keeps a list of elements
//  of some parametric type T. Keep the elements of the list in an array
//  with fixed capacity which is given as parameter in the class constructor.
//  Implement methods for adding element, accessing element by index, removing
//  element by index, inserting element at given position, clearing the list,
//  finding element by its value and ToString(). Check all input parameters to
//  avoid accessing elements at invalid positions.
//
//6. Implement auto-grow functionality: when the internal array is full,
//  create a new array of double size and move all elements to it.
//
//7.Create generic methods Min<T>() and Max<T>() for finding the minimal
//  and maximal element in the  GenericList<T>. You may need to add a
//  generic constraints for the type T.

namespace HomeWork.MyGenericList
{
    using System;

    public class GenericList<T>
        where T : IComparable
    {
        private int count;
        private T[] list;
        public GenericList()
        {
            this.count = 0;
            list = new T[2];
        }

        public GenericList(int size)
            : this()
        {
            list = new T[size];
        }

        public int Capacity
        {
            get
            {
                return this.list.Length;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public T this[int index]
        {
            get
            {
                return this.list[index];
            }
            set
            {
                if (index >= 0 && index < count)
                {
                    this.list[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public void Add(T value)
        {
            if (this.Count == this.Capacity)
            {
                Resize();
            }

            this.list[count++] = value;
        }

        public void Clear()
        {
            list = new T[list.Length];
        }

        public bool Contains(T value)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (value.Equals(this.list[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(T value)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (value.Equals(this.list[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, T value)
        {
            if (index < 0 && index > this.count)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (this.Count == this.Capacity)
            {
                Resize();
            }

            for (int i = this.Count - 1; i > index; i--)
            {
                this.list[i] = this.list[i - 1];
            }
            this.list[index] = value;
            this.count++;
        }

        public T Max()
        {
            T minValue = this.list[0];
            for (int i = 1; i < this.count; i++)
            {
                if (this.list[i].CompareTo(minValue) > 0)
                {
                    minValue = this.list[i];
                }
            }
            return minValue;
        }

        public T Min()
        {
            T minValue = this.list[0];
            for (int i = 1; i < this.count; i++)
            {
                if (this.list[i].CompareTo(minValue) < 0)
                {
                    minValue = this.list[i];
                }
            }
            return minValue;
        }

        public void Remove(T value)
        {
            int index = IndexOf(value);
            RemoveAt(index);
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.list[i] = this.list[i + 1];
            }
            T defaultl = default(T);
            this.list[this.count] = defaultl;
            this.count--;
        }

        private void Resize()
        {
            T[] newArray = new T[this.list.Length * 2];

            for (int i = 0; i < this.Capacity; i++)
            {
                newArray[i] = list[i];
            }

            this.list = newArray;
        }
    }
}