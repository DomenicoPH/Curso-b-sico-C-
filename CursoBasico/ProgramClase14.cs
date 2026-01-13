// Susing System;

namespace CursoBasico
{
    class ProgramClase14
    {
        public static void Ejecutar()
        {

            // Switch Case

            // Con opciones de tipo caracter...
            Console.WriteLine("Elige una de las opciones: ");
            Console.WriteLine("a) Imprimir Hola Mundo ");
            Console.WriteLine("b) Imprimir suma de dos números ");
            Console.WriteLine("c) Imprimir NADA ");

            char option = Convert.ToChar( Console.ReadLine() );

            switch (option)
            {
                case 'a': 
                    Console.WriteLine("Hola Mundo!");
                    break;
                case 'b':
                    int num1 = 3;
                    int num2 = 7;
                    int resultado = num1 + num2;
                    Console.WriteLine(resultado);
                    break;
                case 'c': 
                    Console.WriteLine("NADA");
                    break;
                default:
                    Console.WriteLine("No seleccionaste ninguna de las opciones :(");
                    break;
            }

        }
    }
}