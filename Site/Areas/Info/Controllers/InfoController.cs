using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sdl.Web.Site.Areas.Info.Models;

namespace Sdl.Web.Site.Areas.Info.Controllers
{
    public class InfoController : Controller
    {
        // GET: Info/Info
        public ActionResult Version()
        {
            AssemblyInfos infos = new AssemblyInfos();
            ViewBag.Assemblies = infos.Assemblies;
            return View();
        }

    }
}