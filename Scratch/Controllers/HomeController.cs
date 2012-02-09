using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Scratch.Services;

namespace Scratch.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMessageService _messageService;

        public HomeController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public ActionResult Index()
        {
            ViewBag.Message = _messageService.GetMessage();

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
