using System;
using System.Collections.Generic;

namespace ProgramTest
{
    class Araba
    {
        public string Marka;
        public int Tüketim;

        public Araba(string marka, int tüketim)
        {
            Marka = marka;
            Tüketim = tüketim;
            
        }

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba("Audi", 10);
            Araba araba2 = new Araba("BMW", 15);
            Araba araba3 = new Araba("Mercedes", 20);
            
            Araba[] arabalar = new Araba[] { araba1, araba2, araba3 };

            int toplam = 0;
            foreach (var araba in arabalar)
            {
                toplam += araba.Tüketim;
            }

            Console.WriteLine($"Toplam: {toplam}");
        }
    }
}
