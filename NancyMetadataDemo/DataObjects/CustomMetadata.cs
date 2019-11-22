using System.Collections.Generic;
using Nancy.Routing;

namespace NancyMetadataDemo.DataObjects
{
    public class CustomMetadata
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Method { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> Segments { get; set; }

        public CustomMetadata(RouteDescription route, string description)
        {
            Name = route.Name;
            Path = route.Path;
            Method = route.Method;
            Segments = route.Segments;
            Description = description;
        }
    }
}
