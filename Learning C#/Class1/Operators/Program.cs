using System;
namespace HelloWorld
{
    class Program{
        static void Main(string[] args){
int i = 10;
// float f = 2.0f;
// decimal d = 10.0m;
// bool b = true;
char c = 'c';

string str = "example string";

//var x = "10";
var y = 10;

int [] vals = new int[5];
string [] valss = {"","Two","Test",""};
//int [] valsNotStarted;

Console.WriteLine(c+str);
Console.WriteLine(i);
Console.WriteLine(y);
i+=y;
Console.WriteLine(i);
i--;
Console.WriteLine(i);

Console.WriteLine(i>y);
Console.WriteLine((i>y&&i>50) || i<5);



string test1 ="null";
Console.WriteLine(test1??"null val");
test1 = "value";
Console.WriteLine(test1??"null val");
string test2 = ((i>y&&i>50))?"ifTrueOrNotNull": "ifFalseOrNull";
Console.WriteLine(test2);


TestObj newInstanceOfObject = new TestObj("Julio");
Console.WriteLine(newInstanceOfObject.names);

if(newInstanceOfObject?.names !=null){
Console.WriteLine(newInstanceOfObject?.names);
}
if(newInstanceOfObject?.p !=null){
Console.WriteLine(newInstanceOfObject?.p);
}

// if test1 is null test1 = new value
test1 = null;
test1 ??= "new value";
Console.WriteLine(test1);
        }
    }

    public class TestObj{
        public string p{get;set;}
        public string names;
        public TestObj(string name){
            this.names=name;
        }
    }
}