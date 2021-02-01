using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        StudentsContext _context = new StudentsContext();
        public ActionResult Index()
        {
            IEnumerable<Student> students = _context.Students;
            ViewBag.Students = students;
            return View();
        }
        [HttpGet]
        public ActionResult Add() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Student st)
        {
            _context.Students.Add(st);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
       
    }
}