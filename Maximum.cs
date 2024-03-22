using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
     class Maximum
    {
        public T Findmax<T>(T num1, T num2, T num3) where T:IComparable
        {
            T max = num1;
            if (num2.CompareTo(max) > 0) max = num2; 
            if (num3.CompareTo(max) > 0) max = num3;
            return max;
        }
       
        static void Main(string[] args) 
        {
            Maximum maximum = new Maximum();
           int integer= maximum.Findmax(1, 2, 3);
         
            Console.WriteLine(integer);
            float @float= maximum.Findmax(1.4f, 2.1f, 3.87f);
            Console.WriteLine(@float);
            string @string= maximum.Findmax("Apple","peach","banana");
            Console.WriteLine(@string);
        }
    }
}
