using MVCBlog.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

        // GET: Photoalbums/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Photoalbums/Create
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


        // POST: Photoalbums/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Photoalbum image = db.Images.Find(id);
            if (image == null)
            {
                return HttpNotFound();
            }
            return View(image);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Photoalbum image = db.Images.Find(id);
            db.Images.Remove(image);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}  
