using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DataBaseApi.Controllers
{
    public class SaleInfoApiController : ApiController
    {
        [HttpGet]
        [ActionName("prod")]
        public string test(string id)
        {
            return id;
        }
    }
}
