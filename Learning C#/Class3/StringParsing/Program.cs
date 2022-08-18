using System;
using System.Globalization;
namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string numStr1 = "1";
            string numStr2 = "2.00";
            string numStr3 = "3,000";
            string numStr4 = "4,000.00";
            
            int targetNumber;

            try
            {
                bool b =int.TryParse(numStr1,out targetNumber);
                System.Console.WriteLine(targetNumber);
                targetNumber =int.Parse(numStr2,NumberStyles.Float);
                System.Console.WriteLine(targetNumber);
                targetNumber =int.Parse(numStr3,NumberStyles.AllowThousands);
                System.Console.WriteLine(targetNumber);
                targetNumber =int.Parse(numStr4,NumberStyles.Float|NumberStyles.AllowThousands);
                System.Console.WriteLine(targetNumber);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}