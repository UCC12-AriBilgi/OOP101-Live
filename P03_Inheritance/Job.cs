using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Inheritance
{
    // Bazı bilgiler alabileceğim bir sınıf..sanki raporlama gibi
    internal class Job
    {
        public string jobName { get; set; }

        // C# da varolan class yapımızı da bir parametre olarak kullanabiliriz.
        public void Work (Worker worker)
        {
            Console.WriteLine($"{worker.Ad} isimli çalışan {jobName} işinde çalışıyor..");
        } 


        public void RaporAl(Person person) 
        {
            Console.WriteLine($"{person.Ad} isimli kişi raporunu aldı....\n\n");
        }
    }
}

