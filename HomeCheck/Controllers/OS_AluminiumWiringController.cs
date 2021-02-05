using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HomeCheck.Models;

namespace HomeCheck.Controllers
{
    public class OS_AluminiumWiringController : Controller
    {
        private HomeCheckEntities db = new HomeCheckEntities();

        // GET: OS_AluminiumWiring
        public ActionResult Index()
        {
            return View(db.OS_AluminiumWiring.ToList());
        }

        // GET: OS_AluminiumWiring/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_AluminiumWiring oS_AluminiumWiring = db.OS_AluminiumWiring.Find(id);
            if (oS_AluminiumWiring == null)
            {
                return HttpNotFound();
            }
            return View(oS_AluminiumWiring);
        }

        // GET: OS_AluminiumWiring/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OS_AluminiumWiring/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "aluminiumWiringID,aluminiumWiring")] OS_AluminiumWiring oS_AluminiumWiring)
        {
            if (ModelState.IsValid)
            {
                db.OS_AluminiumWiring.Add(oS_AluminiumWiring);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(oS_AluminiumWiring);
        }

        // GET: OS_AluminiumWiring/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_AluminiumWiring oS_AluminiumWiring = db.OS_AluminiumWiring.Find(id);
            if (oS_AluminiumWiring == null)
            {
                return HttpNotFound();
            }
            return View(oS_AluminiumWiring);
        }

        // POST: OS_AluminiumWiring/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "aluminiumWiringID,aluminiumWiring")] OS_AluminiumWiring oS_AluminiumWiring)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oS_AluminiumWiring).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oS_AluminiumWiring);
        }

        // GET: OS_AluminiumWiring/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_AluminiumWiring oS_AluminiumWiring = db.OS_AluminiumWiring.Find(id);
            if (oS_AluminiumWiring == null)
            {
                return HttpNotFound();
            }
            return View(oS_AluminiumWiring);
        }

        // POST: OS_AluminiumWiring/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OS_AluminiumWiring oS_AluminiumWiring = db.OS_AluminiumWiring.Find(id);
            db.OS_AluminiumWiring.Remove(oS_AluminiumWiring);
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
