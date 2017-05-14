using System;
using Xunit;

namespace NetCoreStack.Contracts.Tests
{
    public class SampleModel : CollectionModel
    {
        public string Name { get; set; }
    }

    public class SampleModelBson : CollectionModelBson
    {
        public string Name { get; set; }
    }

    public class ContractTests
    {
        [Fact]
        public void CollectionModel_IsNew()
        {
            var model = new SampleModel();
            Assert.True(model.IsNew);
        }

        [Fact]
        public void CollectionModel_IsNew_Exist()
        {
            var model = new SampleModel();
            model.Id = 6;
            Assert.False(model.IsNew);
        }

        [Fact]
        public void CollectionModelBson_IsNew()
        {
            var model = new SampleModelBson();
            string id = model.Id;
            Assert.True(model.IsNew);
        }

        [Fact]
        public void CollectionModelBson_IsNew_Exist()
        {
            var model = new SampleModelBson();
            model.Id = Guid.NewGuid().ToString("N");
            Assert.False(model.IsNew);
        }
    }
}
