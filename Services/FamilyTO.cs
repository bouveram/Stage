using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services
{
    public class FamilyTO
    {
        public int Id { get; set; }
        public List<ProductTO> Products { get; set; } = new List<ProductTO>();
        public string Name { get; set; }
    }
}