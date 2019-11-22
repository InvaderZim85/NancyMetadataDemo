using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Nancy.Metadata.Modules;
using NancyMetadataDemo.DataObjects;

namespace NancyMetadataDemo.Metadata
{
    public class MetadataBase<TModule> : MetadataModule<CustomMetadata> where TModule : class
    {
        protected MetadataBase()
        {
            AddDescription();
        }

        private void AddDescription()
        {
            var metaData = GetCustomMetadata<TModule, RouteDescriptionAttribute>();

            foreach (var entry in metaData)
            {
                Describe[entry.Name] = x => new CustomMetadata(x, entry.Description);
            }
        }

        private static List<TAttribute> GetCustomMetadata<TClass, TAttribute>() where TAttribute : Attribute
        {
            return (from constructor in typeof(TClass).GetConstructors()
                from attribute in constructor.GetCustomAttributes<TAttribute>()
                select attribute).ToList();
        }
    }
}