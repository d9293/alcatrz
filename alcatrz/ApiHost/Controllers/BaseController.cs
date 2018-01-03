using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Net.Http.Formatting;

namespace ApiHost.Controllers
{
    public class BaseController : Controller
    {
        public static async Task<HttpResponseMessage> GetSaleInfo()
        {
            HttpResponseMessage response = new HttpResponseMessage();
            using (var httpClient = new HttpClient())
            {
                string id = "1test2";
                string url = ConfigurationManager.AppSettings["DataBaseApi"].ToString();
                //response = httpClient.GetAsync($"http://localhost:53266/api/saleinfoapi/prod/{id}").Result;
                response = httpClient.GetAsync(string.Format("http://{0}/api/saleinfoapi/prod/{1}", url, id)).Result;
                return response;
            }
        }
    }
}