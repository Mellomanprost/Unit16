using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;


namespace Unit16._3.Tests
{
    [TestFixture]
    public class UserRepositoryTests
    {
        [Test]
        public void FindAllMustReturnCorrectValue()
        {
            var list = new List<User>
            {
                new User() { Name = "Антон" },
                new User() { Name = "Иван" },
                new User() { Name = "Алексей" },
            };

            Mock<IUserRepository> mock = new Mock<IUserRepository>();

            mock.Setup(u => u.FindAll()).Returns(list);

            Assert.That(mock.Object.FindAll().Any(user => user.Name == "Антон"));
            Assert.That(mock.Object.FindAll().Any(user => user.Name == "Иван"));
            Assert.That(mock.Object.FindAll().Any(user => user.Name == "Алексей"));
        }
    }
}
