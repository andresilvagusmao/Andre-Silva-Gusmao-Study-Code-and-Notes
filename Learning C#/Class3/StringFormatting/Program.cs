﻿namespace Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] quarters = {1,2,3,4};
            int[] quartersVal = {1000,2000,3000,4000};
            double[] intlMixPct ={.386,.444,.245,.568};
            string str1 ="TestStr";
            int val1=1234;
            decimal val2= 1234.5678m;

            System.Console.WriteLine("{0:D}  |  {0:N}  |  {0:F}  |  {0:G}",val1);
            System.Console.WriteLine("{0:E}  |  {0:N}  |  {0:F}  |  {0:G}",val2);

            //Specify precision
            System.Console.WriteLine("{0:D6}  |  {0:N3}  |  {0:F1}  |  {0:G3}",val1);
            //Formatting with alignment and spacing
            System.Console.WriteLine("{0,12}  |  {1,12}  |  {2,12}  |  {3,12}", quarters[0],quarters[1],quarters[2],quarters[3]);     
            System.Console.WriteLine("{0,12:C0}  |  {1,12:C0}  |  {2,12:C0}  |  {3,12:C0}", quartersVal[0],quartersVal[1],quartersVal[2],quartersVal[3]);     
            System.Console.WriteLine("{0,12:P0}  |  {1,12:P0}  |  {2,12:P1}  |  {3,12:P2}", intlMixPct[0],intlMixPct[1],intlMixPct[2],intlMixPct[3]);   
        }
    }
}