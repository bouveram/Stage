using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositories;
using System.Linq;
using Entities;

namespace TestEntities
{
    /// <summary>
    /// Description résumée pour ContextDB
    /// </summary>
    [TestClass]
    public class TestsRemplissageBD
    {
        
        //[TestMethod]
        public void TestMethod1()
        {
            ContextDeclaration context = new ContextDeclaration();
            List<Product> list = context.Products.ToList();
            Assert.IsTrue(list.Count > 0);
        }

        //[TestMethod]
        public void TestMethodFamily()
        {
            ContextDeclaration context = new ContextDeclaration();
            context.Families.Add(new Family {Name="Peugeot" });
            context.Families.Add(new Family { Name = "Renault" });
            context.Families.Add(new Family { Name = "Citroen" });
            context.Families.Add(new Family { Name = "BMW" });
            context.Families.Add(new Family { Name = "Volkswagen" });
           
            context.SaveChanges();

            FamilyRepository fr = new FamilyRepository { Catalogue = context };
            context.Products.Add(new Product { Name = "208",
                                               Family = fr.GetById(1),
                                               Description = "petite citadine",
                                               ImageUri = "http://www.peugeot.co.uk/media/showrooms/showroom-peugeot-208-5-door-kppv3/medias/Peugeot_208_on_Just_Add_Fuel.jpg"
            });
            context.Products.Add(new Product { Name = "308", Family = fr.GetById(1), Description = "petite familiale", ImageUri = "http://www.peugeot.fr/media/showrooms/showroom-peugeot-308-sw-kppv3/medias/Design.jpg" });
            context.Products.Add(new Product { Name = "Twingo", Family = fr.GetById(2), Description = "petite citadine", ImageUri= "http://images.car.bauercdn.com/upload/33461/images/1040x585/01renaulttwingo5.jpg?mode=pad" });
            context.Products.Add(new Product { Name = "clio", Family = fr.GetById(2), Description = "petite familiale", ImageUri = "http://images.cdn.autocar.co.uk/sites/autocar.co.uk/files/styles/gallery_slide/public/renault-clio-uk-10_4.jpg?itok=XmxBrDvq" });
            context.Products.Add(new Product { Name = "C3", Family = fr.GetById(3), Description = "petite citadine", ImageUri = "http://media.citroen.lu/image/08/8/mm00n9p-1cxaa5nzzk04a04z-zzzzzzzz-001-10.142088.png" });
            context.Products.Add(new Product { Name = "C4", Family = fr.GetById(3), Description = "LA MEILLEURE", ImageUri = "http://media.citroen.fr/image/00/0/-0mm50np9-001.191000.png" });
            context.Products.Add(new Product { Name = "Serie 1", Family = fr.GetById(4), Description = "petite citadine", ImageUri= "http://images.caradisiac.com/logos-ref/modele/modele--bmw-serie-1-f20-m-5-portes/S7-modele--bmw-serie-1-f20-m-5-portes.jpg" });
            context.Products.Add(new Product { Name = "Serie 3", Family = fr.GetById(4), Description = "grosse voiture", ImageUri = "http://img.turbo.fr/04896092-photo-essai-bmw-serie-3-2012-f30-version-335i-sport.jpg" });
            context.Products.Add(new Product { Name = "polo", Family = fr.GetById(5), Description = "petite citadine", ImageUri = "http://images.caradisiac.com/logos-ref/modele/modele--volkswagen-polo-5-gti/S7-modele--volkswagen-polo-5-gti.jpg" });
            context.Products.Add(new Product { Name = "golf", Family = fr.GetById(5), Description = "moyenne citadine", ImageUri = "http://i-cms.linternaute.com/image_cms/original/1462941-volkswagen-golf-7.jpg" });

            context.SaveChanges();

            ProductRepository pr = new ProductRepository { Catalogue = context };
            context.References.Add(new Reference { Ref=5, Information="Version LowCost", Price=10000,Product=pr.GetById(1),  });
            context.References.Add(new Reference { Ref = 10, Information = "Version Chere", Price = 20000, Product = pr.GetById(1) });
            context.References.Add(new Reference { Ref = 15, Information = "Version LowCost", Price = 10000, Product = pr.GetById(2) });
            context.References.Add(new Reference { Ref = 20, Information = "Version Chere", Price = 20000, Product = pr.GetById(2) });
            context.References.Add(new Reference { Ref = 25, Information = "Version LowCost", Price = 10000, Product = pr.GetById(3) });
            context.References.Add(new Reference { Ref = 30, Information = "Version Chere", Price = 20000, Product = pr.GetById(3) });
            context.References.Add(new Reference { Ref = 35, Information = "Version LowCost", Price = 10000, Product = pr.GetById(4) });
            context.References.Add(new Reference { Ref = 40, Information = "Version Chere", Price = 20000, Product = pr.GetById(4) });
            context.References.Add(new Reference { Ref = 45, Information = "Version LowCost", Price = 10000, Product = pr.GetById(5) });
            context.References.Add(new Reference { Ref = 50, Information = "Version Chere", Price = 20000, Product = pr.GetById(5) });
            context.References.Add(new Reference { Ref = 55, Information = "Version LowCost", Price = 10000, Product = pr.GetById(6) });
            context.References.Add(new Reference { Ref = 60, Information = "Version Chere", Price = 20000, Product = pr.GetById(6) });
            context.References.Add(new Reference { Ref = 65, Information = "Version LowCost", Price = 10000, Product = pr.GetById(7) });
            context.References.Add(new Reference { Ref = 70, Information = "Version Chere", Price = 20000, Product = pr.GetById(7) });
            context.References.Add(new Reference { Ref = 75, Information = "Version LowCost", Price = 10000, Product = pr.GetById(8) });
            context.References.Add(new Reference { Ref = 80, Information = "Version Chere", Price = 20000, Product = pr.GetById(8) });
            context.References.Add(new Reference { Ref = 85, Information = "Version LowCost", Price = 10000, Product = pr.GetById(9) });
            context.References.Add(new Reference { Ref = 90, Information = "Version Chere", Price = 20000, Product = pr.GetById(9) });
            context.References.Add(new Reference { Ref = 95, Information = "Version LowCost", Price = 10000, Product = pr.GetById(10) });
            context.References.Add(new Reference { Ref = 100, Information = "Version Chere", Price = 20000, Product = pr.GetById(10) });

            context.SaveChanges();
        }
    }
}
