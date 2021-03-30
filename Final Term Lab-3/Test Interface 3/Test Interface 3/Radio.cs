using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_3
{
    class Radio
    {
            private string title;
           
            public Radio()
            { }
            public Radio(string title)
            {
                this.title = title;
            }
            private Phone phone;

            public Phone Ph1
            {
                get { return phone; }
                set { phone = value; }
            }

            public void ShowInfo()
            {
               
               Console.WriteLine("Channel Title: " + title);
               
            }
    }
 }

