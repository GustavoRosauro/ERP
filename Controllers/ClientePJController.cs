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
        ClientePJ c = new ClientePJ();
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
        public void Adicionar(string Nome, string Uf,string Telefone,string Situacao,string Bairro,string Logradouro,string Numero,string CEP,string Municipio,string Porte,string Abertura,string naturnatureza_juridica,string CNPJ,string Ultima_Atualizacao,string status,string Tipo,string Fantasia,string Complemento,string Email)
        {
            c.Nome = Nome;
            c.Uf = Uf;
            c.Telefone = Telefone;
            c.Situacao = Situacao;
            c.Bairro = Bairro;
            c.Logradouro = Logradouro;
            c.Numero = Numero;
            c.CEP = CEP;
            c.Municipio = Municipio;
            c.Porte = Porte;
            c.Abertura = Abertura;
            c.natureza_juridica = naturnatureza_juridica;
            c.CNPJ = CNPJ;
            c.Ultima_Atualizacao = Ultima_Atualizacao;
            c.status = status;
            c.Tipo = Tipo;
            c.Fantasia = Fantasia;
            c.Complemento = Complemento;
            c.Email = Email;
            db.ClientePJs.Add(c);
            db.SaveChanges();
        }
        public ActionResult Lista()
        {
            return View();
        }
        public JsonResult RetornaLista()
        {
            return Json(db.ClientePJs.ToList(),JsonRequestBehavior.AllowGet);
        }
    }
}

        