using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ERPComercial.Models;

namespace ERPComercial.Controllers
{
    public class ClientePJController : Controller
    {
        private ERPComercialContext db = new ERPComercialContext();

        // GET: ClientePJ
        public ActionResult Index()
        {
            return View();
        }
        public async Task<JsonResult> Cnpj(string cnpj)
        {
            HttpClient httpClient = new HttpClient();
            var url = "https://www.receitaws.com.br/v1/cnpj/"+cnpj;
            var response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var model = Newtonsoft.Json.JsonConvert.DeserializeObject<ClientePJ>(json);
                return Json(model);
            }
            else {
                return Json("Erro");
            }
        }
    }
}

        