using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Entities;

namespace Services
{
    public class Service
    {
        public FamilyRepository fr { get; set; }
        public ProductRepository pr { get; set; }
        public ReferenceRepository rr { get; set; }

        public IEnumerable<FamilyTO> GetFamilyList()
        {
            FamilyTO familyTO;
            ProductTO productTO;
            List<FamilyTO> list = new List<FamilyTO>();
            fr = new FamilyRepository();
            fr.Catalogue = new ContextDeclaration();//à l'avenir on utilisera Unity
            foreach (Family f in fr.GetAll().ToList())
            {
                familyTO = new FamilyTO();
                familyTO.Name = f.Name;
                familyTO.Id = f.Id;
                foreach (Product p in f.Products)
                {
                    productTO = new ProductTO
                    {
                        Name = p.Name,
                        ImageUri = p.ImageUri,
                        Description = p.Description,
                        Id = p.Id
                    };
                    familyTO.Products.Add(productTO);
                }

                list.Add(familyTO);
            }
            return list;
        }

        public IEnumerable<ProductTO> GetProductList()
        {
            ProductTO productTO;
            ReferenceTO referenceTO;
            List<ProductTO> list = new List<ProductTO>();
            pr = new ProductRepository();
            pr.Catalogue = new ContextDeclaration();
            foreach (Product p  in pr.GetAll().ToList())
            {
                productTO = new ProductTO();
                productTO.Name = p.Name;
                productTO.ImageUri = p.ImageUri;
                productTO.Description = p.Description;
                foreach (Reference r in p.References)
                {
                    referenceTO = new ReferenceTO
                    {
                        Information = r.Information,
                        Price = r.Price,
                        Ref = r.Ref
                    };
                    productTO.References.Add(referenceTO);                    

                }
                list.Add(productTO);
            }

            return list;
        }

        public ProductTO GetProductById(int id)
        {
            
            pr = new ProductRepository{Catalogue= new ContextDeclaration()};
            Product p = pr.GetById(id);
            ProductTO productTO = new ProductTO();
            productTO.Name = p.Name;
            productTO.Description = p.Description;
            productTO.ImageUri = p.ImageUri;
            foreach (Reference r in p.References)
            {
                ReferenceTO referenceTO = new ReferenceTO
                {
                    Information = r.Information,
                    Price = r.Price,
                    Ref = r.Ref
                };
                productTO.References.Add(referenceTO);

            }
            return productTO;
        }

        public void SetRefToProduct(int id, ReferenceTO reference)
        {
            pr = new ProductRepository { Catalogue = new ContextDeclaration() };
            Product p = pr.GetById(id);
            p.References.Add(new Reference { Ref=reference.Ref, Information=reference.Information, Price=reference.Price });
            pr.Save();
        }
    }
}
