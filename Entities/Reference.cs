using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Reference : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int Ref { get; set; }
        public string Information { get; set; }
        public double Price { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
