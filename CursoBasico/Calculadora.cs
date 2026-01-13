using System;
using System.Collections.Generic;
using System.Text;

namespace CursoBasico
{
    internal class Calculadora
    {
        public static void Ejecutar()
        {

            string texto_opcion = "";

            do
            {
                Console.Clear();

                // Manú de operaciones
                Console.WriteLine("Calculadora");
                Console.WriteLine("Selecciona la operación matemática que quieras ejecutar: \n");
                Console.WriteLine("a) Suma de dos números");
                Console.WriteLine("b) Resta de dos números");
                Console.WriteLine("c) Multiplicación de dos números");
                Console.WriteLine("d) División de dos números");

                string texto;
                char option;
                bool esChar;

                do
                {
                    texto = Console.ReadLine();
                    esChar = char.TryParse(texto, out option);

                } while (esChar == false);


                double result;

                switch (option)
                {
                    case 'a':
                        result = Sumar();
                        break;
                    case 'b':
                        result = Restar();
                        break;
                    case 'c':
                        result = Multiplicar();
                        break;
                    case 'd':
                        result = Dividir();
                        break;
                    default:
                        Console.WriteLine("Esta opción no es válida");
                        result = 0;
                        break;
                }

                Console.WriteLine("El resultado de la operación es: " + result);

                Console.WriteLine("\n¿Deseas repetir el programa? (si / no)");
                texto_opcion = Console.ReadLine();

            } while (texto_opcion == "si");

            // Ingresar 2 números y validar el tipo de dato
            // Imprimir resultado de la operación

            // Funciones de operación matemática

            // a. Suma
            static double Sumar()
            {
                Console.Clear();
                double num1;
                double num2;
                string numero1;
                string numero2;
                bool esNumero1;
                bool esNumero2;
                do
                {
                    Console.WriteLine("Ingresa el primer número");
                    numero1 = Console.ReadLine();
                    esNumero1 = double.TryParse(numero1, out num1);

                    Console.WriteLine("\n");

                    Console.WriteLine("Ingresa el segundo número");
                    numero2 = Console.ReadLine();
                    esNumero2 = double.TryParse(numero2, out num2);

                    Console.WriteLine("\n");

                } while (esNumero1 == false || esNumero2 == false);

                double resultado = num1 + num2;

                Console.Clear();

                return resultado;
            }

            // b. Resta
            static double Restar()
            {
                Console.Clear();
                double num1;
                double num2;
                string numero1;
                string numero2;
                bool esNumero1;
                bool esNumero2;
                do
                {
                    Console.WriteLine("Ingresa el primer número");
                    numero1 = Console.ReadLine();
                    esNumero1 = double.TryParse(numero1, out num1);

                    Console.WriteLine("\n");

                    Console.WriteLine("Ingresa el segundo número");
                    numero2 = Console.ReadLine();
                    esNumero2 = double.TryParse(numero2, out num2);

                    Console.WriteLine("\n");

                } while (esNumero1 == false || esNumero2 == false);

                double resultado = num1 - num2;

                Console.Clear();

                return resultado;
            }

            // c. Multiplicación
            static double Multiplicar()
            {
                Console.Clear();
                double num1;
                double num2;
                string numero1;
                string numero2;
                bool esNumero1;
                bool esNumero2;
                do
                {
                    Console.WriteLine("Ingresa el primer número");
                    numero1 = Console.ReadLine();
                    esNumero1 = double.TryParse(numero1, out num1);

                    Console.WriteLine("\n");

                    Console.WriteLine("Ingresa el segundo número");
                    numero2 = Console.ReadLine();
                    esNumero2 = double.TryParse(numero2, out num2);

                    Console.WriteLine("\n");

                } while (esNumero1 == false || esNumero2 == false);

                double resultado = num1 * num2;

                Console.Clear();

                return resultado;
            }

            // d. División
            static double Dividir()
            {
                Console.Clear();
                double num1;
                double num2;
                string numero1;
                string numero2;
                bool esNumero1;
                bool esNumero2;
                do
                {
                    Console.WriteLine("Ingresa el primer número");
                    numero1 = Console.ReadLine();
                    esNumero1 = double.TryParse(numero1, out num1);

                    Console.WriteLine("\n");

                    Console.WriteLine("Ingresa el segundo número");
                    numero2 = Console.ReadLine();
                    esNumero2 = double.TryParse(numero2, out num2);

                    Console.WriteLine("\n");

                } while (esNumero1 == false || esNumero2 == false);

                double resultado = num1 / num2;

                Console.Clear();

                return resultado;
            }
        }
    }
}
