using Scratch.Models.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scratch.Controllers
{
    public class DeviceController : Controller
    {
        private IDevice _device;

        public DeviceController(IDevice device)
        {
            _device = device;
        }

        public ActionResult Index()
        {
            ViewBag.DeviceTypeName = _device.MyTypeName;
            return View();
        }
    }
}
