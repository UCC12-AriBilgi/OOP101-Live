namespace P05_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank(1000);

            //bank.paraYatir(500);
            bank.Balance = 500;

            //Console.WriteLine($"Hesabınızdaki miktar : {bank.getBalance()} PNG Kinadır...\n\n");
            Console.WriteLine($"Hesabınızdaki miktar : {bank.Balance} PNG Kinadır...\n\n");

            bank.paraCek(1000);

            //Console.WriteLine($"Hesabınızdaki miktar : {bank.getBalance()} PNG Kinadır...\n\n");
            Console.WriteLine($"Hesabınızdaki miktar : {bank.Balance} PNG Kinadır...\n\n");












            Console.ReadKey();
        }
    }
}
