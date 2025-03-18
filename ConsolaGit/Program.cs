using miProyectoConGitandVisualStudio;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsolaGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Clientes clientes = new Clientes()
            {
                Nombre = "Karin",
                Apellido="Lugo",
                Cedula="17215556",
                FechaNacimiento =new DateTime(1985,09,14)
            };
             clientes.CalcularEdad();
            Console.WriteLine($"La edad de {clientes.Nombre} es de {clientes.Edad} años"  );
            Console.ReadLine();
        }
    }
}
