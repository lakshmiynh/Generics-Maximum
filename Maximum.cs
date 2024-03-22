using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
     class Maximum<T> where T : IComparable
    {
    

        public Maximum(params T[] values)
        {
            Findmax(values);
        }
        public T? Findmax<T>(params T[] values) 
        {
           List<T> list = new List<T>();
            foreach (T value in values) 
            {
                list.Add(value);
            }
            list.Sort();
            Console.WriteLine($"the Maximum value is {list.Last()}");
            return list.Last();
        }
       
       
    }
}
