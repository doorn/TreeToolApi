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
    public class EstatesController : ApiController
    {
        // GET api/values
        public IEnumerable<EstateModel> Get()
        {
            EstateService service = new EstateService();
            return service.GetEstates();
        }

        // GET api/values/5
        public HttpStatusCode Get(int id)
        {
            return HttpStatusCode.NotImplemented;
        }

        // POST api/values
        public HttpStatusCode Post([FromBody]string value)
        {
            return HttpStatusCode.NotImplemented;
        }

        // PUT api/values/5
        public HttpStatusCode Put(int id, [FromBody]string value)
        {
            return HttpStatusCode.NotImplemented;
        }

        // DELETE api/values/5
        public HttpStatusCode Delete(int id)
        {
            return HttpStatusCode.NotImplemented;
        }

    }
}
