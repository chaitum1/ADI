using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiniProject.Models;

namespace MiniProject.Controllers
{
    public class JobListController : Controller
    {
        // GET: JobList
        private Training_18Apr19_Cloud_CGKPEntities db = new Training_18Apr19_Cloud_CGKPEntities();

        
        public ActionResult Index()
        {
            return View(db.Job_180623.ToList());
        }
    }
}