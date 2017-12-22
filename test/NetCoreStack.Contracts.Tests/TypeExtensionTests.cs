using Xunit;

namespace NetCoreStack.Contracts.Tests
{
    public class TypeExtensionTests
    {
        [Fact]
        public void ObjectToDictionary()
        {
            var obj = new NavigateDescriptor("index", "home", new { foo = "bar" });
            obj.SetRouteValues(new { someProperty = "someValue", intProp = 1 });
            var dictionary = obj.RouteValues;

            Assert.True(dictionary.ContainsKey("foo"));
            Assert.True(dictionary.ContainsKey("someProperty"));
            Assert.True(dictionary.ContainsKey("intProp"));
        }
    }
}
