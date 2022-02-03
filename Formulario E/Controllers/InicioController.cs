using Formulario_E.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Formulario_E.Controllers
{
    public class InicioController : Controller
    {
        
        // GET: Inicio
        public FileResult download()
        {
            //parte infuncinal de la descarga
            menu agg = new menu();
            
            var ruta = Server.MapPath(agg.ActionEx().getFILENAME());
            return File(ruta, "Inicio/Vestudiantes", agg.ActionEx().getFILENAME());
        }
        public ActionResult Index()
        {

            
            return View();
        }
        
        public ActionResult Vestudiantes()
        {

            menu agg = new menu();
            //envio los valores al modelo
            agg.Printmethod(
                Request.Form["type"].ToString(), 
                Request.Form["matricula"].ToString(), 
                Request.Form["nombre"].ToString(), 
                Request.Form["apellidos"].ToString(), 
                Request.Form["nacimiento"].ToString(), 
                Request.Form["carrera"].ToString(), 
                Request.Form["direccion"].ToString(), 
                Request.Form["telefono"].ToString(), 
                Request.Form["correo"].ToString());
            //intento descargar de esta forma, pero no funciona
            download();
            return View();
        }
        public ActionResult Showinf()
        {
            //muestro lo valores 
            menu agg = new menu();
            ViewBag.matricula = agg.ActionEx().getMATRICULA();
            ViewBag.nombre = agg.ActionEx().getNOMBRES();
            ViewBag.apellido = agg.ActionEx().getAPELLIDOS();
            ViewBag.nacimiento = agg.ActionEx().getNACIMIENTO();
            ViewBag.carrera = agg.ActionEx().getCARRERA();
            ViewBag.direccion = agg.ActionEx().getDIRECCION();
            ViewBag.telefono = agg.ActionEx().getTELEFONO();
            ViewBag.correo = agg.ActionEx().getEMAIL();

            return View();
        }
    }
}