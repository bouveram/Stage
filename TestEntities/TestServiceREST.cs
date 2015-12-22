using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebServices.Controllers;
using Services;
using Repositories;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace TestEntities
{
    [TestClass]
    public class TestServiceREST
    {
        [TestMethod]
        public void TestMethod1()
        {
            //RestController rc = new RestController();
            Service service = new Service();
            service.fr = new FamilyRepository();
            service.fr.Catalogue = new ContextDeclaration();
            List<Family> list = new List<Family>();
            list = service.fr.GetAll().ToList();

            Assert.AreEqual(5, list.Count);

            Assert.AreEqual("Peugeot", list.First().Name);

            Assert.AreEqual(2, list.First().Products.ToList().Count);

            Assert.AreEqual("208", list.First().Products.ToList().First().Name);
        }
    }
}
