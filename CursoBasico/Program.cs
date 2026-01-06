// Susing System;

namespace CursoBasico
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}