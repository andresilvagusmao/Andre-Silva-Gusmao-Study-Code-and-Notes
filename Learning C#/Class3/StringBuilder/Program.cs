using System;
using System.Text;

namespace Nae
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = 10;
            string[] animals = {"Cat","Bull","Cow"};

            StringBuilder sb = new StringBuilder("Initial String.",200);
            string test;
            System.Console.WriteLine($"Capacity: {sb.Capacity}. Length: {sb.Length}");
            sb.Append("Jhonson.");
            sb.Append("The Boy.");
            sb.AppendLine();
            sb.AppendFormat("He did it {0}",times);
            sb.AppendLine();
            sb.Append("He also jumped over a");
            sb.AppendJoin(",",animals);
            sb.Replace("Cat","Fox");
            sb.Insert(0,"This is the ");

            System.Console.WriteLine($"Capacity: {sb.Capacity}. Length: {sb.Length}");
            System.Console.WriteLine(sb.ToString());
            test = sb.ToString();
            System.Console.WriteLine("test");
            System.Console.WriteLine(test);
        }   
    }
}