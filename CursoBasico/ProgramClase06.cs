// Susing System;

namespace CursoBasico
{
    class ProgramClase06
    {
        public static void Ejecutar()
        {
            // ciclo for

            for(int cont = 0; cont < 5; cont++)
            {
                Console.WriteLine(cont);
            }
            // 0, 1, 2, 3, 4

            Console.WriteLine("---");


            for (int cont = 5; cont > 0; cont--)
            {
                Console.WriteLine(cont);
            }
            // 5, 4, 3, 2, 1

        }
    }
}