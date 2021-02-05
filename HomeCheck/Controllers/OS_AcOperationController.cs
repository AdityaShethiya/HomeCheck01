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
    public class OS_AcOperationController : Controller
    {
        private HomeCheckEntities db = new HomeCheckEntities();

        // GET: OS_AcOperation
        public ActionResult Index()
        {
            return View(db.OS_AcOperation.ToList());
        }

        // GET: OS_AcOperation/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_AcOperation oS_AcOperation = db.OS_AcOperation.Find(id);
            if (oS_AcOperation == null)
            {
                return HttpNotFound();
            }
            return View(oS_AcOperation);
        }

        // GET: OS_AcOperation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OS_AcOperation/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "acOperationID,acOperation")] OS_AcOperation oS_AcOperation)
        {
            if (ModelState.IsValid)
            {
                db.OS_AcOperation.Add(oS_AcOperation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(oS_AcOperation);
        }

        // GET: OS_AcOperation/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_AcOperation oS_AcOperation = db.OS_AcOperation.Find(id);
            if (oS_AcOperation == null)
            {
                return HttpNotFound();
            }
            return View(oS_AcOperation);
        }

        // POST: OS_AcOperation/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "acOperationID,acOperation")] OS_AcOperation oS_AcOperation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oS_AcOperation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oS_AcOperation);
        }

        // GET: OS_AcOperation/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_AcOperation oS_AcOperation = db.OS_AcOperation.Find(id);
            if (oS_AcOperation == null)
            {
                return HttpNotFound();
            }
            return View(oS_AcOperation);
        }

        // POST: OS_AcOperation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OS_AcOperation oS_AcOperation = db.OS_AcOperation.Find(id);
            db.OS_AcOperation.Remove(oS_AcOperation);
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
