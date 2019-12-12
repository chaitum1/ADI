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
    public class JobsSearchController : Controller
    {
        private Training_18Apr19_Cloud_CGKPEntities db = new Training_18Apr19_Cloud_CGKPEntities();

        // GET: Job_180623
        //[ValidateAntiForgeryToken]
        public ActionResult Index()
        {
            return View(db.Job_180623.ToList());
        }

        // GET: Job_180623/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job_180623 job_180623 = db.Job_180623.Find(id);
            if (job_180623 == null)
            {
                return HttpNotFound();
            }
            return View(job_180623);
        }

        // GET: Job_180623/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Job_180623/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Jobid,Designation,Company,ComapnyName,Salary")] Job_180623 job_180623)
        {
            if (ModelState.IsValid)
            {
                db.Job_180623.Add(job_180623);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(job_180623);
        }

        // GET: Job_180623/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job_180623 job_180623 = db.Job_180623.Find(id);
            if (job_180623 == null)
            {
                return HttpNotFound();
            }
            return View(job_180623);
        }

        // POST: Job_180623/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Jobid,Designation,Company,ComapnyName,Salary")] Job_180623 job_180623)
        {
            if (ModelState.IsValid)
            {
                db.Entry(job_180623).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(job_180623);
        }

        // GET: Job_180623/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job_180623 job_180623 = db.Job_180623.Find(id);
            if (job_180623 == null)
            {
                return HttpNotFound();
            }
            return View(job_180623);
        }

        // POST: Job_180623/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Job_180623 job_180623 = db.Job_180623.Find(id);
            db.Job_180623.Remove(job_180623);
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

        public ActionResult Capgemini()
        {
            return View();
        }
    }
}
