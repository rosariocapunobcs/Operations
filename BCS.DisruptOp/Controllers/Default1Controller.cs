using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BCS.DisruptOp.Models;

namespace BCS.DisruptOp.Controllers
{
    public class Default1Controller : Controller
    {
        private FlightsEntities db = new FlightsEntities();

        //
        // GET: /Default1/

        public ActionResult Index()
        {
            return View(db.Disrupts.ToList());
        }

        //
        // GET: /Default1/Details/5

        public ActionResult Details(int id = 0)
        {
            Disrupt disrupt = db.Disrupts.Find(id);
            if (disrupt == null)
            {
                return HttpNotFound();
            }
            return View(disrupt);
        }

        //
        // GET: /Default1/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Default1/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Disrupt disrupt)
        {
            if (ModelState.IsValid)
            {
                db.Disrupts.Add(disrupt);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(disrupt);
        }

        //
        // GET: /Default1/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Disrupt disrupt = db.Disrupts.Find(id);
            if (disrupt == null)
            {
                return HttpNotFound();
            }
            return View(disrupt);
        }

        //
        // POST: /Default1/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Disrupt disrupt)
        {
            if (ModelState.IsValid)
            {
                db.Entry(disrupt).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(disrupt);
        }

        //
        // GET: /Default1/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Disrupt disrupt = db.Disrupts.Find(id);
            if (disrupt == null)
            {
                return HttpNotFound();
            }
            return View(disrupt);
        }

        //
        // POST: /Default1/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Disrupt disrupt = db.Disrupts.Find(id);
            db.Disrupts.Remove(disrupt);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}