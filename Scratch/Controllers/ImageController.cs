using System;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using System.Drawing;
using System.Web;
using System.Web.Mvc;
using Scratch.Services;

namespace Scratch.Controllers
{
    public class ImageController : Controller
    {
        //
        // GET: /Image/

        public ActionResult Index()
        {
            return View();
        }

        public FileContentResult Show(string id)
        {
            var imageService = new ImageService();
            var imageBytes = imageService.GetImage(id);
            return File(imageBytes, "image/jpg");
        }
    }
}
