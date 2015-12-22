using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entities;

namespace Services
{
    public class ProductTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ReferenceTO> References { get; set; } = new List<ReferenceTO>();
        public string ImageUri { get; set; }
        public string Description { get; set; }
            
        public Family Family { get; set; }
    }
}