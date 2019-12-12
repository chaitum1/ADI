using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MiniProject.Models;

namespace MiniProject.Controllers
{
    public class EmployerController : Controller
    {
        private Training_18Apr19_Cloud_CGKPEntities db = new Training_18Apr19_Cloud_CGKPEntities();

        // GET: Employer_180623
        public ActionResult Index()
        {
            return View(db.Employer_180623.ToList());
        }

        // GET: Employer_180623/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employer_180623 employer_180623 = db.Employer_180623.Find(id);
            if (employer_180623 == null)
            {
                return HttpNotFound();
            }
            return View(employer_180623);
        }

        // GET: Employer_180623/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employer_180623/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,Password,Emailid,MobileNo,Designation,Experience,EmployerClients")] Employer_180623 employer_180623)
        {
            if (ModelState.IsValid)
            {
                db.Employer_180623.Add(employer_180623);
                db.SaveChanges();
                return RedirectToAction("EmployerLogin","Logins");
            }

            return View(employer_180623);
        }

        // GET: Employer_180623/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employer_180623 employer_180623 = db.Employer_180623.Find(id);
            if (employer_180623 == null)
            {
                return HttpNotFound();
            }
            return View(employer_180623);
        }

        // POST: Employer_180623/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Name,Password,Emailid,MobileNo,Designation,Experience,EmployerClients")] Employer_180623 employer_180623)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employer_180623).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employer_180623);
        }

        // GET: Employer_180623/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employer_180623 employer_180623 = db.Employer_180623.Find(id);
            if (employer_180623 == null)
            {
                return HttpNotFound();
            }
            return View(employer_180623);
        }

        // POST: Employer_180623/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Employer_180623 employer_180623 = db.Employer_180623.Find(id);
            db.Employer_180623.Remove(employer_180623);
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
