using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string fromCurreny = "EUR";
            string toCurrency = "USD";

            int amount = 1;

            string[] availableCurrency = CurrencyConverter.GetCurrencyTags();
            Console.WriteLine("Available Currencies");
            Console.WriteLine(string.Join(",", availableCurrency));
            Console.WriteLine("\n");

            Console.WriteLine("Insert Currency you want to convert FROM");
            fromCurreny = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Insert Currency you want to convert TO");
            toCurrency = Console.ReadLine();
            Console.WriteLine("\n");

            float exchangeRate = CurrencyConverter.GetExchangeRate(fromCurreny, toCurrency, amount);
            Console.WriteLine($"FROM {amount} {fromCurreny.ToUpper()} TO {toCurrency.ToUpper()} = {exchangeRate}");

            Console.ReadLine();

        }
    }
}
