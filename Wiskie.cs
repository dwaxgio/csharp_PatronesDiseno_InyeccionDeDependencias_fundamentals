using System;
using System.Collections.Generic;
using System.Text;

namespace PATRON_DISEÑO_INYECCION_DE_DEPENDENCIAS_4
{
    public class Wiskie : IBebida
    {
        public string tipo { get; set; }

        public Wiskie(string pTipo)
        {
            this.tipo = pTipo;
        }
        public void Preparar()
        {
            Console.WriteLine("Se prepara un Wiskie " + tipo);
        }
    }
}
