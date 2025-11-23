using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionBase
{
    class Program
    {
        //Esta es la funcion principal del programa
        // Aqui inicia la aplicacion 
        static void Main(string[] args)
        {
            //Declaramos variables
            string entrada = "";
            int a = 0, b = 0, resultado = 0;

            //Leemos una cadena
            Console.WriteLine("Escribe tu Nombre: ");
            entrada = Console.ReadLine();

            Console.WriteLine("Hola {0}, como estas?", entrada);

            //Leemos dos valores y los sumamos.

            Console.Write("Dame un entero: ");
            entrada = Console.ReadLine();

            //Convertimos la cadena a entero
            a = Convert.ToInt32(entrada);

            Console.Write("Dame otro entero: ");
            entrada = Console.ReadLine();

            //Convertimos la cadena a entero
            b = Convert.ToInt32(entrada);
            
            //Sumamos los valores 
            resultado = a + b;

            //Mostramos el resultado

            Console.WriteLine("El resultado es {0}", resultado);
            
            //Pausa para que no se cierre
            Console.WriteLine("\nPresiona Enter para salir...");
            Console.ReadLine();

        }
    }

}