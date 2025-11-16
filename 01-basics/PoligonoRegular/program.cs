using System;
using System.Collections.Generic;
using System.Text;
// Calcular el perimetro de cualquier poligono regular
namespace AplicacionBase{
    class Program{
            static void Main(string[] args)
        {
            //Declaramos las variables, ahora de tipo flotante
            double n_lados;
            double perimetro;
            double longitud;
            string valor = "";
      
        Console.Write("Dame el numero de lados: ");
        valor = Console.ReadLine();
        n_lados = Convert.ToDouble(valor); // convertimos a double 
 
        Console.Write("Dame la longitud de cada lado: ");
        valor = Console.ReadLine();
        longitud = Convert.ToDouble(valor);

        perimetro = (n_lados * longitud);

         Console.WriteLine("El perimetro es : {0:F2} unidades", perimetro);
        


        }
    }
}