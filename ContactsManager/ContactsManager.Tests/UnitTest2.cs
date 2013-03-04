using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ContactsManager.BusinessObjects;

namespace ContactsManager.Tests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void RepositoryTestGetAll()
        {

            ContactsManager.Repository.Implementations.ContactRepository repos = new Repository.Implementations.ContactRepository();

            var actual = repos.GetContacts();

            var expected = new List<Contact>();

            Assert.AreNotSame(expected,actual);
        
        }
    }
}
