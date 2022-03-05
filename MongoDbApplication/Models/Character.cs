using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MongoDbApplication.Models
{
    public class Character
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }

        public Inventory Inventory { get; set; }

    }
}