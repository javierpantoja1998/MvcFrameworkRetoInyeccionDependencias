using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.Web;
using Microsoft.OData;
using MvcFrameworkReto.Data;
using MvcFrameworkReto.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MvcFrameworkReto
{
    public class MvcApplication : System.Web.HttpApplication
    {
        
        protected void Application_Start()
        {




            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<HospitalContext>()
                .InstancePerRequest();
            builder.RegisterType<RepositoryEmpleados>()
                .InstancePerRequest();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));


            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);




        }
    }
}
