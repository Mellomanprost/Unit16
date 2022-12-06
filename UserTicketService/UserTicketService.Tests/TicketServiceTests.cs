using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UserTicketService.Tests
{
    [TestFixture]
    public class TicketServiceTests
    {
        [Test]
        public void GetTicketPriceMustReturnNotNullableTicket()
        {
            var ticketServiceTest = new TicketService();
            Assert.IsNotNull(ticketServiceTest.GetTicketPrice(1));
        }

        [Test]
        public void GetTicketPriceMustThrowException()
        {
            var ticketServiceTest = new TicketService();
            Assert.Throws<TicketNotFoundException>(() => ticketServiceTest.GetTicketPrice(100));
        }

        [Test]
        public void GetTicketMustReturnNotNullableTicket()
        {
            var ticketServiceTest = new TicketService();
            Assert.IsNotNull(ticketServiceTest.GetTicket(1));
        }

        //[Test]
        //public void SaveTicket()
        //{
        //    var ticketServiceTest = new TicketService();
        //    var newTicket = new Ticket(300, "Test ticket", 1000);

        //    ticketServiceTest.SaveTicket(newTicket);

        //    var allTicketsAfterAddingNewTicket = ticketServiceTest.GetAllTickets();
        //    CollectionAssert.Contains(allTicketsAfterAddingNewTicket, newTicket);

        //    PrivateObject obj = new PrivateObject(ticketServiceTest);

        //    obj.Invoke("DeleteTicket", newTicket);

        //    var allTicketsAfterDeletingNewTicket = ticketServiceTest.GetAllTickets();
        //    CollectionAssert.DoesNotContain(allTicketsAfterDeletingNewTicket, newTicket);
        //}

    }

}
