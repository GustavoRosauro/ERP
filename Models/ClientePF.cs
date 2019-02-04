using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERPComercial.Models
{
    public class ClientePF
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Profissao { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public string logradouro { get; set; }
        public string TipoLogradouro { get; set; }
    }
}