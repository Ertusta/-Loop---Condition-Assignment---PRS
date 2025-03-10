using System;
using System.Collections.Generic;

namespace ProgramTest
{
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public string Meslek;
        public int Maas;
        public string Departman;

        public Calisan(string ad, string soyad, int maas, string departman, string meslek)
        {
            Ad = ad;
            Soyad = soyad;
            Meslek = meslek;
            Maas = maas;
            Departman = departman;
        }

        public void BilgileriGoster()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Meslek: {Meslek}, Maaş: {Maas}, Departman: {Departman}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Calisan> calisanlar = new List<Calisan>
            {
                new Calisan("Ahmet", "Yılmaz", 15000, "Yönetim", "Genel Müdür "),
                new Calisan("Mehmet", "Kaya", 10000, "Yönetim", "Müdür "),
                new Calisan("Ayşe", "Demir", 8000, "Yazılım", "Programcı "),
                new Calisan("Ali", "Çelik", 3000, "Yazılım", "Stajyer")
            };

            int toplamMaas = 0;

            foreach (var calisan in calisanlar)
            {
                calisan.BilgileriGoster();
                toplamMaas += calisan.Maas;
            }

            Console.WriteLine($"Toplam Maaş: {toplamMaas}");
        }
    }
}
