internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.OutputEncoding = System.Text.Encoding.Unicode;

        //а) Обчислення величини знижки 
        int price = 100;
        int discount = 12;
        int netPrice = (price - (discount * price / 100));
        Console.WriteLine($"Ціна без знижки = {price}") ;
        Console.WriteLine($"тільки сьгодні знижка = {discount}");
        Console.WriteLine("ціна із знижкою");
        Console.WriteLine(netPrice );

        //б) Час в секундах
        byte hour = 9;
        byte minutes = 27;
        int seconds = 15;
        //в) Створіть програму, яка виводить інформацію про книгу
        string nameBook = "Atlantis";
        string writer = "Ihor Kutsenko";
        int year = 1950;
        int priceBook = 1500;
        
        Console.ReadKey();

    }
}