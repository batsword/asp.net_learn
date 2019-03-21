using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;

namespace WebApplication1.Controllers
{
    public class TaxController : Controller
    {
        // GET: Tax
        public ActionResult Index()
        {
            return View();
        }

        // GET: Tax/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tax/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tax/Create
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

        // GET: Tax/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tax/Edit/5
        [HttpPost]
        public ActionResult Test(int id, IFormCollection collection)
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

        [HttpPost]
        public string Fill([FromBody] dynamic data)

        {

            string a = data.amount;
            return a;

        }

        [HttpPost]
        public string FillEx(string data)

        {

            string a = data;
            return a;

        }

        [HttpPost]
        public async Task<string> PostText()
        {
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                return await reader.ReadToEndAsync();
            }
        }

        [HttpPost]
        public string GetJsonString([FromBody]string content)
        {
            return "content: " + content;
        }

        [HttpPost]
        [Route("PostX")]
        public ActionResult<string> Post([FromBody] string value)
        {
            return value;
        }
        

        public string Welcome(string name, int numTimes = 1)
        {

            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        }

        // POST: Tax/Edit/5
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

        // GET: Tax/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tax/Delete/5
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