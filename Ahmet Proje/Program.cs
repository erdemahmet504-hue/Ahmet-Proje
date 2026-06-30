using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahmet_Proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Ana Yemekler");
            Console.WriteLine("2-Ara Soguk");
            Console.WriteLine("3-Ara Sıcaklar");
            Console.WriteLine("4-Tatlılar");
            Console.WriteLine("5-İçecekler");
            Console.WriteLine("6-Çorbalar");
            Console.WriteLine("7-Salatalar");
            Console.WriteLine("8-Zeyntinglılar");
            Console.Write("Lütfen bir sayı giriniz: ");
            int number =int.Parse(Console.ReadLine());

            switch(number) {
                case 1:
                        Console.WriteLine("1-İskender Kebap");
                        Console.WriteLine("2- Adana Kebap");
                        Console.WriteLine("3- Izgara Köfte");
                        Console.WriteLine("4- Dana Antrikot");
                        Console.WriteLine("5- Sac Kavurma");
                        Console.Write("Ana Yemek Çeşitlerinden seçiniz = ");
                        int çeşit = int.Parse(Console.ReadLine());
                        Console.WriteLine("Seçtiginiz yemek= " + çeşit);

                        break;
                case 2:
                    Console.WriteLine("1. Haydari");
                    Console.WriteLine("2. Şakşuka");
                    Console.WriteLine("3. Acılı Ezme");
                    Console.WriteLine("4. Humus");
                    Console.WriteLine("5. Fava");

                    Console.Write("Ara Soğuk Çeşitlerinden seçiniz = ");
                    int secim2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Seçtiğiniz ara soğuk = " + secim2);
                    break;

                case 3:
                    Console.WriteLine("1. Paçanga Böreği");
                    Console.WriteLine("2. İçli Köfte");
                    Console.WriteLine("3. Kalamar Tava");
                    Console.WriteLine("4. Sigara Böreği");
                    Console.WriteLine("5. Patates Kızartması");

                    Console.Write("Ara Sıcak Çeşitlerinden seçiniz = ");
                    int secim3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Seçtiğiniz ara sıcak = " + secim3);
                    break;

                case 4:
                    Console.WriteLine("1. Sütlaç");
                    Console.WriteLine("2. Künefe");
                    Console.WriteLine("3. Fıstıklı Baklava");
                    Console.WriteLine("4. Tiramisu");
                    Console.WriteLine("5. Kazandibi");

                    Console.Write("Tatlı Çeşitlerinden seçiniz = ");
                    int secim4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Seçtiğiniz tatlı = " + secim4);
                    break;

                case 5:
                    Console.WriteLine("1. Ayran");
                    Console.WriteLine("2. Kola");
                    Console.WriteLine("3. Şalgam Suyu");
                    Console.WriteLine("4. Çay");
                    Console.WriteLine("5. Philips 5400 Espresso");

                    Console.Write("İçecek Çeşitlerinden seçiniz = ");
                    int secim5 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Seçtiğiniz içecek = " + secim5);
                    break;

                case 6:
                    Console.WriteLine("1. Mercimek Çorbası");
                    Console.WriteLine("2. Ezogelin Çorbası");
                    Console.WriteLine("3. Kelle Paça");
                    Console.WriteLine("4. Domates Çorbası");
                    Console.WriteLine("5. Yayla Çorbası");

                    Console.Write("Çorba Çeşitlerinden seçiniz = ");
                    int secim6 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Seçtiğiniz çorba = " + secim6);
                    break;

                case 7:
                    Console.WriteLine("1. Çoban Salata");
                    Console.WriteLine("2. Sezar Salata");
                    Console.WriteLine("3. Gavurdağı Salatası");
                    Console.WriteLine("4. Akdeniz Salata");
                    Console.WriteLine("5. Mevsim Salata");

                    Console.Write("Salata Çeşitlerinden seçiniz = ");
                    int secim7 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Seçtiğiniz salata = " + secim7);
                    break;

                case 8:
                    Console.WriteLine("1. Zeytinyağlı Yaprak Sarma");
                    Console.WriteLine("2. Zeytinyağlı Enginar");
                    Console.WriteLine("3. Zeytinyağlı Taze Fasulye");
                    Console.WriteLine("4. İmam Bayıldı");
                    Console.WriteLine("5. Barbunya Pilaki");

                    Console.Write("Zeytinyağlı Çeşitlerinden seçiniz = ");
                    int secim8 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Seçtiğiniz zeytinyağlı = " + secim8);
                    break;

                default:Console.WriteLine("Hatalı Giriş");
                    break;


            }


        }
    }
}
