using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPrestamos
{
    class Program
    {
        double prestamo, interes, meses, res;
        int cont;
        bool continuar = true;




        public void Iniciar()
        {

            while (continuar)
            {




                Console.WriteLine("\nIngrese el monto del prestamo: ");
                prestamo = double.Parse(Console.ReadLine());

                Console.WriteLine("\nIngrese la duracion del prestamo (meses): ");
                meses = double.Parse(Console.ReadLine());

                Console.WriteLine("\nIngrese el porcentaje de interes: ");
                interes = double.Parse(Console.ReadLine());

                res = prestamo / meses;
                res = res + ((prestamo * interes) / 100);

                Console.WriteLine("\nEL monto a pagar mensual es de: RD$ " + res);

                Tabla();


                Console.WriteLine("\nDesea hacer otro calculo? \n1- Si\n2- No");
                cont = int.Parse(Console.ReadLine());

                if (cont == 2)
                {
                    continuar = false;
                    Environment.Exit(0);

                }
                else if (cont != 1)
                {
                    Console.WriteLine("\n***** Opcion no valida ******");
                    Console.WriteLine("\nDesea hacer otro calculo? \n1- Si\n2- No");
                    cont = int.Parse(Console.ReadLine());

                }


            }




        }

        public void Tabla()
        {

            int n = Convert.ToInt32(meses);

            string[,] tabla = new string[n, 4];

            tabla[0, 0] = "Mes";
            tabla[0, 1] = "Pago";
            tabla[0, 2] = "Interes";
            tabla[0, 3] = "Amortizacion";

            Console.WriteLine("\n\n\t\t***** Amortizacion del Personal *****");
            Console.WriteLine( "\t" + tabla[0, 0] + "\t" + tabla[0, 1] + "\t" + tabla[0, 2] + "\t\t" + tabla[0, 3]);

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    Console.WriteLine("\t" + tabla[i, j]);

                }
                
            }



        }


        public static void Main(string[] args)
        {
            Console.WriteLine("\n\t\t\t############################" +
                              "\n\t\t\t# Calculadora de Prestamos #" +
                              "\n\t\t\t############################");

            Program calc = new Program();
            calc.Iniciar();

        }

    }
}
