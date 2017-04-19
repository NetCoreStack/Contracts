using System;

namespace NetCoreStack.Contracts
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class NavigationRouteAttribute : Attribute
    {
        public string ActionName { get; set; }

        public string ControllerName { get; set; }

        public NavigationRouteAttribute(string actionName, string controllerName, bool validate = false)
        {
            ActionName = actionName;
            ControllerName = controllerName;
        }

        public NavigateDescriptor GetDescriptor(object routeValues = null)
        {
            return new NavigateDescriptor(ActionName, ControllerName, routeValues);
        }
    }
}