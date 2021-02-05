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
    public class OS_AsbestosController : Controller
    {
        private HomeCheckEntities db = new HomeCheckEntities();

        // GET: OS_Asbestos
        public ActionResult Index()
        {
            return View(db.OS_Asbestos.ToList());
        }

        // GET: OS_Asbestos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_Asbestos oS_Asbestos = db.OS_Asbestos.Find(id);
            if (oS_Asbestos == null)
            {
                return HttpNotFound();
            }
            return View(oS_Asbestos);
        }

        // GET: OS_Asbestos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OS_Asbestos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "asbestosID,asbestos")] OS_Asbestos oS_Asbestos)
        {
            if (ModelState.IsValid)
            {
                db.OS_Asbestos.Add(oS_Asbestos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(oS_Asbestos);
        }

        // GET: OS_Asbestos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_Asbestos oS_Asbestos = db.OS_Asbestos.Find(id);
            if (oS_Asbestos == null)
            {
                return HttpNotFound();
            }
            return View(oS_Asbestos);
        }

        // POST: OS_Asbestos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "asbestosID,asbestos")] OS_Asbestos oS_Asbestos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oS_Asbestos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oS_Asbestos);
        }

        // GET: OS_Asbestos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_Asbestos oS_Asbestos = db.OS_Asbestos.Find(id);
            if (oS_Asbestos == null)
            {
                return HttpNotFound();
            }
            return View(oS_Asbestos);
        }

        // POST: OS_Asbestos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OS_Asbestos oS_Asbestos = db.OS_Asbestos.Find(id);
            db.OS_Asbestos.Remove(oS_Asbestos);
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
