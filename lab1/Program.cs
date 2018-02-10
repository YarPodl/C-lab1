using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            APS t = new APS("Наша станция", 771);
            Console.WriteLine(t.ToString());
            Console.WriteLine();
            t.printNumber16();
        }
    }
}
