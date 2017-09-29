using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment6.Infrastructure;
using System.Net;
using Assignment6.Core;
using System.Data.Entity;

namespace Assignment6.Web.Controllers
{
    public class EmployeeController : Controller
    {
       

        private EmployeeRepository context = new EmployeeRepository();

        // GET  = > Employee List
        public ActionResult Index()
        {
            
            return View(context.GetEmployees());
        }

        


        // GET = > Create  Employee
        public ActionResult Create()
        {
            return View();
        }

        
        // POST = > Create Employee

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Email,PhoneNumber,Status,State,City")] EmployeeUser emp)
        {
            if (ModelState.IsValid)
            {
                context.Add(emp);
                return RedirectToAction("Index");
            }

            return View(emp);
        }

        // GET = > Details Of Employee 
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeUser emp = context.FindById(Convert.ToInt32(id));
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }


        // GET = > Edit Employee 

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeUser emp = context.FindById(Convert.ToInt32(id));
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }


         // POST = > Edit Employee 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Email,PhoneNumber,Status,State,City")] EmployeeUser emp)
        {
            if (ModelState.IsValid)
            {
                context.Edit(emp);
                return RedirectToAction("Index");
            }
            return View(emp);
        }


        // GET = > Delete Employee
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
           
            EmployeeUser emp = context.FindById(Convert.ToInt32(id));
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }


        // POST = > Delete Employee

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
           
            context.Remove(id);
            return RedirectToAction("Index");
        }


        // Dispose Method 
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
              
            }
            base.Dispose(disposing);
        }
    }
}
    
