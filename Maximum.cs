using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
     class Maximum
    {
        public T? Findmax<T>(params T[] values) where T:IComparable
        {
           List<T> list = new List<T>();
            foreach (T value in values) 
            {
                list.Add(value);
            }
            list.Sort();
            return list.Last();
        }
       
        static void Main(string[] args) 
        {
            Maximum maximum = new Maximum();
           int integer= maximum.Findmax(165653, 2, 3);
         
            Console.WriteLine(integer);
            float @float= maximum.Findmax(1.4f, 2.1f, 3.87f);
            Console.WriteLine(@float);
            string @string= maximum.Findmax("Apple","peach","banana");
            Console.WriteLine(@string);
        }
    }
}
