using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Cliente
    {
        private string CLI_DNI;

        // Propiedades públicas
        public string CLI_Nombre { get; set; }
        public string CLI_Apellido { get; set; }
        public string CLI_Sexo { get; set; }
        public DateTime CLI_FechaNacimiento { get; set; }
        public decimal CLI_Ingresos { get; set; }
        public string CLI_Direccion { get; set; }
        public string CLI_Telefono { get; set; }
        public List<Prestamo> Prestamos { get; set; }

        // Constructor
        public Cliente(string dni)
        {
            this.CLI_DNI = dni;
        }

        // Método para acceder al DNI si se requiere
        public string GetDNI()
        {
            return CLI_DNI;
        }

        public void SetDNI(string dni)
        {
            CLI_DNI = dni;
        }
    }
}
