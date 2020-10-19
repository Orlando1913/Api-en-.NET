using Newtonsoft.Json;
using ServiciosWeb.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Mvc;


namespace ServiciosWeb.ClienteWeb.Controllers
{
    public class AutoController : Controller
    {
        // GET: Auto
        public ActionResult Index()
        {
            HttpClient clienteHttp = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:44326")
            };

            var request = clienteHttp.GetAsync("api/Auto").Result;

            if (request.IsSuccessStatusCode)
            {
                var resultString = request.Content.ReadAsStringAsync().Result;
                var Listado = JsonConvert.DeserializeObject<List<Auto>>(resultString);

                return View(Listado);
            }
            return View();
        }

        [HttpGet]
        public ActionResult Nuevo()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Nuevo(Auto auto)
        {
            HttpClient clienteHttp = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:44326")
            };

            var request = clienteHttp.PostAsync("api/Auto", auto, new JsonMediaTypeFormatter()).Result;

            if (request.IsSuccessStatusCode)
            {
                var resultString = request.Content.ReadAsStringAsync().Result;
                var correcto = JsonConvert.DeserializeObject<bool>(resultString);

                if (correcto)
                {
                    return RedirectToAction("Index");
                }
                return View(auto);
            }
            return View(auto);
        }


        [HttpGet]
        public ActionResult Actualizar(int? id)
        {
            HttpClient clienteHttp = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:44326")
            };

            var request = clienteHttp.GetAsync("api/Auto?id=" + id).Result;

            if (request.IsSuccessStatusCode)
            {
                var resultString = request.Content.ReadAsStringAsync().Result;
                var informacion = JsonConvert.DeserializeObject<Auto>(resultString);
                return View(informacion);
            }
            return View();
        }


        [HttpPost]
        public ActionResult Actualizar(Auto auto)
        {
            HttpClient clienteHttp = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:44326")
            };

            var request = clienteHttp.PutAsync("api/Auto?id=", auto, new JsonMediaTypeFormatter()).Result;

            if (request.IsSuccessStatusCode)
            {
                var resultString = request.Content.ReadAsStringAsync().Result;
                var correcto = JsonConvert.DeserializeObject<bool>(resultString);

                if (correcto)
                {
                    return RedirectToAction("Index");
                }
                return View(auto);
            }
            return View(auto);
        }


        //[HttpDelete]
        public ActionResult Eliminar(int? id)
        {

            HttpClient clienteHttp = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:44326")
            };

            var request = clienteHttp.DeleteAsync("api/Auto?id=" + id).Result;

            if (request.IsSuccessStatusCode)
            {
                var resultString = request.Content.ReadAsStringAsync().Result;
                var correcto = JsonConvert.DeserializeObject<bool>(resultString);

                if (correcto)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }


        [HttpGet]
        public ActionResult Detalle(int? id)
        {
            HttpClient clienteHttp = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:44326")
            };

            var request = clienteHttp.GetAsync("api/Auto?id=" + id).Result;

            if (request.IsSuccessStatusCode)
            {
                var resultString = request.Content.ReadAsStringAsync().Result;
                var informacion = JsonConvert.DeserializeObject<Auto>(resultString);
                return View(informacion);
            }
            return View();
        }
    }
}