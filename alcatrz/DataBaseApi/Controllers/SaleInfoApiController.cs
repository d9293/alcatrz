using System.Web.Http;
using DataBaseApi.RepositoryStub;
using SyncClassLibrary.Model;
using System.Configuration;
using DataBaseApi.Repositories;

namespace DataBaseApi.Controllers
{
    public class SaleInfoApiController : ApiController
    {
        [HttpGet]
        [ActionName("prod")]
        public SalesInfoModel test(string id)
        {
            if (ConfigurationManager.AppSettings["version"] == "stub")
            {
                SalesInfoRepositoryStub stub = new SalesInfoRepositoryStub();
                return stub.GetItems(0);
            }
            SalesInfoRepository salesInfo = new SalesInfoRepository();
            return salesInfo.GetItems(0);
        }
    }
}
