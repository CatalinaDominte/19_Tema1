using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAndMax
{
    public class  MinAndMaxArr <T> where T : IComparable<T>
    {
        public MinAndMaxArr()
        {

        }

         public T Max(T[] arr) 
        {
           
                T max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(max) > 0)
                {
                    max = arr[i];
                }
               
            }
            Console.WriteLine(max);
            return max;

        }
        public T Min(T [] arr)
        {

            T min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(min) < 0)
                {
                    min = arr[i];
                }

            }
            Console.WriteLine(min);
            return min;



        }
    }
    

}
