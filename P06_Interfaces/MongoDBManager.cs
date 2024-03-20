using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Interfaces
{
    internal class MongoDBManager : IDatabase
    {
        private string value; // db tarafına gidecek/gelecek değer

        private string userName = "mongo"; // Mongo kullanıcı adı
        private string password = "admin"; // Şifresi

        public void addvalue(string value)
        {
            this.value = value;
        }

        public void close()
        {
            Console.WriteLine("MongoDB bağlantısı başarılı bir şekilde sonlandırıldı...\n");
        }

        public void deletevalue()
        {
            this.value = null;

            Console.WriteLine("Veritabanı üzerindeki bilgiler silindi...\n");
        }

        public void getValue()
        {
            if (value != null)
            {
                Console.WriteLine($"İsteğiniz üzere {value} bilgisi veritabanından getirildi...\n");
            }
            else
            {
                Console.WriteLine("Veritabanı içersinde herhangi bir değer yoktur. Daha sonra tekrar deneyiniz..\n");
            }
        }

        public int login(string userName, string password)
        {
            if (userName == this.userName && password == this.password)
            {
                return 1; // giriş uygunsa
            }
            else
                return 0; // uygun değilse.
        }

        public void updatevalue(string value)
        {
            this.value = value;

            Console.WriteLine("Veritabanı üzerindeki bilgi güncellendi...\n");
        }
    }
}
