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
    public class OS_ApproximateAgeController : Controller
    {
        private HomeCheckEntities db = new HomeCheckEntities();

        // GET: OS_ApproximateAge
        public ActionResult Index()
        {
            return View(db.OS_ApproximateAge.ToList());
        }

        // GET: OS_ApproximateAge/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_ApproximateAge oS_ApproximateAge = db.OS_ApproximateAge.Find(id);
            if (oS_ApproximateAge == null)
            {
                return HttpNotFound();
            }
            return View(oS_ApproximateAge);
        }

        // GET: OS_ApproximateAge/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OS_ApproximateAge/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "approximateAgeID,approximateAge")] OS_ApproximateAge oS_ApproximateAge)
        {
            if (ModelState.IsValid)
            {
                db.OS_ApproximateAge.Add(oS_ApproximateAge);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(oS_ApproximateAge);
        }

        // GET: OS_ApproximateAge/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_ApproximateAge oS_ApproximateAge = db.OS_ApproximateAge.Find(id);
            if (oS_ApproximateAge == null)
            {
                return HttpNotFound();
            }
            return View(oS_ApproximateAge);
        }

        // POST: OS_ApproximateAge/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "approximateAgeID,approximateAge")] OS_ApproximateAge oS_ApproximateAge)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oS_ApproximateAge).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oS_ApproximateAge);
        }

        // GET: OS_ApproximateAge/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_ApproximateAge oS_ApproximateAge = db.OS_ApproximateAge.Find(id);
            if (oS_ApproximateAge == null)
            {
                return HttpNotFound();
            }
            return View(oS_ApproximateAge);
        }

        // POST: OS_ApproximateAge/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OS_ApproximateAge oS_ApproximateAge = db.OS_ApproximateAge.Find(id);
            db.OS_ApproximateAge.Remove(oS_ApproximateAge);
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
