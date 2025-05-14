using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Rol
    {
        private string ROL_Codigo;

        // Propiedad pública
        public string ROL_Descripcion { get; set; }

        // Constructor
        public void Rol(string codigo, string descripcion)
        {
            this.ROL_Codigo = codigo;
            this.ROL_Descripcion = descripcion;
        }

        public string GetCodigo(){
            return this.ROL_Codigo;
        }
        public void SetCodigo(string codigo) {
            this.ROL_Codigo = codigo;
        }
    }
}
