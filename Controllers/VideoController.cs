using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLaboratorio.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(int idVideo, 
                                    string titulo, 
                                    int repro, 
                                    string url)
        {
            return View();
        }
        public ActionResult delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult delete(int idVideo)
        {
            return View();
        }
        public ActionResult edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult edit(int idVideo,
                                    string titulo,
                                    int repro,
                                    string url)
        {
            return View();
        }


    }
}
