using Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Api.Controllers
{
    public class TreeController : ApiController
    {
        // GET api/values
        public string Get()
        {
            TreeService service = new TreeService();
            return HttpStatusCode.NotImplemented.ToString();
        }

        // GET api/values/5
        public string Get(int id)
        {
            throw new NotImplementedException();
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
