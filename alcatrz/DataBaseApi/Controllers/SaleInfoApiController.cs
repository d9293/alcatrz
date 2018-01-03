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
