using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    public class Program
    {

        static void Main(string[] args)
        {
            Maximum<int> integer = new Maximum<int>(165653, 2, 3);

            Maximum<float> @float = new Maximum<float>(1.4f, 2.1f, 3.87f);

            Maximum<string> @string = new Maximum<string>("Apple", "peach", "banana");
        }
    }
}
