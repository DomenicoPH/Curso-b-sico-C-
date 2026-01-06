// Susing System;

namespace CursoBasico
{
    class ProgramClase04
    {
        public static void Ejecutar()
        {

            string texto1 = "Hola";
            string texto2 = "hola";

            if (texto1 == texto2)
            {
                Console.WriteLine("texto1 es igual que texto2");
            }
            else
            {
                Console.WriteLine("texto1 es diferente que texto2");
            }

            string texto3 = "Mosca";
            string texto4 = "Mosca";

            if (texto3.Equals(texto4))
            {
                Console.WriteLine("texto3 es igual que texto4");
            }
            else
            {
                Console.WriteLine("texto3 es diferente que texto4");
            }


            char caracter1 = 'a';
            char caracter2 = 'b';

            if (caracter1 == caracter2)
            {
                Console.WriteLine("caracter1 es igual que caracter2");
            }
            else
            {
                Console.WriteLine("caracter1 es diferente que caracter2");
            }


            char caracter3 = 'X';
            char caracter4 = 'X';

            if (caracter3.Equals(caracter4))
            {
                Console.WriteLine("caracter3 es igual que caracter4");
            }
            else
            {
                Console.WriteLine("caracter3 es diferente que caracter4");
            }

        }
    }
}