using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_class
{
    public class GenericList<T>
    {
        private T[] array;

        private int size;

        private int currentElemIdx;


        public GenericList(int size)
        {
            this.currentElemIdx = 0;
            this.size = size;
            this.array = new T[size];
        }

        public void Add(T value)
        {
            if (this.currentElemIdx == this.size)
            {
                Grow();
                
            }

            this.array[this.currentElemIdx] = value;
            this.currentElemIdx++;
        }
        public void Print()
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        public T GetElement(int index)
        {
            if (index >= this.size)
            {
                throw new ArgumentException();
            }
            else
            {
                return this.array[index];
            }

        }
        public void RemoveElement(int index)
        {
            if (index >= this.size)
            {
                throw new ArgumentException();
            }
            else
            {
                Array.Clear(array, index, 1);
            }

        }
        public T InsertElement(int index, T value)
        {
            if (index >= this.size)
            {
                throw new ArgumentException();
            }
            else
            {
                return array[index] = value;
            }
        }
        public void RemoveList()
        {
            int index = 0;

            Array.Clear(array, index, size);

        }
        public string FindIndex(T value)
        {
            return Array.IndexOf(array, value).ToString();
        }

        //Problem 2. Auto-grow
        //Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
        public void Grow()
        {
            T[] newArray = null;
            if (this.currentElemIdx == this.size)
            {
                newArray = new T[size * 2];
                {
                    for (int i = 0; i < size; i++)
                    {
                        newArray[i] = array[i];
                    }
                }
            }
            array = newArray;
            size = size * 2;
        }
    }
}


        
    


