using System.Collections.Generic;

namespace NetCoreStack.Contracts
{
    public interface INavigatable
    {
        string RouteName { get; set; }
        string ControllerName { get; set; }
        string ActionName { get; set; }
        string Url { get; set; }
        bool Protect { get; set; }
        IDictionary<string, object> RouteValues { get; set; }
    }
}