using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class ActionResultTestController : Controller
    {
        public IActionResult ContentTest()
        {
            return Content("Content Result Test --ken.io");
        }

        public IActionResult JsonTest()
        {
            return Json(new { Message = "JsonResult Test", Author = "ken.io" });
        }

        public IActionResult FileTest()
        {
            var bytes = Encoding.Default.GetBytes("FileResult Test by ken.io");
            return File(bytes, "application/text", "filetest.txt");
        }

        public IActionResult GetId(int id)
        {
            return Content($"Action params mapping test by ken.io, id:{id}");
        }
    }
}
