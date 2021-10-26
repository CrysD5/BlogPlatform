
using BlogPlatform.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace BlogPlatform.Controllers
{
    public class PostController : Controller
    {
        private readonly BlogContext _db;
        public PostController(BlogContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Posts.ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Categories = _db.Categories.ToList();
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(Post post)
        {
            ViewBag.Categories = _db.Categories.ToList();
            post.PublishDate = DateTime.Now;
            _db.Posts.Add(post);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Categories = _db.Categories.ToList();
            var post = _db.Posts.Find(id);
            return View(post);
        }

        [HttpPost]
        public IActionResult Edit(int id, Post model)
        {
            ViewBag.Categories = _db.Categories.ToList();
            _db.Update(model);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var post = _db.Posts.Find(id);
            _db.Posts.Remove(post);
            _db.SaveChanges();

            return RedirectToAction("Index");

        }

        public IActionResult Details(int id)
        {
            var post = _db.Posts.Find(id);
            return View(post);
        }



    }
}
