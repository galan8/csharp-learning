using System;
using System.Collections.Generic;
using System.Text;
// Calcular el area y perimetro del rectangulo 
namespace AplicacionBase{
    class Program{
        //Esta es la funcion principal del programa
        //Aqui indica la aplicacion
        static void Main(string[] args)
        {
            //Declaramos las variables, ahora de tipo flotante
            float area = 0.0f;
            float perimetro = 0.0f;
            float ancho = 1.0f;
            float alto = 1.0f;
            string valor = "";

        Console.Write("Dame el ancho del rectangulo: ");
        valor = Console.ReadLine();
        ancho = Convert.ToSingle(valor); // Convertimos a flotante
        
        Console.Write("Dame el alto del rectangulo: ");
        valor = Console.ReadLine();
        alto = Convert.ToSingle(valor);

        area = ancho * alto;

        perimetro = (ancho + alto) * 2;

        Console.WriteLine("El area es: {0} unidades cuadradas", area);
        Console.WriteLine("El perimetro es : {0} unidades", perimetro);
        
        }
    }
}