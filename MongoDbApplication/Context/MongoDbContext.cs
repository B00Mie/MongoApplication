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
            Inventory i = new Inventory(10, items);

            Character char1 = new Character("Vasya", "Rogue", 3);
            char1.Inventory.Items.Add(new Weapon { ItemName = "Knife", Damage = 1, Range = 0, Weight = 0.5, ItemType = "Weapon", WeaponType = "Mele", Quantity = 1 });
            char1.Inventory.Items.Add(new Item { ItemName = "Grub", Weight = 3, Quantity = 6, ItemType = "Food" });
            Character char2 = new Character("Petro", "Mage", 2);
            char2.Inventory.Items.Add(new Weapon { ItemName = "Wind staff", Damage = 1, Range = 0, Weight = 0.5, ItemType = "Weapon", WeaponType = "Magic", Quantity = 1 });
            char2.Inventory.Items.Add(new Item { ItemName = "Grub", Weight = 3, Quantity = 6, ItemType = "Food" });


            collection.InsertMany(new[] {char1,char2 });

        }
    }
}