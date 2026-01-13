// Susing System;

namespace CursoBasico
{
    class ProgramClase12
    {
        public static void Ejecutar()
        {

            // Operadores lógicos

            int num1 = 5;
            int num2 = 4;

            // AND &&
            if (num1 == 5 && num2 == 4)
            {
                Console.WriteLine("Las condiciones son verdaderas");
            }
            else 
            {
                Console.WriteLine("Al menos una condición es falsa");
            }

            // OR ||
            if (num1 == 5 || num2 == 7)
            {
                Console.WriteLine("Al menos una condición es verdadera");
            }
            else
            {
                Console.WriteLine("Las condiciones son falsas");
            }

            // NOT !
            bool option = true;

            if (!option)
            {
                Console.WriteLine("Es verdadera");
            }
            else
            {
                Console.WriteLine("Es falsa");
            }
        }
    }
}