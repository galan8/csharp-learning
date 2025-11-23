using System;
using System.Collections.Generic;
using System.Text;
// Hacer un programa que transforma grados a radianes 
namespace AplicacionBase{
    class Program{
            static void Main(string[] args)
        {
            //Declaramos las variables
            double grados;
            double radianes;
      

        Console.Write("Dame el numero de grados :");      
        grados = Convert.ToDouble(Console.ReadLine());
              
        Console.ReadLine();
        radianes = grados * (3.1416 / 180);
        
        Console.WriteLine("{0}° = {1:F5} radianes", grados, radianes);
      
        }
    }
}