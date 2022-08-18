namespace Namess
{
    public class Book
    {
        private string _name;
        protected int _pagecount;
        private string _author;

        //Properties
        public string Name{
            get{
                return _name;
            }
            set{
                _name=value;
            }
        }
        public string Author{
            get=>_author;
            set=>_author=value;
        }

        public string Description{
            get => $"{Name}{Author}";
        }

        public int Pages { get; private set;}

        public void ChangePagesWithBussinessLogic(int val){
            Pages=val;
        }

        


    public Book(string name, string author, int pages)
    {
        _name=name;
        _pagecount = pages;
        _author = author;
    }
    public string GetDescription(){
        return $"{_name} by {_author} with {_pagecount} pages. AND PAGES{Pages}";
    }
    public void SetName(string s){
        _name = s;
    }
        public void SetAuthor(string s){
        _author = s;
    }
        public void SetPageCount(int i){
        _pagecount = i;
    }

    }
}