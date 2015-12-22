using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Services;
using Repositories;
using Entities;

namespace WebServices.Controllers
{
    public class RestController : ApiController
    {
        [HttpGet]
        [Route("rest/family/list")]
        public IEnumerable<FamilyTO> GetFamilyList()
        {
            Service service = new Service();

            return service.GetFamilyList();
        }

        [HttpGet]
        [Route("rest/product/list")]
        public IEnumerable<ProductTO> GetProductList()
        {
            Service service = new Service();

            return service.GetProductList();
        }

        [HttpGet]
        [Route("rest/product/{id}")]

        public ProductTO GetById(int id)
        {
            Service service = new Service();

            return service.GetProductById(id);
        }

        [HttpPost]
        [Route("rest/add-reference")]
        public void SetRefToProduct([FromBody] ReferenceTO reference)
        {
            Service service = new Service();
            int productId = reference.Id;
            service.SetRefToProduct(productId, reference);
        }

    }
}
