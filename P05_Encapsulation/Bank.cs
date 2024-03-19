using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Encapsulation
{
    public class Bank
    {

        private decimal balance; // Dışarıya kapalı içte kullandığım bir değişgen/property.. hesabımdaki miktar

        // Bu sınıfın bir constructor (yapıcı) metodu olsun. Bazı ayarlar yapayım

        public Bank(decimal initialBalance)
        {
            balance = initialBalance; // sınıftan bir nesne yaratıldığı an arka planda burası çalışacak.
                
        }

        // Para yatırmak istiyorum diyelim

        public void paraYatir(decimal miktar) // set 
        {
            balance = balance + miktar;
        }

        // Para çekme kısmı
        public void paraCek(decimal miktar)
        {
            // bankadaki balance eğer miktar bilgisinden fazlaysa işlem yapılsın
            if (balance >= miktar)
            {
                balance = balance - miktar;

            }
            else
            {
                Console.WriteLine("Yetersiz miktar..Lütfen kontrol ediniz....");
            }
        }

        //Bankadaki miktarı direkt veren metot
        public decimal getBalance() // get
        {
            return balance;
        }
    }
}
