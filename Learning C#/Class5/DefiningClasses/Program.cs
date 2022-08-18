namespace Namess
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Lalaland","lololo",250);

            Book b2 = new Book("DDDDD","SSSSSSS",500);

            System.Console.WriteLine(b1.GetDescription());
            System.Console.WriteLine(b2.GetDescription());
        }
    }
}