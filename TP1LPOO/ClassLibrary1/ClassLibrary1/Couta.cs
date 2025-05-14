using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{

    public enum EstadoCuota
    {
        PAGADA,
        PENDIENTE,
        VENCIDA
    }

    public class Couta
    {
        // Atributo privado
        private int CUO_Codigo;

        // Atributo protegido
        protected int PRE_Numero;

        // Propiedades públicas
        public int CUO_Numero { get; set; }
        public DateTime CUO_Vencimiento { get; set; }
        public decimal CUO_Importe { get; set; }
        public EstadoCuota CUO_Estado { get; set; }

        // Constructor
        public void Cuota(int codigo, int preNumero)
        {
            this.CUO_Codigo = codigo;
            this.PRE_Numero = preNumero;
            this.CUO_Estado = EstadoCuota.PENDIENTE;
        }

        public int GetCodigo(){
            return this.CUO_Codigo;
        }
        public void SetCodigo(int codigo){
            this.CUO_Codigo = codigo;
        }
    }
}
