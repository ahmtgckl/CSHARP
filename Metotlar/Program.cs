﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
     
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";
            urun1.StokAdedi = 120;

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 28;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.StokAdedi = 300;

            Product[] urunler = new Product[] {urun1,urun2 };


            // type safe- tip güvenli
            foreach (Product x in urunler)
            {
                Console.WriteLine("...........foreach............");
                Console.WriteLine(x.Adi);
                Console.WriteLine(x.Fiyati);
                Console.WriteLine(x.Aciklama);
                Console.WriteLine(x.StokAdedi);
                
            }

            Console.WriteLine(".............Metotlar...........");

            SeperManager seperManager = new SeperManager();
            seperManager.Ekle(urun1);
            seperManager.Ekle(urun2);


        }
    }
}