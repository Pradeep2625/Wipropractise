using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Book
    {
        public string Title {  get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public bool IsBorrowed { get; set; }

        public Book(string title, string author, string iSBN)
        {
            bool isBorrowed = false;
            Title=title;
            Author=author;
            ISBN=iSBN;
            
        }

        public void Borrow()
        {
            IsBorrowed = true;
        }
        public void Return()
        {
            IsBorrowed = false;
        }
    }
}
