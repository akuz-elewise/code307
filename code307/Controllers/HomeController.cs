using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using code307.Models;

namespace code307.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult CheckGet()
        {
            //return RedirectPreserveMethod("/Home/CatchGet");
            return Redirect("/Home/CatchGet");
        }

        public IActionResult CatchGet()
        {
            return new ContentResult()
            {
                Content = "GET",
                ContentType = "text/plain",
                StatusCode = 200,
            };
        }

        public IActionResult CheckPost()
        {
            //return RedirectPreserveMethod("/Home/CatchPost");
            return Redirect("/Home/CatchPost");
        }

        public IActionResult CatchPost()
        {
            return new ContentResult()
            {
                Content = "POST",
                ContentType = "text/plain",
                StatusCode = 200,
            };
        }

        public IActionResult CheckPut()
        {
            //return RedirectPreserveMethod("/Home/CatchPut");
            return Redirect("/Home/CatchPut");
        }

        public IActionResult CatchPut()
        {
            return new ContentResult()
            {
                Content = "PUT",
                ContentType = "text/plain",
                StatusCode = 200,
            };
        }

        public IActionResult CheckDelete()
        {
            //return RedirectPreserveMethod("/Home/CatchDelete");
            return Redirect("/Home/CatchDelete");
        }

        public IActionResult CatchDelete()
        {
            return new ContentResult()
            {
                Content = "DELETE",
                ContentType = "text/plain",
                StatusCode = 200,
            };
        }

        public IActionResult CheckHead()
        {
            //return RedirectPreserveMethod("/Home/CatchHead");
            return Redirect("/Home/CatchHead");
        }

        public IActionResult CatchHead()
        {
            return new ContentResult()
            {
                Content = "HEAD",
                ContentType = "text/plain",
                StatusCode = 200,
            };
        }

        public IActionResult CheckOptions()
        {
            //return RedirectPreserveMethod("/Home/CatchOptions");
            return Redirect("/Home/CatchOptions");
        }

        public IActionResult CatchOptions()
        {
            return new ContentResult()
            {
                Content = "OPTIONS",
                ContentType = "text/plain",
                StatusCode = 200,
            };
        }
    }
}
