﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlog.Controllers
{
    public class PhotoalbumsController : Controller
    {
        // GET: Photoalbums
        public ActionResult Index()
        {
            return View();
        }
    }
}