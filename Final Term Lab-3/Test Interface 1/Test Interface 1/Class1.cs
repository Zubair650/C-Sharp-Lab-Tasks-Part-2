using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_1
{
    abstract class Class1 
    {
        public int X { get; set; }

        public int Y { get; set; }

        public void ShowInfo(int x, int y)
        {
            this.X = x;
            this.Y = y;
            Console.WriteLine("X= " + x + " Y= " + y);
        }


    }
}
