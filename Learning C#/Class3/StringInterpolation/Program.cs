namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string make = "Mercedes-Benz";
            string model ="G Class";
            int year = 2020;
            float miles = 8_450.27f;
            decimal price = 60_275.0m;

            System.Console.WriteLine($"This car is a {make} model {model} year {year} with {{{miles*1.6:F2}}} KM that costs {price:C2}");
        }
    }
}