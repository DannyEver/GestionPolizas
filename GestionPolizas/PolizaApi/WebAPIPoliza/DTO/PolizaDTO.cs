using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIPoliza.DTO
{
    public class PolizaDTO
    {
        public int idPoliza { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string TipoCubrimiento { get; set; }
        public System.DateTime inicioVigencia { get; set; }
        public int periodoCobertura { get; set; }
        public decimal precio { get; set; }
        public string TipoRiesgo { get; set; }
        public string EmailEmpleado { get; set; }

    }
}