using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
     public class Book
     {
        string name; //название товара

        Author a;

        public Author Author
        {
            get { return a; }
            set { a = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Book()
        {
            Author = null;
            Name = "unknown";
        }
        
        public override string ToString()
        {
            return Name;
        }

    }

}
