using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MongoDbApplication.Models
{
    public class Inventory
    {
        public int Capacity { get; set; } = 0;
        public List<Item> Items { get; set; } = new List<Item>();

        public Inventory(int capacity, List<Item> items = null)
        {
            Capacity = capacity;
            Items = items ?? new List<Item>();
        }
    }
}