// Susing System;

namespace CursoBasico
{
    class ProgramClase02
    {
        public static void Ejecutar()
        {

            int num1 = 10;
            int num2 = 20;
            int num3 = 30;
            int num4 = 40;

            // es igual que...
            if (num1 == num2)
            {
                Console.WriteLine(num1 + " es igual que " + num2);
            }
            else if (num1 == num3)
            {
                Console.WriteLine(num1 + " es igual que " + num3);
            }
            else if (num1 == num4)
            {
                Console.WriteLine(num1 + " es igual que " + num4);
            }
            else
            {
                Console.WriteLine(num1 + " no es igual que los otros números.");
            }


            // número mayor...
            if (num3 < num1)
            {
                Console.WriteLine(num3 + " es menor que " + num1);
            }
            else if (num3 < num2)
            {
                Console.WriteLine(num3 + " es menor que " + num2);
            }
            else if (num3 < num4)
            {
                Console.WriteLine(num3 + " es menor que " + num4);
            }
            else
            {
                Console.WriteLine(num3 + " es el número mayor");
            }

        }
    }
}