namespace AnyNameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            string empty;
            string s1 = "trest string";
            string s2 = "Test String";
            string s3 = "TEST STRING";
            string[] s4 = {"Test String0", "Test String1", "Test String2", "Test String3"};
            string s5 = "Test String";
            
            System.Console.WriteLine(s1.Length);
            System.Console.WriteLine(s2[0]);
            foreach (char c in s3)
            {
                if(c=='S')
                continue;
                if(c=='R')
                break;
                System.Console.Write(c);
            }
            System.Console.WriteLine(String.Concat(s4));
            empty= String.Concat(s4);
            System.Console.WriteLine(empty);
            empty= s1+" "+s2;
            System.Console.WriteLine(empty);
            empty= String.Join('.',s4);
            System.Console.WriteLine(empty);
            empty= String.Join("'.'",s4);
            System.Console.WriteLine(empty);


            int result = String.Compare(s1,s2);
            System.Console.WriteLine(result);

            bool isEqual = s1.Equals(s2);
            System.Console.WriteLine(isEqual);

            System.Console.WriteLine("Original String  "+s1);
            System.Console.WriteLine(s1.IndexOf('r'));
            System.Console.WriteLine(s1.LastIndexOf('s'));

            System.Console.WriteLine(s1.Replace("tr","lalala"));
        }
    }
}