using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro37
{
    class Banco
    {

        //Atributos
        private DateTime _fechaInicio;
        private List<CuentaCorriente> _listaCuentaCorriente;
        private String _razonSocial;

        //Constructor
        public Banco(String razonSocial, DateTime fechaInicio)
        {
            this._razonSocial = razonSocial;
            this._fechaInicio = fechaInicio;
            this._listaCuentaCorriente = new List<CuentaCorriente>();
        }

        //Metodos
        public void MostrarBanco()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Razon social: " + this._razonSocial);
            sb.AppendLine("Fecha de inicio: " + this._fechaInicio);
            foreach (CuentaCorriente item in this._listaCuentaCorriente)
            {
                sb.AppendLine(Usuario.Mostrar(item.Dueño));
                sb.AppendLine("Saldo: " + (double)item);
            }

            Console.WriteLine(sb.ToString());
        }

        //Operadores sobrecargados
        public static Banco operator +(Banco banco, CuentaCorriente cuenta)
        {
            int cont = 0;
            do
            {
                if (banco._listaCuentaCorriente.Count == 0)
                {
                    banco._listaCuentaCorriente.Add(cuenta);
                    Console.WriteLine("Se ha agregado una cuenta corriente");
                    break;
                }
                if (banco._listaCuentaCorriente[cont] != cuenta)
                {
                    banco._listaCuentaCorriente.Add(cuenta);
                    Console.WriteLine("Se ha agregado una cuenta corriente");
                    break;
                }
                else
                {
                    Console.WriteLine("Ya existe una cuenta corritente para el usuario");
                    break;
                }
                
                cont++;
            } while (cont < banco._listaCuentaCorriente.Count);


            return banco;
        }

        public static Banco operator -(Banco banco, CuentaCorriente cuenta)
        {
            int cont = 0;

            do
	        {
                if (banco._listaCuentaCorriente[cont] == cuenta)
                {
                    banco._listaCuentaCorriente.Remove(banco._listaCuentaCorriente[cont]);
                    Console.WriteLine("Elimino una cuenta de banco");
                    break;
                }
                else
                {
                    Console.WriteLine("No existe actualmente esta cuenta");
                    break;
                }
                cont++;
            } while (cont < banco._listaCuentaCorriente.Count);

            return banco;
        }
    }
}
