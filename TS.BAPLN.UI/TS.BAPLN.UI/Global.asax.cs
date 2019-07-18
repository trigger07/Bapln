using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace TS.BAPLN.UI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_PreSendRequestHeaders(object sender, EventArgs e)
        {
            // Remove the "Server" HTTP Header from response
            HttpApplication app = sender as HttpApplication;
            if (null != app && null != app.Request && !app.Request.IsLocal &&
                null != app.Context && null != app.Context.Response)
            {
                NameValueCollection headers = app.Context.Response.Headers;
                if (null != headers)
                {
                    headers.Remove("Server");
                }
            }
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("favicon.ico");
            routes.IgnoreRoute("{*browserlink}", new { browserlink = @".*__browserLink.*" });

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "Estudiante/Estudiantes/",
            url: "Estudiantes",
            defaults: new { controller = "Estudiante", action = "Estudiantes", id = UrlParameter.Optional });

            routes.MapRoute(
            name: "Estudiante/Crear/",
            url: "CrearEstudiante",
            defaults: new { controller = "Estudiante", action = "Crear", id = UrlParameter.Optional });

            // routes.MapRoute(
            //name: "Estudiante/Editar/",
            //url: "EditarEstudiante",
            //defaults: new { controller = "Estudiante", action = "Editar", id = UrlParameter.Optional });

            routes.MapRoute(
            name: "Estudiante/Activar/",
            url: "ActivarEstudiante",
            defaults: new { controller = "Estudiante", action = "Activar", id = UrlParameter.Optional });

            routes.MapRoute(
            name: "Estudiante/Inactivar/",
            url: "InactivarEstudiante",
            defaults: new { controller = "Estudiante", action = "Inactivar", id = UrlParameter.Optional });

            //routes.MapRoute(
            //name: "Institucion/Instituciones/",
            //url: "Instituciones",
            //defaults: new { controller = "Institucion", action = "Instituciones", id = UrlParameter.Optional });
        }
    }
}
