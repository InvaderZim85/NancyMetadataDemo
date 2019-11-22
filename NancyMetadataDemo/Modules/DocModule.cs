using System.Linq;
using Nancy;
using Nancy.Routing;
using NancyMetadataDemo.DataObjects;

namespace NancyMetadataDemo.Modules
{
    public sealed class DocModule : NancyModule
    {
        public DocModule(IRouteCacheProvider cacheProvider) : base("/docs")
        {
            Get("/", _ =>
            {
                var metadata = cacheProvider.GetCache().RetrieveMetadata<CustomMetadata>().Where(w => w != null)
                    .ToList();

                return Response.AsJson(metadata);
            });

            Get("/page", _ =>
            {
                var metaData = cacheProvider.GetCache().RetrieveMetadata<CustomMetadata>().Where(w => w != null)
                    .ToList();

                return View["RouteInfo.html", metaData];
            });
        }
    }
}
