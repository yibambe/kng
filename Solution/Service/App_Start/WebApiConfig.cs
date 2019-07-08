using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
namespace Service
{
    public class UnsupportedMediaTypeConnegHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
                                                               CancellationToken cancellationToken)
        {
            var contentType = request.Content.Headers.ContentType;
            var formatters = request.GetConfiguration().Formatters;
            var hasFormetterForContentType = formatters //
                .Any(formatter => formatter.SupportedMediaTypes.Contains(contentType));

            if (!hasFormetterForContentType)
            {
                return Task<HttpResponseMessage>.Factory //
                    .StartNew(() => new HttpResponseMessage(System.Net.HttpStatusCode.UnsupportedMediaType));
            }

            return base.SendAsync(request, cancellationToken);
        }
    }
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.EnableCors(new EnableCorsAttribute("*", headers: "*", methods: "*"));
            config.MessageHandlers.Add(new UnsupportedMediaTypeConnegHandler());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
