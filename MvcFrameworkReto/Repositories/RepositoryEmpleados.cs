using MvcFrameworkReto.Data;
using MvcFrameworkReto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcFrameworkReto.Repositories
{
    public class RepositoryEmpleados
    {
        private HospitalContext context;

        public RepositoryEmpleados(HospitalContext context)
        {
            this.context = context;
        }

        public List<Empleado> GetEmpleados() {

            return this.context.Empleados.ToList();
        }
    }
}