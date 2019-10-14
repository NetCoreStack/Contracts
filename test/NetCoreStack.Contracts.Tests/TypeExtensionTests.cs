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

        [Fact]
        public void OrderDescriptorsAscending()
        {
            var order = new ColumnOrder
            {
                Column = 0,
                Dir = "asc"
            };

            var descriptor = order.ConvertToDescriptor("Title");

            Assert.True(descriptor.Direction == ListSortDirection.Ascending);
            Assert.True(descriptor.ColumnIndex == 0);
            Assert.True(descriptor.Name == "Title");
        }

        [Fact]
        public void OrderDescriptorsDescending()
        {
            var order = new ColumnOrder
            {
                Column = 1,
                Dir = "desc"
            };

            var descriptor = order.ConvertToDescriptor("Firstname");

            Assert.True(descriptor.Direction == ListSortDirection.Descending);
            Assert.True(descriptor.ColumnIndex == 1);
            Assert.True(descriptor.Name == "Firstname");
        }
    }
}
