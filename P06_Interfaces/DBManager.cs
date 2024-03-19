using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace P06_Interfaces
{
    internal class DBManager
    {
        private IDatabase database;

        public DBManager()
        {
                
        }

        // Parametrik constructor...Buraya o anki db nin classını göndercem
        public DBManager(IDatabase database)
        {
            //içsel değeri gelen parametreye göre değiştiriyorum
            this.database = database;
        }

        public void loginDB() // vt sistemine giriş işini halledecek metot
        {
            string userName, password;

            Console.WriteLine("Veritabanı bağlantısı :\n\nKullanıcı Adı : ");
            userName = Console.ReadLine();

            Console.WriteLine("Kullanıcı şifresi : ");
            password = Console.ReadLine();

            if (database.login(userName,password)==1)
            {
                menu();
            }
        }

        private void menu()
        {
            string value; // işlemlerde kullanılacak değer
            int option; // menu seceneği

            Console.WriteLine("Veritabanı işlemleri \n\n");
            Console.WriteLine("1 - Veri ekle\n2 - Veri Sil\n3 - Veri Getir\n4 - Bağlantıyı kes\n");
            Console.WriteLine("Yapacağınız işlem ");

            option = Convert.ToInt32(Console.ReadLine);

            switch(option)
            {
                case 1:
                    Console.Write("Eklemek istediğiniz veri : ");
                    value = Console.ReadLine();

                    //addValue(value);
                    Console.Clear();
                    menu();
                    break;
                case 2:
                    Console.Clear();
                    //deleteValue();
                    menu();
                    break;
                case 3:
                    Console.Clear();
                    //getValue();
                    menu();
                    break;
                case 4:
                    Console.Clear();
                    //closeDB();
                    menu();
                    break;

                default:
                    break;
            }

        }





    }
}
