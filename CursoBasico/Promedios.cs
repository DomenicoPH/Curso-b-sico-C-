using System;
using System.Collections.Generic;
using System.Text;

namespace CursoBasico
{
    internal class Promedios
    {
        // Pedir calificaciones de materias: Matemáticas, Español, Física y Química
        // Evaluar que los valores ingresados sean números
        // Calcular el promedio
        // Devolver la calificación final
        public static void Ejecutar()
        {

            // Matemáticas:
            double mate;
            string txtmate = "";
            bool esNumMate;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingresa tu calificación de Matemáticas ");
                txtmate = Console.ReadLine();
                esNumMate = double.TryParse(txtmate, out mate);

            } while (esNumMate == false);

            // Español:
            double esp;
            string txtesp = "";
            bool esNumEsp;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingresa tu calificación de Español ");
                txtesp = Console.ReadLine();
                esNumEsp = double.TryParse(txtesp, out esp);

            } while (esNumEsp == false);

            // Física:
            double fis;
            string txtfis = "";
            bool esNumFis;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingresa tu calificación de Física ");
                txtfis = Console.ReadLine();
                esNumFis = double.TryParse(txtfis, out fis);

            } while (esNumFis == false);

            // Química:
            double quim;
            string txtquim = "";
            bool esNumQuim;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingresa tu calificación de Química ");
                txtquim = Console.ReadLine();
                esNumQuim = double.TryParse(txtquim, out quim);

            } while (esNumQuim == false);

            // --- 

            double promedio = (mate + esp + fis + quim) / 4;

            Console.Clear();
            Console.WriteLine("Promedio: " + promedio);


        }
    }
}
