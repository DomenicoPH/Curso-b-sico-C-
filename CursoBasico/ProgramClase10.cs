// Susing System;

namespace CursoBasico
{
    class ProgramClase10
    {
        public static void Ejecutar()
        {

            // Funciones II

            int num = 5;

            FuncionPorValor(num);
            Console.WriteLine(num);
            // retorna 5 (num sigue valiendo 5)

            Console.WriteLine("----\n");

            FuncionPorReferencia(ref num);
            Console.WriteLine(num);
            // retorna 10 (al pasarle num como referencia si se ve afectado en su origen)


        }

        static void FuncionPorValor(int num)
        {
            num *= 2;
            Console.WriteLine("Valor de num dentro de la función por valor: " + num);
        }

        static void FuncionPorReferencia(ref int num)
        {
            num *= 2;
            Console.WriteLine("Valor de num dentro de la función por referencia: " + num);
        }
    }
}