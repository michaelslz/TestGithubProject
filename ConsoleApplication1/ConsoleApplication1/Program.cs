using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Github!");
        }

        public int add(int a, int b = 1)
        {
            return a + b;
        }

        public int add(int a)
        {
            return a;
        }
    }
}
