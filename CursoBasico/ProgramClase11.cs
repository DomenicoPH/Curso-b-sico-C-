// Susing System;

using System;

namespace CursoBasico
{
    class ProgramClase11
    {
        public static void Ejecutar()
        {

            int num1 = 5;
            int num2 = 46;
            int num3 = 74;
            decimal dec = (decimal)10.2;
            string hola = "Hola";
            string texto = "Curso de programación";

            FuncionPorValor(num1, num3, dec);

            FuncionPorRef(ref num1, hola, ref texto);

        }

        static void FuncionPorValor(int num1, int num2, decimal dec)
        {
            num1 *= 2;
            Console.WriteLine("Valor de num dentro de la función por valor: " + num1 + ' ' + num2 + ' ' + dec);

        }

        static void FuncionPorRef(ref int num1, string hola, ref string texto)
        {
            num1 *= 2;
            Console.WriteLine("Valor de num dentro de la función por referencia: " + num1 + ' ' + hola + ' ' + texto);

        }
    }
}