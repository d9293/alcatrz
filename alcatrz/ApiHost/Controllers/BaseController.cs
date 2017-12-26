using System;
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
                response = await httpClient.GetAsync($"http://localhost:53266/api/saleinfoapi/prod/{id}");
                //var response2 = await httpClient.PostAsync(url2);
                //var response3 = await httpClient.SendAsync(url3);
            }
            return response.Content.ReadAsStringAsync().Result;
        }
    }
}