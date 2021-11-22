using Assignment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var listStudent = new DBcontext().Students.ToList();
            return View(listStudent);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Student model)
        {
            try
            {
                // TODO: Add insert logic here
                var context = new DBcontext();
                context.Students.Add(model);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            var context = new DBcontext();
            var editting = context.Students.Find(id);
            return View(editting);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(Student model)
        {
            try
            {
                // TODO: Add update logic here
                var context = new DBcontext();
                var olditem = context.Students.Find(model.StudentID);
                olditem.StudentName = model.StudentName;
                olditem.Gender = model.Gender;
                olditem.LectureName = model.LectureName;
                olditem.LectureID = model.LectureID;
                context.SaveChanges();
                return RedirectToAction("Index");
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            var context = new DBcontext();
            var delete = context.Students.Find(id);
            return View(delete);
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                var context = new DBcontext();
                var delete = context.Students.Find(id);
                context.Students.Remove(delete);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
