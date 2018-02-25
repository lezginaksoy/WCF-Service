using Autofac;
using Autofac.Integration.Wcf;
using Lidya.Business;
using Lidya.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Lidya.ServiceHost
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            IOCConfiguration();
        }

        private void IOCConfiguration()
        {
            var builder = new ContainerBuilder();
                       
            builder.RegisterType<CoreBusiness>().As<ICoreBusiness>();
            builder.RegisterType<CategoryBusiness>().As<ICategoryBusiness>();
            builder.RegisterType<MemberBusiness>().As<IMemberBusiness>();
            builder.RegisterType<ProductBusiness>().As<IProductBusiness>();
            builder.RegisterType<OrderBusiness>().As<IOrderBusiness>();
            builder.RegisterType<MediaBusiness>().As<IMediaBusiness>();
            builder.RegisterType<ReturnBusiness>().As<IReturnBusiness>();
            builder.RegisterType<XmlBusiness>().As<IXmlBusiness>();
            builder.RegisterType<Lidya.ServiceHost.Integration>();
            
            AutofacHostFactory.Container = builder.Build();            
        }

        //protected void Session_Start(object sender, EventArgs e)
        //{

        //}

        //protected void Application_BeginRequest(object sender, EventArgs e)
        //{

        //}

        //protected void Application_AuthenticateRequest(object sender, EventArgs e)
        //{

        //}

        //protected void Application_Error(object sender, EventArgs e)
        //{

        //}

        //protected void Session_End(object sender, EventArgs e)
        //{

        //}

        //protected void Application_End(object sender, EventArgs e)
        //{

        //}
    }
}