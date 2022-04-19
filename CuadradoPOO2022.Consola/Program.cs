using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CuadradoPOO2022.Entidades;

namespace CuadradoPOO2022.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            bool errorObjeto = true;
            do
            {
                bool error = true;
                int lado;
                do
                {
                    Console.Write("Ingrese el valor del lado=");
                    if (!int.TryParse(Console.ReadLine(), out lado))
                    {
                        Console.WriteLine("ERROR no se pudo convertir a entero");

                    }
                    else
                    {
                        error = false;
                    }

                } while (error);
                Cuadrado c = new Cuadrado(lado);
                if (c.Validar())
                {
                    Console.WriteLine($"Perimetro={c.GetPerimetro()}");
                    Console.WriteLine($"Superficie={c.GetSuperficie()}");
                    errorObjeto = false;
                }
                else
                {
                    Console.WriteLine("ERROR al validar el objeto... reintentar");
                }

            } while (errorObjeto);

            Console.ReadLine();
        }
    }
}
