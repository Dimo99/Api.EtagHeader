using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Api.EtagHeader
{
    [AttributeUsage(AttributeTargets.Method,AllowMultiple = false)]
    public class EtagAttribute : Attribute, IFilterFactory
    {
        public IFilterMetadata CreateInstance(IServiceProvider serviceProvider) => new EtagHeaderFilter();

        public bool IsReusable => true;
    }
}