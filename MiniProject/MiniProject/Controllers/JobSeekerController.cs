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
    public class JobSeekerController : Controller
    {
        private Training_18Apr19_Cloud_CGKPEntities db = new Training_18Apr19_Cloud_CGKPEntities();

        // GET: JobSeeker_180623
        public ActionResult Index()
        {
            var jobSeeker_180623 = db.JobSeeker_180623.Include(j => j.Approved_180623);
            return View(jobSeeker_180623.ToList());
        }

        // GET: JobSeeker_180623/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobSeeker_180623 jobSeeker_180623 = db.JobSeeker_180623.Find(id);
            if (jobSeeker_180623 == null)
            {
                return HttpNotFound();
            }
            return View(jobSeeker_180623);
        }

        // GET: JobSeeker_180623/Create
        public ActionResult Create()
        {
            ViewBag.Name = new SelectList(db.Approved_180623, "Name", "status");
            return View();
        }

        // POST: JobSeeker_180623/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,Password,Emailid,MobileNo,Location,photo,Position,Experience,PreferredJobLocation,Skills,Dateofapplication,Resume,Status")] JobSeeker_180623 jobSeeker_180623)
        {
            if (ModelState.IsValid)
            {
                db.JobSeeker_180623.Add(jobSeeker_180623);
                db.SaveChanges();
                return RedirectToAction("JobseekerLogin", "Logins");
            }

            ViewBag.Name = new SelectList(db.Approved_180623, "Name", "status", jobSeeker_180623.Name);
            return View(jobSeeker_180623);
        }

        // GET: JobSeeker_180623/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobSeeker_180623 jobSeeker_180623 = db.JobSeeker_180623.Find(id);
            if (jobSeeker_180623 == null)
            {
                return HttpNotFound();
            }
            ViewBag.Name = new SelectList(db.Approved_180623, "Name", "status", jobSeeker_180623.Name);
            return View(jobSeeker_180623);
        }

        // POST: JobSeeker_180623/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Name,Password,Emailid,MobileNo,Location,photo,Position,Experience,PreferredJobLocation,Skills,Dateofapplication,Resume,Status")] JobSeeker_180623 jobSeeker_180623)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobSeeker_180623).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Name = new SelectList(db.Approved_180623, "Name", "status", jobSeeker_180623.Name);
            return View(jobSeeker_180623);
        }

        // GET: JobSeeker_180623/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobSeeker_180623 jobSeeker_180623 = db.JobSeeker_180623.Find(id);
            if (jobSeeker_180623 == null)
            {
                return HttpNotFound();
            }
            return View(jobSeeker_180623);
        }

        // POST: JobSeeker_180623/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            JobSeeker_180623 jobSeeker_180623 = db.JobSeeker_180623.Find(id);
            db.JobSeeker_180623.Remove(jobSeeker_180623);
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

        public ActionResult Search()
        {
            return RedirectToAction("Capgemini", "JobsSearch");

        }
    }
}
