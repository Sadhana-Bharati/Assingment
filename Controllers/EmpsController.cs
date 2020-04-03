using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assign2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assign2.Controllers
{
    public class EmpsController : Controller
    {
        // GET: Emps
        List<Emps> emp = new List<Emps>()
            {
                new Emps{Empid=1,Empname="Sadhana",age=21 },
                new Emps{Empid=2,Empname="Ankita",age=22},
                new Emps{Empid=3,Empname="Abhay",age=23}
            };
        // GET: Employee
        public ActionResult Index()
        {

            ViewBag.employee = emp;
            return View(emp);
        }

        // GET: Emps/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Emps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emps/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Emps/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Emps/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Emps/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Emps/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}