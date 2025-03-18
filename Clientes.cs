using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace miProyectoConGitandVisualStudio
{
    public class Clientes:Persona
    {
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }


        public void CalcularEdad()
        {
            var edad= DateTime.Now.Year - this.FechaNacimiento.Year;
           this.Edad= Convert.ToInt32(edad);
        }
        public void Saludar2()
        {
            Console.WriteLine($"Hola {Nombre } {Apellido} como esta");
        }
        public void LimpiarTerminal()
        {
            Console.WriteLine(  "Limpiando terminal");
            Console.Clear();
        }

    }
}
