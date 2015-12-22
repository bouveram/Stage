using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities;
using System.Collections.Generic;

namespace TestEntities
{
    [TestClass]
    public class testsEntities
    {
        [TestMethod]
        public void TestReference()
        {
            Reference r = new Reference
            {
                Id = 1,
                Information = "ceci est une info",
                Price = 10.5,
                Ref = 10000222

            };

            Assert.AreEqual(10.5, r.Price);
        }

        [TestMethod]
        public void TestFamily()
        {
            Family f = new Family
            {
                Id = 1,
                Name ="famille de produits"

            };

            Assert.AreEqual("famille de produits", f.Name);
        }

        [TestMethod]
        public void TestProduct()
        {
            Family f = new Family
            {
                Id = 1,
                Name = "famille de produits"

            };
            Reference r1 = new Reference
            {
                Id = 1,
                Information = "ceci est une info1",
                Price = 10.5,
                Ref = 10000221

            };
            Reference r2 = new Reference
            {
                Id = 2,
                Information = "ceci est une info2",
                Price = 10.5,
                Ref = 10000222

            };

            Product p = new Product
            { Id = 1, Name = "produit 1", References = new List<Reference> {r1,r2 }, Family = f };
            Assert.AreEqual(2, p.References.Count);
            Assert.AreEqual(1, p.Family.Id);
        }
    }
}
