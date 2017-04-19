using System.Collections.Generic;

namespace NetCoreStack.Contracts
{
    public class NavigateDescriptor : INavigatable
    {
        public string RouteName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string Url { get; set; }
        public bool Protect { get; set; }
        public IDictionary<string, object> RouteValues { get; set; }

        public NavigateDescriptor(string actionName, string controllerName, object routeValues, bool protect = true)
        {
            RouteValues = new Dictionary<string, object>();
            ActionName = actionName;
            ControllerName = controllerName;
            Protect = protect;
            SetRouteValues(routeValues);
        }

        public void SetRouteValues(object values)
        {
            if (values != null)
            {
                RouteValues.Merge(values.ToDictionary());
            }
        }
    }
}