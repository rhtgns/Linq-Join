using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Join { 



class Author
{

    public int AuthorId { get; set; } // yazarın benzersiz kimliği
    public string Name { get; set; }  // yazarın adı

}

class Book
{
    public int BookId { get; set; } // kitabın benzersiz kimliği 
    public string Title { get; set; }
    public int AuthorId { get; set; }

}

}