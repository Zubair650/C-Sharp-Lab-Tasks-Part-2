using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_1
{
    class Class2 : Class1, ScientificCalculatorInterface
    {
        //int div;
        public int division(int x, int y)
        {
            this.X = x;
            this.Y = y;
            int div = x / y;
            Console.WriteLine("Division: " + div);
            return div;

        }

        public int multiplication(int x, int y)
        {
            this.X = x;
            this.Y = y;
            int mul = x * y;
            Console.WriteLine("Multiplication: " + mul);
            return mul;

        }

        public int sub(int x, int y)
        {
            this.X = x;
            this.Y = y;
            int sb = x - y;
            Console.WriteLine("Subtraction: " + sb);
            return sb;
        }

        public int sum(int x, int y)
        {
            this.X = x;
            this.Y = y;
            int sm = x + y;
            Console.WriteLine("Sumation: " + sm);
            return sm;

        }

        public int XtoY(int x, int y)
        {
            this.X = x;
            this.Y = y;
            int temp = x;
            x = y;
            y = temp;

            Console.WriteLine("X= " + x + " Y= " + y);
            return 0;
        }

        public int square(int x, int y)
        {
            int sqX = x*x;
            int sqY = y*y;
            Console.WriteLine("X^2= " + sqX + " Y^2= " + sqY);
            return 0;
        }



    }
}
