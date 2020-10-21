using System;

namespace InversionDependenciaG01
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormato formato = new FormatoExcelService();
            IFormato pdf = new FormatoPDFService();
            IFormato xml = new FormatoXMLService(); 
            ImpresionService service = new ImpresionService(xml);

            Console.WriteLine(service.Imprimir());
            Console.ReadKey();
        }
    }
}
