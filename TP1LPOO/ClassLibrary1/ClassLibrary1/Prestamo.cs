using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public enum EstadoPrestamo
    {
        CANCELADO,
        PENDIENTE,
        APROBADO,
        RECHAZADO
    }

    public class Prestamo
    {
        private int PRE_Numero;

        // Atributos protegidos
        protected string CLI_DNI;
        protected int DES_Codigo;
        protected int PER_Codigo;

        // Propiedades públicas
        public DateTime PRE_Fecha { get; set; }
        public decimal PRE_Importe { get; set; }
        public double PRE_TasaInteres { get; set; }
        public int PRE_CantidadCuotas { get; set; }
        public EstadoPrestamo PRE_Estado { get; set; }

        // Constructor
        public Prestamo(int numero, string dni, int desCodigo, int perCodigo)
        {
            this.PRE_Numero = numero;
            this.CLI_DNI = dni;
            this.DES_Codigo = desCodigo;
            this.PER_Codigo = perCodigo;
            this.PRE_Estado = EstadoPrestamo.PENDIENTE;
        }

        // Métodos de acceso al número de préstamo
        public int GetNumero()
        {
            return PRE_Numero;
        }

        public void SetNumero(int numero)
        {
            PRE_Numero = numero;
        }
    }
}
