using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit16._6._2.Tests
{
    [TestClass]
    public class FileWorkerTests
    {
        [TestMethod]
        public void GetSafeFilenameMustReturnCorrectValue()
        {
            var fileWorker = new FileWorker();
            PrivateObject privateObject = new PrivateObject(fileWorker, new PrivateType(typeof(FileWorker)));
            var privateFunction = privateObject.Invoke("GetSafeFilename", @"File\_:?fileName:");
            Assert.AreEqual(privateFunction, "File____fileName_");
        }
    }
}
