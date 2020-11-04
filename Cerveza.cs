using System;
using System.Collections.Generic;
using System.Text;

namespace PATRON_DISEÑO_INYECCION_DE_DEPENDENCIAS_4
{
    public class Cerveza : IBebida
    {
        public void Preparar()
        {
            Console.WriteLine("Se prepara una Cerveza");
        }
    }
}
