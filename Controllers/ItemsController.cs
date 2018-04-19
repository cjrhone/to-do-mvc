using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class ItemsController : Controller
    {

        [HttpGet("/items")]
        public ActionResult Index()
        {
            List<Item> allItems = Item.GetAll();
            return View(allItems);
        }

        [HttpGet("/items/new")]
        public ActionResult CreateForm()
        {
            return View();
        }
        // [HttpPost("/items")]
        // public ActionResult Create()
        // {
        //   Item newItem = new Item (Request.Form["new-item"]);
        //   // newItem.Save(); //no longer needed because each item contains ID
        //   List<Item> allItems = Item.GetAll();
        //   return View("Index", allItems); //Categories Controller handles creating now
        // }

        [HttpPost("/items/delete")]
        public ActionResult DeleteAll()
        {
            Item.ClearAll();
            return View();
        }

        [HttpGet("/items/{id}")] //Route to be called when someone clicks a particular Item (1,2,3,etc)
        public ActionResult Details(int id)
        {
          Item item = Item.Find(id);
          return View(item);
        }

        [HttpGet("/categories/{categoryId}/items/new")]
        public ActionResult CreateForm(int categoryId)
         {
          Dictionary<string, object> model = new Dictionary<string, object>();
          Category category = Category.Find(categoryId);
          return View(category);
         }

         [HttpGet("/categories/{categoryId}/items/{itemId}")]
         public ActionResult Details(int categoryId, int itemId)
         {
            Item item = Item.Find(itemId);
            Dictionary<string, object> model = new Dictionary<string, object>();
            Category category = Category.Find(categoryId);
            model.Add("item", item);
            model.Add("category", category);
            return View(item);
        }
    }
}
