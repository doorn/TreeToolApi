using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Web.Http;
using Api.Services;
using Models;
using System.Net;

namespace Api.Controllers
{
    public class InventoryController : ApiController
    {
        // GET api/values
        public string Get()
        {
            throw new NotImplementedException();
        }

        // GET api/values/5
        public IEnumerable<TreeInventoryModel> Get(int id)
        {
            try
            {
                InventoryService service = new InventoryService();
                return service.GetTreeInventoryByEstateName(id);
            }
            catch (Exception ex) { 
                 var response = ControllerContext.Request.CreateResponse(HttpStatusCode.NotFound);
                 throw new HttpResponseException(response);
            }
        }

        // POST api/values
        public HttpStatusCode Post([FromBody]TreeInventoryModel inventory)
        {
            InventoryService service = new InventoryService();
            return service.SaveInventory(inventory);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

    }
}
