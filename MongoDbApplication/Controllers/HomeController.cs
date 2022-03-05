using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbApplication.Context;
using MongoDbApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MongoDbApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var collection = MongoDbContext.CurrDatabase.GetCollection<Character>("characters");

            List<Character> data = collection.Find(new BsonDocument()).ToList();
            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CharacterPartial(Character character)
        {
            
            return PartialView(character);
        }


        public ActionResult AddCharacter(Character character)
        {
            MongoDbContext.CurrDatabase.GetCollection<Character>("characters").InsertOne(character);

            return RedirectToAction("Index");
        }
    }
}