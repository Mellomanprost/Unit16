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
    }
}
