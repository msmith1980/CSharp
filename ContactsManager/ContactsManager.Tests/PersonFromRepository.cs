using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ContactsManager.BusinessObjects;
using ContactsManager.Repository.Contracts;
using ContactsManager.Repository.Implementations;
using System.ComponentModel.Composition;
using MEFedMVVM.ViewModelLocator;
using MEFedMVVM.Services;
using MEFedMVVM.Common;
using MEFedIoC;
using Rhino.Mocks;


namespace ContactsManager.Tests
{
    [TestClass]
    public class PersonFromRepository
    {
        IContactsRepository<Contact> contactRepository;

        [TestInitialize]
        public void Initialise()
        {
            contactRepository = MockRepository.GenerateMock<ContactRepository>();
        }

        [TestMethod]
        public void RepositoryTestGetAll()
        {

            var actual = contactRepository.GetContacts();

            var expected = new List<Contact>();

            Assert.AreNotSame(expected, actual);

        }

        [TestMethod]
        [TestCategory("ContactsManager.DAL")]
        [DataSource("PeopleSource")]
        public void BuildPerson()
        {
            Assert.IsTrue(true);
        }

    }
}
