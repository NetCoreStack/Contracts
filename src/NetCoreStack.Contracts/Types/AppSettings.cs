using System.Collections.Generic;

namespace NetCoreStack.Contracts
{
    public class AppSettings
    {
        public string Name { get; set; }
        public string[] SysAdmins { get; set; }
        public Dictionary<string, string> Environments { get; set; }
    }

    public class ServerSettings : AppSettings
    {
        public string SqlConnectionString { get; set; }
        public string MongoDbConnectionString { get; set; }
        public int? CommandTimeout { get; set; }
    }
}
