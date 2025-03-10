using System;
using System.Runtime.InteropServices;

namespace ProgramTest
{
    class Program
    {
        string yashesap()
        {
            Console.WriteLine("yaş gir");
            int yas = Convert.ToInt32(Console.ReadLine());

            if (0 <= yas && yas < 10)
            {
                return "Arabanız yeni";
            }
            else if (10 <= yas && yas < 20)
            {
                return "Servise götürmeniz gerekebilir";
            }
            else if (20 <= yas && yas < 30)
            {
                return "Arabanız hurdaya çıkabilir";
            }
            else
            {
                return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.yashesap());
        }
    }
}

