using System;

namespace ClassLibrary2
{
    public class Book
    {
        public string _title;
        public string _author;
        public int _pagenumber;
        public string _isbn13;

        public Book()
        {

        }
        public Book(string title, string author, string isbn, int pages)
        {
            title = Title;
            isbn = ISBN13;
            author = Author;
            pages = PageNumber;
        }
         public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value.Length > 2)
                {
                    _title = value;

                }
                else
                {
                    throw new Exception(" The Title of the book should be at least 2 chars");
                }
            }
        }
        public string ISBN13
        {
            get
            {
                return _isbn13;
            }
            set
            {
                if (value.Length > 12 && value.Length < 14)
                {
                    _isbn13 = value;

                }
                else
                {
                    throw new Exception(" ISBM must be 13 chars");
                }
            }
        }

        public int PageNumber
        {
            get
            {
                return _pagenumber;
            }
            set
            {
                if (value > 10 && value < 1001)
                {
                    _pagenumber = value;

                }
                else
                {
                    throw new Exception(" The pages of th ebook should be at least 10 and not more than 1001");
                }
            }
            
        }
        public string Author
        {
            get
            {
                return _author;

            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception(" The Author must be specified ");
                }
                else
                {
                    _author = value;
                }
            }
        }
        
    }
}
