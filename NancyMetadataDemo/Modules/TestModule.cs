using Nancy;

namespace NancyMetadataDemo.Modules
{
    public sealed class TestModule : NancyModule
    {
        [RouteDescription("HelloRoute", "The main test route")]
        public TestModule() : base("/test")
        {
            Get("/", _ => Response.AsText("Hello from the test module"), name: "HelloRoute");
        }
    }
}
