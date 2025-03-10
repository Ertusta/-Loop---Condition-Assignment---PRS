using System;
using System.Runtime.InteropServices;

namespace ProgramTest
{
    class Program
    {
        string yashesap()
        {
            Console.WriteLine("yaş girin");
            int yas = Convert.ToInt32(Console.ReadLine());
            if (0 < yas && yas < 18)
            {
                return "küçüksün";
            }
            else if (18 < yas && yas < 35)
            {
                return "gençsin";
            }
            else if (35 < yas && yas < 55)
            {
                return "orta yaşlısınız";
            }
            else if (55 < yas && yas < 75)
            {
                return "yaşlısınız";
            }
            else if (75 < yas && yas < 99)
            {
                return "çok yaşlısınız";
            }
            else
            {
                return "Ya hiç doğmadınız ya da çoktan öldünüz.";
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.yashesap());
        }
    }
}
