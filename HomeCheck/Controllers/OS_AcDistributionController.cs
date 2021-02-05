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
    public class OS_AcDistributionController : Controller
    {
        private HomeCheckEntities db = new HomeCheckEntities();

        // GET: OS_AcDistribution
        public ActionResult Index()
        {
            return View(db.OS_AcDistribution.ToList());
        }

        // GET: OS_AcDistribution/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_AcDistribution oS_AcDistribution = db.OS_AcDistribution.Find(id);
            if (oS_AcDistribution == null)
            {
                return HttpNotFound();
            }
            return View(oS_AcDistribution);
        }

        // GET: OS_AcDistribution/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OS_AcDistribution/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "acDistributionID,acDistribution")] OS_AcDistribution oS_AcDistribution)
        {
            if (ModelState.IsValid)
            {
                db.OS_AcDistribution.Add(oS_AcDistribution);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(oS_AcDistribution);
        }

        // GET: OS_AcDistribution/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_AcDistribution oS_AcDistribution = db.OS_AcDistribution.Find(id);
            if (oS_AcDistribution == null)
            {
                return HttpNotFound();
            }
            return View(oS_AcDistribution);
        }

        // POST: OS_AcDistribution/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "acDistributionID,acDistribution")] OS_AcDistribution oS_AcDistribution)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oS_AcDistribution).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oS_AcDistribution);
        }

        // GET: OS_AcDistribution/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_AcDistribution oS_AcDistribution = db.OS_AcDistribution.Find(id);
            if (oS_AcDistribution == null)
            {
                return HttpNotFound();
            }
            return View(oS_AcDistribution);
        }

        // POST: OS_AcDistribution/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OS_AcDistribution oS_AcDistribution = db.OS_AcDistribution.Find(id);
            db.OS_AcDistribution.Remove(oS_AcDistribution);
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
