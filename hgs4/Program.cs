using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList AraçSayisi = new ArrayList();
            Gişe gişe1 = new Gişe();
            Yönetim yönetim1 = new Yönetim();
            otomobil otomobil1 = new otomobil();
            minibüs minibüs1 = new minibüs();
            otobüs otobüs1 = new otobüs(); 
            Console.WriteLine("**********Otomobil Geçişleri**********");
            otomobil1.HgsNumarasi = 1000142015;
            otomobil1.İsim = "Yasin";
            otomobil1.Soyİsim = "Ertekin";
            otomobil1.AracınSinifi = "1.Sınıf Otomobil";
            otomobil1.GeçişYaptığıTarih = "20/08/2022";
            otomobil1.GeçişYaptığıSaaat = "17.00";            
            otomobil1.Bakiye = 100;
            otomobil1.ücret = 50;
            otomobil1.YeniBakiye = otomobil1.Bakiye - otomobil1.ücret;
            Console.WriteLine("HGS Numarası: {0}", otomobil1.HgsNumarasi);
            Console.WriteLine("Otomobil Şoförünün Adı: {0}" ,otomobil1.İsim);
            Console.WriteLine("Otomobil Şoförünün Soyadı: {0}", otomobil1.Soyİsim);
            Console.WriteLine("Otomobil Şoförünün Sınıfı: {0}", otomobil1.AracınSinifi);
            Console.WriteLine("Geçiş Yaptığı Tarih: {0}", otomobil1.GeçişYaptığıTarih);
            Console.WriteLine("Geçiş Yaptığı Saat: {0}", otomobil1.GeçişYaptığıSaaat);
            Console.WriteLine("Otomobilin Bakiyesi: {0}",otomobil1.YeniBakiye);
            Console.WriteLine("**********Minibüs Geçişleri**********");
            minibüs1.HgsNumarasi = 1000845678;
            minibüs1.İsim = "Süeda";
            minibüs1.Soyİsim = "Ertekin";
            minibüs1.AracınSinifi = "2.Sınıf Minibüs";
            minibüs1.GeçişYaptığıTarih = "20/08/2022";
            minibüs1.GeçişYaptığıSaaat = "17.00";
            minibüs1.Bakiye = 200;
            minibüs1.ücret = 40;
            minibüs1.YeniBakiye = minibüs1.Bakiye - minibüs1.ücret;
            Console.WriteLine("Minibüs Şoförünün HGS Numarası: {0}", minibüs1.HgsNumarasi);
            Console.WriteLine("Minibüs Şoförünün Adı: {0}", minibüs1.İsim);
            Console.WriteLine("Minibüs Şoförünün Soyadı: {0}", minibüs1.Soyİsim);
            Console.WriteLine("Minibüs Şoförünün  Sınıfı: {0}", minibüs1.AracınSinifi);
            Console.WriteLine("Geçiş Yaptığı Tarih: {0}", minibüs1.GeçişYaptığıTarih);
            Console.WriteLine("Geçiş Yaptığı Saat: {0}", minibüs1.GeçişYaptığıSaaat);
            Console.WriteLine("Minibüsün Bakiyesi: {0}", minibüs1.YeniBakiye);
            Console.WriteLine("**********Otobüs Geçişleri**********");
            otobüs1.HgsNumarasi = 1000451236;
            otobüs1.İsim = "Esma";
            otobüs1.Soyİsim = "Ertekin";
            otobüs1.AracınSinifi = "3.Sınıf Otobüs";
            otobüs1.GeçişYaptığıTarih = "17/05/2020";
            otobüs1.GeçişYaptığıSaaat = "06.00";
            otobüs1.Bakiye = 300;
            otobüs1.ücret = 30;
            otobüs1.YeniBakiye = otobüs1.Bakiye - otobüs1.ücret;
            Console.WriteLine("Otobüs Şoförünün HGS Numarası: {0}", otobüs1.HgsNumarasi);
            Console.WriteLine("Otobüs Şoförünün Adı: {0}", otobüs1.İsim);
            Console.WriteLine("Otobüs Şoförünün Soyadı: {0}", otobüs1.Soyİsim);
            Console.WriteLine("Otobüs Şoförünün  Sınıfı: {0}", otobüs1.AracınSinifi);
            Console.WriteLine("Geçiş Yaptığı Tarih: {0}", otobüs1.GeçişYaptığıTarih);
            Console.WriteLine("Geçiş Yaptığı Saat: {0}", otobüs1.GeçişYaptığıSaaat);
            Console.WriteLine("Otobüsün Bakiyesi: {0}", otobüs1.YeniBakiye);
            
            int ToplamBakiye = otobüs1.ücret + minibüs1.ücret + otomobil1.ücret;
            yönetim1.AraçSayisi = AraçSayisi.Add(otomobil1);
            yönetim1.AraçSayisi = AraçSayisi.Add(minibüs1);
            yönetim1.AraçSayisi = AraçSayisi.Add(otobüs1);
            
            Console.Write("Günlük Bakiyeyi ve Geçen Araç Sayısını Görmek için 1'e çıkmak için 2'ye basınız: ");
            try
            {
                int girdi = Convert.ToInt32(Console.ReadLine());

                if (girdi == 1)
                {
                    Console.WriteLine("Toplam Günlük Bakiye: {0}", ToplamBakiye);
                    Console.WriteLine("Toplam Geçen Araç Sayısı: {0}", AraçSayisi.Count);
                }

                else if (girdi == 2)
                {
                    Console.WriteLine("Programdan Çıkılıyor...");
                }

                else
                {
                    Console.WriteLine("Lütfen 1'e veya 2'ye basınız");
                }
                
                
            }
            catch (Exception)
            {

                Console.WriteLine("Lütfen Numeric Bir Değer Giriniz");
            }
            








        }



        class Gişe
        {
            public long HgsNumarasi { get; set; }
            public string İsim { get; set; }

            public string Soyİsim { get; set; }

            public string AracınSinifi { get; set; }

            public string GeçişYaptığıTarih { get; set; }

            public string GeçişYaptığıSaaat { get; set; }

            public int Bakiye { get; set; }

            public int ücret { get; set; }

            public int YeniBakiye { get; set; }

            public int AraçSayisi { get; set; }



        }

        class otomobil : Gişe
        {

        }

        class minibüs : Gişe
        {

  
        }


        class otobüs : Gişe
        {

        }

        class Yönetim : Gişe
        {

        }
    }
}