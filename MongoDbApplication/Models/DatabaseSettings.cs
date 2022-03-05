using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MongoDbApplication.Models
{
    public class DatabaseSettings
    {
        public string ConnnectionString { get; set; } = null;
        public string DatabaseName { get; set; } = null;
        public string CollectionName { get; set; } = null;
    }
}