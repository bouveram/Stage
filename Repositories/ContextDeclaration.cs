using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ContextDeclaration : DbContext
    {
        public DbSet<Family> Families { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<Product> Products { get; set; }

        public ContextDeclaration():base("Name=ContextDeclaration") {}

        

    }
}
