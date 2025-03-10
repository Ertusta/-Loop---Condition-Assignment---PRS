using System;
using System.Runtime.InteropServices;

namespace ProgramTest
{
    class Program
    {
        void whiler()
        {
            int a = 5;

            while(a > 5)
            {
                   Console.WriteLine("bu kod çalışmaycak");
            }

            do
            {
                Console.WriteLine("bu kod çalışacak");
            } while (a > 5);
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.whiler();
        }
    }
}

