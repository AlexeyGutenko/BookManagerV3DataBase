using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagerV3DataBase
{
    internal class Book
    {
        public int Id { get; set; }
        public string Autor_Book { get; set; }
        public string Title_Book { get; set; }
        public string description { get; set; } 
        public int publication_date { get; set; }
        public string file_URL { get; set; }
        
        public Book(int id, string Autor_Book, string Title_Book,string description ,int publication_date,string file_URL)
        {
            this.Id = id;
            this.Autor_Book = Autor_Book;
            this.Title_Book = Title_Book;
            this.description= description;
            this.publication_date = publication_date;
            this.file_URL = file_URL;
        }
    }
}
