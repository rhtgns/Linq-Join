using Linq_Join;

class Program
{
    static void Main()
    {
        List<Author> authors = new List<Author>
        {
            new Author { AuthorId = 1, Name = "Orhan Pamuk" },
            new Author { AuthorId = 2, Name = "Elif Şafak" },
            new Author { AuthorId = 3, Name = "Ahmet Ümit" },
            new Author {AuthorId =4, Name ="Nikolav Vasilyevic"},
            new Author {AuthorId =5, Name="Stefan ZWeıg"}
        };

        List<Book> books = new List<Book>
        {
            new Book { BookId = 1, Title = "Masumiyet Müzesi", AuthorId = 1 },
            new Book { BookId = 2, Title = "Benim Adım Kırmızı", AuthorId = 1 },
            new Book { BookId = 3, Title = "Aşk", AuthorId = 2 },
            new Book { BookId = 4, Title = "İstanbul Hatırası", AuthorId = 3 },
            new Book { BookId = 5, Title = "Satranc", AuthorId = 4 }
        };



        var query = from book in books
                    join author in authors on book.AuthorId equals author.AuthorId//LINQ sorgusu ile kitapları ve yazarları birleştiriyoruz
                    select new
                    {
                        Booktitle = book.Title,
                        Authorname = author.Name

                    };


        foreach (var item in query)
        {
            Console.WriteLine($"Kitap: {item.Booktitle},  yazar : {item.Authorname}");
        }

    }
}
