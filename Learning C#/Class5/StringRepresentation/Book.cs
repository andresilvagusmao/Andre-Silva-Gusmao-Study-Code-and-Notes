namespace Namess
{
    public class Book
    {
        private string _name;
        private int _pagecount;
        private string _author;

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        


    public Book(string name, string author, int pages)
    {
        _name=name;
        _pagecount = pages;
        _author = author;
    }
    public string GetDescription(){
        return $"{_name} by {_author} with {_pagecount} pages.";
    }

        public override string ToString()
        {
            return $"Name = {_name}. Author: {Author}";
        }

        public  string ToString(char c)
        {
            return $"Name = {_name}{c}{c}. Au{c}thor: {Author}{c}";
        }
    }
}