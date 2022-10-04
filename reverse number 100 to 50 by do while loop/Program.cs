using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_number_100_to_50_by_do_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i= 100;
            do
            {
                Console.WriteLine(i);
                i--;

            } while (i>=50);


        }
    }
}
