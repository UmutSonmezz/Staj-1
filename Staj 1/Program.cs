﻿using System;

namespace Staj_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 3200;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");


            }

            else if (dolarDun < dolarBugun) ;   
            {
                Console.WriteLine("Artış butonu");
            }

            else
            {
                Console.WriteLine("değişmedi butonu");      
            }

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yapma butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
