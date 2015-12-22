using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositories;
using Entities;
using System.Linq;
using System.Collections.Generic;

namespace TestEntities
{
    [TestClass]
    public class TestsRepositories
    {
        [TestMethod]
        public void TestGetAll()
        {
            FamilyRepository fr = new FamilyRepository{ Catalogue = new ContextDeclaration()};
            Assert.AreEqual(5, fr.GetAll().ToList().Count);
        }

        [TestMethod]
        public void TestGetById()
        {
            FamilyRepository fr = new FamilyRepository { Catalogue = new ContextDeclaration() };
            Assert.AreEqual("Peugeot", fr.GetById(1).Name);
            int i = fr.GetById(1).Products.ToList().First().References.ToList().First().Ref;
            Assert.AreEqual(5, i);
        }


        [TestMethod]
        public void TestGetProductByFamily()
        {
            FamilyRepository fr = new FamilyRepository { Catalogue = new ContextDeclaration() };
            List<Product> l = new List<Product>();
            l = fr.GetById(1).Products.ToList();
            Assert.AreEqual(2, l.Count);
        }


        [TestMethod]
        public void TestGetFamilyByProduct()
        {
            ProductRepository pr = new ProductRepository { Catalogue = new ContextDeclaration() };
            Assert.AreEqual("Peugeot", pr.GetById(2).Family.Name);
        }
    }
}
