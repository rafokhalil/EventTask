using System;
using System.Threading;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            
            Console.Write("Enter string : ");
            var str = Console.ReadLine();
            Console.WriteLine("Loading . . .");
            Thread.Sleep(3000);

            var cls = new MyClass();

            Func funcDell = cls.Space;
            funcDell += cls.Reverse;

            var run = new Run();

            run.RunFunc(funcDell, str);

        }
    }
}
