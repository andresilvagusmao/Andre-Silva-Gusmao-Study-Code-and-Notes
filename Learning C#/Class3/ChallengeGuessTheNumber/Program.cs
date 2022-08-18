namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = new Random().Next(20);
            bool challengeOn = true;
            string input;
            int val;
            int guessCount=0;
            for (;challengeOn ; )
            {
            System.Console.WriteLine("Guess the number between 0 and 20. Type -1 to give up.");
            input = System.Console.ReadLine();
            if (input=="-1"){
                System.Console.WriteLine("You quit the program");
                challengeOn=false;
            }
            else if(int.TryParse(input,out val)){
                System.Console.WriteLine("You typed "+val);
                if(val>number)
                System.Console.WriteLine("Your number is bigger than the challenge number. Try again.");
                else if(val<number)
                System.Console.WriteLine("Your number is smaller than the challenge number. Try again.");
                else{
                System.Console.WriteLine($"You got it in {guessCount} tries. Congratulation.");
                challengeOn=false;
                }
            }
            else{
                System.Console.WriteLine($"You typed: {input}. This is not a valid value");
            }
            guessCount++;
            }
        }
    }
}