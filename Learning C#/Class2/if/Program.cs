using System;
namespace HelloWorld
{
    class Program{
        /// I can summarize the class with a XML comment
        /// <summary>
        /// This is the main sample app function
        /// </summary>
        /// <param name="args"> name of the person</param>
        /// <returns> there is no return</returns>
        static void Main(string[] args){

            /*
                Playing around with numbers

            Console.WriteLine("success");   
            var theVal = 50;
            int i = 10;
            float f = 2.01020301f;
            double dou= 5.0102030190102030101020301D;
            decimal dec = 10.10010203010102030101020309999m;
            Console.WriteLine("float {0}",f);
            Console.WriteLine("double {0}",dou);
            Console.WriteLine("decimal {0}",dec);
            i=(int)f;
            Console.WriteLine("integer {0}",i);
            */
            var theVal = 50;
            if(theVal == 50){
                Console.WriteLine("Exactly 50 {0}",theVal);
            }
            else if(theVal>=51 && theVal <=60){
                Console.WriteLine("between 51 and 60 {0}",theVal);
            }
            else{
                Console.WriteLine("Another value {0}",theVal);
            }

            Console.WriteLine(theVal<50 ? "the val is small" :"The val is large");
        
        }
    }

}