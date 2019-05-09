using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PFController : Controller
    {
        // GET: PF
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult GetJiaoQiu(JiaoQiu jq)
        {
            string DuiMing = jq.DuiMing;
            string Half = jq.Half;
            string Time = jq.Time;
            string ChuPanJiao = jq.ChuPanJiao;
            string DangQianJiao = jq.DangQianJiao;
            string SheZheng = jq.SheZheng;
            string ShePian = jq.ShePian;
            string ChuPanRang = jq.ChuPanRang;
            string DangQianRang = jq.DangQianRang;



            return Content(DuiMing + "*************" + Half);

        }


        // GET: PF/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PF/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PF/Create
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

        // GET: PF/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PF/Edit/5
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

        // GET: PF/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PF/Delete/5
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