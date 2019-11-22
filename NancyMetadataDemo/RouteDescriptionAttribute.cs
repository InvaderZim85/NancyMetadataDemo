using System;

namespace NancyMetadataDemo
{
    [AttributeUsage(AttributeTargets.Constructor, AllowMultiple = true)]
    public class RouteDescriptionAttribute : Attribute
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public RouteDescriptionAttribute(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
