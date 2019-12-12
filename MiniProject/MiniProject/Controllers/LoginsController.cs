using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiniProject.Models;

namespace MiniProject.Controllers
{
    public class LoginsController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            if (Session["EmailID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }


        public ActionResult EmployerLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EmployerLogin(Employer_180623 user)
        {
            ViewBag.Status = false;
            using (Training_18Apr19_Cloud_CGKPEntities tbc = new Training_18Apr19_Cloud_CGKPEntities())
            {
                try
                {
                    var get_user = tbc.Employer_180623.Single(p => p.Emailid == user.Emailid
                    && p.Password == user.Password);
                    if (get_user != null)
                    {
                        Session["EmailID"] = get_user.Emailid.ToString();


                        return RedirectToAction("Index", "JobSeeker");
                    }
                    else
                    {

                        ViewBag.Message = "UserName or Password does not match.";
                    }
                }
                catch (SystemException ex)
                {
                    ViewBag.Message = "UserName or Password does not match.";
                }
            }
            return View();
        }


        public ActionResult ReqApplication()
        {
            Training_18Apr19_Cloud_CGKPEntities db = new Training_18Apr19_Cloud_CGKPEntities();
            var res = db.JobSeeker_180623.ToList();
            return View(res);
        }

        [HttpPost]
        public ActionResult ReqApplication(JobSeeker_180623 obj)
        {
            //if(obj.Status== "Accepted")
            //    {
            //    ViewBag.job applied succesfully;
            //    return RedirectToAction("")
            //}
            return View();
        }


        public ActionResult JobseekerLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult JobseekerLogin(JobSeeker_180623 user)
        {
            ViewBag.Status = false;
            using (Training_18Apr19_Cloud_CGKPEntities tbc = new Training_18Apr19_Cloud_CGKPEntities())
            {
                try
                {
                    var get_user = tbc.JobSeeker_180623.Single(p => p.Emailid == user.Emailid
                    && p.Password == user.Password);
                    if (get_user != null)
                    {
                        Session["EmailID"] = get_user.Emailid.ToString();


                        return RedirectToAction("ReqApplication");
                    }
                    else
                    {

                        ViewBag.Message = "UserName or Password does not match.";
                    }
                }
                catch (SystemException ex)
                {
                    ViewBag.Message = "UserName or Password does not match.";
                }
            }
            return View();
        }


        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Index", "MainContextSection");
        }
    }
}