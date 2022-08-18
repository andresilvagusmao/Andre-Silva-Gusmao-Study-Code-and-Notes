using System;
namespace s
{
    class Program
    {

        static (int,int) PlusTimes(int arg1,int arg2)
        {
            return(arg1+arg2,arg1*arg2);
        }
        static void Main(string[] args)
        {
            (int a, int b) tup1= (5,10);
            var tup2 = ("Some text",10.5);

            tup1.b=20;
            tup2.Item1+=" newString";
            System.Console.WriteLine($"Tup1 {tup1.a} and {tup1.b}");
            System.Console.WriteLine($"Tup2 {tup2.Item1} and {tup2.Item2}");
        
            (int,int) result = PlusTimes(6,12);
            System.Console.WriteLine($"Sum: {result.Item1}, Product:{result.Item2}");
            System.Console.WriteLine($"Sum: {result}");
        }


    }
}