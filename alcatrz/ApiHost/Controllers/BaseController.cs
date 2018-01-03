using System;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ApiHost.Controllers
{
    public class BaseController : Controller
    {
        public async Task<string> GetSaleInfo()
        {
            HttpResponseMessage response = new HttpResponseMessage();
            using (var httpClient = new HttpClient())
            {
                string id = "1test2";
                string url = ConfigurationManager.AppSettings["DataBaseApi"].ToString();
                //response = await httpClient.GetAsync($"http://localhost:53266/api/saleinfoapi/prod/{id}");
                response = await httpClient.GetAsync(string.Format("http://{0}/api/saleinfoapi/prod/{1}", url, id));
            }
            return response.Content.ReadAsStringAsync().Result;
        }
    }
}