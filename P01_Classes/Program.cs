﻿namespace P01_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Personel Bilgileri
            Console.WriteLine("Personel Bilgileri");
            Console.WriteLine("------------------");

            // Hazırlanmış olan sınıftan yararlanabilmem için o sınıftan bir nesne(object) yaratıyorum.

            Personel umit = new Personel(); // nesne oluşturuluyor
            Personel yagmur = new Personel(); // nesne oluşturuluyor
            Personel erdem = new Personel(); // nesne oluşturuluyor

            //per1.PersonelID = 1;
            //per1.Ad = "Ümit";
            //per1.Soyad = "KARAÇİVİ";
            //per1.Maas = 10500;

            // maas bilgisi random hesaplansın
            int maasilk = 9000;
            int maasson = 20000;


            umit.setPersonelBilgileri("Ümit", "Karaçivi", new Random().Next(maasilk,maasson));
            yagmur.setPersonelBilgileri("Yağmur", "Nesim", new Random().Next(maasilk, maasson));
            erdem.setPersonelBilgileri("Erdem", "Hasar", new Random().Next(maasilk, maasson));
            

            Console.WriteLine(umit.getPersonelBilgileri());
            Console.WriteLine(yagmur.getPersonelBilgileri());
            Console.WriteLine(erdem.getPersonelBilgileri());
            #endregion


            Console.ReadKey();
        }
    }
}
