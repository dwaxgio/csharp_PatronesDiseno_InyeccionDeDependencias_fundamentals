using System;
using System.Collections.Generic;
using System.Text;

namespace PATRON_DISEÑO_INYECCION_DE_DEPENDENCIAS_4
{
    public class Cantinero
    {
        IBebida oBebida;

        public Cantinero(IBebida pBebida)
        {
            this.oBebida = pBebida;
        }

        public void Preparar()
        {
            this.oBebida.Preparar();
        }
    }
}
