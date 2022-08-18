using System;
namespace HelloWorld
{
    class Program{
        static void Main(string[] args){


            var theVal = 10;
            int [] numbers = new int[]{3,14,15,92,6};
            string str = "String example";
            
            Console.WriteLine("For loop:");
            for (int i = 0; i < theVal; i++)
            {
                Console.WriteLine("i value is {0}",i);
            }
            Console.WriteLine("foreach:");
            foreach(int i in numbers){
                Console.WriteLine("i value is {0}",i);
            }
            Console.WriteLine("foreach in string:");
            foreach(char i in str){
                Console.WriteLine("i value is {0}",i);
            }

            string inputString = "";
            Console.WriteLine("Basic While:");
            while(inputString != "exit"){
                inputString = Console.ReadLine();
                Console.WriteLine("You entered: {0}", inputString);
            }
            Console.WriteLine("Basic Do While:");
            do{
                inputString = Console.ReadLine();
                Console.WriteLine("You entered: {0}", inputString);
            }while(inputString != "exit");


    }
    }
}