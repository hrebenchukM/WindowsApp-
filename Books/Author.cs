using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
     public class Author
     {
        string name; //название товара

        List<Book> books = new List<Book>();
        public List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Author()
        {
            Name = "unknown";
        }
        public override string ToString()
        {
            return Name ;
        }

    }
}
