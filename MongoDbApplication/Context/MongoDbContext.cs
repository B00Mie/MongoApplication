using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MongoDbApplication.Context
{
    public static class MongoDbContext
    {
        public static MongoClient Client { get; set; }
        public static IMongoDatabase CurrDatabase { get; set; }
        //public MongoDbContext(string connection)
        //{
        //    MongoClient client = new MongoClient(connection);
        //    Client = client;
        //    CurrDatabase = client.GetDatabase("test");
        //}
        public static void Init(string connection)
        {
            MongoClient client = new MongoClient(connection);
            client.DropDatabase("test");
            Client = client;
            CurrDatabase = client.GetDatabase("test");
        }
        public static void PassSampleData()
        {
            var collection = CurrDatabase.GetCollection<Character>("characters");
            List<Item> items = new List<Item>();
            items.Add(new Weapon { ItemName = "Нож", Damage = 1, Range = 0, Weight = 0.5, ItemType = "Weapon", WeaponType = "Mele", Quantity = 1 });
            items.Add(new Item { ItemName = "Еда", Weight = 3, Quantity = 6, ItemType = "Food" });
            Inventory i = new Inventory { Capacity = 10, Items = items };

            Character char1 = new Character
            {
                Name = "Vasya",
                Class = "Rogue",
                Inventory = i
            };
            
            Character char2 = new Character
            {
                Name = "Petro",
                Class = "Mage",
                Inventory = i
            };

            collection.InsertMany(new[] {char1,char2 });

        }
    }
}