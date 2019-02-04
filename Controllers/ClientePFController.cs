using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ERPComercial.Models;

namespace ERPComercial.Controllers
{
    public class ClientePFController : Controller
    {
        private ERPComercialContext db = new ERPComercialContext();
        ClientePF cliente = new ClientePF();
        public ActionResult Cadastro()
        {
            return View();
        }
        public JsonResult Adicionar(string Nome,string Profissao,string Email,string CPF, string CEP,string cidade,string estado,string logradouro,string bairro,string TipoLogradouro)
        {
            cliente.Nome = Nome;
            cliente.Profissao = Profissao;
            cliente.Email = Email;
            cliente.CPF = CPF;
            cliente.CEP = CEP;
            cliente.Cidade = cidade;
            cliente.Estado = estado;
            cliente.Bairro = bairro;
            cliente.logradouro = logradouro;
            cliente.TipoLogradouro = TipoLogradouro;
            db.ClientePFs.Add(cliente);
            db.SaveChanges();
            return Json("Adicionado com sucesso!!");
        }
        public ActionResult Lista()
        {
            return View();
        }
        public JsonResult ListaClientes()
        {
            return Json(db.ClientePFs.ToList(), JsonRequestBehavior.AllowGet);
        }
        public void Excluir(int id)
        {
            var cliente = db.ClientePFs.Find(id);
            db.ClientePFs.Remove(cliente);
            db.SaveChanges();
        }
    }
}
