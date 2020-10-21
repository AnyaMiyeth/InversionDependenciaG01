using System;
using System.Collections.Generic;
using System.Text;

namespace InversionDependenciaG01
{
    public class FormatoPDFService: IFormato
    {
        private ReporteVentaService reporte;

        public FormatoPDFService()
        {
            reporte = new ReporteVentaService();
        }

        public string Generar()
        {
            return "Yo Genero un Objeto PDF con el Documento " + reporte.CrearDocumento();
        }

    }
}
