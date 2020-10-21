﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InversionDependenciaG01
{
    public class ImpresionService
    {
        private IFormato formato;
        public ImpresionService(IFormato _formato)
        {
            formato = _formato;
        }

        public string Imprimir()
        {  
             return "Yo Imprimo por Pantalla: " + formato.Generar();  
        }
    }
}
