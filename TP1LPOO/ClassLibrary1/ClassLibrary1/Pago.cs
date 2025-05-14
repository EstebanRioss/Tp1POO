using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Pago
    {
         // Atributo privado
        private int PAG_Codigo;

        // Atributo protegido
        protected int CUO_Codigo;

        // Propiedades públicas
        public DateTime PAG_Fecha { get; set; }
        public decimal PAG_Importe { get; set; }

        // Constructor
        public void Pago(int codigo, int cuoCodigo)
        {
            this.PAG_Codigo = codigo;
            this.CUO_Codigo = cuoCodigo;
        }

        public int GetCodigo(){
            return this.CUO_Codigo;
        }
        public void SetCodigo(int codigo) {
            this.CUO_Codigo = codigo;
        }
    }
}
