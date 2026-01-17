using System;
using System.Collections.Generic;
using System.Text;

namespace CursoBasico
{
    internal class Loteria
    {
        // Juego de Lotería

        // Pedir seis números del 1 al 50, validarlos y guardarlos en un arreglo.
        // Generar seis números aleatorios y guardarlos en un arreglo.
        // Comparar los números del usuario con el número ganador.
        // - Si el usuario tuvo todos los números igual que el del sorteo: gana el primer premio.
        // - Si tuvo 5 de 6: gana el segundo premio.
        // - Si tuvo 4 de 6: gana el tercer premio.
        // Imprimir número del usuario y número ganador (con el número de conteo a los que acertó).

        // Primer premio:   $ 2,000,000.00
        // Segundo premio:  $ 1,000,000.00
        // Tercer premio:   $ 500,000.00

        public static void Ejecutar()
        {

            int[] mis_numeros = new int[6];
            int[] numeros_aleatorios = new int[6];

            Console.WriteLine("Loteria: Ingresa 6 números entre 1 y 50 para participar.");

            // Números aleatorios del jugador:
            for (int cont = 0; cont < mis_numeros.Length; cont++)
            {

                // Comprobación: Muestra números aleatorios antes
                /*
                for(int h = 0; h < numeros_aleatorios.Length; h++)
                {
                    Console.Write(numeros_aleatorios[h] + " ");
                };
                */

                int num;
                string txtnum;
                bool esNum;

                do
                {
                    int numeroActual = cont + 1;
                    Console.WriteLine("Ingresa tu " + numeroActual + "° número.");
                    txtnum = Console.ReadLine();
                    esNum = int.TryParse(txtnum, out num);

                } while (esNum == false || num < 1 || num > 50);

                mis_numeros[cont] = num;
            };


            // Números aleatorios del sorteo (Números ganadores);
            for (int cont = 0; cont < numeros_aleatorios.Length; cont++)
            {
                Random random = new Random();
                int num_aleatorio = random.Next(1, 51); //números entre 1 y 50
                numeros_aleatorios[cont] = num_aleatorio;
            };


            // Números coincidentes
            int contador_numeros_iguales = 0;

            for(int cont = 0; cont < numeros_aleatorios.Length; cont++)
            {
                if (mis_numeros[cont] == numeros_aleatorios[cont])
                {
                    contador_numeros_iguales += 1;
                }
            };

            Console.Clear();

            Console.WriteLine("Los números con los que jugaste son: ");

            for(int cont = 0; cont < mis_numeros.Length; cont++)
            {
                Console.Write(mis_numeros[cont] + " ");
            };

            Console.WriteLine("\nLos números ganadores de la lotería son: ");

            for(int cont = 0; cont < numeros_aleatorios.Length; cont++)
            {
                Console.Write(numeros_aleatorios[cont] + " ");
            };

            Console.WriteLine("\n******************************************");
            Console.WriteLine("\nCoincidiste en " + contador_numeros_iguales + " números.");
            Console.WriteLine("\n******************************************");

            switch (contador_numeros_iguales)
            {
                case 6: Console.WriteLine("¡ Eres el ganador del primer premio: $2,000,000.00 !");
                    break;
                case 5: Console.WriteLine("¡ Eres el ganador del segundo premio: $1,000,000.00 !");
                    break;
                case 4: Console.WriteLine("¡ Eres el ganador del tercer premio: $500,000.00 !");
                    break;
                default: Console.WriteLine(" No ganaste ningún premio, vuelve a intentarlo ");
                    break;
            }

        }

        /*
            * Esta app de Lotería tiene fallos:
            - El usuario puede repetir números.
            - Los números ganadores aleatorios pueden ser repetidos.
            - El programa busca coincidencia tomando en cuenta el índice (para que haya coincidencia tiene que ser el mismo número en la misma posición).
        */
    }
}
