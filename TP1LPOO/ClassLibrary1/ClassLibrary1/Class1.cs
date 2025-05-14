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

    public enum EstadoCuota
    {
        PAGADA,
        PENDIENTE,
        VENCIDA
    }

    public class Cliente
    {
        private string CLI_DNI;
        public string CLI_Nombre { get; set; }
        public string CLI_Apellido { get; set; }
        public string CLI_Sexo { get; set; }
        public DateTime CLI_FechaNacimiento { get; set; }
        public decimal CLI_Ingresos { get; set; }
        public string CLI_Direccion { get; set; }
        public string CLI_Telefono { get; set; }

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
    public class Prestamo
    {
        // Atributo privado
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

    public class Cuota
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
        public Cuota(int codigo, int preNumero)
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
        public Pago(int codigo, int cuoCodigo)
        {
            this.PAG_Codigo = codigo;
            this.CUO_Codigo = cuoCodigo;
        }

        public int GetCodigo(){
            return this.PAG_Codigo;
        }
        public void SetCodigo(int codigo){
            this.PAG_Codigo = codigo;
        }
    }

    public class Periodo
    {
        // Atributo privado
        private int PER_Codigo;

        // Propiedad pública
        public string PER_Descripcion { get; set; }

        // Constructor
        public Periodo(int codigo, string descripcion)
        {
            this.PER_Codigo = codigo;
            this.PER_Descripcion = descripcion;
        }

        public int GetCodigo(){
            return this.PER_Codigo;
        }
        public void SetCodigo(int codigo){
            this.PER_Codigo = codigo;
        }
    }

    public class Destino
    {
        // Atributo privado
        private int DES_Codigo;

        // Propiedad pública
        public string DES_Descripcion { get; set; }

        // Constructor
        public Destino(int codigo, string descripcion)
        {
            this.DES_Codigo = codigo;
            this.DES_Descripcion = descripcion;
        }

        public int GetCodigo(){
            return this.DES_Codigo;
        }
        public void SetCodigo(int codigo){
            this.DES_Codigo = codigo;
        }
    }

    public class Usuario
    {
        // Atributo privado
        private int USU_ID;

        // Propiedades públicas
        public string USU_NombreUsuario { get; set; }
        public string USU_Contraseña { get; set; }
        public string USU_ApellidoNombre { get; set; }

        // Atributo protegido
        protected string ROL_Codigo;

        // Constructor
        public Usuario(int id, string rolCodigo)
        {
            this.USU_ID = id;
            this.ROL_Codigo = rolCodigo;
        }

        public int GetID(){
            return this.USU_ID;
        }
        public void SetID(int id){
            this.USU_ID = id;
        }
    }

    public class Rol
    {
        // Atributo privado
        private string ROL_Codigo;

        // Propiedad pública
        public string ROL_Descripcion { get; set; }

        // Constructor
        public Rol(string codigo, string descripcion)
        {
            this.ROL_Codigo = codigo;
            this.ROL_Descripcion = descripcion;
        }

        public string GetCodigo(){
            return this.ROL_Codigo;
        }
        public void SetCodigo(string codigo){
            this.ROL_Codigo = codigo;
        }
        
    }

}
