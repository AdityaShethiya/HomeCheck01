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
    public class OS_AdditionalBuildingsController : Controller
    {
        private HomeCheckEntities db = new HomeCheckEntities();

        // GET: OS_AdditionalBuildings
        public ActionResult Index()
        {
            return View(db.OS_AdditionalBuildings.ToList());
        }

        // GET: OS_AdditionalBuildings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_AdditionalBuildings oS_AdditionalBuildings = db.OS_AdditionalBuildings.Find(id);
            if (oS_AdditionalBuildings == null)
            {
                return HttpNotFound();
            }
            return View(oS_AdditionalBuildings);
        }

        // GET: OS_AdditionalBuildings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OS_AdditionalBuildings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "additionalBuildingID,additionalBuilding")] OS_AdditionalBuildings oS_AdditionalBuildings)
        {
            if (ModelState.IsValid)
            {
                db.OS_AdditionalBuildings.Add(oS_AdditionalBuildings);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(oS_AdditionalBuildings);
        }

        // GET: OS_AdditionalBuildings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_AdditionalBuildings oS_AdditionalBuildings = db.OS_AdditionalBuildings.Find(id);
            if (oS_AdditionalBuildings == null)
            {
                return HttpNotFound();
            }
            return View(oS_AdditionalBuildings);
        }

        // POST: OS_AdditionalBuildings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "additionalBuildingID,additionalBuilding")] OS_AdditionalBuildings oS_AdditionalBuildings)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oS_AdditionalBuildings).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oS_AdditionalBuildings);
        }

        // GET: OS_AdditionalBuildings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_AdditionalBuildings oS_AdditionalBuildings = db.OS_AdditionalBuildings.Find(id);
            if (oS_AdditionalBuildings == null)
            {
                return HttpNotFound();
            }
            return View(oS_AdditionalBuildings);
        }

        // POST: OS_AdditionalBuildings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OS_AdditionalBuildings oS_AdditionalBuildings = db.OS_AdditionalBuildings.Find(id);
            db.OS_AdditionalBuildings.Remove(oS_AdditionalBuildings);
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
