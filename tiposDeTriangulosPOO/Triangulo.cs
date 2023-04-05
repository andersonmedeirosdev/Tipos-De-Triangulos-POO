using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiposDeTriangulosPOO
{
    internal class Triangulo
    {
        internal int lado1, lado2, lado3;
        internal string tipo;

        public string GerarTipo()
        {
                if (lado1 + lado2 < lado3 || lado2 + lado3 < lado1 || lado1 + lado3 < lado2)
                {
                    return "\nNão é um triângulo";
                }
                else if (lado1 == lado2 && lado2 == lado3)
                {
                    return "\nTriângulo Equilátero.";
                }
                else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
                {
                    return "\nTriângulo Isóceles";
                }
                else
                {
                    return "\nTriângulo Escalêno";
                }
        }
    }
}
