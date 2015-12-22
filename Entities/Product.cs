using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product : IProduct
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Reference> References { get; set; } = new List<Reference>();
        public string ImageUri { get; set; }
        public string Description { get; set; }

        public int FamilyId { get; set; }
        public virtual Family Family { get; set; }
    }
}
