// Susing System;

namespace CursoBasico
{
    class ProgramClase05
    {
        public static void Ejecutar()
        {
            // ciclo while

            int numero = 1;

            Console.WriteLine("-- Inicio del programa. --");

            if (numero == 1)
            {
                while (numero < 5)
                {
                    Console.WriteLine(numero + " antes de la suma");
                    numero = numero + 1;
                    Console.WriteLine(numero + " después de la suma");
                    if(numero == 2)
                    {
                        Console.WriteLine("(!) numero es igual a 2");
                    }
                }
            }
            else
            {
                Console.WriteLine("numero no es igual a 1");
            }

                Console.WriteLine("-- Fin del programa. --");

        }
    }
}