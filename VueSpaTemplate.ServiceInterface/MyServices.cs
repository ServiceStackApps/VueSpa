using System;
using ServiceStack;
using VueSpaTemplate.ServiceModel;

namespace VueSpaTemplate.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
