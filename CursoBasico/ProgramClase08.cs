// Susing System;

namespace CursoBasico
{
    class ProgramClase08
    {
        public static void Ejecutar()
        {

            //Arreglos

            int[] arreglo1 = new int[4];

            arreglo1[0] = 12;
            arreglo1[1] = 23;
            arreglo1[2] = 84;
            arreglo1[3] = 40;

            Console.WriteLine("Longitud de arreglo1: ", arreglo1.Length);

            for(int cont = 0; cont < arreglo1.Length; cont++)
            {
                Console.WriteLine("Valor almacenado en el índice " + cont + ": " + arreglo1[cont]);
            }

            Console.WriteLine("\n----\n");

            Console.WriteLine("--- Programa Ejemplo: Creación de un arreglo ---");

            // ***

            Console.WriteLine("Ingresa la longitud del arreglo: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            string[] arr = new string[cantidad];

            Console.WriteLine("\nAhora vas a ingresar los valores a guardar en el arreglo\n");

            for(int cont = 0; cont < arr.Length; cont++)
            {
                Console.WriteLine("Ingresa el valor que se va a guardar en el espacio " + cont);
                arr[cont] = Console.ReadLine();
            }

            Console.WriteLine("\nLos valores que se guardaron en el arreglo son: ");

            for(int cont = 0; cont < arr.Length; cont++)
            {
                Console.Write(arr[cont] + " ");
            }

            Console.WriteLine("--- Fin del programa ---");

            // ***

        }
    }
}