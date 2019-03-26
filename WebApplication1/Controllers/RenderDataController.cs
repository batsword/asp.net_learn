using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class RenderDataController : Controller
    {
        // GET: RenderData
        public ActionResult Index()
        {
            return View();
        }

        // GET: RenderData/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RenderData/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RenderData/Create
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

        // GET: RenderData/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RenderData/Edit/5
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

        // GET: RenderData/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RenderData/Delete/5
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

        public IActionResult SectionDemo()
        {
            ViewBag.Title = "Home";
            ViewBag.Message = "Hello World ！ -ken.io";

            return View();
        }

        public IActionResult ViewDataDemo()
        {
            ViewData["name"] = "ken";
            ViewData["birthday"] = new DateTime(2000, 1, 1);
            ViewData["hobby"] = new string[] { "跑步", "阅读", "Coding" };
            return View();
        }

        public IActionResult ViewBagDemo()
        {
            ViewBag.Title = "ViewBag传值示例";
            ViewBag.Name = "ken";
            ViewBag.Birthday = new DateTime(2000, 1, 1);
            ViewBag.Hobby = new string[] { "跑步", "阅读", "Coding" };
            return View();
        }

        public IActionResult ViewModelDemo()
        {
            ViewBag.Title = "ViewModel传值示例";
            var person = new Person2
            {
                Name = "ken",
                Birthday = new DateTime(2000, 1, 1),
                Hobby = new string[] { "跑步", "阅读", "Coding" }
            };
            //等同于 return View("ViewModelDemo", person);
            return View(person);
        }
    }

    public class Person2
    {
        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public string[] Hobby { get; set; }
    }
}