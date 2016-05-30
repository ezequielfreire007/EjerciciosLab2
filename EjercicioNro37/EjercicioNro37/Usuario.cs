using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro37
{
    class Usuario
    {

        //Atributos
        private String _apellido;
        private double _dni;
        private String _nombre;

        //Propiedades
        public double DNI
        {
            get { return this._dni;  }
        }

        //Constructor
        public Usuario(String apellido, String nombre, double dni)
        {
            this._apellido = apellido;
            this._nombre = nombre;
            this._dni = dni;
        }

        //Metodos
        private String DevolverDatosFormatoString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this._nombre);
            sb.AppendLine("Apellido: " + this._apellido);
            sb.AppendLine("Dni: " + this._dni);

            return sb.ToString();
        }

        public static String Mostrar(Usuario usuario)
        {
            return usuario.DevolverDatosFormatoString();
        }
    }
}
