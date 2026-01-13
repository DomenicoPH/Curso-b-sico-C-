// Susing System;

namespace CursoBasico
{
    class ProgramClase13
    {
        public static void Ejecutar()
        {

            // Números aleatorios

            Random random = new Random();

            int randomNumber = random.Next(0, 100); //aleatorio del 0 al 99 (no incluye el max)
            Console.WriteLine(randomNumber);

            double randomDecimal = random.NextDouble();
            Console.WriteLine(randomDecimal);

            Console.WriteLine(randomNumber + randomDecimal);

        }
    }
}