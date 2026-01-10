// Susing System;

namespace CursoBasico
{
    class ProgramClase09
    {
        public static void Ejecutar()
        {

            // Funciones I

            Console.WriteLine("Ingresa tu nombre:");
            string nombre = Console.ReadLine();
            Saludar(nombre);

            int num = Devolvernumero();
            Console.WriteLine(num);

            int resultadoSuma1 = suma(10, 10);
            int resultadoSuma2 = suma(3, 7);
            Console.WriteLine(resultadoSuma1);
            Console.WriteLine(resultadoSuma2);



        }


        static void Saludar(string nombre)
        {
            //código que ejecuta la función
            Console.WriteLine("Hola " + nombre + "!");
        }

        static int Devolvernumero()
        {
            int num1 = 2;
            int num2 = 9;
            int suma = num1 + num2;
            return suma;
        }

        static int suma(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
    }
}