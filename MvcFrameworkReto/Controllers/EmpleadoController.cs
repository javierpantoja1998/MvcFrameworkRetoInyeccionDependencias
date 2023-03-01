using MvcFrameworkReto.Models;
using MvcFrameworkReto.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFrameworkReto.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        private RepositoryEmpleados repo;

        public EmpleadoController(RepositoryEmpleados repo)
        {
            this.repo = repo;
        }

        public ActionResult Index()
        {
            List<Empleado> empleados = this.repo.GetEmpleados();
            return View(empleados);
        }
    }
}