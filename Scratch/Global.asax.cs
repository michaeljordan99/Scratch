﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using Scratch.Repositories;
using Scratch.Services;
using Scratch.Models.Transactions;
using Scratch.Models.Devices;
using Ninject.Activation;
using Scratch.Provider;

namespace Scratch
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            DIBootstrapper();
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }

        public void DIBootstrapper()
        {
            //Create Ninject DI kernel
            IKernel kernel = new StandardKernel();

            //Register services with Ninject DI Container
            kernel.Bind<IMessageService>().To<MessageService>();
            kernel.Bind<IRepository>().To<Repository>();
            //kernel.Bind<IDevice>().To<TheirDevice>();
            kernel.Bind<IDevice>().ToProvider(new DeviceProvider());

            //Tell ASP.Net MVC 3 to use our Ninject DI Container
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}