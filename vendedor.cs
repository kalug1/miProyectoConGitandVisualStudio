using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace miProyectoConGitandVisualStudio
{
    class Vendedor:Persona
    {
        public string Zona { get; set; }
        public string Ciudad { get; set; }

        public void GenerarVenta()
        {
            Console.WriteLine( "venta generada con exito");
        }
    }
}
