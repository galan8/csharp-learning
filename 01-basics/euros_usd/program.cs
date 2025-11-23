using System;
using System.Collections.Generic;
using System.Text;
// Hacer un programa que transforme entre dolares y euros  y que tambien pida el tipo de cambio del dia 
namespace AplicacionBase{
    class Program{
            static void Main(string[] args)
        {
            //Declaramos las variables
            double conversion;
            double euros;
            double cambio;
  
        Console.Write("Dame el tipo de cambio del dia de hoy (EUR -> USD): ");    
        cambio = Convert.ToDouble(Console.ReadLine());           
   
        Console.Write("Dame la cantidad de euros: ");    
        euros = Convert.ToDouble(Console.ReadLine());  

        conversion = euros * cambio;
       Console.WriteLine("{0} Euros = {1} USD (cambio: {2})", euros, conversion, cambio);
                     
        }
    }
}