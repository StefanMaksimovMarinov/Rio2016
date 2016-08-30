using MVCBlog.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlog.Controllers
{
    public class PhotoalbumsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Photoalbums
        public ActionResult Index()
        {
            List<Photoalbum> all = new List<Photoalbum>();
            all = db.Images.ToList();
            return View(all);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(HttpPostedFileBase file)
        {
            Photoalbum IG = new Photoalbum();
            IG.FileName = file.FileName;
            IG.ImageSize = file.ContentLength;

            byte[] data = new byte[file.ContentLength];
            file.InputStream.Read(data, 0, file.ContentLength);

            IG.ImageData = data;

            var model = new Photoalbum
            {
                FileName = file.FileName,
                ImageSize = file.ContentLength,
                ImageData = data,
                File = file
            };
            db.Images.Add(IG);
            db.SaveChanges();
            
            return RedirectToAction("Index");
        }
    }
}