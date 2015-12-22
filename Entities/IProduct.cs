using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IProduct : IEntity
    {
        string Name { get; set; }
        Family Family { get; set; }
        List<Reference> References { get; set; }
        string ImageUri { get; }
        string Description { get; set; }

    }
}
