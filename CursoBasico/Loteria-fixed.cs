using System;
using System.Collections.Generic;
using System.Text;

namespace CursoBasico
{
    internal class LoteriaFixed
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
            var misUnicos = new HashSet<int>();
            for (int i = 0; i < mis_numeros.Length; i++)
            {                
                int num;
                bool ok;
                do
                {
                    Console.WriteLine($"Ingresa tu {i + 1}° número (1-50, sin repetir).");
                    string txt = Console.ReadLine();
                    ok = int.TryParse(txt, out num);

                } while (!ok || num < 1 || num > 50 || !misUnicos.Add(num));

                mis_numeros[i] = num;
            };


            // Generar números aleatorios únicos (Números ganadores);
            var random = new Random();
            var ganadoresSet = new HashSet<int>();
            while (ganadoresSet.Count < 6) 
            {
                ganadoresSet.Add(random.Next(1, 51));
            }
            numeros_aleatorios = ganadoresSet.ToArray();

                // Comprobación: Muestra números aleatorios antes
                /*
                for (int h = 0; h < numeros_aleatorios.Length; h++)
                {
                    Console.Write(numeros_aleatorios[h] + " ");
                };
                */


            // Contar aciertos sin importar la posición;
            int aciertos = 0;
            foreach(var n in mis_numeros)
            {
                if (ganadoresSet.Contains(n))
                    aciertos++;
            };


            // Mostrar resultados;
            Console.Clear();
            Console.WriteLine("Los números con los que jugaste son: ");
            Console.WriteLine(string.Join(" ", mis_numeros));

            Console.WriteLine("\nLos números ganadores de la lotería son: ");
            Console.WriteLine(string.Join(" ", numeros_aleatorios));

            Console.WriteLine("\n******************************************");
            Console.WriteLine($"\nCoincidiste en {aciertos} números.");
            Console.WriteLine("\n******************************************");


            switch (aciertos)
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
    }
}
