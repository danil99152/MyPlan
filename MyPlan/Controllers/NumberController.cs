using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyPlan.DAL;
using MyPlan.Models;

namespace MyPlan.Controllers
{
    public class NumberController : Controller
    {
        private Context db = new Context();

        // GET: Number
        public ActionResult Index()
        {
            var numbers = db.Numbers.Include(n => n.Contact);
            return View(numbers.ToList());
        }

        // GET: Number/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Number number = db.Numbers.Find(id);
            if (number == null)
            {
                return HttpNotFound();
            }
            return View(number);
        }

        // GET: Number/Create
        public ActionResult Create()
        {
            ViewBag.ContactID = new SelectList(db.Contacts, "ID", "FirstName");
            return View();
        }

        // POST: Number/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NumberID,ContactID,PhoneNumber")] Number number)
        {
            if (ModelState.IsValid)
            {
                db.Numbers.Add(number);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ContactID = new SelectList(db.Contacts, "ID", "FirstName", number.ContactID);
            return View(number);
        }

        // GET: Number/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Number number = db.Numbers.Find(id);
            if (number == null)
            {
                return HttpNotFound();
            }
            ViewBag.ContactID = new SelectList(db.Contacts, "ID", "FirstName", number.ContactID);
            return View(number);
        }

        // POST: Number/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NumberID,ContactID,PhoneNumber")] Number number)
        {
            if (ModelState.IsValid)
            {
                db.Entry(number).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ContactID = new SelectList(db.Contacts, "ID", "FirstName", number.ContactID);
            return View(number);
        }

        // GET: Number/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Number number = db.Numbers.Find(id);
            if (number == null)
            {
                return HttpNotFound();
            }
            return View(number);
        }

        // POST: Number/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Number number = db.Numbers.Find(id);
            db.Numbers.Remove(number);
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
