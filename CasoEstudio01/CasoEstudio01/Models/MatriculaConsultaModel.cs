using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CasoEstudio01.Models
{
    public class MatriculaConsultaModel
    {
        public long Consecutivo { get; set; }
        public string Identificacion { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string DescripcionTipoCurso { get; set; }
    }
}