using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Unit16._3.BookRepository;
using Xunit;

namespace Unit16._3.Tests
{
    public class BookRepositoryTests
    {
        [Fact]
        public void FindAllMustReturnCorrectValue()
        {
            var list = new List<Book>
            {
                new Book() { Title = "Война и мир" },
                new Book() { Title = "Человек-невидимка" },
                new Book() { Title = "Анна Каренина" },
            };

            Mock<IBookRepository> mock = new Mock<IBookRepository>();

            mock.Setup(b => b.FindAll()).Returns(list);

            Assert.Contains(mock.Object.FindAll(), book => book.Title == "Война и мир");
            Assert.Contains(mock.Object.FindAll(), book => book.Title == "Человек-невидимка");
            Assert.Contains(mock.Object.FindAll(), book => book.Title == "Анна Каренина");
        }
    }
}
