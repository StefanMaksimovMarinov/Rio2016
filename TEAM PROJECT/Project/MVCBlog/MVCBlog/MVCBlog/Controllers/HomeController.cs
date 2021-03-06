﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBlog.Models;
using System.Data.Entity;

namespace MVCBlog.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var posts = db.Posts.Include(p => p.Author).OrderByDescending(p => p.Date).Take(3);
            return View(posts.ToList());
        }

        public ActionResult History()
        {
            return View();
        }

        public ActionResult Ranking()
        {
            return View();
        }

        public ActionResult Players()
        {
            return View();
        }

        public ActionResult Preparation()
        {
            return View();
        }
    }
}