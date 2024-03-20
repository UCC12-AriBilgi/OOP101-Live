namespace P06_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;

            DBManager database;

            Console.WriteLine("Veritabanı bağlantıları");
            Console.WriteLine("------------------------\n");
            Console.WriteLine("1. Oracle bağlantısı kur");
            Console.WriteLine("2. MySQL bağlantısı kur");
            Console.WriteLine("3. Mongo bağlantısı kur\n");
            Console.Write("Seçiminiz : ");

            option=Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    database= new DBManager(new OracleDbManager());
                    database.loginDB();
                    break;
                case 2:
                    database = new DBManager(new MySqlDBManager());
                    database.loginDB();
                    break;
                case 3:
                    database = new DBManager(new MongoDBManager());
                    database.loginDB();
                    break;
                default:
                    break;
            }


            Console.ReadKey();
        }
    }
}
