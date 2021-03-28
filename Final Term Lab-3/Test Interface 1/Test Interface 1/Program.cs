using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class2 c1 = new Class2();
            Class3 c2 = new Class3();
            c1.ShowInfo(20, 10);
            c2.sum(20, 10);
            c2.sub(20, 10);
            c2.multiplication(20, 10);
            c2.division(20, 10);
            c1.XtoY(20, 10);
            c1.square(20, 10);

        }
    }
}
