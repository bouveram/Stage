using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ReferenceTO
    {
        public int Id { get; set; }
        public int Ref { get; set; }
        public string Information { get; set; }
        public double Price { get; set; }

        public Product Product { get; set; }
    }
}
