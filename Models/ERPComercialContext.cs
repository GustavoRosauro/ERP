using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ERPComercial.Models
{
    public class ERPComercialContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ERPComercialContext() : base("name=ERPComercialContext")
        {
        }

        public System.Data.Entity.DbSet<ERPComercial.Models.ClientePF> ClientePFs { get; set; }

        public System.Data.Entity.DbSet<ERPComercial.Models.ClientePJ> ClientePJs { get; set; }
    }
}
