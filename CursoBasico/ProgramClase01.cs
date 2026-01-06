// Susing System;

namespace CursoBasico
{
    class ProgramClase01
    {
        public static void Ejecutar()
        {

            // Tipos de datos

            int cajaentero = 15;
            int cajaenteronegativo = -4;
            int cajaentero2 = 1800;

            double materia_mate = 4.5;
            double materia_espa = 8.5;

            decimal dinero1 = (decimal) 250.76532;
            decimal dinero2 = 630.67875M;

            char letra = 'A';
            char letra2 = 'B';
            
            string nombre = "Domenico";
            string apellido = "Pagano";

            bool verdadero = true;
            bool falso = false;


            Console.WriteLine("Hello, World!");

            Console.WriteLine(cajaentero);
            Console.WriteLine(cajaenteronegativo);
            Console.WriteLine(cajaentero2);

            Console.WriteLine(materia_mate);
            Console.WriteLine(materia_espa);

            Console.WriteLine(dinero1);
            Console.WriteLine(dinero2);

            Console.WriteLine(letra);
            Console.WriteLine(letra2);

            Console.WriteLine(nombre + ' ' + apellido);

            Console.WriteLine(verdadero);
            Console.WriteLine(falso);

            // Condicionales

            // condición igual que ==
            if (cajaentero == cajaentero2)
            {
                Console.WriteLine("Son iguales");
            }
            else 
            { 
                Console.WriteLine(cajaentero + " y " + cajaentero2 + " no son iguales.");
            }

            // condición diferente que !=
            if ( cajaentero != cajaentero2 )
            {
                Console.WriteLine("Son diferentes");
            }
            else
            {
                Console.WriteLine(cajaentero + " y " + cajaentero2 + " son iguales.");
            }

            // condición menor que <
            if ( cajaentero < cajaentero2 )
            {
                Console.WriteLine(cajaentero + " es menor que " + cajaentero2);
            }
            else
            {
                Console.WriteLine(cajaentero + " es mayor que " + cajaentero2);
            }

            // condición mayor que >
            if ( cajaentero > cajaentero2 )
            {
                Console.WriteLine(cajaentero + " es mayor que " + cajaentero2);
            }
            else
            {
                Console.WriteLine(cajaentero + " es menor que " + cajaentero2);
            }


            // Uso de bool para condiciones
            if(verdadero)
            {
                Console.WriteLine("Es verdadero");
            }
            else
            {
                Console.WriteLine("Es falsa");
            }

            if (!verdadero)
            {
                Console.WriteLine("Es verdadero");
            }
            else
            {
                Console.WriteLine("Es falsa");
            }
        }
    }
}