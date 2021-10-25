using BlogPlatform.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Controllers
{
    public class CategoryController : Controller
    {
        private BlogContext _db;
        public CategoryController(BlogContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Posts.ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Post = _db.Posts.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {            
            _db.Categories.Add(category);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var category = _db.Categories.Find(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(int id, Category model)
        {
            _db.Update(model);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var category = _db.Categories.Find(id);
            _db.Categories.Remove(category);
            _db.SaveChanges();

            return RedirectToAction("Index");

        }

        public IActionResult Details(int id)
        {
            var category = _db.Categories.Find(id);
            return View(category);
        }
    }
}
