using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro17
{
    class Program
    {
        static void Main(string[] args)
        {

            Cuenta cuentaUno = new Cuenta();

            Console.Write("Ingrese el nombre: ");
            cuentaUno.setNombre(Console.ReadLine());
            Console.WriteLine();
            while(cuentaUno.getNombre().Equals("1"))
            {
                Console.Write("Ingrese el nombre corretamente: ");
                cuentaUno.setNombre(Console.ReadLine());
                Console.WriteLine();
            }

            Console.Write("Ingrese el numero de cuenta:");
            cuentaUno.setNroCuenta(long.Parse(Console.ReadLine()));
            Console.WriteLine();
            while(cuentaUno.getNroCuenta() == -1)
            {
                Console.Write("Ingrese el numero de cuenta correctamente:");
                cuentaUno.setNroCuenta(long.Parse(Console.ReadLine()));
                Console.WriteLine();
            }

            Console.Write("Ingrese el saldo de la cuenta: ");
            cuentaUno.setSaldo(double.Parse(Console.ReadLine()));
            Console.WriteLine();
            while (cuentaUno.getSaldo() == -1)
            {
                Console.Write("Ingrese el saldo correctamente:");
                cuentaUno.setSaldo(double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }

            Console.Write("Ingrese el tipo de interes: ");
            cuentaUno.setTipoInteres((ETipoInteres)int.Parse(Console.ReadLine()));
            Console.WriteLine();
            while (cuentaUno.getTipoInteres() == (ETipoInteres)4)
            {
                Console.Write("Ingrese el tipo de interes correctamente:");
                cuentaUno.setTipoInteres((ETipoInteres)int.Parse(Console.ReadLine()));
                Console.WriteLine();
            }

            //Mostrar datos
            Console.WriteLine();
            Console.WriteLine("Nombre: {0}",cuentaUno.getNombre());
            Console.WriteLine("Nro de Cuenta: {0}",cuentaUno.getNroCuenta());
            Console.WriteLine("Saldo: {0}",cuentaUno.getSaldo());
            Console.WriteLine("Tipo de interes: {0}",cuentaUno.getTipoInteres());

            Console.ReadLine();


        }
    }
}
