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

        public int Strength { get; set; }
        public int Wits { get; set; }
        public int Dexterity { get; set; }
        public int Empathy { get; set; }

        public Inventory Inventory { get; set; }

        public Character(string name, string charClass, int strength, int dex, int wits, int empathy)
        {
            Name = name;
            Class = charClass;
            Strength = strength;
            Dexterity = dex;
            Wits = wits;
            Empathy = empathy;
            Inventory = new Inventory(Strength * 2);
        }

    }
}