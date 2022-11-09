using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {   IEnumerable<string> items = Enumerable.Range(1,10).Select(x=>"no-"+x);
            

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            IEnumerable<string> items2 = Enumerable.Range(10, 15).Select(x => "no." + x);

            foreach(var item in items2)
            {
                Console.WriteLine(item);
            }


        }
    }
}
