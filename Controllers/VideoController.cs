﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.SqlClient;
using System.Data;
using MVCLaboratorio.Utilerias;
namespace MVCLaboratorio.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            ViewData["video"] = BaseHelper.ejecutarConsulta("sp_mostrarvideo", CommandType.StoredProcedure);
 
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
        {//guardae el video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url", url));

            BaseHelper.ejecutarSentencia("sp_video_insertar",
                                           CommandType.StoredProcedure,
                                           parametros);

            return View();
        }
        public ActionResult delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult delete(int idVideo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));

            BaseHelper.ejecutarSentencia("sp_video_Eliminar",
                                           CommandType.StoredProcedure,
                                           parametros);
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
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url", url));

            BaseHelper.ejecutarSentencia("sp_video_editar",
                                           CommandType.StoredProcedure,
                                           parametros);

            return View();
        }


    }
}
