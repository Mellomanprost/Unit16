using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserTicketService.MS.Tests
{
    [TestClass]
    public class WorkRepositoryTests
    {
        [TestMethod]
        public void ConnectionTrueMustReturnTrue()
        {
            var workRepository = new WorkRepository();
            PrivateObject privateObject = new PrivateObject(workRepository, new PrivateType(typeof(BaseRepository)));

            Assert.AreEqual(true, privateObject.Invoke("ConnectionTrue"));
        }

        //[TestMethod]
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
