namespace P03_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir trainer nesnesi yaratalım
            Trainer trainer = new Trainer();

            trainer.Ad = "Ümit"; // Person sınıfından kalıtım yoluyla(Worker<-Person) Trainer sınıfına yerleşti
            trainer.Soyad = "KARAÇİVİ"; // ""
            trainer.Brans = "C#"; // Trainer classından geldi
            trainer.Maas = 5000; // Worker sınıfından kalıtım yoluyla geldi.

            // Bir salesrepresant nesnesi yaratalım
            SalesRepresant salesRepresant = new SalesRepresant();

            salesRepresant.Ad = "Faruk";
            salesRepresant.Maas = 3000;
            salesRepresant.CalisanId = "1";
            salesRepresant.Prim = 300;

            // Bir ogrenci nesnesi yaratalım
            Student student = new Student();

            student.Ad = "Arda";
            student.OkulAd = "İ.T.Ü.";
            student.Bolum = "Elektronik Müh.";

            // Raporlama bölümü
            Job job = new Job();

            job.jobName = "Kendine uygun bir işte ";

            job.Work(trainer);
            job.Work(salesRepresant);
            //job.Work(student);

            job.RaporAl(student);
            job.RaporAl(trainer);
            job.RaporAl(salesRepresant);


            // Altsınıf-üst sınıf
            Tutorials tutorials = new Tutorials();

            tutorials.setTutorial(1, "C# dersleri");
            Console.WriteLine(tutorials.getTutorialName());


            SubTutorials subTutorials = new SubTutorials();

            subTutorials.DersAdiBelirle("SQL Dersleri.."); // alt sınıf ders adını değiştirdi.

            Console.WriteLine(tutorials.getTutorialName());









            
            Console.ReadKey();
        }
    }
}
