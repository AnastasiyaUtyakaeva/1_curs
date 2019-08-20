using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Data
{
    public class Book
    {
        static List<Book> books = null;
        public static List<Book> Books
        {
            get
            {
                //При первом обращении к списку читателей загружаем его из файла
                if (books == null)
                {
                    books = new List<Book>();

                    //считываем из файла с книгами по одной строчке
                    foreach (string s in File.ReadAllLines("books.txt"))
                    {
                        var ts = s.Split(',');
                        //создаем новый экземпляр книги
                        books.Add(new Book()
                        {
                            IndividualNumber = int.Parse(ts[0]),
                            nomer = int.Parse(ts[1]),
                            Pages = int.Parse(ts[2]),
                            Author = ts[3].Trim(),
                            Year = int.Parse(ts[4]),
                            Name = ts[5].Trim(),
                            ISBN = ts[6].Trim(),
                            Issuer = ts[7].Trim()
                        });
                    }
                }
                return books;
            }
        }

        public int IndividualNumber { get; set; }
        public int nomer { get; set; }        
        public int Pages { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }
        public string ISBN { get; set; }
        public string Issuer { get; set; }

        //перегрузка стандартной функции, для корректного отображения объекта в выпадающем списке
        public override string ToString()
        {
            return $"{Author}. {Name} - {Year} г. {Pages}. ISBN: {ISBN}.";
        }
    }
}
