// Susing System;

namespace CursoBasico
{
    class ProgramClase15
    {
        public static void Ejecutar()
        {

            // Switch Case

            // Con opciones de tipo enteros...
            Console.WriteLine("Elige una de las opciones: ");
            Console.WriteLine("1) Imprimir Hola Mundo ");
            Console.WriteLine("2) Imprimir suma de dos números ");
            Console.WriteLine("3) Imprimir NADA ");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Hola Mundo!");
                    break;
                case 2:
                    int num1 = 3;
                    int num2 = 7;
                    int resultado = num1 + num2;
                    Console.WriteLine(resultado);
                    break;
                case 3:
                    Console.WriteLine("NADA");
                    break;
                default:
                    Console.WriteLine("No seleccionaste ninguna de las opciones :(");
                    break;
            }

        }
    }
}