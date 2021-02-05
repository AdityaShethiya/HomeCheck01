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
    public class OS_AcTypeController : Controller
    {
        private HomeCheckEntities db = new HomeCheckEntities();

        // GET: OS_AcType
        public ActionResult Index()
        {
            return View(db.OS_AcType.ToList());
        }

        // GET: OS_AcType/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_AcType oS_AcType = db.OS_AcType.Find(id);
            if (oS_AcType == null)
            {
                return HttpNotFound();
            }
            return View(oS_AcType);
        }

        // GET: OS_AcType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OS_AcType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "acTypeID,acType")] OS_AcType oS_AcType)
        {
            if (ModelState.IsValid)
            {
                db.OS_AcType.Add(oS_AcType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(oS_AcType);
        }

        // GET: OS_AcType/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_AcType oS_AcType = db.OS_AcType.Find(id);
            if (oS_AcType == null)
            {
                return HttpNotFound();
            }
            return View(oS_AcType);
        }

        // POST: OS_AcType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "acTypeID,acType")] OS_AcType oS_AcType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oS_AcType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oS_AcType);
        }

        // GET: OS_AcType/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_AcType oS_AcType = db.OS_AcType.Find(id);
            if (oS_AcType == null)
            {
                return HttpNotFound();
            }
            return View(oS_AcType);
        }

        // POST: OS_AcType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OS_AcType oS_AcType = db.OS_AcType.Find(id);
            db.OS_AcType.Remove(oS_AcType);
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
