using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit16._3.BookRepository
{
    public interface IBookRepository
    {
        IEnumerable<Book> FindAll();
    }
}
