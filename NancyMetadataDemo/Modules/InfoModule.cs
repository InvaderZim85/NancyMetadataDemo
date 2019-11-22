using System;
using Nancy;

namespace NancyMetadataDemo.Modules
{
    public sealed class InfoModule : NancyModule
    {
        [RouteDescription("HelloRoute", "Blub! Very fancy!")]
        [RouteDescription("InfoRoute", "Returns the current date and short hello message")]
        public InfoModule()
        {
            Get("/", _ => Response.AsText("Hello from Nancy!"), name: "HelloRoute");

            Get("/info", _ =>
            {
                var info = new
                {
                    Date = DateTime.Now,
                    Message = "Hello World!"
                };

                return Response.AsJson(info);
            }, name: "InfoRoute");
        }
    }
}
