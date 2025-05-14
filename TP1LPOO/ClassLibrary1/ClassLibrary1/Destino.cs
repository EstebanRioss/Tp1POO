using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Destino
    {
        // Atributo privado
        private int DES_Codigo;

        // Propiedad pública
        public string DES_Descripcion { get; set; }

        // Constructor
        public void Destino(int codigo, string descripcion)
        {
            this.DES_Codigo = codigo;
            this.DES_Descripcion = descripcion;
        }

        public int GetCodigo(){
            return this.DES_Codigo;
        }
        public void SetCodigo(int codigo) {
            this.DES_Codigo = codigo;
        }
    }
}
