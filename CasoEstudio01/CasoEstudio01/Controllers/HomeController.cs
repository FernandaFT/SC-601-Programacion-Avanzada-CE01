using CasoEstudio01.EntityFramework;
using CasoEstudio01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CasoEstudio01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        #region Registro de Matrícula
        [HttpGet]
        public ActionResult Matricula()
        {
            var model = new MatriculaModel();
            model.ListaTiposCursos = ObtenerTiposCursos();
            return View(model);
        }

        private List<SelectListItem> ObtenerTiposCursos()
        {
            using (var context = new CasoEstudioEntities())
            {
                return context.TiposCursos
                    .Select(t => new SelectListItem
                    {
                        Value = t.TipoCurso.ToString(),
                        Text = t.DescripcionTipoCurso
                    }).ToList();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Matricula (MatriculaModel model)
        {
            using (var context = new CasoEstudioEntities())
            {
                context.sp_RegistrarM(
                    model.Identificacion,
                    model.Monto,
                    model.TipoCurso
                );
            }

            return RedirectToAction("MatriculaConsulta", "Home");
        }
        #endregion

        #region Consultar Matrícula
        [HttpGet]
        public ActionResult MatriculaConsulta(MatriculaModel model)
        {
            using (var context = new CasoEstudioEntities())
            {
                var lista = context.sp_ListarMatriculas()
                    .Select(x => new MatriculaConsultaModel
                    {
                        Consecutivo = x.Consecutivo,
                        Identificacion = x.Identificacion,
                        Fecha = x.Fecha,
                        Monto = x.Monto,
                        DescripcionTipoCurso = x.DescripcionTipoCurso
                    }).ToList();

                return View(lista);
            }
        }
        #endregion
    }
}