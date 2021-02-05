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
    public class OS_MethodOfInspectionController : Controller
    {
        private HomeCheckEntities db = new HomeCheckEntities();

        // GET: OS_MethodOfInspection
        public ActionResult Index()
        {
            return View(db.OS_MethodOfInspection.ToList());
        }

        // GET: OS_MethodOfInspection/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_MethodOfInspection oS_MethodOfInspection = db.OS_MethodOfInspection.Find(id);
            if (oS_MethodOfInspection == null)
            {
                return HttpNotFound();
            }
            return View(oS_MethodOfInspection);
        }

        // GET: OS_MethodOfInspection/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OS_MethodOfInspection/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "methodOfInspectionID,methodOfInspection")] OS_MethodOfInspection oS_MethodOfInspection)
        {
            if (ModelState.IsValid)
            {
                db.OS_MethodOfInspection.Add(oS_MethodOfInspection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(oS_MethodOfInspection);
        }

        // GET: OS_MethodOfInspection/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_MethodOfInspection oS_MethodOfInspection = db.OS_MethodOfInspection.Find(id);
            if (oS_MethodOfInspection == null)
            {
                return HttpNotFound();
            }
            return View(oS_MethodOfInspection);
        }

        // POST: OS_MethodOfInspection/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "methodOfInspectionID,methodOfInspection")] OS_MethodOfInspection oS_MethodOfInspection)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oS_MethodOfInspection).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oS_MethodOfInspection);
        }

        // GET: OS_MethodOfInspection/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_MethodOfInspection oS_MethodOfInspection = db.OS_MethodOfInspection.Find(id);
            if (oS_MethodOfInspection == null)
            {
                return HttpNotFound();
            }
            return View(oS_MethodOfInspection);
        }

        // POST: OS_MethodOfInspection/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OS_MethodOfInspection oS_MethodOfInspection = db.OS_MethodOfInspection.Find(id);
            db.OS_MethodOfInspection.Remove(oS_MethodOfInspection);
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
