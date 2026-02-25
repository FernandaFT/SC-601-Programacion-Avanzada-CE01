using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CasoEstudio01.Models
{
    public class MatriculaModel
    {
        public long Consecutivo { get; set; }
        public string Identificacion {  get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public int TipoCurso { get; set; }

        public List<SelectListItem> ListaTiposCursos { get; set; }
    }

}