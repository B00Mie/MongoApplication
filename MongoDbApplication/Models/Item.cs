using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MongoDbApplication.Models
{
    public class Item
    {
        public string ItemName { get; set; }
        public double Weight { get; set; }
        public string ItemType { get; set; }
        public double Quantity { get; set; }
    }
}