using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Csharp_OO_FS_Net.Demos
{
    public class Book
    {
        public static int CurrentId = 1;
        public Book()
        {
            Id = CurrentId++;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"Id : {Id} \n" +
                   $"Titre : {Title} \n" +
                   $"Descritpion : {Description} \n" +
                   $"Auteur : {Author}"; 
        }
    }

    public static class FakeDb
    {
        public static List<Book> Books = new List<Book>()
        {
            new Book()
            {
                Title = "The Great Gatsby",
                Description = "A novel by F. Scott Fitzgerald",
                Author = "F. Scott Fitzgerald"
            },
            new Book()
            {
                Title = "To Kill a Mockingbird",
                Description = "A novel by Harper Lee",
                Author = "Harper Lee"
            },
            new Book()
            {
                Title = "1984",
                Description = "A novel by George Orwell",
                Author = "George Orwell"
            }
        };
        //public List<User> Users = new List<User>()
        //{
        //    ...
        //};
    }
}
