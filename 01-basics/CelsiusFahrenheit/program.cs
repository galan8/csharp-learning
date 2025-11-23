using System;
using System.Collections.Generic;
using System.Text;
// Hacer un programa que transforme grados centrigrados a Fahrenheit
namespace AplicacionBase{
    class Program{
            static void Main(string[] args)
        {
            //Declaramos las variables
            double grados;
            double fahrenheit;
  
        Console.Write("Dame el numero de grados: ");    
        grados = Convert.ToDouble(Console.ReadLine());           
   

        fahrenheit = (grados * 9/5) + 32;
       Console.WriteLine("C {0}° = F {1}°", grados, fahrenheit);
                     
        }
    }
}