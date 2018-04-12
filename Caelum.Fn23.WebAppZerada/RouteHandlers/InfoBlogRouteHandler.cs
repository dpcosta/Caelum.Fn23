using Caelum.Fn23.WebAppZerada.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Caelum.Fn23.WebAppZerada.RouteHandlers
{
    public class InfoBlogHandler : IHttpHandler
    {
        public bool IsReusable => true;

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("<html>");
            context.Response.Write("<body>");
            context.Response.Write("Este é um blog de resenhas culturais.");
            context.Response.Write("</body>");
            context.Response.Write("</html>");
            context.Response.End();
        }
    }

    public class InfoBlogRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new InfoBlogHandler();
        }
    }
}