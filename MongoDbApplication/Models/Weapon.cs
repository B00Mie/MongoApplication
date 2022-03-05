using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MongoDbApplication.Models
{
    public class Weapon :Item
    {
        public double Damage { get; set; }
        public string WeaponType { get; set; }
        public double Range { get; set; }
    }
}