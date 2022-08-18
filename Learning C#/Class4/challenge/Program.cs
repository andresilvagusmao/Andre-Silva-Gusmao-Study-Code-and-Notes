static (bool,int) isPalindrome(string s){
string processed = preProcessString(s);
int index=0;
foreach (var item in processed)
{
    System.Console.WriteLine("Processed[index] "+ processed[index]+ " Processed[processed.Length-1] " + processed[processed.Length-1]);
    if(processed[index]!=processed[processed.Length-index-1])
    return (false,0);
    else{
        index++;
    }
}
return (true,processed.Length);
}

static string preProcessString(string s){
    s= s.ToUpper();
    string result = "";
    foreach (var item in s)
    {
        if(item >='A'&& item<='Z')
            result+=item;
    }
    return result;
}

bool prog = true;
while (prog)
{
    System.Console.WriteLine("Enter string to test Palindrome. Type exit to exit");
    string s=System.Console.ReadLine();
    if(s=="exit"){
        prog=false;
    }
    else{
        if(s.Length>0){
        (bool boolean,int count) result = isPalindrome(s);
        if(result.boolean){
            System.Console.WriteLine("The word is not a palindrome. Size: {0}",result.count);
        }
        else{
            System.Console.WriteLine("The word is a palindrome. Size: {0}",result.count);
        }
        }
        else{
            System.Console.WriteLine("Invalid input");
        }
    }
    
}

