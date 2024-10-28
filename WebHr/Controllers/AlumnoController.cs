using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebHr.Models;
using WebHr.servicio;

namespace WebHr.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumno
        public ActionResult Index(string apellido="", string pais="")
        {
            Debug.WriteLine("Param Nombre: " + apellido);
            Debug.WriteLine("Param Pais: " +  pais);

            ServicioAlumno servicioAlumno = new ServicioAlumno();
            List<Alumno> lista = servicioAlumno.listaAlumno(apellido, pais);

            return View(lista);
        }
    }
}