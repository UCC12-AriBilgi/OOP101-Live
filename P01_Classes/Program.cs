namespace P01_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Personel Bilgileri
            //Console.WriteLine("Personel Bilgileri");
            //Console.WriteLine("------------------");

            //// Hazırlanmış olan sınıftan yararlanabilmem için o sınıftan bir nesne(object) yaratıyorum.

            //Personel umit = new Personel(); // nesne oluşturuluyor
            //Personel yagmur = new Personel(); // nesne oluşturuluyor
            //Personel erdem = new Personel(); // nesne oluşturuluyor

            ////per1.PersonelID = 1;
            ////per1.Ad = "Ümit";
            ////per1.Soyad = "KARAÇİVİ";
            ////per1.Maas = 10500;

            //// maas bilgisi random hesaplansın
            //int maasilk = 9000;
            //int maasson = 20000;


            //umit.setPersonelBilgileri("Ümit", "Karaçivi", new Random().Next(maasilk,maasson));
            //yagmur.setPersonelBilgileri("Yağmur", "Nesim", new Random().Next(maasilk, maasson));
            //erdem.setPersonelBilgileri("Erdem", "Hasar", new Random().Next(maasilk, maasson));


            //Console.WriteLine(umit.getPersonelBilgileri());
            //Console.WriteLine(yagmur.getPersonelBilgileri());
            //Console.WriteLine(erdem.getPersonelBilgileri());
            #endregion


            #region CustomerManager,ProductManager

            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add();

            //ProductManager productManager = new ProductManager();
            //productManager.Add();

            //customerManager.Update();
            //productManager.Update();

            #endregion

            #region Farklı class/nesne kullanım şekilleri
            // 1.
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Ümit";
            customer.LastName = "Karaçivi";
            customer.City = "İstanbul";

            Console.WriteLine($"Müşteri Adı : {customer.FirstName}\n");

            // 2.
            Customer customer1 = new Customer
            {
                Id = 1,
                FirstName = "Nurgül",
                LastName = "Karaçivi",
                City = "Bursa"

            };

            Console.WriteLine($"Müşteri Adı : {customer1.FirstName}");

            #endregion


            Console.ReadKey();
        }
    }
}
