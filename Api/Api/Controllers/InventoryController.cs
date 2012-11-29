using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Web.Http;
using Api.Services;
using Models;

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
        public string Get(int name)
        {
            throw new NotImplementedException();
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            throw new NotImplementedException();
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
