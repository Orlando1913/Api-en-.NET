using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace Prueba_API.Models
{
    public class CarrosContext : DbContext
    {
        public CarrosContext() : base("ConexionAPI")
        {

        }

        public DbSet<Auto> Autos { get; set; }

         






    }




}