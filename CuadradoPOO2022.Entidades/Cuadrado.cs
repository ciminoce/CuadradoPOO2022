using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CuadradoPOO2022.Entidades
{
    public class Cuadrado
    {
        //Atributos
        public int Lado { get; set; }
        //Constructores
        public Cuadrado()
        {
            
        }
        public Cuadrado(int medidaLado)
        {
            Lado = medidaLado;
        }
        //Métodos
        public bool Validar()
        {
            return Lado > 0;
        }

        public int GetPerimetro() => 4 * Lado;
        public double GetSuperficie() => Math.Pow(Lado, 2);
    }
}
