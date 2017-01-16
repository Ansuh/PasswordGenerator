using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGen
{
    class Program
    {
        static void Main(string[] args)
        {

            PassGen Pw = new PassGen(0, 1, 2, 3);
            Console.WriteLine(Pw);
        }
    }
}
