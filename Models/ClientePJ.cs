using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERPComercial.Models
{
    public class ClientePJ
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }
        public string Telefone { get; set; }
        public string Situacao { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }
        public string Municipio { get; set; }
        public string Porte { get; set; }
        public string Abertura { get; set; }
        public string natureza_juridica { get; set; }
        public string CNPJ { get; set; }
        public string Ultima_Atualizacao { get; set; }
        public string status { get; set; }
        public string Tipo { get; set; }
        public string Fantasia { get; set; }
        public string Complemento { get; set; }
        public string Email { get; set; }
    }
}