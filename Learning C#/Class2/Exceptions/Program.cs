// See https://aka.ms/new-console-template for more information
int x=100;
int y = 1;
int resultf;

try
{
    resultf = x/y;
    Console.WriteLine(resultf);
    if(x/y>10){
        throw new ArgumentOutOfRangeException("x","x is too large");
    }
}
catch (DivideByZeroException e)
{
    Console.WriteLine("error message");
    Console.WriteLine(e.Message);
    // throw;
}
catch(ArgumentOutOfRangeException e){
    Console.WriteLine("Sorry error more than 1000");
    Console.WriteLine(e.Message);
}
finally{
    Console.WriteLine("this code allways runs");
}
Console.WriteLine("after");