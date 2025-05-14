using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Usuario
    {
        private int USU_ID;

        // Propiedades públicas
        public string USU_NombreUsuario { get; set; }
        public string USU_Contraseña { get; set; }
        public string USU_ApellidoNombre { get; set; }

        // Atributo protegido
        protected string ROL_Codigo;

        // Constructor
        public void Usuario(int id, string rolCodigo)
        {
            this.USU_ID = id;
            this.ROL_Codigo = rolCodigo;
        }

        public int GetID(){
            return this.USU_ID;
        }
        public void SetID(int id) {
            this.USU_ID = id;
        }
    }
}
