using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class ProductController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        // GET: Product
        public ActionResult Index()
        {
            var data = db.Products.Select(p => p).ToList();
            return View(data);
        }

        public ActionResult Create()
        {
            ViewBag.Category = db.categories.ToList();
            return View();

        }

        [HttpPost]
        public ActionResult Create(Product model)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    db.Products.Add(model);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

            }
            catch (Exception)
            {
                //
            }
            ViewBag.Category = db.categories.ToList();
            return View("Edit");
        }

        public ActionResult Edit(int id)
        {
            ViewBag.Category = db.categories.ToList();
            var data = db.Products.Find(id);
            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(Product model)
        {
           
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            var model = db.Products.Find(Id);
            if (model != null)
            {
                db.Products.Remove(model);
                db.SaveChanges();
            }
                return RedirectToAction("Index");
        }

    }
}