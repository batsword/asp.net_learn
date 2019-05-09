using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using WebApplication1.SignalR;

namespace WebApplication1.Controllers
{
    public class SignalRController : Controller
    {
        //private IHubContext<MyChatHub> _hubContext;

        //public SignalRController(
        //     IHubContext<MyChatHub> hubContext)
        //{
        //    _hubContext = hubContext;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

    }
}