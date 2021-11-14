using System;

namespace Application
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Hello " + args.FirstOrDefault());
            return 0;
        }
    }
}