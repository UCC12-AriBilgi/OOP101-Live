using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Classes
{
    internal class Personel
    {
        // Burada bir yapı oluşturacağım.
        // Bunu oluştururken bu sınıfın bazı özellikleri olacak(properties)

        // Tanıtımlar..

        public int PersonelID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Unvan { get; set; }
        public int Maas { get; set; }
        public int IzinGunu { get; set; }

        public void setPersonelBilgileri(string pAd,string pSoyad,int pMaas)
        {
            // Üzerine gele parametrelere göre ilgili kişinin ünvanını ve izin gününü belirleyecek. Bunun için parametre olarak gelen maas bilgisini(PNG Kina) kullanacak.

            if ( pAd != null && pSoyad != null ) 
            {
                // eğer bilgiler dolu geldiyse işleme basla

                if (pMaas >= 10000) //  Sınırım 10000miş
                {
                    // Varsayılan değerleri atadım
                    this.Ad = pAd;
                    this.Soyad = pSoyad;
                    this.Maas = pMaas;
                    this.IzinGunu = 14;

                    // Maas bilgisine göre Unvan / Izingünü düzenlemeleri

                    if (pMaas >=10000 && pMaas <= 14000)
                    {
                        this.Unvan = "Kıdemli Personel";
                        this.IzinGunu = 20;
                    }
                    else if (pMaas >=14001 && pMaas <= 15500)
                    {
                        this.Unvan = "Kıdemli+ Personel";
                        this.IzinGunu = 24;
                    }
                    else if(pMaas > 15501)
                    {
                        this.Unvan = "Uzman Personel";
                        this.IzinGunu = 30;
                    }
                    else
                    {
                        this.Unvan = "Junior Personel";
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("-- Personel Oluşturulamadı --\n\n");
                    Console.WriteLine("Bir personelin oluşturulması için maasının en az 10000 olması lazım...Kontrol ediniz...");
                }
            }

        }

        // Atamış olduğumuz bilgileri okuyacak bir metot
        public string getPersonelBilgileri()
        {
            string sonuc;

            if (Unvan != null) // Unvan bilgisi oluşmuş mu
            {
                sonuc = $"\n-- Personel oluşturuldu--\n\nPersonel Adı : {Ad}\nPersonel Soyadı : {Soyad}\nPersonel Maaşı : {Maas} PNG Kina\nPersonel Ünvanı : {Unvan}\nPersonel İzin Günü : {IzinGunu} Gün\n";
            }
            else
                sonuc = $"\n-- Personel oluşturmanız gerekiyor--\nKontrol ediniz...";

            return sonuc;
        }
    }
}
