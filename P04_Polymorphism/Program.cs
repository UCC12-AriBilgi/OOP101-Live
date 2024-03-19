namespace P04_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tutorials tutorials = new Tutorials();

            tutorials.setTutorial("SQL Server eğitimi"); // 1.hal
            Console.WriteLine(tutorials.getTutorialInfo());

            tutorials.setTutorial(1, "C# dersleri"); // 2.hal
            Console.WriteLine(tutorials.getTutorialInfo());


            tutorials.setTutorial(2, "HTML Dersleri", "Web tasarımı konusunda"); //3.hal
            Console.WriteLine(tutorials.getTutorialInfo());

            Console.ReadKey();
        }
    }
}
