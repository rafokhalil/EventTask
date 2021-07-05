using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class MyClass
    {

        public void Space(string str)
        {
            Console.WriteLine(MethodHelper.Space(str));
        }

        public void Reverse(string str)
        {
            Console.WriteLine(MethodHelper.Reverse(str));
        }

    }
}
