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
    public class OS_AlarmController : Controller
    {
        private HomeCheckEntities db = new HomeCheckEntities();

        // GET: OS_Alarm
        public ActionResult Index()
        {
            return View(db.OS_Alarm.ToList());
        }

        // GET: OS_Alarm/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_Alarm oS_Alarm = db.OS_Alarm.Find(id);
            if (oS_Alarm == null)
            {
                return HttpNotFound();
            }
            return View(oS_Alarm);
        }

        // GET: OS_Alarm/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OS_Alarm/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "alarmID,alarm")] OS_Alarm oS_Alarm)
        {
            if (ModelState.IsValid)
            {
                db.OS_Alarm.Add(oS_Alarm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(oS_Alarm);
        }

        // GET: OS_Alarm/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_Alarm oS_Alarm = db.OS_Alarm.Find(id);
            if (oS_Alarm == null)
            {
                return HttpNotFound();
            }
            return View(oS_Alarm);
        }

        // POST: OS_Alarm/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "alarmID,alarm")] OS_Alarm oS_Alarm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oS_Alarm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oS_Alarm);
        }

        // GET: OS_Alarm/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS_Alarm oS_Alarm = db.OS_Alarm.Find(id);
            if (oS_Alarm == null)
            {
                return HttpNotFound();
            }
            return View(oS_Alarm);
        }

        // POST: OS_Alarm/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OS_Alarm oS_Alarm = db.OS_Alarm.Find(id);
            db.OS_Alarm.Remove(oS_Alarm);
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
