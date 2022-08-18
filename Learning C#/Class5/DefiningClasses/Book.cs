namespace Namess
{
    public class Book
    {
        string _name;
        int _pagecount;
        string _author;


    public Book(string name, string author, int pages)
    {
        _name=name;
        _pagecount = pages;
        _author = author;
    }
    public string GetDescription(){
        return $"{_name} by {_author} with {_pagecount} pages.";
    }
    }
}