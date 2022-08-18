void PrintWithPrefix(string theStr,string prefix = ""){
    System.Console.WriteLine($"::> {prefix} {theStr}");
}

PrintWithPrefix("Test String");
PrintWithPrefix("Test String number 2","Banana");

PrintWithPrefix(prefix:"pref", theStr:"Hello World");
PrintWithPrefix(theStr:"Hello World");