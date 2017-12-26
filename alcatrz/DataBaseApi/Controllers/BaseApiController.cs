using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DataBaseApi.Controllers
{
    public class BaseApiController : ApiController
    {
        [HttpGet]
        [Route("test/{id}")]
        public string test(string id)
        {
            return id;
        }
    }
}
