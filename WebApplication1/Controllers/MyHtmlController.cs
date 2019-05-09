using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class MyHtmlController : Controller
    {
        // GET: MyHtml
        public ActionResult Index()
        {
            return View();
        }

        // GET: MyHtml/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MyHtml/Details/5
        public ActionResult GetHtml(int id)
        {
            return View();
        }

        // GET: MyHtml/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MyHtml/Create
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

        // GET: MyHtml/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MyHtml/Edit/5
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

        // GET: MyHtml/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MyHtml/Delete/5
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