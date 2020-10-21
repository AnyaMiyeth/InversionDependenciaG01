using System;
using System.Collections.Generic;
using System.Text;

namespace InversionDependenciaG01
{
   public class FormatoExcelService:IFormato
    {
        private ReporteVentaService reporte;
        public FormatoExcelService()
        {
            reporte = new ReporteVentaService();
        }

        public string Generar()
        {
            return "Yo Genero un Objeto Excel con el Documento " + reporte.CrearDocumento();
        }

      
    }
}
