using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Interfaces
{
    internal interface IDatabase
    {
        // Burasını bir sözleşme metni gibi düşünebilirsiniz.
        // Sınıflara üzerinde neler olacağını bildiriyorum. Herhangi bir kod bloğu bulunmuyor

        // db mize giriş yapacak olan metot tanımı
        int login(string userName,string password);

        // db mizi kapatacak olan metot imzası
        void close();

        // db mize bir kayıt ekleyecek metot
        void addvalue(string value);

        // db mizden bir kayıt silecek metot
        void deletevalue();

        // db mizde kayıt güncelleycek metot
        void updatevalue(string value);

        // db mizden bir değer getirecek olan metot
        void getValue();

    }
}
