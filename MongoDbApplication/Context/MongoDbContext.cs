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

            Character char1 = new Character
            {
                Name = "Vasya",
                Class = "Rogue"
            };
            Character char2 = new Character
            {
                Name = "Petro",
                Class = "Mage"
            };

            collection.InsertMany(new[] {char1,char2 });

        }
    }
}