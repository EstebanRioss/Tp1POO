using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Periodo
    {
        // Atributo privado
        private int PER_Codigo;

        // Propiedad pública
        public string PER_Descripcion { get; set; }

        // Constructor
        public void Periodo(int codigo, string descripcion)
        {
            this.PER_Codigo = codigo;
            this.PER_Descripcion = descripcion;
        }

        public int GetCodigo(){
            return this.PER_Codigo;
        }
        public void SetCodigo(int codigo) {
            this.PER_Codigo = codigo;
        }
    }
}
