using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_1_C__Advance.Classes
{
    internal class FixedSizeList<T>
    {
       

        public int Capacity { get; set; }
        private T[] array;
        public int Count { get; set; } = 0;

        public FixedSizeList(int capacity)
        {
            Capacity = capacity;
            array = new T[capacity];
        }



        public void Add(  T value)
        {
            if ( Count == Capacity)
            {
                throw new Exception("list is already full");
            }
            else
            {
                
                    array [Count] = value;
                    Count++;
                
            }
        }
        public T Get(int index)
        {
            if (index >= Count)
            {
                throw new Exception();
            }
            return array[index];
        }
    }

}
