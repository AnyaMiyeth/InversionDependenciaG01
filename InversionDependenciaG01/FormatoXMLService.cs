using System;
using System.Collections.Generic;
using System.Text;

namespace InversionDependenciaG01
{
    public class FormatoXMLService : IFormato
    {
        private ReporteVentaService reporte;
        public FormatoXMLService()
        {
            reporte = new ReporteVentaService();
        }

        public string Generar()
        {
            return "Yo Genero un Objeto XML con el Documento " + reporte.CrearDocumento();
        }
    }
}
