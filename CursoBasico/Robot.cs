using System;
using System.Collections.Generic;
using System.Text;

namespace CursoBasico
{
    internal class Robot
    {
        // Programar un robot que haga preguntas
        // 1ra pregunta: ¿Cómo te llamas?               / saludar con la respuesta.
        // 2da pregunta: ¿Cuántos años tienes?          / dar un comentario con la respuesta.
        // 3ra pregunta: ¿Cómo estás?                   / evaluar si contiene 'bien' o 'mal' para dar un comentario.
        // 4ta pregunta: ¿Te gustó el curso de C#?      / evaluar y responder. 

        public static void Ejecutar()
        {

            // Nombre
            Console.WriteLine("Hola, soy GnomoBot y tengo algunas preguntas para ti.");
            Console.WriteLine("\n¿Cómo te llamas?");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Hola {nombre}, encantado de conocerte.");


            // Edad
            int edad;
            string edadString;
            bool esNum;
            do
            {
                Console.WriteLine($"\n¿Cuántos años tienes?");
                edadString = Console.ReadLine();
                esNum = int.TryParse(edadString, out edad);
            } while (!esNum);

            if(edad < 18)
            {
                Console.WriteLine($"{edad} años! Es genial que siendo tan joven estés programando!");
            }
            if(edad > 18)
            {
                Console.WriteLine($"{edad} años! Es un gusto tenerte en este curso de programación!");
            }
            if(edad >= 18 && edad > 50)
            {
                Console.WriteLine($"{edad} años! Nunca es tarde para aprender a programar!");
            };


            // Cómo estás?
            Console.WriteLine($"\n¿Cómo estás?");
            string estas = Console.ReadLine();
            estas = estas.ToLower();

            if (estas.Contains("bien"))
            {
                Console.WriteLine($"Me alegra mucho que estés bien, {nombre}");
            }
            else if (estas.Contains("mal"))
            {
                Console.WriteLine($"Lamento mucho que no te encuentres bien, {nombre}");
            }
            else
            {
                Console.WriteLine($"Considero que te encuentras mas o menos... Te sugiero hacer alguna actividad de tu agrado {nombre}");
            };


            // Curso
            Console.WriteLine("\n¿Te gustó el curso de C#? (si / no)");
            string curso = Console.ReadLine();
            curso.ToLower();

            switch (curso)
            {
                case "si": Console.WriteLine("Estupendo! pronto tendremos el curso intermedio y avanzado!");
                    break;
                case "no": Console.WriteLine("Lo siento mucho, me gustaría que dejes tus opiniones para poder mejorar.");
                    break;
                default: Console.WriteLine("No te entendí.");
                    break;
            }
        }
    }
}
