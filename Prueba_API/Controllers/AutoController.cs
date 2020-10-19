using Prueba_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba_API.Controllers
{
    public class AutoController : ApiController
    {
        [HttpGet]
        public IEnumerable<Auto> Get()
        {
            using (var context = new CarrosContext())
            {
                return context.Autos.ToList();
            }
        }


        [HttpGet]
        public Auto Get(int id)
        {
            using (var context = new CarrosContext())
            {
                return context.Autos.FirstOrDefault(x=> x.Id==id);
            }
        }

      

        [HttpPost]
        public bool Post(Auto auto)
        {
            using (var context = new CarrosContext())
            {
                context.Autos.Add(auto);
                return context.SaveChanges() > 0;
            }
        }

       

        [HttpPut]
        public bool Put(Auto auto)
        {
            using (var context = new CarrosContext())
            {
                var AutoActualizar = context.Autos.FirstOrDefault(x => x.Id == auto.Id);

                AutoActualizar.Nombre = auto.Nombre;
                AutoActualizar.Modelo = auto.Modelo;
                AutoActualizar.Imagen = auto.Imagen;
                return context.SaveChanges() > 0;
            }
        }


       

        [HttpDelete]
        public bool Delete(int? id)
        {
            using (var context = new CarrosContext())
            {
                var AutoEliminar = context.Autos.FirstOrDefault(x => x.Id == id);
                context.Autos.Remove(AutoEliminar);
                return context.SaveChanges() > 0;
            }
        }
    }
}
