using System;
namespace HelloWorld
{
    class Program{
        static void Main(string[] args){


            var theVal = 10;
            int [] numbers = {3,14,15,41,92,6,7,15};
            string str = "String example";

            
            Console.WriteLine("For break:");
            foreach (var item in numbers)
            {
                // if(item>=40){
                //     break;
                // }
                if(item>=40){
                    continue;
                }
                // Console.WriteLine($"val is currently {item}");
                Console.WriteLine($"val is currently "+ item);


            }


    }
    }
}