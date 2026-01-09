// Susing System;

namespace CursoBasico
{
    class ProgramClase07
    {
        public static void Ejecutar()
        {

            // Lectura de datos

            // Solicita nombre:

            string nombre = "";

            Console.WriteLine("Ingresa tu nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("\n Tu nombre es: " + nombre);


            Console.WriteLine("-------");

            // Suma números
            Console.WriteLine("Ingresa el primer número");
            int num1 = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("Ingresa el segundo número");
            int num2 = Convert.ToInt32( Console.ReadLine() );

            int resultadoSuma = num1 + num2;
            Console.WriteLine("la suma de los dos números es: " + resultadoSuma);


        }
    }
}