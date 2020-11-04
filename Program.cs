using System;

namespace PATRON_DISEÑO_INYECCION_DE_DEPENDENCIAS_4
{
    class Program
    {
        static void Main(string[] args)
        {
            IBebida oBebida = new Wiskie("En las rocas");
            Cantinero oCantinero = new Cantinero(oBebida);
            oCantinero.Preparar();
        }
    }
}
