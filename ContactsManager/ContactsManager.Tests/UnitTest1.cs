using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContactsManager.BusinessObjects;

namespace ContactsManager.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPerson()
        {
            Person p = new Person(1);

            Assert.AreEqual<int>(1, p.ObjectID);

        }
    }
}
