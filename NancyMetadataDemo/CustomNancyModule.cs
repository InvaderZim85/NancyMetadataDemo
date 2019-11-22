using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace NancyMetadataDemo
{
    public class CustomNancyModule : NancyModule
    {
        public override void Get(string path, Func<dynamic, object> action, Func<NancyContext, bool> condition = null, string name = null)
        {
            base.Get(path, action, condition, name);
        }
    }
}
